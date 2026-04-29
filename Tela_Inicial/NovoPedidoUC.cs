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
            int Mesa = Convert.ToInt32(cbMesa.Text);

            // Armazenar dados:
            nomeDoCliente = txtNomeCliente.Text;
            lanches = comboBox1.Text;
            acompanhamentos = cbAcompanhamento.Text;
            bebidas = cbBebidas.Text;
            observacoes = txtObservacoes.Text;

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

                string sql = @"INSERT INTO pedidos (nome_cliente, mesa, itens, observacoes, forma_pagamento, data_hora, status) VALUES (@nomeDoCliente, 
                @Mesa, @itens, @observacoes, @formaPagamento, @Data, 'Em Preparo')";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nomeDoCliente", txtNomeCliente.Text);
                cmd.Parameters.AddWithValue("@Mesa", cbMesa.Text);
                cmd.Parameters.AddWithValue("@itens", itens);
                cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);
                cmd.Parameters.AddWithValue("@formaPagamento", formaPagamento);
                cmd.Parameters.AddWithValue("@Data", DateTime.Now);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido salvo com sucesso!");
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }


    }
}

