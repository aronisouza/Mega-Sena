using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Sena
{
    public partial class Adicionar : Form
    {
        public Adicionar(  )
        {
            InitializeComponent();
        }

        Cadastro cad = new Cadastro();
        Home home = new Home();

        private void Adicionar_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Janelas[0] = false;
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text) && !string.IsNullOrEmpty(txt2.Text) &&
                !string.IsNullOrEmpty(txt3.Text) && !string.IsNullOrEmpty(txt4.Text) &&
                !string.IsNullOrEmpty(txt5.Text) && !string.IsNullOrEmpty(txt6.Text)
                )
            {
                string[] cadN =
                {
                    "n1=" + txt1.Text,
                    "n2=" + txt2.Text,
                    "n3=" + txt3.Text,
                    "n4=" + txt4.Text,
                    "n5=" + txt5.Text,
                    "n6=" + txt6.Text
                };

                cad.ExeCadastro("MegaSena", cadN);

                if (cad.GetResut() > 0) { MessageBox.Show("Cadastrado \r\n valor = " + cad.GetResut()); }
                else { MessageBox.Show("Erro ao Cadastrar");  }
            }
            else
            {
                MessageBox.Show("Todos os campos devem estar com valor!");
            }
            BtLimpar_Click(sender, e);
        }

        private void SoNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

    }
}
