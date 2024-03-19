using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao03
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

        public void Adicionar(int valor)
        {
            No novoNo = new No(valor);
            if (cabeca == null)
            {
                cabeca = novoNo;
            }
            else
            {
                No atual = cabeca;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNo;
            }
            contador++;
        }

        public void ImprimirLista()
        {
            No atual = cabeca;
            while (atual != null)
            {
                Console.Write(atual.Valor + " ");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }

        public ListaEncadeada InverterLista()
        {
            ListaEncadeada reversedList = new ListaEncadeada();
            No atual = cabeca;
            while (atual != null)
            {
                reversedList.AdicionarNaFrente(atual.Valor);
                atual = atual.Proximo;
            }
            return reversedList;
        }

        public ListaEncadeada SomarMeiaLista()
        {
            ListaEncadeada somarMeiaLista = new ListaEncadeada();
            No atual = cabeca;
            for (int i = 0; i < contador / 2; i++)
            {
                int sum = atual.Valor + PegarNoNaPosicao(contador - i - 1).Valor;
                somarMeiaLista.Adicionar(sum);
                atual = atual.Proximo;
            }
            return somarMeiaLista;
        }

        private void AdicionarNaFrente(int valor)
        {
            No novoNo = new No(valor);
            novoNo.Proximo = cabeca;
            cabeca = novoNo;
            contador++;
        }

        private No PegarNoNaPosicao(int posicao)
        {
            if (posicao < 0 || posicao >= contador)
            {
                throw new ArgumentOutOfRangeException(nameof(posicao));
            }

            No atual = cabeca;
            for (int i = 0; i < posicao; i++)
            {
                atual = atual.Proximo;
            }
            return atual;
        }
    }
}
