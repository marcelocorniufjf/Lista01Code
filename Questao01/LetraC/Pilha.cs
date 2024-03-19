using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao01.LetraC
{
    public class Pilha
    {
        private No topo;

        public Pilha()
        {
            this.topo = null;
        }

        public bool Contido(int chave)
        {
            No atual = this.topo;
            while (atual != null)
            {
                if (atual.chave == chave)
                {
                    return true;
                }
                atual = atual.proximo;
            }
            return false;
        }

        public void Inserir(int chave)
        {
            No novoNo = new No(chave);
            if (this.topo == null)
            {
                this.topo = novoNo;
            }
            else
            {
                novoNo.proximo = this.topo;
                this.topo = novoNo;
            }
        }

        public void Remover()
        {
            if (this.topo != null)
            {
                this.topo = this.topo.proximo;
            }
        }
    }
}
