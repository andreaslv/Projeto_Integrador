namespace Tela_Inicial
{
    partial class EditarPedidoUC
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelTotal = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            cbLanche1 = new ComboBox();
            cbAcomp = new ComboBox();
            cbBebida1 = new ComboBox();
            txtObservacoes = new TextBox();
            btnAddLanche = new Button();
            button4 = new Button();
            btnAddAcomp = new Button();
            button6 = new Button();
            btnAddBebida = new Button();
            button8 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            lblMesa = new Label();
            lblNomeCliente1 = new Label();
            lblNumPedido = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 1;
            label1.Text = "Editar Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Lanche";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 2;
            label4.Text = "Mesa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(11, 205);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 2;
            label5.Text = "Acompanhamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(13, 254);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "Bebida";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(13, 495);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 2;
            label7.Text = "Observações";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(16, 552);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 3;
            label8.Text = "Total:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 11.25F);
            labelTotal.Location = new Point(58, 552);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(65, 20);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "R$ 00,00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 51);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 2;
            label10.Text = "Pedido";
            // 
            // button1
            // 
            button1.Location = new Point(44, 587);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 587);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbLanche1
            // 
            cbLanche1.FormattingEnabled = true;
            cbLanche1.Items.AddRange(new object[] { "Smash Tasty", "Smash Original", "Smash Egg", "Frango Supremo Crocante", "Smash Duplo Egg", "Smash Original Duplo", "Smash Onions Duplo" });
            cbLanche1.Location = new Point(12, 176);
            cbLanche1.Name = "cbLanche1";
            cbLanche1.Size = new Size(137, 23);
            cbLanche1.TabIndex = 9;
            cbLanche1.SelectedIndexChanged += cbLanche1_SelectedIndexChanged;
            // 
            // cbAcomp
            // 
            cbAcomp.FormattingEnabled = true;
            cbAcomp.Items.AddRange(new object[] { "Batata Frita Pequena", "Batata Frita Média", "Batata Frita Grande", "Onion Rings", "Nuggets 6 unidades", "Nuggets 10 unidades" });
            cbAcomp.Location = new Point(12, 228);
            cbAcomp.Name = "cbAcomp";
            cbAcomp.Size = new Size(137, 23);
            cbAcomp.TabIndex = 10;
            // 
            // cbBebida1
            // 
            cbBebida1.FormattingEnabled = true;
            cbBebida1.Items.AddRange(new object[] { "Coca Cola 350ml", "Coca Cola 600ml", "Coca Cola Zero 350ml", "Coca Cola Zero 600ml", "Guaraná 350ml", "Guaraná 600ml", "Suco Laranja 300ml", "Limonada 300ml" });
            cbBebida1.Location = new Point(13, 277);
            cbBebida1.Name = "cbBebida1";
            cbBebida1.Size = new Size(137, 23);
            cbBebida1.TabIndex = 11;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(13, 518);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(330, 23);
            txtObservacoes.TabIndex = 12;
            // 
            // btnAddLanche
            // 
            btnAddLanche.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAddLanche.Location = new Point(154, 176);
            btnAddLanche.Name = "btnAddLanche";
            btnAddLanche.Size = new Size(38, 23);
            btnAddLanche.TabIndex = 16;
            btnAddLanche.Text = "+";
            btnAddLanche.UseVisualStyleBackColor = true;
            btnAddLanche.Click += btnAddLanche_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            button4.Location = new Point(198, 176);
            button4.Name = "button4";
            button4.Size = new Size(38, 23);
            button4.TabIndex = 16;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnAddAcomp
            // 
            btnAddAcomp.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAddAcomp.Location = new Point(154, 228);
            btnAddAcomp.Name = "btnAddAcomp";
            btnAddAcomp.Size = new Size(38, 23);
            btnAddAcomp.TabIndex = 16;
            btnAddAcomp.Text = "+";
            btnAddAcomp.UseVisualStyleBackColor = true;
            btnAddAcomp.Click += btnAddAcompanhamento_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            button6.Location = new Point(198, 227);
            button6.Name = "button6";
            button6.Size = new Size(38, 23);
            button6.TabIndex = 16;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnAddBebida
            // 
            btnAddBebida.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAddBebida.Location = new Point(155, 277);
            btnAddBebida.Name = "btnAddBebida";
            btnAddBebida.Size = new Size(38, 23);
            btnAddBebida.TabIndex = 16;
            btnAddBebida.Text = "+";
            btnAddBebida.UseVisualStyleBackColor = true;
            btnAddBebida.Click += btnAddBebida_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            button8.Location = new Point(199, 276);
            button8.Name = "button8";
            button8.Size = new Size(38, 23);
            button8.TabIndex = 16;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(13, 84);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome do cliente:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(11, 317);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(332, 154);
            listBox1.TabIndex = 17;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Segoe UI", 11.25F);
            lblMesa.Location = new Point(63, 115);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(21, 20);
            lblMesa.TabIndex = 18;
            lblMesa.Text = "   ";
            lblMesa.Click += lblMesa_Click;
            // 
            // lblNomeCliente1
            // 
            lblNomeCliente1.AutoSize = true;
            lblNomeCliente1.Font = new Font("Segoe UI", 11.25F);
            lblNomeCliente1.Location = new Point(135, 84);
            lblNomeCliente1.Name = "lblNomeCliente1";
            lblNomeCliente1.Size = new Size(17, 20);
            lblNomeCliente1.TabIndex = 18;
            lblNomeCliente1.Text = "  ";
            // 
            // lblNumPedido
            // 
            lblNumPedido.AutoSize = true;
            lblNumPedido.Font = new Font("Segoe UI", 11.25F);
            lblNumPedido.Location = new Point(63, 52);
            lblNumPedido.Name = "lblNumPedido";
            lblNumPedido.Size = new Size(38, 20);
            lblNumPedido.TabIndex = 18;
            lblNumPedido.Text = " #01";
            // 
            // EditarPedidoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNumPedido);
            Controls.Add(lblNomeCliente1);
            Controls.Add(lblMesa);
            Controls.Add(listBox1);
            Controls.Add(button8);
            Controls.Add(btnAddBebida);
            Controls.Add(button6);
            Controls.Add(btnAddAcomp);
            Controls.Add(button4);
            Controls.Add(btnAddLanche);
            Controls.Add(txtObservacoes);
            Controls.Add(cbBebida1);
            Controls.Add(cbAcomp);
            Controls.Add(cbLanche1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTotal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarPedidoUC";
            Size = new Size(366, 636);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelTotal;
        private Label label10;
        private Button button1;
        private Button button2;
        private ComboBox cbLanche1;
        private ComboBox cbAcomp;
        private ComboBox cbBebida1;
        private TextBox txtObservacoes;
        private Button btnAddLanche;
        private Button button4;
        private Button btnAddAcomp;
        private Button button6;
        private Button btnAddBebida;
        private Button button8;
        private Label label2;
        private ListBox listBox1;
        private Label lblMesa;
        private Label lblNomeCliente1;
        private Label lblNumPedido;
    }
}
