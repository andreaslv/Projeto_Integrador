namespace Tela_Inicial
{
    partial class PedidosFinalizadosUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosFinalizadosUC));
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Pedidos = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Forma_de_pagamento = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Observação = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(74, 67);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(485, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(438, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 0;
            label2.Text = "Data:";
            label2.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pedidos, Valor, Forma_de_pagamento, Horario, Observação });
            dataGridView1.Location = new Point(32, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(702, 318);
            dataGridView1.TabIndex = 2;
            // 
            // Pedidos
            // 
            Pedidos.HeaderText = "Pedidos";
            Pedidos.Name = "Pedidos";
            Pedidos.Width = 110;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Forma_de_pagamento
            // 
            Forma_de_pagamento.HeaderText = "Forma_de_pagamento";
            Forma_de_pagamento.Name = "Forma_de_pagamento";
            Forma_de_pagamento.Width = 150;
            // 
            // Horario
            // 
            Horario.HeaderText = "Horário";
            Horario.Name = "Horario";
            // 
            // Observação
            // 
            Observação.HeaderText = "Observação";
            Observação.Name = "Observação";
            Observação.Width = 210;
            // 
            // button1
            // 
            button1.Location = new Point(286, 486);
            button1.Name = "button1";
            button1.Size = new Size(202, 38);
            button1.TabIndex = 3;
            button1.Text = "Ver detalhes do pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 51);
            panel1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(286, 14);
            label5.Name = "label5";
            label5.Size = new Size(222, 25);
            label5.TabIndex = 0;
            label5.Text = "PEDIDOS FINALIZADOS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(74, 442);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 0;
            label3.Text = "Total do dia:";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9.75F);
            label4.Location = new Point(166, 442);
            label4.Name = "label4";
            label4.Size = new Size(23, 17);
            label4.TabIndex = 0;
            label4.Text = "R$";
            label4.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(444, 442);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 0;
            label6.Text = "Total de pedidos:";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 9.75F);
            label7.Location = new Point(565, 444);
            label7.Name = "label7";
            label7.Size = new Size(126, 17);
            label7.TabIndex = 0;
            label7.Text = "numero_de_pedidos";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 9.75F);
            label8.Location = new Point(195, 442);
            label8.Name = "label8";
            label8.Size = new Size(37, 17);
            label8.TabIndex = 0;
            label8.Text = "valor";
            label8.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(350, 66);
            button2.Name = "button2";
            button2.Size = new Size(45, 25);
            button2.TabIndex = 30;
            button2.UseVisualStyleBackColor = true;
            // 
            // PedidosFinalizadosUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PedidosFinalizadosUC";
            Size = new Size(771, 551);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn Pedidos;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Forma_de_pagamento;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Observação;
        private Button button2;
    }
}
