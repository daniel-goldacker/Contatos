namespace Contatos.UI
{
    partial class frmConsultaContatos
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaContatos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContatos = new System.Windows.Forms.Panel();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.pnlContato = new System.Windows.Forms.Panel();
            this.btnGerarCSV = new System.Windows.Forms.Button();
            this.btnSairSistema = new System.Windows.Forms.Button();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.fbdDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2.SuspendLayout();
            this.pnlContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.pnlContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlContatos);
            this.panel2.Controls.Add(this.pnlTopo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 251);
            this.panel2.TabIndex = 17;
            // 
            // pnlContatos
            // 
            this.pnlContatos.Controls.Add(this.dgvContatos);
            this.pnlContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContatos.Location = new System.Drawing.Point(0, 31);
            this.pnlContatos.Name = "pnlContatos";
            this.pnlContatos.Size = new System.Drawing.Size(836, 218);
            this.pnlContatos.TabIndex = 17;
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContatos.Location = new System.Drawing.Point(0, 0);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(836, 218);
            this.dgvContatos.TabIndex = 16;
            this.dgvContatos.DoubleClick += new System.EventHandler(this.dgvContatos_DoubleClick);
            // 
            // pnlTopo
            // 
            this.pnlTopo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Controls.Add(this.txbPesquisa);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(836, 31);
            this.pnlTopo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa (Nome)";
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(666, 3);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(165, 20);
            this.txbPesquisa.TabIndex = 0;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // pnlContato
            // 
            this.pnlContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContato.Controls.Add(this.btnGerarCSV);
            this.pnlContato.Controls.Add(this.btnSairSistema);
            this.pnlContato.Controls.Add(this.btnAddContato);
            this.pnlContato.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContato.Location = new System.Drawing.Point(0, 251);
            this.pnlContato.Name = "pnlContato";
            this.pnlContato.Size = new System.Drawing.Size(838, 45);
            this.pnlContato.TabIndex = 0;
            // 
            // btnGerarCSV
            // 
            this.btnGerarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarCSV.Image")));
            this.btnGerarCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarCSV.Location = new System.Drawing.Point(580, 4);
            this.btnGerarCSV.Name = "btnGerarCSV";
            this.btnGerarCSV.Size = new System.Drawing.Size(109, 37);
            this.btnGerarCSV.TabIndex = 17;
            this.btnGerarCSV.Text = "Gerar CSV";
            this.btnGerarCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarCSV.UseVisualStyleBackColor = true;
            this.btnGerarCSV.Click += new System.EventHandler(this.btnGerarCSV_Click);
            // 
            // btnSairSistema
            // 
            this.btnSairSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSairSistema.Image")));
            this.btnSairSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairSistema.Location = new System.Drawing.Point(695, 5);
            this.btnSairSistema.Name = "btnSairSistema";
            this.btnSairSistema.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSairSistema.Size = new System.Drawing.Size(138, 36);
            this.btnSairSistema.TabIndex = 12;
            this.btnSairSistema.Text = "Sair do Sistema";
            this.btnSairSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairSistema.UseVisualStyleBackColor = true;
            this.btnSairSistema.Click += new System.EventHandler(this.btnSairSistema_Click);
            // 
            // btnAddContato
            // 
            this.btnAddContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContato.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContato.Image")));
            this.btnAddContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContato.Location = new System.Drawing.Point(4, 5);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddContato.Size = new System.Drawing.Size(151, 36);
            this.btnAddContato.TabIndex = 11;
            this.btnAddContato.Text = "Adicionar Contato";
            this.btnAddContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddContato.UseVisualStyleBackColor = true;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // frmConsultaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 296);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContato);
            this.Name = "frmConsultaContatos";
            this.Text = "Lista de Contatos";
            this.panel2.ResumeLayout(false);
            this.pnlContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlContato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContato;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.Button btnSairSistema;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Panel pnlContatos;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Button btnGerarCSV;
        private System.Windows.Forms.FolderBrowserDialog fbdDiretorio;
    }
}

