using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena
{
    class SimularJogadaAi
    {

        // usar classe FzLgd para fazer o sorteio
        FzJgd jj = new FzJgd();

        public int[] Ret { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] Sorteados { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
       
        public void SorteadosReset()
        {
            for (int i = 0; i <= 14; i++)
            {
                Sorteados[i] = 0;
            }
        }

        public void SimularJogo(int i, int[] n)
        {
            if (i == 1)
            {
                // faz um sorteio aleatoio de 6 numeros
                jj.Sorteio("ms");

                // verifica se numeros do sorteio aleatorio 
                // bate com os jogados pelo usuario
                for (int j = 0; j < n.Length; j++)
                {
                    for (int v = 0; v < jj.MegaSena.Length; v++)
                    {
                        if (n[j]==jj.MegaSena[v])
                        {
                            Ret[j] = jj.MegaSena[v];
                        }
                        
                    }
                    Sorteados[j] = jj.MegaSena[j];
                }
            }
            else
            {
                // faz um sorteio aleatoio de 15 numeros
                jj.Sorteio("lf");

                // verifica se numeros do sorteio aleatorio 
                // bate com os jogados pelo usuario
                for (int j = 0; j < n.Length; j++)
                {
                    for (int v = 0; v < jj.LotoFacil.Length; v++)
                    {
                        if (n[j] == jj.LotoFacil[v])
                        {
                            Ret[j] = jj.LotoFacil[v];
                        }
                    }
                    Sorteados[j] = jj.LotoFacil[j];
                }
            }
        }

        public void ResetRet()
        {
            for(int i = 0; i< Ret.Length; i++)
            {
                Ret[i] = 0;
            }
        }
    }
}
