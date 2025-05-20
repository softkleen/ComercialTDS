namespace ComercialTDSDesk
{
    partial class FrmProduto
    {

        private System.ComponentModel.IContainer components = null;

     
        /// <summary>
        /// Required designer variable.
        /// </summary>
       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            txtCodBarras = new TextBox();
            txtDescricao = new TextBox();
            nudValorUnit = new NumericUpDown();
            txtUnidadeVenda = new TextBox();
            cmbCategoria = new ComboBox();
            nudEstoqueMinimo = new NumericUpDown();
            nudClasseDesconto = new NumericUpDown();
            chkDescontinuado = new CheckBox();
            picImagem = new PictureBox();
            btnCarregarImagem = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ofdObterImagem = new OpenFileDialog();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(96, 25);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "Código de Barras";
            txtCodBarras.Size = new Size(200, 23);
            txtCodBarras.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(96, 54);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(342, 23);
            txtDescricao.TabIndex = 1;
            // 
            // nudValorUnit
            // 
            nudValorUnit.DecimalPlaces = 2;
            nudValorUnit.Location = new Point(96, 83);
            nudValorUnit.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudValorUnit.Name = "nudValorUnit";
            nudValorUnit.Size = new Size(100, 23);
            nudValorUnit.TabIndex = 2;
            nudValorUnit.Enter += nudValorUnit_Enter;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(296, 82);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "Unid. Venda";
            txtUnidadeVenda.Size = new Size(142, 23);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Location = new Point(96, 112);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(342, 23);
            cmbCategoria.TabIndex = 4;
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.DecimalPlaces = 2;
            nudEstoqueMinimo.Location = new Point(120, 145);
            nudEstoqueMinimo.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(100, 23);
            nudEstoqueMinimo.TabIndex = 5;
            // 
            // nudClasseDesconto
            // 
            nudClasseDesconto.DecimalPlaces = 2;
            nudClasseDesconto.Location = new Point(338, 145);
            nudClasseDesconto.Name = "nudClasseDesconto";
            nudClasseDesconto.Size = new Size(100, 23);
            nudClasseDesconto.TabIndex = 6;
            // 
            // chkDescontinuado
            // 
            chkDescontinuado.Location = new Point(296, 178);
            chkDescontinuado.Name = "chkDescontinuado";
            chkDescontinuado.Size = new Size(150, 24);
            chkDescontinuado.TabIndex = 7;
            chkDescontinuado.Text = "Descontinuado";
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.FixedSingle;
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(455, 12);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(150, 150);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 8;
            picImagem.TabStop = false;
            // 
            // btnCarregarImagem
            // 
            btnCarregarImagem.Location = new Point(455, 172);
            btnCarregarImagem.Name = "btnCarregarImagem";
            btnCarregarImagem.Size = new Size(150, 30);
            btnCarregarImagem.TabIndex = 9;
            btnCarregarImagem.Text = "Carregar Imagem";
            btnCarregarImagem.Click += btnCarregarImagem_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(61, 222);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 35);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "&Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(239, 222);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 35);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "&Editar";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(415, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 35);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&Cancelar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 11;
            label1.Text = "CodBarras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 85);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 13;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 88);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 14;
            label4.Text = "Unidade Venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 115);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 15;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 147);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 16;
            label6.Text = "Estoque Mínimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 148);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 17;
            label7.Text = "Classe Desconto";
            // 
            // ofdObterImagem
            // 
            ofdObterImagem.FileName = "foto_produto";
            // 
            // button1
            // 
            button1.Location = new Point(351, 13);
            button1.Name = "button1";
            button1.Size = new Size(87, 35);
            button1.TabIndex = 10;
            button1.Text = "&Buscar";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 347);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodBarras);
            Controls.Add(txtDescricao);
            Controls.Add(nudValorUnit);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(cmbCategoria);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(nudClasseDesconto);
            Controls.Add(chkDescontinuado);
            Controls.Add(picImagem);
            Controls.Add(btnCarregarImagem);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Name = "FrmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        // Componentes da interface
        private Button btnEditar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCodBarras;
        private TextBox txtDescricao;
        private NumericUpDown nudValorUnit;
        private TextBox txtUnidadeVenda;
        private ComboBox cmbCategoria;
        private NumericUpDown nudEstoqueMinimo;
        private NumericUpDown nudClasseDesconto;
        private CheckBox chkDescontinuado;
        private PictureBox picImagem;
        private Button btnCarregarImagem;
        private Button btnSalvar;
        private OpenFileDialog ofdObterImagem;
        private Button button1;
    }
    #endregion
}