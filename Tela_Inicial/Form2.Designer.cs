namespace Tela_Inicial
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button4 = new Button();
            textBox1 = new TextBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(-5, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Pedido";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button4.Location = new Point(99, 368);
            button4.Name = "button4";
            button4.Size = new Size(149, 38);
            button4.TabIndex = 13;
            button4.Text = "Salvar Pedido";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(23, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 32);
            textBox1.TabIndex = 12;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = SystemColors.ScrollBar;
            comboBox4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(241, 135);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(92, 25);
            comboBox4.TabIndex = 11;
            comboBox4.Text = "Refrigerante";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.ScrollBar;
            comboBox3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Batata frita", "Onion Ring", "" });
            comboBox3.Location = new Point(126, 135);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(94, 25);
            comboBox3.TabIndex = 10;
            comboBox3.Text = "Acompanhamentos";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ScrollBar;
            comboBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Smash onios", "Smash Melt duplo", "Bomba de chedar", "Smash Tasty ", "Smash Original Duplo ", "Smash Onions Duplo", "Googlebig", "Whatsauce ( X-Salada )", "Facebacon ( X-Bacon )", "Pcq ( X-burguer )", "Burger Tik Crock " });
            comboBox2.Location = new Point(16, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(84, 25);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "Lanches";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ScrollBar;
            comboBox1.ForeColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(241, 296);
            button3.Name = "button3";
            button3.Size = new Size(75, 47);
            button3.TabIndex = 7;
            button3.Text = "Cartão";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(130, 302);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 6;
            button2.Text = "Pix";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(23, 302);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 5;
            button1.Text = "Dinheiro";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 259);
            label4.Name = "label4";
            label4.Size = new Size(200, 25);
            label4.TabIndex = 4;
            label4.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(6, 181);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 3;
            label3.Text = "Endereço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(5, 95);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 2;
            label2.Text = "Itens do pedido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 1;
            label1.Text = "Nome do cliente";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(401, 448);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Padding = new Padding(15, 20, 15, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Button button4;
        private TextBox textBox1;
    }
}