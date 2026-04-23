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
            ltbPedido = new ListBox();
            label6 = new Label();
            txtObservacoes = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.BackColor = Color.Silver;
            btnSalvarPedido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSalvarPedido.Location = new Point(136, 447);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(149, 38);
            btnSalvarPedido.TabIndex = 26;
            btnSalvarPedido.Text = "Salvar Pedido";
            btnSalvarPedido.UseVisualStyleBackColor = false;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ScrollBar;
            txtNomeCliente.Location = new Point(38, 87);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(315, 23);
            txtNomeCliente.TabIndex = 25;
            // 
            // cbBebidas
            // 
            cbBebidas.BackColor = SystemColors.ScrollBar;
            cbBebidas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cbBebidas.FormattingEnabled = true;
            cbBebidas.Location = new Point(342, 168);
            cbBebidas.Name = "cbBebidas";
            cbBebidas.Size = new Size(109, 25);
            cbBebidas.TabIndex = 24;
            cbBebidas.Text = "Bebidas";
            // 
            // cbAcompanhamento
            // 
            cbAcompanhamento.BackColor = SystemColors.ScrollBar;
            cbAcompanhamento.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cbAcompanhamento.FormattingEnabled = true;
            cbAcompanhamento.Items.AddRange(new object[] { "Batata frita", "Onion Ring", "" });
            cbAcompanhamento.Location = new Point(175, 168);
            cbAcompanhamento.Name = "cbAcompanhamento";
            cbAcompanhamento.Size = new Size(149, 25);
            cbAcompanhamento.TabIndex = 23;
            cbAcompanhamento.Text = "Acompanhamentos";
            // 
            // cbMesa
            // 
            cbMesa.BackColor = SystemColors.ScrollBar;
            cbMesa.ForeColor = SystemColors.WindowFrame;
            cbMesa.FormattingEnabled = true;
            cbMesa.Location = new Point(394, 87);
            cbMesa.Name = "cbMesa";
            cbMesa.Size = new Size(77, 23);
            cbMesa.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(25, 206);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 17;
            label4.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(377, 65);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 16;
            label3.Text = "Mesa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(25, 129);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 15;
            label2.Text = "Itens do pedido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(25, 65);
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
            // ltbPedido
            // 
            ltbPedido.FormattingEnabled = true;
            ltbPedido.ItemHeight = 15;
            ltbPedido.Location = new Point(481, 151);
            ltbPedido.Name = "ltbPedido";
            ltbPedido.Size = new Size(268, 364);
            ltbPedido.TabIndex = 28;
            ltbPedido.SelectedIndexChanged += ltbPedido_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(585, 126);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 16;
            label6.Text = "Pedido";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(25, 332);
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(394, 23);
            txtObservacoes.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(25, 301);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 17;
            label7.Text = "Observações:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 31;
            comboBox1.Text = "Lanche";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(13, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(234, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 32;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(114, 37);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 32;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton1";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(25, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 78);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // NovoPedidoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtObservacoes);
            Controls.Add(ltbPedido);
            Controls.Add(panel1);
            Controls.Add(btnSalvarPedido);
            Controls.Add(txtNomeCliente);
            Controls.Add(cbBebidas);
            Controls.Add(cbAcompanhamento);
            Controls.Add(cbMesa);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NovoPedidoUC";
            Size = new Size(771, 551);
            Load += NovoPedidoUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ListBox ltbPedido;
        private Label label6;
        private TextBox txtObservacoes;
        private Label label7;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
    }
}
