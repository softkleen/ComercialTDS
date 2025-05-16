using ComercialTDSClass;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            comboBox1.DataSource = niveis;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new(
                    "Maria das Couves",
                    "maria.couves@gmail.com",
                    "1234",
                    Nivel.ObterPorId(Convert.ToInt32(comboBox1.SelectedValue))
                );
            user.Inserir();
            
        }
    }
}
