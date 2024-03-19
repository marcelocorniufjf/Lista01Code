using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao03
{
    public class No
    {
        public int Valor { get; set; }
        public No Proximo { get; set; }

        public No(int valor)
        {
            Valor = valor;
            Proximo = null;
        }
    }
}
