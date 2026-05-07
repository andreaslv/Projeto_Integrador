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
            btnEntrar = new Button();
            label1 = new Label();
            Login = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            pictureBox1 = new PictureBox();
            btnFecharL = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Red;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(322, 551);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(129, 41);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(242, 465);
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
            Login.Location = new Point(242, 347);
            Login.Name = "Login";
            Login.Size = new Size(57, 21);
            Login.TabIndex = 2;
            Login.Text = "Login:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(30, 30, 30);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(242, 489);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(274, 30);
            txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(30, 30, 30);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(242, 371);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(274, 33);
            txtLogin.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, -36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(483, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnFecharL
            // 
            btnFecharL.BackColor = Color.Red;
            btnFecharL.FlatAppearance.BorderSize = 0;
            btnFecharL.FlatStyle = FlatStyle.Flat;
            btnFecharL.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecharL.ForeColor = Color.Black;
            btnFecharL.Location = new Point(717, 0);
            btnFecharL.Name = "btnFecharL";
            btnFecharL.Size = new Size(44, 42);
            btnFecharL.TabIndex = 4;
            btnFecharL.Text = "X";
            btnFecharL.UseVisualStyleBackColor = false;
            btnFecharL.Click += btnFecharL_Click;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(762, 667);
            Controls.Add(btnFecharL);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "telaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLogin;
        private Label label1;
        private Label Login;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnFecharL;
    }
}