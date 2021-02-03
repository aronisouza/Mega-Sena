using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Mega_Sena
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Selecionar pesq = new Selecionar();

        // sempre pega o concurso
        int concurso;
        private string[] filid;
        private string tabela;

        //------------------------------  AddMS  AddLF  TabMS  TabLF
        private static bool[] janelas = { false, false, false, false , false, false };

        public bool[] Janelas { get => janelas; set => janelas = value; }

        private void SoNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
        private void ResetaCorLabls() {
            lb1.BackColor = SystemColors.Control;
            lb2.BackColor = SystemColors.Control;
            lb3.BackColor = SystemColors.Control;
            lb4.BackColor = SystemColors.Control;
            lb5.BackColor = SystemColors.Control;
            lb6.BackColor = SystemColors.Control;
            lb7.BackColor = SystemColors.Control;
            lb8.BackColor = SystemColors.Control;
            lb9.BackColor = SystemColors.Control;
            lb10.BackColor = SystemColors.Control;
            lb11.BackColor = SystemColors.Control;
            lb12.BackColor = SystemColors.Control;
            lb13.BackColor = SystemColors.Control;
            lb14.BackColor = SystemColors.Control;
            lb15.BackColor = SystemColors.Control;
            lb16.BackColor = SystemColors.Control;
            lb17.BackColor = SystemColors.Control;
            lb18.BackColor = SystemColors.Control;
            lb19.BackColor = SystemColors.Control;
            lb20.BackColor = SystemColors.Control;
            lb21.BackColor = SystemColors.Control;
            lb22.BackColor = SystemColors.Control;
            lb23.BackColor = SystemColors.Control;
            lb24.BackColor = SystemColors.Control;
            lb25.BackColor = SystemColors.Control;
            lb26.BackColor = SystemColors.Control;
            lb27.BackColor = SystemColors.Control;
            lb28.BackColor = SystemColors.Control;
            lb29.BackColor = SystemColors.Control;
            lb30.BackColor = SystemColors.Control;
            lb31.BackColor = SystemColors.Control;
            lb32.BackColor = SystemColors.Control;
            lb33.BackColor = SystemColors.Control;
            lb34.BackColor = SystemColors.Control;
            lb35.BackColor = SystemColors.Control;
            lb36.BackColor = SystemColors.Control;
            lb37.BackColor = SystemColors.Control;
            lb38.BackColor = SystemColors.Control;
            lb39.BackColor = SystemColors.Control;
            lb40.BackColor = SystemColors.Control;
            lb41.BackColor = SystemColors.Control;
            lb42.BackColor = SystemColors.Control;
            lb43.BackColor = SystemColors.Control;
            lb44.BackColor = SystemColors.Control;
            lb45.BackColor = SystemColors.Control;
            lb46.BackColor = SystemColors.Control;
            lb47.BackColor = SystemColors.Control;
            lb48.BackColor = SystemColors.Control;
            lb49.BackColor = SystemColors.Control;
            lb50.BackColor = SystemColors.Control;
            lb51.BackColor = SystemColors.Control;
            lb52.BackColor = SystemColors.Control;
            lb53.BackColor = SystemColors.Control;
            lb54.BackColor = SystemColors.Control;
            lb55.BackColor = SystemColors.Control;
            lb56.BackColor = SystemColors.Control;
            lb57.BackColor = SystemColors.Control;
            lb58.BackColor = SystemColors.Control;
            lb59.BackColor = SystemColors.Control;
            lb60.BackColor = SystemColors.Control;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            filid = null;
            // reseta cor dos labels
            ResetaCorLabls();


            if (rbLotoFacil.Checked)
            {
                string[] condicao =
                {
                    "n1=" + txtn.Text,
                    "n2=" + txtn.Text,
                    "n3=" + txtn.Text,
                    "n4=" + txtn.Text,
                    "n5=" + txtn.Text,
                    "n6=" + txtn.Text,
                    "n7=" + txtn.Text,
                    "n8=" + txtn.Text,
                    "n9=" + txtn.Text,
                    "n10=" + txtn.Text,
                    "n11=" + txtn.Text,
                    "n12=" + txtn.Text,
                    "n13=" + txtn.Text,
                    "n14=" + txtn.Text,
                    "n15=" + txtn.Text
                };

                filid = condicao;
                tabela = "LotoFacil";

            }
            else if(rbMegaSena.Checked)
            {
                string[] condicao =
                {
                    "n1=" + txtn.Text,
                    "n2=" + txtn.Text,
                    "n3=" + txtn.Text,
                    "n4=" + txtn.Text,
                    "n5=" + txtn.Text,
                    "n6=" + txtn.Text
                };
                filid = condicao;
                tabela = "MegaSena";
            }

            else if (rbQuina.Checked)
            {
                string[] condicao =
                {
                    "n1=" + txtn.Text,
                    "n2=" + txtn.Text,
                    "n3=" + txtn.Text,
                    "n4=" + txtn.Text,
                    "n5=" + txtn.Text
                };
                filid = condicao;
                tabela = "Quina";
            }

            string[] coluna ={"*"};

            if (string.IsNullOrEmpty(txtn.Text))
            {
                pesq.ExeSelecionar(tabela, coluna, null);
            }
            else
            {
                pesq.ExeSelecionar(tabela, coluna, filid);
            }

            dGv.DataSource = pesq.GetTabela();
            //dGv.CurrentCell = dGv.Rows[dGv.Rows.Count - 1].Cells[0];
            label1.Text = pesq.GetRows().ToString();
        }

        private void JnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Janelas[0])
            {
                Janelas[0] = true;
                Adicionar add = new Adicionar();
                add.Show();
            }
        }

        private void LotoFácilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Janelas[1])
            {
                Janelas[1] = true;
                AdicionarLoto jn = new AdicionarLoto();
                jn.Show();
            }
        }

        private void JnTabNumeros_Click(object sender, EventArgs e)
        {
            if (!Janelas[3])
            {
                Janelas[3] = true;
                TabelaItens tab = new TabelaItens();
                tab.Show();
            }
        }

        private void BtLotoFacil_Click(object sender, EventArgs e)
        {
            if (!Janelas[4])
            {
                Janelas[4] = true;
                TabelaLotoFacil tab = new TabelaLotoFacil();
                tab.Show();
            }
        }

        private void BtMegaSenaJogada_Click(object sender, EventArgs e)
        {
            FzJgdMegaSena jn = new FzJgdMegaSena();
            jn.Show();
        }

        private void BtnSimularJogo_Click(object sender, EventArgs e)
        {
            if (!Janelas[5])
            {
                Janelas[5] = true; SimularJogada sim = new SimularJogada();
                sim.Show();
            }
        }

        private void LotoFácilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LotoFacil lf = new LotoFacil();
            lf.Show();
        }

        private void RbMegaSena_CheckedChanged(object sender, EventArgs e)
        {
            MegasenaCartela(true);
            DesabilitaTbs(false);
            pictureBox1.Size = new Size(438, 79);
            pictureBox1.Image = Properties.Resources.mega_sena;
            lb6.Location = new Point(229, 85);
            lb7.Location = new Point(271, 85);
            lb8.Location = new Point(315, 85);
            lb9.Location = new Point(360, 85);
            lb10.Location = new Point(404, 85);
            lb11.Location = new Point(8, 112);
            lb12.Location = new Point(52, 112);
            lb13.Location = new Point(96, 112);
            lb14.Location = new Point(140, 112);
            lb15.Location = new Point(184, 112);
            lb16.Location = new Point(228, 112);
            lb17.Location = new Point(271, 112);
            lb18.Location = new Point(315, 112);
            lb19.Location = new Point(359, 112);
            lb20.Location = new Point(403, 112);
            lb21.Location = new Point(8, 140);
            lb22.Location = new Point(52, 140);
            lb23.Location = new Point(96, 140);
            lb24.Location = new Point(140, 140);
            lb25.Location = new Point(184, 140);
            lb26.Location = new Point(228, 140);
            lb27.Location = new Point(271, 140);
            lb28.Location = new Point(315, 140);
            lb29.Location = new Point(359, 140);
            lb30.Location = new Point(403, 140);
            lb31.Location = new Point(8, 167);
            lb32.Location = new Point(52, 167);
            lb33.Location = new Point(96, 167);
            lb34.Location = new Point(140, 167);
            lb35.Location = new Point(184, 167);
            lb36.Location = new Point(228, 167);
            lb37.Location = new Point(271, 167);
            lb38.Location = new Point(315, 167);
            lb39.Location = new Point(359, 167);
            lb40.Location = new Point(403, 167);
            lb41.Location = new Point(8, 195);
            lb42.Location = new Point(52, 195);
            lb43.Location = new Point(96, 195);
            lb44.Location = new Point(140, 195);
            lb45.Location = new Point(184, 195);
            lb46.Location = new Point(228, 195);
            lb47.Location = new Point(271, 195);
            lb48.Location = new Point(315, 195);
            lb49.Location = new Point(359, 195);
            lb50.Location = new Point(403, 195);
            lb51.Location = new Point(8, 223);
            lb52.Location = new Point(52, 223);
            lb53.Location = new Point(96, 223);
            lb54.Location = new Point(140, 223);
            lb55.Location = new Point(184, 223);
            lb56.Location = new Point(228, 223);
            lb57.Location = new Point(271, 223);
            lb58.Location = new Point(315, 223);
            lb59.Location = new Point(359, 223);
            lb60.Location = new Point(403, 223);
        }

        private void RbLotoFacil_CheckedChanged(object sender, EventArgs e)
        {
            MegasenaCartela(false);
            DesabilitaTbs(true);
            pictureBox1.Size = new Size(219, 79);
            pictureBox1.Image = Properties.Resources.lotofacil;
            lb6.Location = new Point(8, 113);
            lb7.Location = new Point(52, 113);
            lb8.Location = new Point(96, 113);
            lb9.Location = new Point(140, 113);
            lb10.Location = new Point(184, 113);
            lb11.Location = new Point(8, 141);
            lb12.Location = new Point(52, 141);
            lb13.Location = new Point(96, 141);
            lb14.Location = new Point(140, 141);
            lb15.Location = new Point(184, 141);
            lb16.Location = new Point(8, 169);
            lb17.Location = new Point(52, 169);
            lb18.Location = new Point(96, 169);
            lb19.Location = new Point(140, 169);
            lb20.Location = new Point(184, 169);
            lb21.Location = new Point(8, 197);
            lb22.Location = new Point(52, 197);
            lb23.Location = new Point(96, 197);
            lb24.Location = new Point(140, 197);
            lb25.Location = new Point(184, 197);
        }

        private void MegasenaCartela(bool t)
        {
            lb26.Visible = t;
            lb27.Visible = t;
            lb28.Visible = t;
            lb29.Visible = t;
            lb30.Visible = t;
            lb31.Visible = t;
            lb32.Visible = t;
            lb33.Visible = t;
            lb34.Visible = t;
            lb35.Visible = t;
            lb36.Visible = t;
            lb37.Visible = t;
            lb38.Visible = t;
            lb39.Visible = t;
            lb40.Visible = t;
            lb41.Visible = t;
            lb42.Visible = t;
            lb43.Visible = t;
            lb44.Visible = t;
            lb45.Visible = t;
            lb46.Visible = t;
            lb47.Visible = t;
            lb48.Visible = t;
            lb49.Visible = t;
            lb50.Visible = t;
            lb51.Visible = t;
            lb52.Visible = t;
            lb53.Visible = t;
            lb54.Visible = t;
            lb55.Visible = t;
            lb56.Visible = t;
            lb57.Visible = t;
            lb58.Visible = t;
            lb59.Visible = t;
            lb60.Visible = t;
        }

        private void DGv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ResetaCorLabls();

            concurso = Convert.ToInt32(dGv["Concurso", e.RowIndex].Value);
            
            int pp = 0;
            if (rbLotoFacil.Checked)
            {
                pp = 16;
            }

            if (rbMegaSena.Checked)
            {
                pp = 7;
            }

            for (int i = 1; i < pp; i++)
            {
                switch (dGv.Rows[e.RowIndex].Cells[i].Value.ToString())
                {
                    case "1":
                        lb1.BackColor = SystemColors.Desktop;
                        break;
                    case "2":
                        lb2.BackColor = SystemColors.Desktop;
                        break;
                    case "3":
                        lb3.BackColor = SystemColors.Desktop;
                        break;
                    case "4":
                        lb4.BackColor = SystemColors.Desktop;
                        break;
                    case "5":
                        lb5.BackColor = SystemColors.Desktop;
                        break;
                    case "6":
                        lb6.BackColor = SystemColors.Desktop;
                        break;
                    case "7":
                        lb7.BackColor = SystemColors.Desktop;
                        break;
                    case "8":
                        lb8.BackColor = SystemColors.Desktop;
                        break;
                    case "9":
                        lb9.BackColor = SystemColors.Desktop;
                        break;
                    case "10":
                        lb10.BackColor = SystemColors.Desktop;
                        break;
                    case "11":
                        lb11.BackColor = SystemColors.Desktop;
                        break;
                    case "12":
                        lb12.BackColor = SystemColors.Desktop;
                        break;
                    case "13":
                        lb13.BackColor = SystemColors.Desktop;
                        break;
                    case "14":
                        lb14.BackColor = SystemColors.Desktop;
                        break;
                    case "15":
                        lb15.BackColor = SystemColors.Desktop;
                        break;
                    case "16":
                        lb16.BackColor = SystemColors.Desktop;
                        break;
                    case "17":
                        lb17.BackColor = SystemColors.Desktop;
                        break;
                    case "18":
                        lb18.BackColor = SystemColors.Desktop;
                        break;
                    case "19":
                        lb19.BackColor = SystemColors.Desktop;
                        break;
                    case "20":
                        lb20.BackColor = SystemColors.Desktop;
                        break;
                    case "21":
                        lb21.BackColor = SystemColors.Desktop;
                        break;
                    case "22":
                        lb22.BackColor = SystemColors.Desktop;
                        break;
                    case "23":
                        lb23.BackColor = SystemColors.Desktop;
                        break;
                    case "24":
                        lb24.BackColor = SystemColors.Desktop;
                        break;
                    case "25":
                        lb25.BackColor = SystemColors.Desktop;
                        break;
                    case "26":
                        lb26.BackColor = SystemColors.Desktop;
                        break;
                    case "27":
                        lb27.BackColor = SystemColors.Desktop;
                        break;
                    case "28":
                        lb28.BackColor = SystemColors.Desktop;
                        break;
                    case "29":
                        lb29.BackColor = SystemColors.Desktop;
                        break;
                    case "30":
                        lb30.BackColor = SystemColors.Desktop;
                        break;
                    case "31":
                        lb31.BackColor = SystemColors.Desktop;
                        break;
                    case "32":
                        lb32.BackColor = SystemColors.Desktop;
                        break;
                    case "33":
                        lb33.BackColor = SystemColors.Desktop;
                        break;
                    case "34":
                        lb34.BackColor = SystemColors.Desktop;
                        break;
                    case "35":
                        lb35.BackColor = SystemColors.Desktop;
                        break;
                    case "36":
                        lb36.BackColor = SystemColors.Desktop;
                        break;
                    case "37":
                        lb37.BackColor = SystemColors.Desktop;
                        break;
                    case "38":
                        lb38.BackColor = SystemColors.Desktop;
                        break;
                    case "39":
                        lb39.BackColor = SystemColors.Desktop;
                        break;
                    case "40":
                        lb40.BackColor = SystemColors.Desktop;
                        break;
                    case "41":
                        lb41.BackColor = SystemColors.Desktop;
                        break;
                    case "42":
                        lb42.BackColor = SystemColors.Desktop;
                        break;
                    case "43":
                        lb43.BackColor = SystemColors.Desktop;
                        break;
                    case "44":
                        lb44.BackColor = SystemColors.Desktop;
                        break;
                    case "45":
                        lb45.BackColor = SystemColors.Desktop;
                        break;
                    case "46":
                        lb46.BackColor = SystemColors.Desktop;
                        break;
                    case "47":
                        lb47.BackColor = SystemColors.Desktop;
                        break;
                    case "48":
                        lb48.BackColor = SystemColors.Desktop;
                        break;
                    case "49":
                        lb49.BackColor = SystemColors.Desktop;
                        break;
                    case "50":
                        lb50.BackColor = SystemColors.Desktop;
                        break;
                    case "51":
                        lb51.BackColor = SystemColors.Desktop;
                        break;
                    case "52":
                        lb52.BackColor = SystemColors.Desktop;
                        break;
                    case "53":
                        lb53.BackColor = SystemColors.Desktop;
                        break;
                    case "54":
                        lb54.BackColor = SystemColors.Desktop;
                        break;
                    case "55":
                        lb55.BackColor = SystemColors.Desktop;
                        break;
                    case "56":
                        lb56.BackColor = SystemColors.Desktop;
                        break;
                    case "57":
                        lb57.BackColor = SystemColors.Desktop;
                        break;
                    case "58":
                        lb58.BackColor = SystemColors.Desktop;
                        break;
                    case "59":
                        lb59.BackColor = SystemColors.Desktop;
                        break;
                    case "60":
                        lb60.BackColor = SystemColors.Desktop;
                        break;
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            tb1.Text = string.Empty;
            tb2.Text = string.Empty;
            tb3.Text = string.Empty;
            tb4.Text = string.Empty;
            tb5.Text = string.Empty;
            tb6.Text = string.Empty;
            tb7.Text = string.Empty;
            tb8.Text = string.Empty;
            tb9.Text = string.Empty;
            tb10.Text = string.Empty;
            tb11.Text = string.Empty;
            tb12.Text = string.Empty;
            tb13.Text = string.Empty;
            tb14.Text = string.Empty;
            tb15.Text = string.Empty;
            tb15.Text = string.Empty;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //*** Falta adicionar checagem de campos vazios
            filid = null;
            if (rbLotoFacil.Checked)
            {
                string[] condicao =
                {
                    "n1<" + tb1.Text,
                    "n2<" + tb2.Text,
                    "n3<" + tb3.Text,
                    "n4<" + tb4.Text,
                    "n5<" + tb5.Text,
                    "n6<" + tb6.Text,
                    "n7<" + tb7.Text,
                    "n8<" + tb8.Text,
                    "n9<" + tb9.Text,
                    "n10<" + tb10.Text,
                    "n11<" + tb11.Text,
                    "n12<" + tb12.Text,
                    "n13<" + tb13.Text,
                    "n14<" + tb14.Text,
                    "n15<" + tb15.Text
                };
                filid = condicao;
                tabela = "LotoFacil";
            }
            else if (rbMegaSena.Checked)
            {
                string[] condicao =
                {
                    "n1<" + tb1.Text,
                    "n2<" + tb2.Text,
                    "n3<" + tb3.Text,
                    "n4<" + tb4.Text,
                    "n5<" + tb5.Text,
                    "n6<" + tb6.Text
                };
                filid = condicao;
                tabela = "MegaSena";
            }

            //********************************************
            string[] coluna = { "*" };
            pesq.ExeSelecionar(tabela, coluna, filid);
            dGv.DataSource = pesq.GetTabela();
            lbResultado.Text = pesq.GetRows().ToString();
        }

        private void DesabilitaTbs(bool t)
        {
            tb7.Enabled = t;
            tb8.Enabled = t;
            tb9.Enabled = t;
            tb10.Enabled = t;
            tb11.Enabled = t;
            tb12.Enabled = t;
            tb13.Enabled = t;
            tb14.Enabled = t;
            tb15.Enabled = t;
        }
      
        private void MenuD_Editar_Click(object sender, EventArgs e)
        {
            int jogo = 0;
            if (rbQuina.Checked)
            {
                // LotoFacil
                jogo = 3;
            }
            else if (rbLotoFacil.Checked)
            {
                // LotoFacil
                jogo = 1;
            }
            else
            {
                // Mega Sena
                jogo = 2;
            }

            EditarSelecionado edi = new EditarSelecionado(concurso, jogo);
            edi.ShowDialog();
        }

        private void MenuD_Cartela_Click(object sender, EventArgs e)
        {
            if (rbLotoFacil.Checked)
            {

            }
            else if (rbQuina.Checked)
            {
                CartelaQuina cc = new CartelaQuina();
                cc.ShowDialog();
            }
            else if (rbMegaSena.Checked)
            {

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if(!checkBox1.Checked) ;
            //else ;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string[] coluna = { "*" };
            string[] ff = { "Concurso="+txtBuscarConcurso.Text };
            string banco = string.Empty;
            if (!string.IsNullOrEmpty(txtBuscarConcurso.Text))
            {
                if (rbLotoFacil.Checked) banco = "LotoFacil";
                else if (rbMegaSena.Checked) banco = "MegaSena";
                else if (rbQuina.Checked) banco = "Quina";

                pesq.ExeSelecionar(banco, coluna, ff);
                try
                {
                    dGv.DataSource = pesq.GetTabela();
                    dGv.CurrentCell = dGv.Rows[dGv.Rows.Count - 1].Cells[0];
                    label1.Text = pesq.GetRows().ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Numero do concurso não existe !!!");
                }
            }
           
        }
    }
}
