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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            pnl_NvPedido = new Panel();
            panel6 = new Panel();
            btnEditarPedidos = new Button();
            label2 = new Label();
            dgvListadePedidos = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadePedidos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 22);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 0;
            label1.Text = "Controle de Pedido";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(-3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 721);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.HighlightText;
            panel8.Controls.Add(label4);
            panel8.Location = new Point(3, 186);
            panel8.Name = "panel8";
            panel8.Size = new Size(211, 68);
            panel8.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(73, 25);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 0;
            label4.Text = "PEDIDOS";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.HighlightText;
            panel7.Controls.Add(label3);
            panel7.Location = new Point(3, 112);
            panel7.Name = "panel7";
            panel7.Size = new Size(211, 68);
            panel7.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(82, 25);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 0;
            label3.Text = "HOME";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(pnl_NvPedido);
            panel4.Location = new Point(217, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(860, 603);
            panel4.TabIndex = 3;
            // 
            // pnl_NvPedido
            // 
            pnl_NvPedido.BackColor = SystemColors.InactiveBorder;
            pnl_NvPedido.Location = new Point(48, 26);
            pnl_NvPedido.Name = "pnl_NvPedido";
            pnl_NvPedido.Size = new Size(771, 551);
            pnl_NvPedido.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLight;
            panel6.Controls.Add(btnEditarPedidos);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(dgvListadePedidos);
            panel6.Location = new Point(1083, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(389, 660);
            panel6.TabIndex = 1;
            // 
            // btnEditarPedidos
            // 
            btnEditarPedidos.Location = new Point(117, 598);
            btnEditarPedidos.Name = "btnEditarPedidos";
            btnEditarPedidos.Size = new Size(180, 36);
            btnEditarPedidos.TabIndex = 3;
            btnEditarPedidos.Text = "Editar Pedido";
            btnEditarPedidos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 14);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 2;
            label2.Text = "Lista de Pedidos";
            // 
            // dgvListadePedidos
            // 
            dgvListadePedidos.BackgroundColor = SystemColors.InactiveBorder;
            dgvListadePedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadePedidos.Location = new Point(10, 57);
            dgvListadePedidos.Name = "dgvListadePedidos";
            dgvListadePedidos.Size = new Size(367, 535);
            dgvListadePedidos.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(13, 92, 182);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(294, 7);
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
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(628, 7);
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
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(795, 7);
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
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(461, 7);
            button3.Name = "button3";
            button3.Size = new Size(161, 39);
            button3.TabIndex = 2;
            button3.Text = "Em Preparo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 51);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1470, 720);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadePedidos).EndInit();
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
        private Label label2;
        private DataGridView dgvListadePedidos;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel2;
        private Label label3;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnEditarPedidos;
    }
}
