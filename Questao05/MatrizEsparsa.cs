using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01Code.Questao05
{
    public class MatrizEsparsa
    {
        // Estrutura de dados para representar a matriz esparsa
        private List<int> linhas;
        private List<int> colunas;
        private List<int> valores;

        // Construtor para inicializar a matriz esparsa
        public MatrizEsparsa()
        {
            linhas = new List<int>();
            colunas = new List<int>();
            valores = new List<int>();
        }

        // a) Método para inserir um valor na matriz
        public void Inserir(int linha, int coluna, int valor)
        {
            linhas.Add(linha);
            colunas.Add(coluna);
            valores.Add(valor);
        }

        // b) Método para localizar um valor na matriz
        public int Find(int linha, int coluna)
        {
            for (int i = 0; i < linhas.Count; i++)
            {
                if (linhas[i] == linha && colunas[i] == coluna)
                {
                    return valores[i];
                }
            }
            return 0; // Valor irrelevante se não encontrado
        }

        // c) Método para calcular A^2 utilizando a estrutura
        public MatrizEsparsa Quadrado()
        {
            MatrizEsparsa result = new MatrizEsparsa();
            for (int i = 0; i < linhas.Count; i++)
            {
                int linhaAtual = linhas[i];
                int colunaAtual = colunas[i];
                int valorAtual = valores[i];
                for (int j = 0; j < linhas.Count; j++)
                {
                    if (colunaAtual == linhas[j])
                    {
                        int proximaColuna = colunas[j];
                        int proximoValor = valores[j];
                        int produto = valorAtual * proximoValor;
                        result.Inserir(linhaAtual, proximaColuna, produto);
                    }
                }
            }
            return result;
        }

        // Método para imprimir a matriz esparsa
        public void Imprimir()
        {
            for (int i = 0; i < linhas.Count; i++)
            {
                Console.WriteLine("({0}, {1}): {2}", linhas[i], colunas[i], valores[i]);
            }
        }
    }
}
