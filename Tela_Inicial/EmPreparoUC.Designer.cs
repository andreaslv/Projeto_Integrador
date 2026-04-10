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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            Pedidos = new DataGridViewTextBoxColumn();
            Itens_do_Pedido = new DataGridViewTextBoxColumn();
            Tempo_em_preparo = new DataGridViewTextBoxColumn();
            Observações = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pedidos, Itens_do_Pedido, Tempo_em_preparo, Observações });
            dataGridView1.Location = new Point(19, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(733, 388);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(124, 483);
            button1.Name = "button1";
            button1.Size = new Size(250, 38);
            button1.TabIndex = 2;
            button1.Text = "Marcar como Pronto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(399, 483);
            button2.Name = "button2";
            button2.Size = new Size(249, 38);
            button2.TabIndex = 2;
            button2.Text = "Cancelar Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            Pedidos.HeaderText = "Pedidos";
            Pedidos.Name = "Pedidos";
            Pedidos.Width = 110;
            // 
            // Itens_do_Pedido
            // 
            Itens_do_Pedido.HeaderText = "Itens_do_Pedido";
            Itens_do_Pedido.Name = "Itens_do_Pedido";
            Itens_do_Pedido.Width = 200;
            // 
            // Tempo_em_preparo
            // 
            Tempo_em_preparo.HeaderText = "Tempo_em_preparo";
            Tempo_em_preparo.Name = "Tempo_em_preparo";
            Tempo_em_preparo.Width = 180;
            // 
            // Observações
            // 
            Observações.HeaderText = "Observações";
            Observações.Name = "Observações";
            Observações.Width = 200;
            // 
            // EmPreparoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "EmPreparoUC";
            Size = new Size(771, 551);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Pedidos;
        private DataGridViewTextBoxColumn Itens_do_Pedido;
        private DataGridViewTextBoxColumn Tempo_em_preparo;
        private DataGridViewTextBoxColumn Observações;
    }
}
