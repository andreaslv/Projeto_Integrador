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
            dataGridView1 = new DataGridView();
            Pedido = new DataGridViewTextBoxColumn();
            Observação = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pedido, Observação, Status, horario });
            dataGridView1.Location = new Point(52, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 300);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Pedido
            // 
            Pedido.HeaderText = "Pedido";
            Pedido.Name = "Pedido";
            // 
            // Observação
            // 
            Observação.HeaderText = "Observação";
            Observação.Name = "Observação";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // horario
            // 
            horario.HeaderText = "horario";
            horario.Name = "horario";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(52, 458);
            button1.Name = "button1";
            button1.Size = new Size(155, 34);
            button1.TabIndex = 2;
            button1.Text = "Entregar pedido";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(291, 458);
            button2.Name = "button2";
            button2.Size = new Size(168, 34);
            button2.TabIndex = 3;
            button2.Text = "Voltar para o preparo";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(536, 458);
            button3.Name = "button3";
            button3.Size = new Size(158, 34);
            button3.TabIndex = 4;
            button3.Text = "Cancelar pedido";
            button3.UseVisualStyleBackColor = false;
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PedidosProntosUC";
            Size = new Size(771, 551);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Pedido;
        private DataGridViewTextBoxColumn Observação;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn horario;
        private Panel panel1;
        private Label label2;
    }
}
