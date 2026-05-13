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
    public partial class PedidosProntosUC : UserControl
    {
        public PedidosProntosUC()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPedidosProntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosProntos.MultiSelect = false;
            dgvPedidosProntos.ReadOnly = true;
        }

        public void CarregarPedidosProntos()
        {

            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            string sql = "SELECT id_pedido, data_hora, itens, observacoes, nome_cliente, mesa FROM pedidos WHERE status = 'Pronto'";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conectar))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidosProntos.DataSource = dt;
                    dgvPedidosProntos.Columns["id_pedido"].Visible = false;

                    dgvPedidosProntos.Columns["data_hora"].FillWeight = 105;
                    dgvPedidosProntos.Columns["itens"].FillWeight = 300;
                    dgvPedidosProntos.Columns["observacoes"].FillWeight = 140;
                    dgvPedidosProntos.Columns["nome_cliente"].FillWeight = 100;
                    dgvPedidosProntos.Columns["mesa"].FillWeight = 40;
                    dgvPedidosProntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void PedidosProntosUC_Load(object sender, EventArgs e)
        {
            CarregarPedidosProntos();
        }

        private void btnEntregarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidosProntos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido!");
                return;
            }

            int idPedido = Convert.ToInt32(
                dgvPedidosProntos.SelectedRows[0].Cells["id_pedido"].Value
            );

            string itens = dgvPedidosProntos.SelectedRows[0].Cells["itens"].Value.ToString();
            decimal valorTotal = CalcularTotalPedido(itens);

            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conectar))
                {
                    con.Open();

                    string sql = @"
                UPDATE pedidos 
                SET status = 'Finalizado',
                    valorTotal = @valor,
                    data_hora = NOW()
                WHERE id_pedido = @id
            ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        //cmd.Parameters.AddWithValue("@valor", valorTotal);
                        cmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = valorTotal;
                        cmd.Parameters.AddWithValue("@id", idPedido);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pedido FINALIZADO com sucesso!");

                CarregarPedidosProntos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {

            if (dgvPedidosProntos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido!");
                return;
            }

            int idPedido = Convert.ToInt32(
                dgvPedidosProntos.SelectedRows[0].Cells["id_pedido"].Value
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

                // 🔥 Atualiza a tela
                CarregarPedidosProntos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }



        private void btnVoltaPreparo_Click(object sender, EventArgs e)
        {
            if (dgvPedidosProntos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido!");
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Deseja voltar este pedido para o PREPARO?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao != DialogResult.Yes)
                return;

            int idPedido = Convert.ToInt32(
                dgvPedidosProntos.SelectedRows[0].Cells["id_pedido"].Value
            );


            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            string sql = "UPDATE pedidos SET status = 'Em Preparo' WHERE id_pedido = @id";

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

                MessageBox.Show("Pedido voltou para PREPARO 🔄");

                // Atualiza a lista de pedidos prontos
                CarregarPedidosProntos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

            private decimal CalcularTotalPedido(string itens)

        {
            decimal total = 0;

            string[] listaItens = itens.Split(',');

            foreach (string item in listaItens)
            {
                string nomeItem = item.Trim();

                switch (nomeItem)
                {
                    case "Smash Tasty":
                        total += 18.00m;
                        break;

                    case "Smash Original":
                        total += 15.00m;
                        break;

                    case "Smash Egg":
                        total += 17.00m;
                        break;

                    case "Frango Supremo Crocante":
                        total += 19.00m;
                        break;

                    case "Smash Duplo Egg":
                        total += 22.00m;
                        break;

                    case "Smash Original Duplo":
                        total += 21.00m;
                        break;

                    case "Smash Onions Duplo":
                        total += 23.00m;
                        break;

                    case "Batata Frita Pequena":
                        total += 6.00m;
                        break;

                    case "Batata Frita Média":
                        total += 8.00m;
                        break;

                    case "Batata Frita Grande":
                        total += 10.00m;
                        break;

                    case "Onion Rings":
                        total += 9.00m;
                        break;

                    case "Nuggets 6 unidades":
                        total += 7.00m;
                        break;

                    case "Nuggets 10 unidades":
                        total += 11.00m;
                        break;

                    case "Coca Cola 350ml":
                        total += 5.00m;
                        break;

                    case "Coca Cola 600ml":
                        total += 7.00m;
                        break;

                    case "Coca Cola Zero 350ml":
                        total += 5.00m;
                        break;

                    case "Coca Cola Zero 600ml":
                        total += 7.00m;
                        break;

                    case "Guaraná 350ml":
                        total += 5.00m;
                        break;

                    case "Guaraná 600ml":
                        total += 7.00m;
                        break;

                    case "Suco Laranja":
                        total += 6.00m;
                        break;

                    case "Limonada":
                        total += 5.00m;
                        break;
                }
            }

            return total;
        }

    }
}