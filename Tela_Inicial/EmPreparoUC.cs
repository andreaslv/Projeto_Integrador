using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Inicial
{
    public partial class EmPreparoUC : UserControl
    {

        // ✅ EVENTO DENTRO DA CLASSE (CORRETO)
        public event Action<int>? PedidoEditarSolicitado;

        public EmPreparoUC()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmPreparo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmPreparo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmPreparo.MultiSelect = false;
            dgvEmPreparo.ReadOnly = true;
        }


        public void CarregarUsuarios()
        {
            string conectar = "server=localhost; database=bdthebuurger; Uid=root; password=;";

            string sql = @"SELECT id_pedido, data_hora, itens, observacoes, nome_cliente, mesa FROM pedidos WHERE status = 'Em Preparo'";


            try
            {
                MySqlConnection con = new MySqlConnection(conectar);
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvEmPreparo.DataSource = dt;


                    // 🔧 ajustes mais equilibrados
                    dgvEmPreparo.Columns["data_hora"].FillWeight = 105;
                    dgvEmPreparo.Columns["itens"].FillWeight = 300;
                    dgvEmPreparo.Columns["observacoes"].FillWeight = 140;
                    dgvEmPreparo.Columns["nome_cliente"].FillWeight = 100;
                    dgvEmPreparo.Columns["mesa"].FillWeight = 40;
                    dgvEmPreparo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgvEmPreparo.Columns["id_pedido"].Visible = false;

                    foreach (DataGridViewRow row in dgvEmPreparo.Rows)
                    {
                        if (row.Cells["itens"].Value != null)
                        {
                            string texto = row.Cells["itens"].Value.ToString();

                            string textoLimpo = System.Text.RegularExpressions.Regex
                                .Replace(texto, @"\s*-\s*R\$\s*\d+,\d+", "");

                            textoLimpo = textoLimpo.Replace("[L]", "")
                                                   .Replace("[A]", "")
                                                   .Replace("[B]", "")
                                                   .Replace("  ", " ")
                                                   .Trim();

                            row.Cells["itens"].Value = textoLimpo;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void EmPreparoUC_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void btnMarcarPronto_Click(object sender, EventArgs e)
        {

            if (dgvEmPreparo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido!");
                return;
            }

            // Pegar o ID do pedido selecionado
            int idPedido = Convert.ToInt32(
                dgvEmPreparo.SelectedRows[0].Cells["id_pedido"].Value
            );

            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            string sql = "UPDATE pedidos SET status = 'Pronto' WHERE id_pedido = @id";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conectar))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idPedido);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pedido marcado como PRONTO ✅");

                // 🔄 Atualiza o DataGridView
                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (dgvEmPreparo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido!");
                return;
            }



            int idPedido = Convert.ToInt32(
            dgvEmPreparo.SelectedRows[0].Cells["id_pedido"].Value


            );

            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conectar))
                {
                    con.Open();



                    string sql = "UPDATE pedidos SET status = 'Cancelado' WHERE id_pedido = @id";



                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idPedido);
                        cmd.ExecuteNonQuery();
                    }
                }



                MessageBox.Show("Pedido CANCELADO!");



                // Atualiza a tela
                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvEmPreparo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para editar.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idPedido = Convert.ToInt32(
                dgvEmPreparo.SelectedRows[0].Cells["id_pedido"].Value
            );


            // ✅ Dispara o evento
            PedidoEditarSolicitado?.Invoke(idPedido);

            // AbrirTelaEditarPedido(idPedido);
        }

        /*private void AbrirTelaEditarPedido(int idPedido)
        {
            NovoPedidoUC editar = new NovoPedidoUC();
            editar.CarregarPedido(idPedido);

            this.Controls.Clear();
            this.Controls.Add(editar);

            editar.Dock = DockStyle.Fill; // importante para ajustar à tela
        }*/

    }
}
