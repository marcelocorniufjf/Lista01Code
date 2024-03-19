Console.WriteLine("Códigos da Lista 01 de exercícios de AED");

//Questão 01 - Letra A - Exemplos de uso

var q01A = new Lista01Code.Questao01.LetraA.ListaDuplamenteEncadeada();

q01A.Inserir(10);
q01A.Inserir(5);
q01A.Inserir(6);
q01A.Inserir(55);

var procurar01AChave6 = q01A.Contido(6);

Console.WriteLine(procurar01AChave6);

//Remove a chave 6
q01A.Remover(6);

procurar01AChave6 = q01A.Contido(6);

Console.WriteLine(procurar01AChave6);

//Questão 01 - Letra B - Exemplos de uso

var q01B = new Lista01Code.Questao01.LetraB.Fila(); //FIFO

q01B.Inserir(10);
q01B.Inserir(5);
q01B.Inserir(6);
q01B.Inserir(55);

var procurar01BChave10 = q01B.Contido(10);

Console.WriteLine(procurar01BChave10);


//Remove a chave 10
q01B.Remover();

procurar01BChave10 = q01B.Contido(10);
Console.WriteLine(procurar01BChave10);


//Questão 01 - Letra C - Exemplo de uso

var q01C = new Lista01Code.Questao01.LetraC.Pilha(); //LIFO

q01C.Inserir(10);
q01C.Inserir(5);
q01C.Inserir(6);
q01C.Inserir(55);

var procurar01CChave55 = q01C.Contido(55);

Console.WriteLine(procurar01CChave55);


//Remove a chave 55
q01C.Remover();

procurar01CChave55 = q01C.Contido(55);
Console.WriteLine(procurar01CChave55);

//Questão 01 - Letra D - Exemplo de uso

var q01D = new Lista01Code.Questao01.LetraD.ListaDuplamenteEncadeadaCircular();

q01D.Inserir(10);
q01D.Inserir(5);
q01D.Inserir(6);
q01D.Inserir(55);

var procurar01DChave55 = q01D.Contido(55);

Console.WriteLine(procurar01DChave55);

//Remove a chave 55
q01D.Remover(55);

procurar01DChave55 = q01D.Contido(55);
Console.WriteLine(procurar01DChave55);


//Questão 02 - Exemplo de uso

var q02Lista1 = new Lista01Code.Questao02.ListaInteiroGrande();

var q02Lista2 = new Lista01Code.Questao02.ListaInteiroGrande();

var q02Lista3 = new Lista01Code.Questao02.ListaInteiroGrande();

q02Lista1.InserirDigito(9);
q02Lista1.InserirDigito(9);
q02Lista1.InserirDigito(9);

q02Lista2.InserirDigito(5);
q02Lista2.InserirDigito(1);
q02Lista2.InserirDigito(2);

//Somar as listas - Resultado esperado 1511 = (999 + 512)
q02Lista3 = q02Lista3.Soma(q02Lista1, q02Lista2);
q02Lista3.Imprimir();


//Questão 03 - Exemplo de uso
var q03 = new Lista01Code.Questao03.ListaEncadeada();

q03.Inserir(10);
q03.Inserir(5);
q03.Inserir(6);
q03.Inserir(55);

q03.Imprimir();

q03 = q03.InverterLista();

q03.Imprimir();

var q03Soma = new Lista01Code.Questao03.ListaEncadeada();

q03Soma = q03.SomarMeiaLista();

q03Soma.Imprimir();

//Questão 04 - Exemplo de uso

var q0401 = new Lista01Code.Questao04.ListaEncadeada();

q0401.Inserir('R');
q0401.Inserir('A');
q0401.Inserir('D');
q0401.Inserir('A');
q0401.Inserir('R');

Console.WriteLine(q0401.EPalindromo() ? "É palíndromo" : "Não é Palíndromo");

var q0402 = new Lista01Code.Questao04.ListaEncadeada();

q0402.Inserir('B');
q0402.Inserir('A');
q0402.Inserir('T');
q0402.Inserir('A');
q0402.Inserir('T');
q0402.Inserir('A');

Console.WriteLine(q0402.EPalindromo() ? "É palíndromo" : "Não é Palíndromo");


//Questão 05 - Exemplo de uso

var q05 = new Lista01Code.Questao05.MatrizEsparsa();

// a) Inserindo valores na matriz
q05.Inserir(0, 0, 2);
q05.Inserir(0, 1, 3);
q05.Inserir(0, 2, 4);
q05.Inserir(1, 0, 5);
q05.Inserir(1, 1, 6);
q05.Inserir(1, 2, 7);

Console.WriteLine("Matriz Esparsa:");
q05.Imprimir();

// b) Localizando um valor na matriz
int valor = q05.Procurar(1, 0);
Console.WriteLine("Valor encontrado: " + valor);

// c) Calculando A^2
var q05Quadrado = q05.Quadrado();
Console.WriteLine("Matriz A^2:");
q05Quadrado.Imprimir();

// d) complexidade O(k^2) do médodo Quadrado(), sendo K o número de elementos não irrelevantes.

Console.ReadKey();