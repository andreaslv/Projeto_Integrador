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
        private int _idPedido = 0; // 0 = novo | >0 = edição
        public NovoPedidoUC()
        {
            InitializeComponent();

        }

        public void CarregarPedido(int idPedido)
        {
            _idPedido = idPedido;

            using (MySqlConnection conn = Conexao.Connection())
            {
                conn.Open();

                string sql = @"SELECT nome_cliente, mesa, itens, observacoes, forma_pagamento
                       FROM pedidos
                       WHERE id_pedido = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idPedido);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNomeCliente.Text = dr["nome_cliente"].ToString();
                    cbMesa.Text = dr["mesa"].ToString();
                    txtObservacoes.Text = dr["observacoes"].ToString();

                    string itens = dr["itens"].ToString();
                    string[] partes = itens.Split(',');

                    if (partes.Length > 0)
                        comboBox1.Text = partes[0].Trim();

                    if (partes.Length > 1)
                        cbAcompanhamento.Text = partes[1].Trim();

                    if (partes.Length > 2)
                        cbBebidas.Text = partes[2].Trim();
                }
            }
        }

        private void ltbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        public void CarregarProdutosPorCategoria()
        {

        }

        private void NovoPedidoUC_Load(object sender, EventArgs e)
        {
        }

        public void CarregarProdutos()
        {


        }

        private void CarregarMesas()
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            string nomeDoCliente, lanches, acompanhamentos, bebidas, formaPagamento, observacoes;
            // int Mesa = Convert.ToInt32(cbMesa.Text);

            // Mesa obrigatória
            if (string.IsNullOrWhiteSpace(cbMesa.Text))
            {
                MessageBox.Show(
                    "Selecione a mesa.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbMesa.Focus();
                return;
            }
            int mesa = int.Parse(cbMesa.Text);

            // Armazenar dados:
            nomeDoCliente = txtNomeCliente.Text;
            lanches = comboBox1.Text;
            acompanhamentos = cbAcompanhamento.Text;
            bebidas = cbBebidas.Text;
            observacoes = txtObservacoes.Text;


            // ====== VALIDAÇÕES ======

           // Nome obrigatório
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente.");
                txtNomeCliente.Focus();
                return;
            }

            // Nome apenas letras
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtNomeCliente.Text, @"^[a-zA-ZÀ-ú\s]+$"))
            {
                MessageBox.Show("O nome do cliente deve conter apenas letras.");
                txtNomeCliente.Focus();
                return;
            }

            // Mesa obrigatória
            if (string.IsNullOrWhiteSpace(cbMesa.Text))
            {
                MessageBox.Show("Selecione uma mesa.");
                cbMesa.Focus();
                return;
            }

            // Lanche obrigatório
            if (comboBox1.SelectedIndex == -1 || comboBox1.Text == "Selecione um lanche")
            {
                MessageBox.Show("É obrigatório escolher um lanche.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            bool temLanche = comboBox1.SelectedIndex > 0;

            bool temAcompanhamento =
                !string.IsNullOrWhiteSpace(cbAcompanhamento.Text) &&
                cbAcompanhamento.Text != "Acompanhamentos";

            bool temBebida =
                !string.IsNullOrWhiteSpace(cbBebidas.Text) &&
                cbBebidas.Text != "Bebidas";


            if (!temLanche && !(temAcompanhamento && temBebida))
            {
                MessageBox.Show(
                    "É obrigatório escolher um lanche ou um acompanhamento junto com uma bebida.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }



            // Forma de pagamento obrigatória
            if (!rbDinheiro.Checked && !rbCartao.Checked && !rbPix.Checked)
            {
                MessageBox.Show("Selecione a forma de pagamento.");
                return;
            }

            formaPagamento = "";
            if (rbDinheiro.Checked)
                formaPagamento = "Dinheiro";
            else if (rbCartao.Checked)
                formaPagamento = "Cartão";
            else if (rbPix.Checked)
                formaPagamento = "Pix";

            // Itens do pedido
            string itens = $"{comboBox1.Text}, {cbAcompanhamento.Text}, {cbBebidas.Text}";


            MySqlConnection conn = Conexao.Connection();

            try
            {
                conn.Open();

                string sql;

                if (_idPedido == 0)
                {
                    sql = @"INSERT INTO pedidos
            (nome_cliente, mesa, itens, observacoes, forma_pagamento, data_hora, status)
            VALUES
            (@nome, @mesa, @itens, @obs, @pagamento, @data, 'Em Preparo')";
                }
                else
                {
                    sql = @"UPDATE pedidos SET
            nome_cliente = @nome,
            mesa = @mesa,
            itens = @itens,
            observacoes = @obs,
            forma_pagamento = @pagamento
            WHERE id_pedido = @id";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", txtNomeCliente.Text);
                cmd.Parameters.AddWithValue("@mesa", cbMesa.Text);
                cmd.Parameters.AddWithValue("@itens", itens);
                cmd.Parameters.AddWithValue("@obs", txtObservacoes.Text);
                cmd.Parameters.AddWithValue("@pagamento", formaPagamento);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);

                if (_idPedido > 0)
                {
                    cmd.Parameters.AddWithValue("@id", _idPedido);
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show(_idPedido == 0
                    ? "Pedido salvo com sucesso!"
                    : "Pedido atualizado com sucesso!");
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }


            totalPedido = 0;

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                totalPedido += PrecoLanche(comboBox1.Text);
            }

            if (!string.IsNullOrEmpty(cbAcompanhamento.Text))
            {
                totalPedido += PrecoAcompanhamento(cbAcompanhamento.Text);
            }

            if (!string.IsNullOrEmpty(cbBebidas.Text))
            {
                totalPedido += PrecoBebida(cbBebidas.Text);
            }

            lblTotal.Text = $"R$ {totalPedido:F2}";
            lblTotal.Text = $"R$ {totalPedido:F2}";

        }

        decimal totalPedido = 0;

        private decimal PrecoLanche(string lanche)
        {
            switch (lanche)
            {
                case "Smash Tasty":
                    return 18.00m;
                case "Smash Original":
                    return 15.00m;
                case "Smash Egg":
                    return 17.00m;
                case "Frango Supremo Crocante":
                    return 19.00m;
                case "Smash Duplo Egg":
                    return 22.00m;
                case "Smash Original Duplo":
                    return 21.00m;
                case "Smash Onions Duplo":
                    return 23.00m;
                default:
                    return 0;
            }
        }

        private decimal PrecoAcompanhamento(string acomp)
        {
            switch (acomp)
            {
                case "Batata Frita Pequena":
                    return 6.00m;
                case "Batata Frita Média":
                    return 8.00m;
                case "Batata Frita Grande":
                    return 10.00m;
                case "Onion Rings":
                    return 9.00m;
                case "Nuggets 6 unidades":
                    return 7.00m;
                case "Nuggets 10 unidades":
                    return 11.00m;
                default:
                    return 0;
            }
        }

        private decimal PrecoBebida(string bebida)
        {
            switch (bebida)
            {
                case "Coca Cola 350ml":
                    return 5.00m;
                case "Coca Cola 600ml":
                    return 7.00m;
                case "Coca Cola Zero 350ml":
                    return 5.00m;
                case "Coca Cola Zero 600ml":
                    return 7.00m;
                case "Guaraná 350ml":
                    return 5.00m;
                case "Guaraná 600ml":
                    return 7.00m;
                case "Suco Laranja":
                    return 6.00m;
                case "Limonada":
                    return 5.00m;
                default:
                    return 0;
            }
        }

        private void AtualizarTotal()
        {
            totalPedido = 0;

            if (!string.IsNullOrEmpty(comboBox1.Text))
                totalPedido += PrecoLanche(comboBox1.Text);

            if (!string.IsNullOrEmpty(cbAcompanhamento.Text))
                totalPedido += PrecoAcompanhamento(cbAcompanhamento.Text);

            if (!string.IsNullOrEmpty(cbBebidas.Text))
                totalPedido += PrecoBebida(cbBebidas.Text);

            if (totalPedido > 0)
            {
                lblTotal.Visible = true;
                lblTotal.Text = $"R$ {totalPedido:F2}";
            }
            else
            {
                lblTotal.Visible = false;
            }
        }

        private void cbAcompanhamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void cbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espaço e Backspace
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia números e caracteres especiais
            }
        }

    }
}

