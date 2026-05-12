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
    public partial class EditarPedidoUC : UserControl
    {
        private int _idPedido;
        public EditarPedidoUC(int idPedido)
        {
            InitializeComponent();

            _idPedido = idPedido;

            // CarregarPedido(); ❌ DESABILITADO POR ENQUANTO
        }

        private void CarregarPedido()
        {
            using (MySqlConnection conn = Conexao.Connection())
            {
                conn.Open();

                string sql = @"
            SELECT nome_cliente, mesa, itens, observacoes
            FROM pedidos
            WHERE id_pedido = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _idPedido);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //txtNomeCliente.Text = dr["nome_cliente"].ToString();
                        //cbMesa.Text = dr["mesa"].ToString();
                        //txtObservacoes.Text = dr["observacoes"].ToString();

                        // por enquanto, só isso
                        // depois você liga com ListBox/ItensPedidoUC
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
