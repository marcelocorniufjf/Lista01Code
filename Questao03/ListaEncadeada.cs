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

        public void Inserir(int valor)
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

        public void Imprimir()
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
            ListaEncadeada listaReversa = new ListaEncadeada();
            No atual = cabeca;
            while (atual != null)
            {
                listaReversa.InserirNaFrente(atual.Valor);
                atual = atual.Proximo;
            }
            return listaReversa;
        }

        public ListaEncadeada SomarMeiaLista()
        {
            ListaEncadeada somarMeiaLista = new ListaEncadeada();
            No atual = cabeca;
            for (int i = 0; i < contador / 2; i++)
            {
                int sum = atual.Valor + PegarNoNaPosicao(contador - i - 1).Valor;
                somarMeiaLista.Inserir(sum);
                atual = atual.Proximo;
            }
            return somarMeiaLista;
        }

        private void InserirNaFrente(int valor)
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
