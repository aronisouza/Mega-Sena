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
    public partial class AdicionarLoto : Form
    {
        public AdicionarLoto()
        {
            InitializeComponent();
        }

        Cadastro cad = new Cadastro();
        Home home = new Home();

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt8.Clear();
            txt9.Clear();
            txt10.Clear();
            txt11.Clear();
            txt12.Clear();
            txt13.Clear();
            txt14.Clear();
            txt15.Clear();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text) && !string.IsNullOrEmpty(txt2.Text) &&
                !string.IsNullOrEmpty(txt3.Text) && !string.IsNullOrEmpty(txt4.Text) &&
                !string.IsNullOrEmpty(txt5.Text) && !string.IsNullOrEmpty(txt6.Text) &&
               
                !string.IsNullOrEmpty(txt7.Text) && !string.IsNullOrEmpty(txt8.Text) &&
                !string.IsNullOrEmpty(txt9.Text) && !string.IsNullOrEmpty(txt10.Text) &&
                !string.IsNullOrEmpty(txt11.Text) && !string.IsNullOrEmpty(txt12.Text) &&
               
                !string.IsNullOrEmpty(txt13.Text) && !string.IsNullOrEmpty(txt14.Text) &&
                !string.IsNullOrEmpty(txt15.Text)
                )
            {
                string[] cadN =
                {
                    "n1=" + txt1.Text,
                    "n2=" + txt2.Text,
                    "n3=" + txt3.Text,
                    "n4=" + txt4.Text,
                    "n5=" + txt5.Text,
                    "n6=" + txt6.Text,

                    "n7=" + txt7.Text,
                    "n8=" + txt8.Text,
                    "n9=" + txt9.Text,
                    "n10=" + txt10.Text,
                    "n11=" + txt11.Text,
                    "n12=" + txt12.Text,

                    "n13=" + txt13.Text,
                    "n14=" + txt14.Text,
                    "n15=" + txt15.Text
                };

                cad.ExeCadastro("LotoFacil", cadN);

                if (cad.GetResut() > 0) { MessageBox.Show("Cadastrado"); }
                else { MessageBox.Show("Erro ao Cadastrar"); }
            }
            else
            {
                MessageBox.Show("Todos os campos devem estar com valor!");
            }
            BtLimpar_Click(sender, e);
        }

        private void AdicionarLoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Janelas[1] = false;
        }
    }
}
