using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao02
{
    public class No
    {
        public int digito;
        public No proximo;

        public No(int digito)
        {
            this.digito = digito;
            this.proximo = null;
        }
    }
}
