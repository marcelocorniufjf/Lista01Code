using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao01.LetraD
{
    public class ListaDuplamenteEncadeadaCircular
    {
        private No cabeca;
        private No cauda;

        public ListaDuplamenteEncadeadaCircular()
        {
            this.cabeca = null;
            this.cauda = null;
        }

        public bool Contido(int chave)
        {
            No atual = this.cabeca;
            while (atual != null && atual != this.cauda)
            {
                if (atual.chave == chave)
                {
                    return true;
                }
                atual = atual.proximo;
            }
            if (this.cauda != null && this.cauda.chave == chave)
            {
                return true;
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
                novoNo.proximo = novoNo;
                novoNo.anterior = novoNo;
            }
            else
            {
                novoNo.proximo = this.cabeca;
                novoNo.anterior = this.cauda;
                this.cabeca.anterior = novoNo;
                this.cauda.proximo = novoNo;
                this.cauda = novoNo;
            }
        }

        public void Remover(int chave)
        {
            No atual = this.cabeca;
            while (atual != null && atual != this.cauda)
            {
                if (atual.chave == chave)
                {
                    atual.anterior.proximo = atual.proximo;
                    atual.proximo.anterior = atual.anterior;
                    if (atual == this.cabeca)
                    {
                        this.cabeca = atual.proximo;
                    }
                    if (atual == this.cauda)
                    {
                        this.cauda = atual.anterior;
                    }
                    return;
                }
                atual = atual.proximo;
            }
            if (this.cauda != null && this.cauda.chave == chave)
            {
                this.cauda.anterior.proximo = this.cabeca;
                this.cabeca.anterior = this.cauda.anterior;
                this.cauda = this.cauda.anterior;
            }
        }
    }

}
