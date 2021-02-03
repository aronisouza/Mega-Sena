using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena
{
    class FzJgd
    {
        public int[] MegaSena { get; set; } = { 0, 0, 0, 0, 0, 0 };
        public int[] LotoFacil { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public int[] Quina { get; set; } = { 0, 0, 0, 0, 0 };

        private int segura = 0;
        private int vez = 0; 

        private bool CheckNunber(int n, string t)
        {
            if(t == "ms")
            {
                for (int i = 0; i < MegaSena.Length; i++)
                {
                    if (MegaSena[i] == n) return true;
                }
            }
            else
            {
                for (int i = 0; i < LotoFacil.Length; i++)
                {
                    if (LotoFacil[i] == n) return true;
                }
            }
            return false;
        } 

        public void Sorteio(string qual)
        {
            if(qual == "ms")
            {
                bool gg = true;
                do {
                    Random rand = new Random();
                    segura = rand.Next(1, 60);
                    if(!CheckNunber(segura, qual))
                    {
                        MegaSena[vez] = segura;
                        vez++;
                    }
                    if (vez == 6)
                    {
                        gg = false;
                        segura = 0;
                    }
                } while (gg);
                vez = 0;
            }
            else if(qual == "lf")
            {
                bool gg = true;
                do
                {
                    Random rand = new Random();
                    segura = rand.Next(1, 25);
                    if (!CheckNunber(segura, qual))
                    {
                        LotoFacil[vez] = segura;
                        vez++;
                    }
                    if (vez == 15)
                    {
                        gg = false;
                        segura = 0;
                    }
                } while (gg);
                vez = 0;
            }
            else if (qual == "qn")
            {
                bool gg = true;
                do
                {
                    Random rand = new Random();
                    segura = rand.Next(1, 80);
                    if (!CheckNunber(segura, qual))
                    {
                        Quina[vez] = segura;
                        vez++;
                    }
                    if (vez == 5)
                    {
                        gg = false;
                        segura = 0;
                    }
                } while (gg);
                vez = 0;
            }
        }
    }
}
