using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao01.LetraB
{
    public class Fila
    {
        private No cabeca;
        private No cauda;

        public Fila()
        {
            this.cabeca = null;
            this.cauda = null;
        }

        public bool Contido(int chave)
        {
            No atual = this.cabeca;
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
            if (this.cabeca == null)
            {
                this.cabeca = novoNo;
                this.cauda = novoNo;
            }
            else
            {
                this.cauda.proximo = novoNo;
                this.cauda = novoNo;
            }
        }

        public void Remover()
        {
            if (this.cabeca != null)
            {
                this.cabeca = this.cabeca.proximo;
                if (this.cabeca == null)
                {
                    this.cauda = null;
                }
            }
        }
    }
}
