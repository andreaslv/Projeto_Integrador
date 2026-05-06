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
    public partial class PedidosFinalizadosUC : UserControl
    {
        public PedidosFinalizadosUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarPedidosFinalizados()
        {
            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conectar))
                {
                    con.Open();

                    string sql = "SELECT id_pedido, data_hora, itens, nome_cliente, mesa, forma_pagamento, valorTotal FROM pedidos WHERE status = 'Finalizado'";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidosFinalizados.DataSource = dt;
                    dgvPedidosFinalizados.Columns["id_pedido"].Visible = false;

                    dgvPedidosFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void PedidosFinalizadosUC_Load(object sender, EventArgs e)
        {
            CarregarPedidosFinalizados();
            CarregarDatas();
        }

        private void dgvPedidosFinalizados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPedidosFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosFinalizados.MultiSelect = false;
            dgvPedidosFinalizados.ReadOnly = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string busca = txtBuscar.Text.Trim();
            string dataSelecionada = cbData.SelectedItem?.ToString();

            string sql = @"SELECT id_pedido, data_hora, itens, nome_cliente, mesa,
            forma_pagamento, valorTotal FROM pedidos WHERE status = 'Finalizado'";

            MySqlCommand cmd = new MySqlCommand();

            // 🔹 Filtro pelo texto buscar
            if (!string.IsNullOrEmpty(busca))
            {
                sql += " AND (nome_cliente LIKE @busca OR itens LIKE @busca)";
                cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
            }

            // 🔹 Filtro pela data
            if (!string.IsNullOrEmpty(dataSelecionada) && dataSelecionada != "Todas")
            {
                DateTime data = DateTime.ParseExact(dataSelecionada, "dd/MM/yyyy", null);
                sql += " AND DATE(data_hora) = @data";
                cmd.Parameters.AddWithValue("@data", data);
            }

            try
            {
                using (MySqlConnection conn = Conexao.Connection())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidosFinalizados.DataSource = dt;
                    dgvPedidosFinalizados.Columns["id_pedido"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }

        }

        private void CarregarDatas()
        {
            string sql = @"
        SELECT DISTINCT DATE(data_hora) AS dataPedido
        FROM pedidos
        WHERE status = 'Finalizado'
        ORDER BY dataPedido DESC
    ";

            using (MySqlConnection conn = Conexao.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    cbData.Items.Clear();
                    cbData.Items.Add("Todas"); // opção padrão

                    while (dr.Read())
                    {
                        DateTime data = dr.GetDateTime("dataPedido");
                        cbData.Items.Add(data.ToString("dd/MM/yyyy"));
                    }

                    cbData.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar datas: " + ex.Message);
                }
            }


        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbData.SelectedItem.ToString() == "Todas")
            {
                CarregarPedidosFinalizados();
            }
            else
            {
                DateTime dataSelecionada = DateTime.ParseExact(
                    cbData.SelectedItem.ToString(),
                    "dd/MM/yyyy",
                    null
                );

                CarregarPedidosPorData(dataSelecionada);
            }
        }

        private void CarregarPedidosPorData(DateTime data)
        {
            string sql = @"
        SELECT 
            data_hora,
            itens,
            nome_cliente,
            mesa,
            forma_pagamento,
            valorTotal
        FROM pedidos
        WHERE status = 'Finalizado'
          AND DATE(data_hora) = @data
    ";

            using (MySqlConnection conn = Conexao.Connection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@data", data);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidosFinalizados.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao filtrar pedidos: " + ex.Message);
                }
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.PerformClick();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                cbData.SelectedIndex = 0; // "Todas"
                CarregarPedidosFinalizados();
            }
        }

    }
}

