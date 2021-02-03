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
    public partial class LotoFacil : Form
    {
        public LotoFacil()
        {
            InitializeComponent();
        }

        private bool olho = false;
        private string btName = "bt";

        FzJgd jj = new FzJgd();

        private void Cartela_Load(object sender, EventArgs e)
        {
            pc1.Click += new EventHandler(BtClick_Click);
            pc2.Click += new EventHandler(BtClick_Click);
            pc3.Click += new EventHandler(BtClick_Click);
            pc4.Click += new EventHandler(BtClick_Click);
            pc5.Click += new EventHandler(BtClick_Click);
            pc6.Click += new EventHandler(BtClick_Click);
            pc7.Click += new EventHandler(BtClick_Click);
            pc8.Click += new EventHandler(BtClick_Click);
            pc9.Click += new EventHandler(BtClick_Click);
            pc10.Click += new EventHandler(BtClick_Click);
            pc11.Click += new EventHandler(BtClick_Click);
            pc12.Click += new EventHandler(BtClick_Click);
            pc13.Click += new EventHandler(BtClick_Click);
            pc14.Click += new EventHandler(BtClick_Click);
            pc15.Click += new EventHandler(BtClick_Click);
            pc16.Click += new EventHandler(BtClick_Click);
            pc17.Click += new EventHandler(BtClick_Click);
            pc18.Click += new EventHandler(BtClick_Click);
            pc19.Click += new EventHandler(BtClick_Click);
            pc20.Click += new EventHandler(BtClick_Click);
            pc21.Click += new EventHandler(BtClick_Click);
            pc22.Click += new EventHandler(BtClick_Click);
            pc23.Click += new EventHandler(BtClick_Click);
            pc24.Click += new EventHandler(BtClick_Click);
            pc25.Click += new EventHandler(BtClick_Click);
        }

        private void BtClick_Click(object sender, EventArgs e)
        {
            if (!olho && ((Label)sender).Name != btName)
            {
                ((Label)sender).BackColor = ((Label)sender).BackColor == Color.LawnGreen ? Color.Khaki : Color.LawnGreen;
                btName = ((Label)sender).Name;
                olho = true;
            }
            else
            {
                olho = false;
                btName = "bt";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            foreach (object controle in Controls) {
                if (controle.GetType() == typeof(Label))
                {
                    (controle as Label).BackColor =  Color.Khaki;
                }
            }    
        }

        private void BtnAleatorio_Click(object sender, EventArgs e)
        {
            // reseta as cores caso clique varias vezes sem limpar
            BtnLimpar_Click( sender,  e);

            // faz um sorteio do 15 numeros
            jj.Sorteio("lf");

            string conv = string.Empty;
            // procura as label referente ao numero sorteado para seleciona-la
            for (int i = 0; i< jj.LotoFacil.Length; i++)
            {
                if(jj.LotoFacil[i] <= 9) conv = "0" + jj.LotoFacil[i].ToString();
                else conv = jj.LotoFacil[i].ToString();

                foreach (object controle in Controls)
                {
                    if (controle.GetType() == typeof(Label) && (controle as Label).Text == conv)
                    {
                        // isso tem que adicionar para mudar a cor do label
                        // caso seja o mesmo do numero sorteado
                        (controle as Label).BackColor = Color.LawnGreen;

                    }
                }
            }
        }
    }
}
