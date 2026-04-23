using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tela_Inicial
{
    public partial class NovoPedidoUC : UserControl
    {
        public NovoPedidoUC()
        {
            InitializeComponent();

        }

        private void ltbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CarregarProdutosPorCategoria()
        {
            string Lanches = comboBox1.Text;
            string Acompanhamentos = cbAcompanhamento.Text;
            string Bebidas = cbBebidas.Text;

            MySqlConnection con = Conexao.Abrir();
            {
                string sql = "SELECT categoria FROM produtos";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@lanche", Lanches);
                cmd.Parameters.AddWithValue("@Acompanhamento", Acompanhamentos);
                cmd.Parameters.AddWithValue("@Bebida", Bebidas);

                cmd.ExecuteNonQuery();
            }
        }

        private void NovoPedidoUC_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        public void CarregarProdutos()
        {

            MySqlConnection con = Conexao.Abrir();

            string sql = "SELECT nome, categoria FROM tbprodutos WHERE ativo = 1";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            comboBox1.Items.Clear();
            cbAcompanhamento.Items.Clear();
            cbBebidas.Items.Clear();

            while (dr.Read())
            {
                string nomeProduto = dr["nome"]?.ToString() ?? "";
                string categoria = dr["categoria"]?.ToString() ?? "";

                if (categoria == "Lanche")
                    comboBox1.Items.Add(nomeProduto);
                else if (categoria == "Acompanhamento")
                    cbAcompanhamento.Items.Add(nomeProduto);
                else if (categoria == "Bebida")
                    cbBebidas.Items.Add(nomeProduto);
            }

            dr.Close();
            con.Close();

        }

        private void CarregarMesas()
        {
            MySqlConnection con = Conexao.Abrir();

            string sql = "SELECT id_mesa, numero_mesa FROM tbmesas WHERE status = 'Livre'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            cbMesa.Items.Clear();

            while (dr.Read())
            {
                int idMesa = Convert.ToInt32(dr["id_mesa"]);
                string numeroMesa = dr["numero_mesa"]?.ToString() ?? "";

            }


            dr.Close();
            con.Close();

            cbMesa.DisplayMember = "Descricao";
            cbMesa.ValueMember = "IdMesa";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
