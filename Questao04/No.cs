using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao04
{
    public class No
    {
        public char Valor { get; set; }
        public No Proximo { get; set; }

        public No(char value)
        {
            Valor = value;
            Proximo = null;
        }
    }
}
