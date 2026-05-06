namespace Tela_Inicial
{
    partial class NovoPedidoUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvarPedido = new Button();
            txtNomeCliente = new TextBox();
            cbBebidas = new ComboBox();
            cbAcompanhamento = new ComboBox();
            cbMesa = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtObservacoes = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            rbDinheiro = new RadioButton();
            rbCartao = new RadioButton();
            rbPix = new RadioButton();
            gpPagamento = new GroupBox();
            label8 = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            gpPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.BackColor = Color.Silver;
            btnSalvarPedido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSalvarPedido.Location = new Point(300, 486);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(160, 38);
            btnSalvarPedido.TabIndex = 26;
            btnSalvarPedido.Text = "Salvar Pedido";
            btnSalvarPedido.UseVisualStyleBackColor = false;
            btnSalvarPedido.Click += btnSalvarPedido_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ScrollBar;
            txtNomeCliente.Location = new Point(157, 96);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(328, 23);
            txtNomeCliente.TabIndex = 25;
            txtNomeCliente.KeyPress += txtNomeCliente_KeyPress;
            // 
            // cbBebidas
            // 
            cbBebidas.BackColor = SystemColors.ScrollBar;
            cbBebidas.DropDownWidth = 250;
            cbBebidas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cbBebidas.FormattingEnabled = true;
            cbBebidas.Items.AddRange(new object[] { "Coca Cola 350ml", "Coca Cola 600ml", "Coca Cola Zero 350ml", "Coca Cola Zero 600ml", "Guaraná 350ml", "Guaraná 600ml", "Suco Laranja 300ml", "Limonada 300ml" });
            cbBebidas.Location = new Point(491, 177);
            cbBebidas.Name = "cbBebidas";
            cbBebidas.Size = new Size(112, 25);
            cbBebidas.TabIndex = 24;
            cbBebidas.Text = "Bebidas";
            cbBebidas.SelectedIndexChanged += cbBebidas_SelectedIndexChanged;
            // 
            // cbAcompanhamento
            // 
            cbAcompanhamento.BackColor = SystemColors.ScrollBar;
            cbAcompanhamento.DropDownWidth = 250;
            cbAcompanhamento.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cbAcompanhamento.FormattingEnabled = true;
            cbAcompanhamento.Items.AddRange(new object[] { "Batata Frita Pequena", "Batata Frita Média", "Batata Frita Grande", "Onion Rings", "Nuggets 6 unidades", "Nuggets 10 unidades" });
            cbAcompanhamento.Location = new Point(317, 177);
            cbAcompanhamento.Name = "cbAcompanhamento";
            cbAcompanhamento.Size = new Size(149, 25);
            cbAcompanhamento.TabIndex = 23;
            cbAcompanhamento.Text = "Acompanhamentos";
            cbAcompanhamento.SelectedIndexChanged += cbAcompanhamento_SelectedIndexChanged;
            // 
            // cbMesa
            // 
            cbMesa.BackColor = SystemColors.ScrollBar;
            cbMesa.ForeColor = SystemColors.WindowFrame;
            cbMesa.FormattingEnabled = true;
            cbMesa.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbMesa.Location = new Point(526, 96);
            cbMesa.Name = "cbMesa";
            cbMesa.Size = new Size(77, 23);
            cbMesa.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(157, 229);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 17;
            label4.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(526, 74);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 16;
            label3.Text = "Mesa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(157, 150);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 15;
            label2.Text = "Itens do pedido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(157, 74);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 14;
            label1.Text = "Nome do cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(317, 14);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 0;
            label5.Text = "NOVO PEDIDO";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 51);
            panel1.TabIndex = 27;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(157, 379);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(446, 23);
            txtObservacoes.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(157, 310);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 17;
            label7.Text = "Observações:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.DropDownWidth = 250;
            comboBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Smash Tasty", "Smash Original", "Smash Egg", "Frango Supremo Crocante", "Smash Duplo Egg", "Smash Original Duplo", "Smash Onions Duplo" });
            comboBox1.Location = new Point(157, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 31;
            comboBox1.Text = "Lanche";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Location = new Point(64, 37);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(70, 19);
            rbDinheiro.TabIndex = 32;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(306, 37);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(60, 19);
            rbCartao.TabIndex = 32;
            rbCartao.TabStop = true;
            rbCartao.Text = "Cartão";
            rbCartao.UseVisualStyleBackColor = true;
            rbCartao.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(195, 37);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(40, 19);
            rbPix.TabIndex = 32;
            rbPix.TabStop = true;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // gpPagamento
            // 
            gpPagamento.Controls.Add(rbDinheiro);
            gpPagamento.Controls.Add(rbPix);
            gpPagamento.Controls.Add(rbCartao);
            gpPagamento.Location = new Point(157, 251);
            gpPagamento.Name = "gpPagamento";
            gpPagamento.Size = new Size(446, 78);
            gpPagamento.TabIndex = 33;
            gpPagamento.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(157, 348);
            label8.Name = "label8";
            label8.Size = new Size(92, 19);
            label8.TabIndex = 17;
            label8.Text = "Observações:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(334, 433);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 32);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "R$ 0,00";
            // 
            // NovoPedidoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotal);
            Controls.Add(gpPagamento);
            Controls.Add(comboBox1);
            Controls.Add(txtObservacoes);
            Controls.Add(panel1);
            Controls.Add(btnSalvarPedido);
            Controls.Add(txtNomeCliente);
            Controls.Add(cbBebidas);
            Controls.Add(cbAcompanhamento);
            Controls.Add(cbMesa);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NovoPedidoUC";
            Size = new Size(771, 551);
            Load += NovoPedidoUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gpPagamento.ResumeLayout(false);
            gpPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvarPedido;
        private TextBox txtNomeCliente;
        private ComboBox cbBebidas;
        private ComboBox cbAcompanhamento;
        private ComboBox cbLanches;
        private ComboBox cbMesa;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Panel panel1;
        private TextBox txtObservacoes;
        private Label label7;
        private ComboBox comboBox1;
        private RadioButton rbDinheiro;
        private RadioButton rbCartao;
        private RadioButton rbPix;
        private GroupBox gpPagamento;
        private Label label8;
        private Label lblTotal;
    }
}
