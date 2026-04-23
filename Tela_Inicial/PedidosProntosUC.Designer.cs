namespace Tela_Inicial
{
    partial class PedidosProntosUC
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
            dgvPedidosProntos = new DataGridView();
            Pedido = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Observação = new DataGridViewTextBoxColumn();
            btnEntregarPedido = new Button();
            btnVoltaPreparo = new Button();
            btnCancelarPedido = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosProntos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidosProntos
            // 
            dgvPedidosProntos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPedidosProntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosProntos.Columns.AddRange(new DataGridViewColumn[] { Pedido, Horario, Status, Observação });
            dgvPedidosProntos.Location = new Point(52, 85);
            dgvPedidosProntos.Name = "dgvPedidosProntos";
            dgvPedidosProntos.Size = new Size(660, 328);
            dgvPedidosProntos.TabIndex = 1;
            dgvPedidosProntos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Pedido
            // 
            Pedido.HeaderText = "Pedido";
            Pedido.Name = "Pedido";
            Pedido.Width = 120;
            // 
            // Horario
            // 
            Horario.HeaderText = "Horário";
            Horario.Name = "Horario";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Observação
            // 
            Observação.HeaderText = "Observação";
            Observação.Name = "Observação";
            Observação.Width = 250;
            // 
            // btnEntregarPedido
            // 
            btnEntregarPedido.BackColor = SystemColors.ActiveBorder;
            btnEntregarPedido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEntregarPedido.ForeColor = SystemColors.ActiveCaptionText;
            btnEntregarPedido.Location = new Point(52, 458);
            btnEntregarPedido.Name = "btnEntregarPedido";
            btnEntregarPedido.Size = new Size(155, 38);
            btnEntregarPedido.TabIndex = 2;
            btnEntregarPedido.Text = "Entregar pedido";
            btnEntregarPedido.UseVisualStyleBackColor = false;
            // 
            // btnVoltaPreparo
            // 
            btnVoltaPreparo.BackColor = SystemColors.ActiveBorder;
            btnVoltaPreparo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnVoltaPreparo.Location = new Point(291, 458);
            btnVoltaPreparo.Name = "btnVoltaPreparo";
            btnVoltaPreparo.Size = new Size(168, 38);
            btnVoltaPreparo.TabIndex = 3;
            btnVoltaPreparo.Text = "Voltar para o preparo";
            btnVoltaPreparo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.BackColor = SystemColors.ActiveBorder;
            btnCancelarPedido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancelarPedido.Location = new Point(536, 458);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(158, 38);
            btnCancelarPedido.TabIndex = 4;
            btnCancelarPedido.Text = "Cancelar pedido";
            btnCancelarPedido.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 51);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 13);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 0;
            label2.Text = "PEDIDOS PRONTOS";
            // 
            // PedidosProntosUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnVoltaPreparo);
            Controls.Add(btnEntregarPedido);
            Controls.Add(dgvPedidosProntos);
            Name = "PedidosProntosUC";
            Size = new Size(771, 551);
            ((System.ComponentModel.ISupportInitialize)dgvPedidosProntos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvPedidosProntos;
        private Button btnEntregarPedido;
        private Button btnVoltaPreparo;
        private Button btnCancelarPedido;
        private Panel panel1;
        private Label label2;
        private DataGridViewTextBoxColumn Pedido;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Observação;
    }
}
