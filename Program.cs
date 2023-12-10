using System.Security.Cryptography;
using System.Data;
using System.Dynamic;
using System; 
using Microsoft.CSharp.RuntimeBinder;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

//dotnet new console - cria aplicação base .net
//dotnet run program.cs - compila o código e roda a aplicação dotnet.

// desenvolvendo uma aplicação - Screen Sound
// C# é uma linguagem fortemente tipada, significa que sempre
//temos que declarar o tipo do dado.

//tipo de dado "String" - "Nome da variável" - "dado que será armazenado"
/*
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Console.WriteLine(mensagemDeBoasVindas);


//Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
string curso = "C#: criando sua primeira aplicação";

//Mostrar o conteúdo da variável curso no console
Console.WriteLine(curso);

//Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
string nome = "Romário";
string sobreNome = "Oliveira";
Console.WriteLine(nome + " " + sobreNome);


//Mostrar na tela o nome dos instrutores do curso.
string instrutor1 = "Daniel Portugal";
string instrutor2 = "Guilherme Lima";
Console.WriteLine(instrutor1 + "\n" + instrutor2);


//tipos e funções

//uma das formas de reaproveitar código é através de funções

//o primeiro passo é indicar se a função tem um retorno ou não
//quando a função não tem retorno utiliza-se a palavra reservada "void"

//função sem retorno para exibir a mensagem de boas vindas
//sintaxe da função
void ExibirMensagemDeBoasVindas()
{
  //verbatim literal - serve basicamente para colocar a string da forma com que você quer que ela apareça (parece template literals)
  Console.WriteLine(@"
  
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
  ");
  Console.WriteLine(mensagemDeBoasVindas);
}
//chamando a função
//ExibirMensagemDeBoasVindas();


//fsymbols.com/pt/geradores/ - utilizado para pegar caracteres diferenciados pelos instrutores

//função void "sem retorno" para exibir opções do menu
//
void ExibirOpcoesDoMenu()
{
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");
  //WriteLine pula uma linha, o Write apenas cria a linha
  Console.Write("\nDigite a sua opção: ");
  //ReadLine cria um "prompt" que espera alguma resposta

  //armazenando a resposta do usuário em uma váriavel do tipo string
  string opcaoEscolhida = Console.ReadLine()!; //o sinal de exclamação indica que essa variável não pode receber valor null, precisa receber uma string
  //convertendo a variável string para inteiro com int.Parse(); - pois não dá para comparar string com int
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  //condições usando IF-Else
  //if(opcaoEscolhidaNumerica == 1)
  //{
  //  Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
  //}else if(opcaoEscolhidaNumerica == 2)
  // {
  // Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
  //}

  //utilizando switch case
  
  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
      break;
    case 2:
      Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
      break;
    case 3:
      Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
      break;
    case 4:
      Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
      break;
    case -1:
      Console.WriteLine("Tchau Tchau :)" );
      break;
    default:
      Console.WriteLine("Opção Inválida");
      break;
  }
}

//
//
Uma pessoa desenvolveu um programa que solicita o nome e exibe uma mensagem de saudação dizendo Olá seguido do nome digitado pela pessoa, como mostra o código abaixo:

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();
Console.WriteLine("Olá, " + nome + "!");

Sabendo disso, analise as afirmações e selecione a alternativa na qual a saída do console será a mesma:

A - Console.WriteLine($"Olá, {nome}!"); - Resposta correta
B - Console.WriteLine("Olá, [nome!]"); - Errada
C - Console.WriteLine("Olá, {0}!", nome); - Resposta correta

Explicação:

A - Console.WriteLine($"Olá, {nome}!");
Isso aí! Neste caso usamos a sintaxe de interpolação de string que nos permite incluir variáveis diretamente em uma string usando chaves {}. Ao colocar o sinal $ antes da string, indicamos ao compilador que ela deve ser interpolação de string

C - Console.WriteLine("Olá, {0}!", nome);
Isso aí! Neste caso, usamos um formato de string que nos permite substituir marcadores de posição {0}, {1}, etc. por valores específicos. Ao passar a variável nome como segundo argumento para o método Console.WriteLine, ela será substituída no marcador de posição {0}.


//chamando funções
//ExibirMensagemDeBoasVindas();
//ExibirOpcoesDoMenu();

//Exercícios
//
1- Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
2 - Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
3 - Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
4 - Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
 

//
void programaAprovacao()
{
  //solicitando que o usuário digite uma nota
Console.Write("Digite sua nota: ");
//armazenando a nota digitada em uma variável
string notaMedia = Console.ReadLine()!;
//convertendo o dado tipo string para inteiro para poder comparar a nota
int notaMediaNum = int.Parse(notaMedia);
//condicional para exibir a mensagem de aprovação/reprovação
if(notaMediaNum >= 5)
{
  Console.WriteLine("\nNota suficiente para aprovação: " + notaMedia);
}
else
{
  Console.WriteLine("\nNota insuficiente para aprovação: " + notaMedia);
}
//mensagem de encerramento de programa
Console.WriteLine("\n\nEncerrando Programa!");
}
programaAprovacao();
*/

//Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
//R:

//int media = 5;
//if(media >= 5){
 //   Console.WriteLine("Nota suficiente para aprovação");
//}

//Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
//R:

//List<string> linguagens = new () {"C#", "Java", "JavaScript"};

//Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
//R:

//Console.WriteLine(linguagens[0]);

//List<int> num = new () {1,2,3};
//Console.WriteLine(num[0]);

//Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
//R:

//int posicao = int(Console.read());
//Console.WriteLine(lista[posicao]);

//List<int> lista = new() {1,2,3,4,5};

//é melhor usar Convert.ToInt32 pois o int.Parse aceita valor null
//Console.Write("Digite a posição: ");
//int posicao = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(lista[posicao]);


/*
Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.

Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.
*/
/*
//definindo número secreto randomico
Random aleatorio = new Random();
//next retorna um valor inteiro não negativo entre os números(1 e 101) específicados no parâmetro
int numeroSecreto = aleatorio.Next(1,101);

//desenvolvendo a lógica do jogo

do{
  //solicitando interação do usuário
  Console.Write("Digite um número entre 1 e 100: ");
  //armazenando palpite do usuário
  int chute = int.Parse(Console.ReadLine());
  
  //condicional para o palpite do usuário
  if(chute == numeroSecreto)
  {
    Console.WriteLine("Parabéns! você acertou o número.");
    break;
  }else if(chute < numeroSecreto)
  {
    Console.WriteLine("O número é maior");
  }else
  {
    Console.WriteLine("O número é menor.");
  }

}while(true);
*/
/*
//dado
void PlayDice()
{
  Random numAleatorio = new Random();
  int ValueDice = numAleatorio.Next(1,7);
  Console.WriteLine("Você jogou o dado e o seu número é: " + ValueDice);
}
PlayDice();
*/