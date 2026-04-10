namespace Tela_Inicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl_NvPedido.Controls.Clear();
            EmPreparoUC EmPreparoUC = new EmPreparoUC();
            EmPreparoUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(EmPreparoUC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_NvPedido.Controls.Clear();
            PedidosProntosUC PedidosProntosUC = new PedidosProntosUC();
            PedidosProntosUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(PedidosProntosUC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_NvPedido.Controls.Clear();
            NovoPedidoUC NovoPedidoUC = new NovoPedidoUC();
            NovoPedidoUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(NovoPedidoUC);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnl_NvPedido.Controls.Clear();
            PedidosFinalizadosUC PedidosFinalizadosUC = new PedidosFinalizadosUC();
            PedidosFinalizadosUC.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(PedidosFinalizadosUC);
        }
    }
}
