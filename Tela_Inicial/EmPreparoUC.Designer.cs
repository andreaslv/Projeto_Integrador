namespace Tela_Inicial
{
    partial class EmPreparoUC
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
            panel1 = new Panel();
            label1 = new Label();
            dgvEmPreparo = new DataGridView();
            btnMarcarPronto = new Button();
            btnCancelarPedido = new Button();
            btnEditarPedido = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmPreparo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 14);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "EM PREPARO";
            // 
            // dgvEmPreparo
            // 
            dgvEmPreparo.BackgroundColor = SystemColors.MenuBar;
            dgvEmPreparo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmPreparo.Location = new Point(19, 57);
            dgvEmPreparo.Name = "dgvEmPreparo";
            dgvEmPreparo.Size = new Size(733, 388);
            dgvEmPreparo.TabIndex = 1;
            dgvEmPreparo.CellContentClick += dgvEmPreparo_CellContentClick;
            // 
            // btnMarcarPronto
            // 
            btnMarcarPronto.Location = new Point(32, 482);
            btnMarcarPronto.Name = "btnMarcarPronto";
            btnMarcarPronto.Size = new Size(213, 38);
            btnMarcarPronto.TabIndex = 2;
            btnMarcarPronto.Text = "Marcar como Pronto";
            btnMarcarPronto.UseVisualStyleBackColor = true;
            btnMarcarPronto.Click += btnMarcarPronto_Click;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Location = new Point(528, 482);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(213, 38);
            btnCancelarPedido.TabIndex = 2;
            btnCancelarPedido.Text = "Cancelar Pedido";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            btnCancelarPedido.Click += btnCancelarPedido_Click;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.Location = new Point(280, 482);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(213, 38);
            btnEditarPedido.TabIndex = 3;
            btnEditarPedido.Text = "Editar Pedido";
            btnEditarPedido.UseVisualStyleBackColor = true;
            btnEditarPedido.Click += button1_Click;
            // 
            // EmPreparoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnEditarPedido);
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnMarcarPronto);
            Controls.Add(dgvEmPreparo);
            Controls.Add(panel1);
            Name = "EmPreparoUC";
            Size = new Size(771, 551);
            Load += EmPreparoUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmPreparo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvEmPreparo;
        private Button btnMarcarPronto;
        private Button btnCancelarPedido;
        private Button btnEditarPedido;
    }
}
