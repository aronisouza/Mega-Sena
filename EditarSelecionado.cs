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
    public partial class EditarSelecionado : Form
    {
        private int Cartela, Concurso;
        private DataTable dt;
        
        public EditarSelecionado(int i , int cartela)
        {
            InitializeComponent();
            Concurso = i;
            Cartela = cartela;
            // -- 1 para : lotofacil
            // -- 2 para : Megasena
            // -- 3 para : Quina
            pcbImage.Image = (
                cartela == 3 ? Properties.Resources.quina : 
                cartela == 2 ? Properties.Resources.mega_sena : 
                Properties.Resources.lotofacil
                );
            PopulaCampos();
            label1.Text = Concurso.ToString();
        }

        Selecionar pesq = new Selecionar();
        Atualizar atul = new Atualizar();
        string tabela;
        private string[] filid;

        private void PopulaCampos()
        {
            //-- Busca as informações no banco
            string[] condicao = { "Concurso=" + Concurso };
            tabela = (Cartela == 3 ? "Quina" : Cartela == 2 ? "MegaSena" : "LotoFacil");
            string[] coluna = { "*" };
            pesq.ExeSelecionar(tabela, coluna, condicao);
            dt = pesq.GetTabela();


            // AS 5 primeiras tem nos 3 jogos
            txt1.Text = dt.Rows[0]["n1"].ToString();
            txt2.Text = dt.Rows[0]["n2"].ToString();
            txt3.Text = dt.Rows[0]["n3"].ToString();
            txt4.Text = dt.Rows[0]["n4"].ToString();
            txt5.Text = dt.Rows[0]["n5"].ToString();

            switch (Cartela)
            {
                case 1:
                    LiberarCampos(true);
                    txt6.Text = dt.Rows[0]["n6"].ToString();
                    txt7.Text = dt.Rows[0]["n7"].ToString();
                    txt8.Text = dt.Rows[0]["n8"].ToString();
                    txt9.Text = dt.Rows[0]["n9"].ToString();
                    txt10.Text = dt.Rows[0]["n10"].ToString();
                    txt11.Text = dt.Rows[0]["n11"].ToString();
                    txt12.Text = dt.Rows[0]["n12"].ToString();
                    txt13.Text = dt.Rows[0]["n13"].ToString();
                    txt14.Text = dt.Rows[0]["n14"].ToString();
                    txt15.Text = dt.Rows[0]["n15"].ToString();
                    break;
                case 2:
                    txt6.Text = dt.Rows[0]["n6"].ToString();
                    LiberarCampos(false);
                    break;
                case 3:
                    LiberarCampos(false);
                    break;

                default: break;
            }
        }

        private void LiberarCampos(bool b)
        {
            
            if(Cartela != 2) txt6.Enabled = b;
            txt7.Enabled = b;
            txt8.Enabled = b;
            txt9.Enabled = b;
            txt10.Enabled = b;
            txt11.Enabled = b;
            txt12.Enabled = b;
            txt13.Enabled = b;
            txt14.Enabled = b;
            txt15.Enabled = b;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // *** FAzer verificação dos campos para não deixar vazio
            string tab = (Cartela == 1 ? "LotoFacil" : "MegaSena");
            filid = null;

            if (Cartela == 1)
            { 
                string[] condicao =
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

                filid = condicao;
            }
            else if(Cartela == 2)
            {
                string[] condicao =
                {
                    "n1=" + txt1.Text,
                    "n2=" + txt2.Text,
                    "n3=" + txt3.Text,
                    "n4=" + txt4.Text,
                    "n5=" + txt5.Text,
                    "n6=" + txt6.Text
                };
                filid = condicao;
            }

            atul.ExeAtualizar(tab, filid, Concurso);
            if (atul.GetResult() == 1)
            {
                MessageBox.Show("Atualizou " + atul.GetResult());
            }
            else { MessageBox.Show("Deu erro " + atul.GetResult()); };
        }
    }
}
