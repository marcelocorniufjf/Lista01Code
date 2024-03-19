using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao01.LetraB
{
    public class No
    {
        public int chave;
        public No proximo;

        public No(int chave)
        {
            this.chave = chave;
            this.proximo = null;
        }
    }
}
