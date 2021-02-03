using System;
using System.Collections;
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
    public partial class TabelaLotoFacil : Form
    {
        public TabelaLotoFacil()
        {
            InitializeComponent();
        }

        Home home = new Home();
        Selecionar pes = new Selecionar();
        Configuracao conf = new Configuracao();

        private void TabelaItens_Load(object sender, EventArgs e)
        {
            if (conf.Ativo[1] == false)
            {
                string[] coluna =
                {
                    "*"
                 };

                for (int i = 0; i <= 24; i++)
                {
                    string[] condicao =
                    {
                        "n1=" + (i+1), "n2=" + (i+1), "n3=" + (i+1),
                        "n4=" + (i+1), "n5=" + (i+1), "n6=" + (i+1),
                        "n7=" + (i+1), "n8=" + (i+1), "n9=" + (i+1),
                        "n10=" + (i+1), "n11=" + (i+1), "n12=" + (i+1),
                        "n13=" + (i+1), "n14=" + (i+1), "n15=" + (i+1),
                    };
                    pes.ExeSelecionar("LotoFacil", coluna, condicao);
                    conf.ListaLoto[i] = pes.GetRows();
                }
                conf.Ativo[1] = true;
            }

            txt01.Text = conf.ListaLoto[0].ToString();
            txt02.Text = conf.ListaLoto[1].ToString();
            txt03.Text = conf.ListaLoto[2].ToString();
            txt04.Text = conf.ListaLoto[3].ToString();
            txt05.Text = conf.ListaLoto[4].ToString();
            txt06.Text = conf.ListaLoto[5].ToString();
            txt07.Text = conf.ListaLoto[6].ToString();
            txt08.Text = conf.ListaLoto[7].ToString();
            txt09.Text = conf.ListaLoto[8].ToString();
            txt10.Text = conf.ListaLoto[9].ToString();

            txt11.Text = conf.ListaLoto[10].ToString();
            txt12.Text = conf.ListaLoto[11].ToString();
            txt13.Text = conf.ListaLoto[12].ToString();
            txt14.Text = conf.ListaLoto[13].ToString();
            txt15.Text = conf.ListaLoto[14].ToString();
            txt16.Text = conf.ListaLoto[15].ToString();
            txt17.Text = conf.ListaLoto[16].ToString();
            txt18.Text = conf.ListaLoto[17].ToString();
            txt19.Text = conf.ListaLoto[18].ToString();
            txt20.Text = conf.ListaLoto[19].ToString();

            txt21.Text = conf.ListaLoto[20].ToString();
            txt22.Text = conf.ListaLoto[21].ToString();
            txt23.Text = conf.ListaLoto[22].ToString();
            txt24.Text = conf.ListaLoto[23].ToString();
            txt25.Text = conf.ListaLoto[24].ToString();
        }

        private void TabelaItens_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Janelas[4] = false;
        }
    }
}
