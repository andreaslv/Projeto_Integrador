using MySql.Data.MySqlClient;
namespace Tela_Inicial
{
    public partial class Form1 : Form
    {

        private EmPreparoUC emPreparoUC;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            pnl_NvPedido.Controls.Clear();

            emPreparoUC = new EmPreparoUC();

            emPreparoUC.PedidoEditarSolicitado += AbrirEditarPedido;

            emPreparoUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(emPreparoUC);

        }

        private void AbrirEditarPedido(int idPedido)
        {

            panelDetalhes.Visible = true;
            panelDetalhes.Controls.Clear();

            EditarPedidoUC editar = new EditarPedidoUC(idPedido);

            // ? AQUI É O PONTO IMPORTANTE
            editar.PedidoAtualizado += AtualizarEmPreparo;

            editar.Dock = DockStyle.Fill;
            panelDetalhes.Controls.Add(editar);

        }

        private void AtualizarEmPreparo()
        {
            // pega o EmPreparo que já está na tela

            foreach (Control ctrl in pnl_NvPedido.Controls)
            {
                if (emPreparoUC != null)
                {
                    emPreparoUC.CarregarUsuarios();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LimparPainelDetalhes();

            pnl_NvPedido.Controls.Clear();
            PedidosProntosUC PedidosProntosUC = new PedidosProntosUC();
            PedidosProntosUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(PedidosProntosUC);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LimparPainelDetalhes();

            pnl_NvPedido.Controls.Clear();
            NovoPedidoUC NovoPedidoUC = new NovoPedidoUC();
            NovoPedidoUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(NovoPedidoUC);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimparPainelDetalhes();

            pnl_NvPedido.Controls.Clear();
            PedidosFinalizadosUC PedidosFinalizadosUC = new PedidosFinalizadosUC();
            PedidosFinalizadosUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(PedidosFinalizadosUC);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparPainelDetalhes()
        {
            panelDetalhes.Controls.Clear();
            panelDetalhes.Visible = false; // opcional, mas recomendado
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            // Cole isso
            var result = MessageBox.Show("Deseja realmente sair?", "Confirmação",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new telaLogin().Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = "Felipe Monteiro";
            lblCargo.Text = "Dono";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
