using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena
{
    class Configuracao
    {
        private static int[] lista =
        {
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0
        };
        public int[] Lista { get => lista; set => lista = value; }

        private static int[] listaLoto =
        {
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0
        };
        public int[] ListaLoto { get => listaLoto; set => listaLoto = value; }

        private static bool[] ativo = { false, false };
        public bool[] Ativo { get => ativo; set => ativo = value; }

    }
}
