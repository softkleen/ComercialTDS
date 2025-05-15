namespace ComercialTDSDesk
{
    partial class FrmNivel
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
            btnGravar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            dgvNiveis = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(73, 214);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(168, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(263, 214);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(208, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(84, 23);
            txtId.TabIndex = 3;
            txtId.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 4;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(78, 172);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 5;
            // 
            // dgvNiveis
            // 
            dgvNiveis.AllowUserToAddRows = false;
            dgvNiveis.AllowUserToDeleteRows = false;
            dgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnSigla });
            dgvNiveis.Location = new Point(371, 57);
            dgvNiveis.Name = "dgvNiveis";
            dgvNiveis.ReadOnly = true;
            dgvNiveis.RowHeadersVisible = false;
            dgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNiveis.Size = new Size(280, 180);
            dgvNiveis.TabIndex = 6;
            dgvNiveis.CellDoubleClick += dgvNiveis_CellDoubleClick;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Visible = false;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 178;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 128);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 175);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Sigla";
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 284);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNiveis);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Name = "FrmNivel";
            Text = "Cadastro de Nível";
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnEditar;
        private Button btnCancelar;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private DataGridView dgvNiveis;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
    }
}