using System;
using System.Windows.Forms;

namespace Mega_Sena
{
    public partial class SimularJogada : Form
    {
        public SimularJogada()
        {
            InitializeComponent();
        }

        Home hm = new Home();
        SimularJogadaAi sim = new SimularJogadaAi();
        FzJgd fz = new FzJgd();
        private int qntJogos = 0; 

        private void LiberaSena()
        {
            txt01.Visible = true;
            txt02.Visible = true;
            txt03.Visible = true;
            txt04.Visible = true;
            txt05.Visible = true;
            txt06.Visible = true;
            LiberaLoto(0);
        }

        private void LiberaLoto(int i)
        {
            txt07.Visible = (i == 1 ? true : false);
            txt08.Visible = (i == 1 ? true : false);
            txt09.Visible = (i == 1 ? true : false);
            txt10.Visible = (i == 1 ? true : false);
            txt11.Visible = (i == 1 ? true : false);
            txt12.Visible = (i == 1 ? true : false);
            txt13.Visible = (i == 1 ? true : false);
            txt14.Visible = (i == 1 ? true : false);
            txt15.Visible = (i == 1 ? true : false);
        }

        private void RbSena_CheckedChanged(object sender, EventArgs e)
        {
            LiberaSena();
        }

        private void RbLoto_CheckedChanged(object sender, EventArgs e)
        {
            LiberaSena();
            LiberaLoto(1);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ResetLabelCor();
                sim.SorteadosReset();
                int quem = 0;
                lblResultado.Text = string.Empty;
                if (rbSena.Checked)
                {
                    int[] j = {
                        Convert.ToInt32(txt01.Text),
                        Convert.ToInt32(txt02.Text),
                        Convert.ToInt32(txt03.Text),
                        Convert.ToInt32(txt04.Text),
                        Convert.ToInt32(txt05.Text),
                        Convert.ToInt32(txt06.Text)
                    };
                    sim.ResetRet();
                    sim.SimularJogo(1, j);
                    quem = 6;
                }
                else if(rbLoto.Checked)
                {
                    int[] k = {
                        Convert.ToInt32(txt01.Text),
                        Convert.ToInt32(txt02.Text),
                        Convert.ToInt32(txt03.Text),
                        Convert.ToInt32(txt04.Text),
                        Convert.ToInt32(txt05.Text),
                        Convert.ToInt32(txt06.Text),
                        Convert.ToInt32(txt07.Text),
                        Convert.ToInt32(txt08.Text),
                        Convert.ToInt32(txt09.Text),
                        Convert.ToInt32(txt10.Text),
                        Convert.ToInt32(txt11.Text),
                        Convert.ToInt32(txt12.Text),
                        Convert.ToInt32(txt13.Text),
                        Convert.ToInt32(txt14.Text),
                        Convert.ToInt32(txt15.Text)
                    };
                    sim.ResetRet();
                    sim.SimularJogo(2, k);
                    quem = 15;
                }
               
                int qnt = 0;
                for (int i = 0; i < quem; i++)
                {
                    // Números sorteados
                    lblResultado.Text = lblResultado.Text + sim.Sorteados[i] + " | ";

                    // Mostra nas labels números que foram acertados
                    if (sim.Ret[i] >= 1 ) { qnt++; }
                    switch(i)
                    {
                        case 0:
                            if (txt01.Text == sim.Ret[i].ToString())
                                txt01.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 1:
                            if (txt02.Text == sim.Ret[i].ToString())
                                txt02.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 2:
                            if (txt03.Text == sim.Ret[i].ToString())
                                txt03.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 3:
                            if (txt04.Text == sim.Ret[i].ToString())
                                txt04.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 4:
                            if (txt05.Text == sim.Ret[i].ToString())
                                txt05.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 5:
                            if (txt06.Text == sim.Ret[i].ToString())
                                txt06.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 6:
                            if (txt07.Text == sim.Ret[i].ToString())
                                txt07.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 7:
                            if (txt08.Text == sim.Ret[i].ToString())
                                txt08.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 8:
                            if (txt09.Text == sim.Ret[i].ToString())
                                txt09.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 9:
                            if (txt10.Text == sim.Ret[i].ToString())
                                txt10.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 10:
                            if (txt11.Text == sim.Ret[i].ToString())
                                txt11.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 11:
                            if (txt12.Text == sim.Ret[i].ToString())
                                txt12.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 12:
                            if (txt13.Text == sim.Ret[i].ToString())
                                txt13.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 13:
                            if (txt14.Text == sim.Ret[i].ToString())
                                txt14.BackColor = System.Drawing.SystemColors.Desktop;

                            break;
                        case 14:
                            if (txt15.Text == sim.Ret[i].ToString())
                                txt15.BackColor = System.Drawing.SystemColors.Desktop;

                            break;

                        default: break;
                    }
                }
                lblNumerosSorteados.Text = qnt.ToString();
                qntJogos++;
                lblQntJogo.Text = qntJogos.ToString();
            }
            catch (Exception ex) { lblResultado.Text =  ex.Message; };
           
        }

        private void LblQntJogo_DoubleClick(object sender, EventArgs e)
        {
            qntJogos = 0;
            lblQntJogo.Text = qntJogos.ToString();
        }

        private void ResetLabelCor ()
        {
            txt01.BackColor = System.Drawing.SystemColors.Control;
            txt02.BackColor = System.Drawing.SystemColors.Control;
            txt03.BackColor = System.Drawing.SystemColors.Control;
            txt04.BackColor = System.Drawing.SystemColors.Control;
            txt05.BackColor = System.Drawing.SystemColors.Control;
            txt06.BackColor = System.Drawing.SystemColors.Control;
            txt07.BackColor = System.Drawing.SystemColors.Control;
            txt08.BackColor = System.Drawing.SystemColors.Control;
            txt09.BackColor = System.Drawing.SystemColors.Control;
            txt10.BackColor = System.Drawing.SystemColors.Control;
            txt11.BackColor = System.Drawing.SystemColors.Control;
            txt12.BackColor = System.Drawing.SystemColors.Control;
            txt13.BackColor = System.Drawing.SystemColors.Control;
            txt14.BackColor = System.Drawing.SystemColors.Control;
            txt15.BackColor = System.Drawing.SystemColors.Control;
        }

        private void SimularJogada_FormClosing(object sender, FormClosingEventArgs e)
        {
            hm.Janelas[5] = false;
        }
    }
}
