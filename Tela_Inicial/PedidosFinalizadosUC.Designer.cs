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
            label2 = new Label();
            dgvPedidosFinalizados = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            txtBuscar = new TextBox();
            label3 = new Label();
            label6 = new Label();
            lblNumeroPedidos = new Label();
            lblValorTotalDia = new Label();
            btnPesquisar = new Button();
            txtData = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosFinalizados).BeginInit();
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
            // dgvPedidosFinalizados
            // 
            dgvPedidosFinalizados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPedidosFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosFinalizados.Location = new Point(17, 110);
            dgvPedidosFinalizados.Name = "dgvPedidosFinalizados";
            dgvPedidosFinalizados.Size = new Size(733, 318);
            dgvPedidosFinalizados.TabIndex = 2;
            dgvPedidosFinalizados.CellContentClick += dgvPedidosFinalizados_CellContentClick;
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
            // txtBuscar
            // 
            txtBuscar.Location = new Point(130, 67);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(214, 23);
            txtBuscar.TabIndex = 29;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.Location = new Point(68, 458);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 0;
            label3.Text = "Total do dia:";
            label3.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label6.Location = new Point(326, 458);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 0;
            label6.Text = "Total de pedidos:";
            label6.Click += label1_Click;
            // 
            // lblNumeroPedidos
            // 
            lblNumeroPedidos.AutoSize = true;
            lblNumeroPedidos.Font = new Font("Segoe UI Symbol", 12F);
            lblNumeroPedidos.Location = new Point(500, 464);
            lblNumeroPedidos.Name = "lblNumeroPedidos";
            lblNumeroPedidos.Size = new Size(151, 21);
            lblNumeroPedidos.TabIndex = 0;
            lblNumeroPedidos.Text = "numero_de_pedidos";
            lblNumeroPedidos.Click += label1_Click;
            // 
            // lblValorTotalDia
            // 
            lblValorTotalDia.AutoSize = true;
            lblValorTotalDia.Font = new Font("Segoe UI Symbol", 12F);
            lblValorTotalDia.Location = new Point(197, 464);
            lblValorTotalDia.Name = "lblValorTotalDia";
            lblValorTotalDia.Size = new Size(45, 21);
            lblValorTotalDia.TabIndex = 0;
            lblValorTotalDia.Text = "valor";
            lblValorTotalDia.Click += label1_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.Location = new Point(350, 66);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(45, 25);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(485, 68);
            txtData.MaxLength = 10;
            txtData.Name = "txtData";
            txtData.Size = new Size(118, 23);
            txtData.TabIndex = 31;
            txtData.TextChanged += txtData_TextChanged;
            txtData.KeyPress += txtData_KeyPress;
            txtData.Leave += txtData_Leave;
            // 
            // PedidosFinalizadosUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtData);
            Controls.Add(btnPesquisar);
            Controls.Add(txtBuscar);
            Controls.Add(panel1);
            Controls.Add(dgvPedidosFinalizados);
            Controls.Add(label2);
            Controls.Add(lblValorTotalDia);
            Controls.Add(lblNumeroPedidos);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PedidosFinalizadosUC";
            Size = new Size(771, 551);
            Load += PedidosFinalizadosUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidosFinalizados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvPedidosFinalizados;
        private Panel panel1;
        private Label label5;
        private TextBox txtBuscar;
        private Label label3;
        private Label label6;
        private Label lblNumeroPedidos;
        private Label lblValorTotalDia;
        private Button btnPesquisar;
        private TextBox txtData;
    }
}
