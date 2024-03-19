using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao01.LetraA
{
    public class ListaDuplamenteEncadeada
    {
        private No cabeca;
        private No cauda;

        public ListaDuplamenteEncadeada()
        {
            cabeca = null;
            cauda = null;
        }

        public bool Contido(int chave)
        {
            No atual = cabeca;
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
            if (cabeca == null)
            {
                cabeca = novoNo;
                cauda = novoNo;
            }
            else
            {
                cauda.proximo = novoNo;
                novoNo.anterior = cauda;
                cauda = novoNo;
            }
        }

        public void Remover(int chave)
        {
            No atual = cabeca;
            while (atual != null)
            {
                if (atual.chave == chave)
                {
                    if (atual.anterior != null)
                    {
                        atual.anterior.proximo = atual.proximo;
                    }
                    else
                    {
                        cabeca = atual.proximo;
                    }
                    if (atual.proximo != null)
                    {
                        atual.proximo.anterior = atual.anterior;
                    }
                    else
                    {
                        cauda = atual.anterior;
                    }
                    return;
                }
                atual = atual.proximo;
            }
        }
    }
}
