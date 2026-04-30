namespace Tela_Inicial
{
    partial class telaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            panel1 = new Panel();
            btnFechar = new Button();
            btnEntrar = new Button();
            label1 = new Label();
            Login = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(191, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 540);
            panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ButtonHighlight;
            btnFechar.Location = new Point(332, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(37, 32);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += button2_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(129, 406);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(129, 41);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 314);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 1;
            label1.Text = "Senha:";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = SystemColors.ActiveCaptionText;
            Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(36, 247);
            Login.Name = "Login";
            Login.Size = new Size(57, 21);
            Login.TabIndex = 2;
            Login.Text = "Login:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(113, 316);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(180, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(113, 245);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(180, 23);
            txtLogin.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 149);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(771, 536);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "telaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Login;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button button1;
        private Label label3;
        private Button btnFechar;
    }
}