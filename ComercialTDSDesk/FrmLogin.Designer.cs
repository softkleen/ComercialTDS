namespace ComercialTDSDesk
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkExibeSenha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(118, 174);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 35);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(232, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "well@gmail.com";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(113, 132);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(207, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "1234";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // chkExibeSenha
            // 
            chkExibeSenha.AutoSize = true;
            chkExibeSenha.Location = new Point(326, 136);
            chkExibeSenha.Name = "chkExibeSenha";
            chkExibeSenha.Size = new Size(89, 19);
            chkExibeSenha.TabIndex = 4;
            chkExibeSenha.Text = "Exibir Senha";
            chkExibeSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 5;
            label1.Text = "Comercial TDS System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 42);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 6;
            label2.Text = "Acesso ao Sistema";
            // 
            // button1
            // 
            button1.Location = new Point(378, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(465, 229);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkExibeSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        public Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private CheckBox chkExibeSenha;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}