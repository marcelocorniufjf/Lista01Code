using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao04
{
    public class ListaEncadeada
    {
        private No cabeca;
        private int contador;

        public ListaEncadeada()
        {
            cabeca = null;
            contador = 0;
        }

        public void Adicionar(char value)
        {
            No newNode = new No(value);
            if (cabeca == null)
            {
                cabeca = newNode;
            }
            else
            {
                No atual = cabeca;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = newNode;
            }
            contador++;
        }

        public bool EPalindromo()
        {
            No lenta = cabeca;
            No rapida = cabeca;
            Stack<char> pilha = new Stack<char>();

            while (rapida != null && rapida.Proximo != null)
            {
                pilha.Push(lenta.Valor);
                lenta = lenta.Proximo;
                rapida = rapida.Proximo.Proximo;
            }

            if (rapida != null)
            {
                lenta = lenta.Proximo;
            }

            while (lenta != null)
            {
                if (pilha.Pop() != lenta.Valor)
                {
                    return false;
                }
                lenta = lenta.Proximo;
            }

            return true;
        }
    }
}
