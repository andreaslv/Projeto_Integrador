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
        private bool houveAlteracao = false;
        private int _idPedido;
        private string itensOriginais = "";

        public EditarPedidoUC(int idPedido)
        {
            InitializeComponent();

            _idPedido = idPedido;

            CarregarPedido();
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
                        // ✅ ID no título
                        lblNumPedido.Text = $" #{_idPedido}";

                        // ✅ Nome
                        lblNomeCliente1.Text = dr["nome_cliente"].ToString();

                        // ✅ Mesa
                        lblMesa.Text = dr["mesa"].ToString();

                        // ✅ Observações
                        txtObservacoes.Text = dr["observacoes"].ToString();


                        // ✅ GUARDA itens originais
                        itensOriginais = dr["itens"].ToString();

                        // ✅ 🔥 AQUI entra o código 🔥
                        listBox1.Items.Clear();


                        string[] partes = itensOriginais.Split(new string[] { " - R$ " }, StringSplitOptions.None);

                        for (int i = 0; i < partes.Length - 1; i++)
                        {
                            string nome = partes[i].Trim();
                            string preco = partes[i + 1].Substring(0, partes[i + 1].IndexOf(',') != -1
                                ? partes[i + 1].IndexOf(',')
                                : partes[i + 1].Length);

                            string item = $"{nome} - R$ {preco}";

                            listBox1.Items.Add(item);
                        }

                        // ✅ Atualiza total ao carregar
                        AtualizarTotal();

                    }
                }
                

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLanche_Click(object sender, EventArgs e)
        {

            if (cbLanche1.SelectedIndex == -1) return;

            string nome = cbLanche1.Text;
            decimal preco = PrecoLanche(nome);

            string item = $"{nome} - R$ {preco:F2}";

            listBox1.Items.Add(item);
            AtualizarTotal();

            houveAlteracao = true; 

            cbLanche1.SelectedIndex = -1;
        }

        private void btnAddAcompanhamento_Click(object sender, EventArgs e)
        {
            if (cbAcomp.SelectedIndex == -1) return;

            string nome = cbAcomp.Text;
            decimal preco = PrecoAcompanhamento(nome);

            string item = $"{nome} - R$ {preco:F2}";

            listBox1.Items.Add(item);
            AtualizarTotal();

            houveAlteracao = true; 

            cbAcomp.SelectedIndex = -1;
        }

        private void btnAddBebida_Click(object sender, EventArgs e)
        {

            if (cbBebida1.SelectedIndex == -1) return;

            string nome = cbBebida1.Text;
            decimal preco = PrecoBebida(nome);

            string item = $"{nome} - R$ {preco:F2}";

            listBox1.Items.Add(item);
            AtualizarTotal();

            houveAlteracao = true; 

            cbBebida1.SelectedIndex = -1;
        }

        private void AtualizarTotal()
        {

            decimal total = 0;

            foreach (string item in listBox1.Items)
            {
                // pega o preço depois do "R$"
                if (item.Contains("R$"))
                {
                    string partePreco = item.Split("R$")[1].Trim();

                    // troca vírgula por ponto para converter
                    partePreco = partePreco.Replace(",", ".");

                    decimal preco;
                    if (decimal.TryParse(partePreco, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out preco))
                    {
                        total += preco;
                    }
                }
            }

            labelTotal.Text = $"R$ {total:F2}";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = Conexao.Connection())
            {
                conn.Open();


                string sql = @"UPDATE pedidos 
               SET itens = @itens,
                   observacoes = @obs
               WHERE id_pedido = @id";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                string itens = itensOriginais;

                if (houveAlteracao && listBox1.Items.Count > 0)
                {
                    itens = string.Join(", ", listBox1.Items.Cast<string>());
                }


                cmd.Parameters.AddWithValue("@itens", itens);
                cmd.Parameters.AddWithValue("@id", _idPedido);
                cmd.Parameters.AddWithValue("@obs", txtObservacoes.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido atualizado com sucesso!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                AtualizarTotal();

                houveAlteracao = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                AtualizarTotal();

                houveAlteracao = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                AtualizarTotal();

                houveAlteracao = true;
            }
        }

        private decimal PrecoLanche(string lanche)
        {
            switch (lanche)
            {
                case "Smash Tasty": return 18;
                case "Smash Original": return 15;
                case "Smash Egg": return 17;
                case "Frango Supremo Crocante": return 19;
                case "Smash Duplo Egg": return 22;
                case "Smash Original Duplo": return 21;
                case "Smash Onions Duplo": return 23;
                default: return 0;
            }
        }

        private decimal PrecoAcompanhamento(string acomp)
        {
            switch (acomp)
            {
                case "Batata Frita Pequena": return 6;
                case "Batata Frita Média": return 8;
                case "Batata Frita Grande": return 10;
                case "Onion Rings": return 9;
                case "Nuggets 6 unidades": return 7;
                case "Nuggets 10 unidades": return 11;
                default: return 0;
            }
        }

        private decimal PrecoBebida(string bebida)
        {
            switch (bebida)
            {
                case "Coca Cola 350ml": return 5;
                case "Coca Cola 600ml": return 7;
                case "Coca Cola Zero 350ml": return 5;
                case "Coca Cola Zero 600ml": return 7;
                case "Guaraná 350ml": return 5;
                case "Guaraná 600ml": return 7;
                case "Suco Laranja": return 6;
                case "Limonada": return 5;
                default: return 0;
            }
        }
        private void cbLanche1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMesa_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {

            if (houveAlteracao)
            {
                DialogResult resposta = MessageBox.Show(
                    "Deseja descartar as alterações?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resposta == DialogResult.No)
                    return;
            }

            // ✅ Fecha o painel de edição
            this.Parent.Controls.Remove(this);

        }

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {
            houveAlteracao = true;
        }

    }
}
