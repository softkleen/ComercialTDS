namespace ComercialTDSDesk
{
    partial class FrmProdutoListar
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
            dgvProduto = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            picImagem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // dgvProduto
            // 
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBar, clnDescricao, clnValorUnit });
            dgvProduto.Location = new Point(57, 51);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.ReadOnly = true;
            dgvProduto.RowHeadersVisible = false;
            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.Size = new Size(494, 300);
            dgvProduto.TabIndex = 0;
            dgvProduto.CellClick += dgvProduto_CellClick;
            dgvProduto.CellContentClick += dataGridView1_CellContentClick;
            dgvProduto.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 130;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Preço";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 60;
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.FixedSingle;
            picImagem.Location = new Point(583, 51);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(300, 300);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 9;
            picImagem.TabStop = false;
            // 
            // FrmProdutoListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 446);
            Controls.Add(picImagem);
            Controls.Add(dgvProduto);
            Name = "FrmProdutoListar";
            Text = "FrmProdutoListar";
            Load += FrmProdutoListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduto;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private PictureBox picImagem;
    }
}