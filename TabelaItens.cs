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
    public partial class TabelaItens : Form
    {
        public TabelaItens()
        {
            InitializeComponent();
        }

        Home home = new Home();
        Selecionar pes = new Selecionar();
        Configuracao conf = new Configuracao();

        private void TabelaItens_Load(object sender, EventArgs e)
        {
            if (conf.Ativo[0] == false)
            {
                string[] coluna =
                {
                    "*"
                 };

                for (int i = 0; i <= 59; i++)
                {
                    string[] condicao =
                    {
                    "n1=" + (i+1), "n2=" + (i+1), "n3=" + (i+1),
                    "n4=" + (i+1), "n5=" + (i+1), "n6=" + (i+1)
                };
                    pes.ExeSelecionar("MegaSena", coluna, condicao);
                    conf.Lista[i] = pes.GetRows();
                }
                conf.Ativo[0] = true;
            }


            txt01.Text = conf.Lista[0].ToString();
            txt02.Text = conf.Lista[1].ToString();
            txt03.Text = conf.Lista[2].ToString();
            txt04.Text = conf.Lista[3].ToString();
            txt05.Text = conf.Lista[4].ToString();
            txt06.Text = conf.Lista[5].ToString();
            txt07.Text = conf.Lista[6].ToString();
            txt08.Text = conf.Lista[7].ToString();
            txt09.Text = conf.Lista[8].ToString();
            txt10.Text = conf.Lista[9].ToString();

            txt11.Text = conf.Lista[10].ToString();
            txt12.Text = conf.Lista[11].ToString();
            txt13.Text = conf.Lista[12].ToString();
            txt14.Text = conf.Lista[13].ToString();
            txt15.Text = conf.Lista[14].ToString();
            txt16.Text = conf.Lista[15].ToString();
            txt17.Text = conf.Lista[16].ToString();
            txt18.Text = conf.Lista[17].ToString();
            txt19.Text = conf.Lista[18].ToString();
            txt20.Text = conf.Lista[19].ToString();

            txt21.Text = conf.Lista[20].ToString();
            txt22.Text = conf.Lista[21].ToString();
            txt23.Text = conf.Lista[22].ToString();
            txt24.Text = conf.Lista[23].ToString();
            txt25.Text = conf.Lista[24].ToString();
            txt26.Text = conf.Lista[25].ToString();
            txt27.Text = conf.Lista[26].ToString();
            txt28.Text = conf.Lista[27].ToString();
            txt29.Text = conf.Lista[28].ToString();
            txt30.Text = conf.Lista[29].ToString();

            txt31.Text = conf.Lista[30].ToString();
            txt32.Text = conf.Lista[31].ToString();
            txt33.Text = conf.Lista[32].ToString();
            txt34.Text = conf.Lista[33].ToString();
            txt35.Text = conf.Lista[34].ToString();
            txt36.Text = conf.Lista[35].ToString();
            txt37.Text = conf.Lista[36].ToString();
            txt38.Text = conf.Lista[37].ToString();
            txt39.Text = conf.Lista[38].ToString();
            txt40.Text = conf.Lista[39].ToString();

            txt41.Text = conf.Lista[40].ToString();
            txt42.Text = conf.Lista[41].ToString();
            txt43.Text = conf.Lista[42].ToString();
            txt44.Text = conf.Lista[43].ToString();
            txt45.Text = conf.Lista[44].ToString();
            txt46.Text = conf.Lista[45].ToString();
            txt47.Text = conf.Lista[46].ToString();
            txt48.Text = conf.Lista[47].ToString();
            txt49.Text = conf.Lista[48].ToString();
            txt50.Text = conf.Lista[49].ToString();

            txt51.Text = conf.Lista[50].ToString();
            txt52.Text = conf.Lista[51].ToString();
            txt53.Text = conf.Lista[52].ToString();
            txt54.Text = conf.Lista[53].ToString();
            txt55.Text = conf.Lista[54].ToString();
            txt56.Text = conf.Lista[55].ToString();
            txt57.Text = conf.Lista[56].ToString();
            txt58.Text = conf.Lista[57].ToString();
            txt59.Text = conf.Lista[58].ToString();
            txt60.Text = conf.Lista[59].ToString();
        }

        private void TabelaItens_FormClosing(object sender, FormClosingEventArgs e)
        {
            home.Janelas[3] = false;
        }
    }
}
