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
        }

        private void dgvPedidosFinalizados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPedidosFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosFinalizados.MultiSelect = false;
            dgvPedidosFinalizados.ReadOnly = true;
        }
    }
}
