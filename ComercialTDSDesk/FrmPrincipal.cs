using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            Hide();
            frmLogin.ShowDialog();
            if (Program.UsuarioLogado.Id > 0)
            {
                tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
            }
            Show();
        }
        private void AssociaPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MaximizeBox = true;
            form.AutoSize = true;
            form.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(form);
            form.Show();
            pnlCentral.Visible = true;
        }


        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            frmLogin.btnCancelar.Text = "&Voltar";
            frmLogin.ShowDialog();
            tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;

        }

        private void conficraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmNivel());
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmUsuario());
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProduto());
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProdutoListar());
        }
    }
}
