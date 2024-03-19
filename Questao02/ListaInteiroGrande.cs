using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao02
{
    public class ListaInteiroGrande
    {
        private No cabeca;

        public ListaInteiroGrande()
        {
            this.cabeca = null;
        }

        public void InserirDigito(int digito)
        {
            No novoNo = new No(digito);
            if (this.cabeca == null)
            {
                this.cabeca = novoNo;
            }
            else
            {
                novoNo.proximo = this.cabeca;
                this.cabeca = novoNo;
            }
        }

        public ListaInteiroGrande Soma(ListaInteiroGrande lista1, ListaInteiroGrande lista2)
        {
            ListaInteiroGrande resultado = new ListaInteiroGrande();
            No atual1 = lista1.cabeca;
            No atual2 = lista2.cabeca;
            int carry = 0;

            while (atual1 != null || atual2 != null || carry != 0)
            {
                int soma = carry;
                if (atual1 != null)
                {
                    soma += atual1.digito;
                    atual1 = atual1.proximo;
                }
                if (atual2 != null)
                {
                    soma += atual2.digito;
                    atual2 = atual2.proximo;
                }

                carry = soma / 10;
                int digitoSoma = soma % 10;
                resultado.InserirDigito(digitoSoma);
            }

            return resultado;
        }

        public void Imprimir()
        {
            No atual = this.cabeca;
            while (atual != null)
            {
                Console.Write(atual.digito);
                atual = atual.proximo;
            }
            Console.WriteLine();
        }
    }
}
