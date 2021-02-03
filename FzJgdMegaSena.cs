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
    public partial class FzJgdMegaSena : Form
    {
        public FzJgdMegaSena()
        {
            InitializeComponent();
        }

        FzJgd _fzJgd = new FzJgd();


        private void Button1_Click(object sender, EventArgs e)
        {
            _fzJgd.Sorteio("ms");
            label1.Text = string.Join(" - ", _fzJgd.MegaSena.OrderBy(s => s));
                //_fzJgd.MegaSena[0].ToString() + " - " +
                //_fzJgd.MegaSena[1].ToString() + " - " +
                //_fzJgd.MegaSena[2].ToString() + " - " +
                //_fzJgd.MegaSena[3].ToString() + " - " +
                //_fzJgd.MegaSena[4].ToString() + " - " +
                //_fzJgd.MegaSena[5].ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _fzJgd.Sorteio("lf");
            label2.Text = string.Join(" - ", _fzJgd.LotoFacil.OrderBy(s => s));
            //_fzJgd.LotoFacil[0].ToString() + " - " +
            //_fzJgd.LotoFacil[1].ToString() + " - " +
            //_fzJgd.LotoFacil[2].ToString() + " - " +
            //_fzJgd.LotoFacil[3].ToString() + " - " +
            //_fzJgd.LotoFacil[4].ToString() + " - " +
            //_fzJgd.LotoFacil[5].ToString() + " - " +
            //_fzJgd.LotoFacil[6].ToString() + " - " +
            //_fzJgd.LotoFacil[7].ToString() + " - " +
            //_fzJgd.LotoFacil[8].ToString() + " - " +
            //_fzJgd.LotoFacil[9].ToString() + " - " +
            //_fzJgd.LotoFacil[10].ToString() + " - " +
            //_fzJgd.LotoFacil[11].ToString() + " - " +
            //_fzJgd.LotoFacil[12].ToString() + " - " +
            //_fzJgd.LotoFacil[13].ToString() + " - " +
            //_fzJgd.LotoFacil[14].ToString();
        }
    }
}
