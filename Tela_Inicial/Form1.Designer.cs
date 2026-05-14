namespace Tela_Inicial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button5 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            panel5 = new Panel();
            lblHora = new Label();
            lblCargo = new Label();
            lblNomeUsuario = new Label();
            btn_Sair = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            label2 = new Label();
            panel4 = new Panel();
            pnl_NvPedido = new Panel();
            panel6 = new Panel();
            panelDetalhes = new Panel();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(216, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 56);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(1207, 4);
            button5.Name = "button5";
            button5.Size = new Size(42, 37);
            button5.TabIndex = 1;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 0;
            label1.Text = "Controle de Pedido";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblCargo);
            panel3.Controls.Add(lblNomeUsuario);
            panel3.Controls.Add(btn_Sair);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 721);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 589);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(9, 19, 31);
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(12, 682);
            panel7.Name = "panel7";
            panel7.Size = new Size(99, 33);
            panel7.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(9, 19, 31);
            panel5.Controls.Add(lblHora);
            panel5.Location = new Point(12, 639);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 37);
            panel5.TabIndex = 5;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHora.ForeColor = Color.DarkOrange;
            lblHora.Location = new Point(70, 7);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(72, 21);
            lblHora.TabIndex = 4;
            lblHora.Text = "00:00:00";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 11.25F);
            lblCargo.ForeColor = SystemColors.ButtonHighlight;
            lblCargo.Location = new Point(72, 610);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(49, 20);
            lblCargo.TabIndex = 4;
            lblCargo.Text = "Cargo";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI", 12F);
            lblNomeUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblNomeUsuario.Location = new Point(72, 589);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(111, 21);
            lblNomeUsuario.TabIndex = 4;
            lblNomeUsuario.Text = "Nome Usuário";
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.FromArgb(9, 19, 31);
            btn_Sair.BackgroundImage = (Image)resources.GetObject("btn_Sair.BackgroundImage");
            btn_Sair.BackgroundImageLayout = ImageLayout.Center;
            btn_Sair.FlatAppearance.BorderColor = Color.FromArgb(9, 19, 31);
            btn_Sair.FlatStyle = FlatStyle.Flat;
            btn_Sair.Location = new Point(115, 682);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(99, 33);
            btn_Sair.TabIndex = 3;
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(9, 19, 31);
            button6.FlatAppearance.BorderColor = Color.FromArgb(9, 19, 31);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 228);
            button6.Name = "button6";
            button6.Size = new Size(216, 57);
            button6.TabIndex = 2;
            button6.Text = "Home";
            button6.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 646);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 248, 240);
            panel4.Controls.Add(pnl_NvPedido);
            panel4.Location = new Point(217, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(860, 603);
            panel4.TabIndex = 3;
            // 
            // pnl_NvPedido
            // 
            pnl_NvPedido.BackColor = Color.FromArgb(255, 248, 240);
            pnl_NvPedido.Location = new Point(48, 26);
            pnl_NvPedido.Name = "pnl_NvPedido";
            pnl_NvPedido.Size = new Size(771, 551);
            pnl_NvPedido.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Bisque;
            panel6.Controls.Add(panelDetalhes);
            panel6.Location = new Point(1083, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(389, 660);
            panel6.TabIndex = 1;
            // 
            // panelDetalhes
            // 
            panelDetalhes.BackColor = Color.FromArgb(255, 248, 240);
            panelDetalhes.Location = new Point(9, 7);
            panelDetalhes.Name = "panelDetalhes";
            panelDetalhes.Size = new Size(366, 636);
            panelDetalhes.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(99, 7);
            button1.Name = "button1";
            button1.Size = new Size(161, 39);
            button1.TabIndex = 2;
            button1.Text = "Novo Produto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(88, 152, 57);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(451, 7);
            button2.Name = "button2";
            button2.Size = new Size(161, 39);
            button2.TabIndex = 2;
            button2.Text = "Prontos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(112, 115, 126);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(627, 7);
            button4.Name = "button4";
            button4.Size = new Size(161, 39);
            button4.TabIndex = 2;
            button4.Text = "Finalizados";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 121, 36);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(275, 7);
            button3.Name = "button3";
            button3.Size = new Size(161, 39);
            button3.TabIndex = 2;
            button3.Text = "Em Preparo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(216, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 51);
            panel2.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1470, 720);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel pnl_NvPedido;
        private Panel panel6;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel2;
        private Button button5;
        private Panel panelDetalhes;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button6;
        private Panel panel5;
        private Label lblCargo;
        private Label lblNomeUsuario;
        private Label lblHora;
        private Button btn_Sair;
        private Panel panel7;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
