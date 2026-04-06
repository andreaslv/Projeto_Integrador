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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_NvPedido.Controls.Clear();
            Form2 NovoPedido = new Form2();
            NovoPedido.Dock = DockStyle.Fill;
            pnl_NvPedido.Controls.Add(NovoPedido);
        }

    }
}
