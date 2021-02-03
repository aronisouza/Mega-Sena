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
    public partial class CartelaQuina : Form
    {
        public CartelaQuina()
        {
            InitializeComponent();
        }

        FzJgd jj = new FzJgd();

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            foreach (object controle in Controls)
            {
                if (controle.GetType() == typeof(Label))
                {
                    (controle as Label).BackColor = Color.White;
                }
            }
        }

        private void BtnAleatorio_Click(object sender, EventArgs e)
        {
            // reseta as cores caso clique varias vezes sem limpar
            BtnLimpar_Click(sender, e);

            // faz um sorteio dos 5 numeros
            jj.Sorteio("qn");

            string conv = string.Empty;
            // procura as label referente ao numero sorteado para seleciona-la
            for (int i = 0; i < jj.Quina.Length; i++)
            {
                if (jj.Quina[i] <= 9) conv = "0" + jj.Quina[i].ToString();
                else conv = jj.Quina[i].ToString();

                foreach (object controle in Controls)
                {
                    if (controle.GetType() == typeof(Label) && (controle as Label).Text == conv)
                    {
                        // isso tem que adicionar para mudar a cor do label
                        // caso seja o mesmo do numero sorteado
                        (controle as Label).BackColor = Color.Chartreuse;
                        break;
                    }
                }
            }
        }
    }
}
