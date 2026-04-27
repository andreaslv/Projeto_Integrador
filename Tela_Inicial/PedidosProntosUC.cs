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

        }

        public void CarregarPedidosProntos()
        {

            string conectar = "server=localhost;database=bdthebuurger;uid=root;password=;";

            string sql = @"SELECT id_pedido, itens, mesa FROM pedidos WHERE status = 'Pronto'";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conectar))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidosProntos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        public void AtualizarTela()
        {
            CarregarPedidosProntos();
        }


        private void PedidosProntosUC_Load(object sender, EventArgs e)
        {
        }

    }
}
