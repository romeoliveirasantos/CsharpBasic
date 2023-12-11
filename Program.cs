using System.Security.Cryptography;
using System.Data;
using System.Dynamic;
using System;
using Microsoft.CSharp.RuntimeBinder;
using System.Collections.Generic;
using System.Security.AccessControl;
 See https:aka.ms/new-console-template for more information

dotnet new console - cria aplicação base .net
dotnet run program.cs - compila o código e roda a aplicação dotnet.

 desenvolvendo uma aplicação - Screen Sound
 C# é uma linguagem fortemente tipada, significa que sempre
temos que declarar o tipo do dado.

tipo de dado "String" - "Nome da variável" - "dado que será armazenado"

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Console.WriteLine(mensagemDeBoasVindas);


Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
string curso = "C#: criando sua primeira aplicação";

Mostrar o conteúdo da variável curso no console
Console.WriteLine(curso);

Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
string nome = "Romário";
string sobreNome = "Oliveira";
Console.WriteLine(nome + " " + sobreNome);


Mostrar na tela o nome dos instrutores do curso.
string instrutor1 = "Daniel Portugal";
string instrutor2 = "Guilherme Lima";
Console.WriteLine(instrutor1 + "\n" + instrutor2);


tipos e funções

uma das formas de reaproveitar código é através de funções

o primeiro passo é indicar se a função tem um retorno ou não
quando a função não tem retorno utiliza-se a palavra reservada "void"

função sem retorno para exibir a mensagem de boas vindas
sintaxe da função
void ExibirMensagemDeBoasVindas()
{
  verbatim literal - serve basicamente para colocar a string da forma com que você quer que ela apareça (parece template literals)
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
chamando a função
ExibirMensagemDeBoasVindas();


fsymbols.com/pt/geradores/ - utilizado para pegar caracteres diferenciados pelos instrutores

função void "sem retorno" para exibir opções do menu

void ExibirOpcoesDoMenu()
{
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");
  WriteLine pula uma linha, o Write apenas cria a linha
  Console.Write("\nDigite a sua opção: ");
  ReadLine cria um "prompt" que espera alguma resposta

  armazenando a resposta do usuário em uma váriavel do tipo string
  string opcaoEscolhida = Console.ReadLine()!; o sinal de exclamação indica que essa variável não pode receber valor null, precisa receber uma string
  convertendo a variável string para inteiro com int.Parse(); - pois não dá para comparar string com int
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  condições usando IF-Else
  if(opcaoEscolhidaNumerica == 1)
  {
    Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
  }else if(opcaoEscolhidaNumerica == 2)
   {
   Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
  }

  utilizando switch case
  
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


chamando funções
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

Exercícios

1- Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
2 - Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
3 - Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
4 - Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
 


void programaAprovacao()
{
  solicitando que o usuário digite uma nota
Console.Write("Digite sua nota: ");
armazenando a nota digitada em uma variável
string notaMedia = Console.ReadLine()!;
convertendo o dado tipo string para inteiro para poder comparar a nota
int notaMediaNum = int.Parse(notaMedia);
condicional para exibir a mensagem de aprovação/reprovação
if(notaMediaNum >= 5)
{
  Console.WriteLine("\nNota suficiente para aprovação: " + notaMedia);
}
else
{
  Console.WriteLine("\nNota insuficiente para aprovação: " + notaMedia);
}
mensagem de encerramento de programa
Console.WriteLine("\n\nEncerrando Programa!");
}
programaAprovacao();


Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
R:

int media = 5;
if(media >= 5){
   Console.WriteLine("Nota suficiente para aprovação");
}

Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
R:

List<string> linguagens = new () {"C#", "Java", "JavaScript"};

Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
R:

Console.WriteLine(linguagens[0]);

List<int> num = new () {1,2,3};
Console.WriteLine(num[0]);

Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
R:

int posicao = int(Console.read());
Console.WriteLine(lista[posicao]);

List<int> lista = new() {1,2,3,4,5};

é melhor usar Convert.ToInt32 pois o int.Parse aceita valor null
Console.Write("Digite a posição: ");
int posicao = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(lista[posicao]);


/*
Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.

Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.
*/

definindo número secreto randomico
Random aleatorio = new Random();
next retorna um valor inteiro não negativo entre os números(1 e 101) específicados no parâmetro
int numeroSecreto = aleatorio.Next(1,101);

desenvolvendo a lógica do jogo

do{
  solicitando interação do usuário
  Console.Write("Digite um número entre 1 e 100: ");
  armazenando palpite do usuário
  int chute = int.Parse(Console.ReadLine());
  
  condicional para o palpite do usuário
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


dado
void PlayDice()
{
  Random numAleatorio = new Random();
  int ValueDice = numAleatorio.Next(1,7);
  Console.WriteLine("Você jogou o dado e o seu número é: " + ValueDice);
}
PlayDice();


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
para criar uma lista usa-se a seguinte sintaxe
declara o tipo da lista - nome da lista - instancia nova lista
List<string> listasDasBandas = new List<string> { "U2", "Beatles", "Calypso" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 6 });
bandasRegistradas.Add("The Beatles", new List<int> { 5, 6, 10, 9, 2 });
bandasRegistradas.Add("Papa Roach", new List<int>());

void ExibirLogo()
{
  verbatim literal - serve basicamente para colocar a string da forma com que você quer que ela apareça (parece template literals)
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

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");
  WriteLine pula uma linha, o Write apenas cria a linha
  Console.Write("\nDigite a sua opção: ");
  ReadLine cria um "prompt" que espera alguma resposta

  armazenando a resposta do usuário em uma váriavel do tipo string
  string opcaoEscolhida = Console.ReadLine()!; o sinal de exclamação indica que essa variável não pode receber valor null, precisa receber uma string
  convertendo a variável string para inteiro com int.Parse(); - pois não dá para comparar string com int
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  condições usando IF-Else
  if(opcaoEscolhidaNumerica == 1)
  {
    Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
  }else if(opcaoEscolhidaNumerica == 2)
   {
   Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
  }

  utilizando switch case

  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      registrarBanda();
      break;
    case 2:
      MostrarBandasRegistradas();
      break;
    case 3:
      AvaliarUmaBanda();
      break;
    case 4:
      ExibirMediaBanda();
      break;
    case -1:
      Console.WriteLine("Tchau Tchau :)");
      break;
    default:
      Console.WriteLine("Opção Inválida");
      break;
  }
}

void registrarBanda()
{
  limpa o console.
  Console.Clear();
  exibe o título
  exibirTituloDaOpcao("Registro das bandas");
  exibe a opção
  Console.Write("Digite o nome da banda que deseja registrar: ");
  guarda o dado inserido pelo usuário na variável
  string nomeDaBanda = Console.ReadLine()!;
  bandasRegistradas.Add(nomeDaBanda, new List<int>());
  exibe a frase e a variável, utilizando interpolação de string
  Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); interpolação de string sintaxe $(onde terá variável usar {})
  thread.sleep da uma pausa baseada em segundos
  Thread.Sleep(2000);
  chama a função de exibir o menu
  ExibirOpcoesDoMenu();
  limpa o console
  Console.Clear();
}
void MostrarBandasRegistradas()
{
  Console.Clear();
  exibirTituloDaOpcao("Exibindo todas as bandas registradas");
  
  for (int i = 0; i < listasDasBandas.Count; i++)
  {
    Console.WriteLine($"Banda: {listasDasBandas[i]}");
  }
  
  foreach (string banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"Banda: {banda}");
  }
  Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void exibirTituloDaOpcao(string titulo)
{
  atribundo o valor da quantidade com base no número de caracteres do titulo
  int quantidadeDeCaracteres = titulo.Length;
  criando uma string vazia e adicionando a quantidade de astericos com base na quantidade de caractere do titulo
  string asteriscos = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
  exibindo os asteriscos
  Console.WriteLine(asteriscos);
  exibindo o titulo
  Console.WriteLine(titulo);
  exibindo os asteriscos
  Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
  digitar qual banda seja avaliar
   se a banda existir no dicionário >> atribuir uma nota
  //Se não existir, voltar ao menu principal
  Console.Clear();
  exibirTituloDaOpcao("Avaliar banda");
  Console.WriteLine("\nBandas registradas");
  foreach (string banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"{banda}");
  }
  Console.Write("Digite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
    int nota = int.Parse(Console.ReadLine()!);
    bandasRegistradas[nomeDaBanda].Add(nota);
    Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
  else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}
//desafio
//limpar o terminal
//exibir o título
//perguntar qual banda
//validar se banda existe
//se exitir exibir média da banda
void ExibirMediaBanda()
{
  Console.Clear();
  exibirTituloDaOpcao("Exibindo todas as bandas registradas");
  foreach (string banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"Banda: {banda}");
  }
  exibirTituloDaOpcao("Média das notas das bandas");
  Console.Write("Digite o nome da banda que você quer consultar a média: ");
  string nomeDaBanda = Console.ReadLine()!;

  if (bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    List<int> valoresDaBanda = bandasRegistradas[nomeDaBanda];

    if (valoresDaBanda.Any())
    {
      double mediaDaBanda = valoresDaBanda.Average();
      int mediaConvertida = (int)mediaDaBanda;

      Console.WriteLine("\n\nCalculando média...");
      Thread.Sleep(2000);
      Console.Clear();
      Console.WriteLine($"\nA média da banda {nomeDaBanda} é de: {mediaConvertida}");
      Console.WriteLine("Aguarde...Voltando ao menu de opções!");
      Thread.Sleep(3000);
      Console.Clear();
      ExibirOpcoesDoMenu();
    }
    else
    {
      Console.WriteLine($"A lista de valores da banda {nomeDaBanda} está vazia");
      Console.WriteLine($"Deseja dar uma nota para {nomeDaBanda}? y/n");
      string userResponse = Console.ReadLine()!;
      if (userResponse == "y")
      {
        AvaliarUmaBanda();
      }
      else
      {
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
      }
    }
  }
  else
  {
    Console.WriteLine($"Banda {nomeDaBanda} não encontrada");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  }

}
ExibirOpcoesDoMenu();




// //praticando listas
// List<string> users = new (){"Roxo","MonoLord","Menix"};
// List<int> years = new () {1994,1995,1996};

// foreach(int ano in years)
// {
//   Console.WriteLine(ano);
// }

// foreach(string user in users)
// {
//   Console.WriteLine(user);
// }

//exercício 1 - criando função para fazer as 4 operações básicas

// void OperacoesMath(int n1, string tipoOp, int n2)
// {
//   switch(tipoOp)
//   {
//     case "+":
//     int resultAdicao = n1 + n2;
//     Console.WriteLine($"O resultado da operação de {n1} {tipoOp} {n2} é : {resultAdicao}");
//     break;
//     case "-":
//     int resultSub = n1 - n2;
//     Console.WriteLine($"O resultado da operação de {n1} {tipoOp} {n2} é : {resultSub}");
//     break;
//     case "/":
//     int resultDiv = n1 / n2;
//     Console.WriteLine($"O resultado da operação de {n1} {tipoOp} {n2} é : {resultDiv}");
//     break;
//     case "*":
//     int resultMult = n1 * n2;
//     Console.WriteLine($"O resultado da operação de {n1} {tipoOp} {n2} é : {resultMult}");
//     break;
//     default:
//     Console.WriteLine("Operação inválida");
//     break;
//   }
// }
// OperacoesMath(3,"/",3);
// Thread.Sleep(2000);
// Console.WriteLine("\nFinalizando aplicação!");
// Thread.Sleep(2000);
// Console.Clear();

//Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

// List<string> bandas = new (){"Issues", "Fire from the Gods","I prevail","Architects"};
// void RegistroDeBandas()
// {
//   Console.WriteLine("Bem-vindo ao Bandas Favoritas!\n");
//   Console.Write("Digite o nome da banda que deseja registrar: ");
//   string nomeBanda = Console.ReadLine()!;
//   bandas.Add(nomeBanda);
//   Console.WriteLine($"Banda: {nomeBanda} registrada com sucesso!");
//   Thread.Sleep(2000);
//   Console.Clear();
//   Console.WriteLine($"Todas as bandas registradas\n");
//   foreach(string banda in bandas)
//   {

//     Console.WriteLine(banda);
//   }
// }
// RegistroDeBandas();
//Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
// List<int> nums = new (){1,2,3,4,5,6,7,8,9};
// void somaDosValores()
// {
// int soma = 0;
// // for(int i = 0; i < nums.Count; i++)
// // {

// //   soma += nums[i];
// //   Console.WriteLine(soma);
// // }
// foreach(int numeros in nums)
// {
//   soma+=numeros;
// }
// Console.WriteLine(soma);

// }
// somaDosValores();
/*
Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.
*/

 List<int> inteiros = new List<int>(){3,7,8,10,20,40,50,70,90,100,31};

 for(int i = 0; i < inteiros.Count; i++)
 {
   if(inteiros[i] % 2 == 0)
   {
     Console.WriteLine(inteiros[i]);
   }
 }

 foreach (int numero in inteiros)
 {
     if (numero % 2 == 0) {
         Console.WriteLine(numero);
     }
 }

 var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
     { "Ana", new Dictionary<string, List<int>> {
         { "C#", new List<int> { 8, 7, 6 } },
         { "Java", new List<int> { 7, 6, 5 } },
         { "Python", new List<int> { 9, 8, 8 } }
     }},
     { "Maria", new Dictionary<string, List<int>> {
         { "C#", new List<int> { 6, 5, 4 } },
         { "Java", new List<int> { 8, 7, 6 } },
         { "Python", new List<int> { 6, 10, 5 } }
     }},
     { "Luiza", new Dictionary<string, List<int>> {
         { "C#", new List<int> { 2, 3, 10 } },
         { "Java", new List<int> { 8, 8, 8 } },
         { "Python", new List<int> { 7, 7, 7 } }
     }}
 };
 código para descobrir a nota com base no código acima seria:
 List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
 double mediaMariaEmPython = notasPythonMaria.Average();
 Console.WriteLine(mediaMariaEmPython);

/*
1-Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
2-Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
3-Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
4-Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
*/

 Dictionary<string,List<int>> NotasPorAluno = new Dictionary<string, List<int>>();
 NotasPorAluno.Add("Roberto", new List<int>{5,6,7,10});

 List<int> notasRoberto = NotasPorAluno["Roberto"];
 double mediaRoberto = notasRoberto.Average();
 Console.WriteLine(mediaRoberto);


programa para gerenciar estoque de uma loja
 criar um dicionário para armazenar o nome do produto e sua quantidade.
criar o sistema de menu do programa
 armazenar o nome do produto no sitema e sua quantidade
consultar a quantidade de produto no estoque pelo nome do produto

 Dictionary<string, int> EstoqueDeProdutos = new Dictionary<string,int>();
 EstoqueDeProdutos.Add("Camiseta", 50);

 void menu()
 {


     Console.WriteLine("Bem-vindo ao Gerenciador de estoque!\n");
     Console.WriteLine("Qual opção deseja acessar?\n");
     Console.WriteLine("1 - Digite 1 para adicionar um produto\n");
     Console.WriteLine("2 - Digite 2 para consultar um produto\n");
     Console.WriteLine("3 - Digite 3 para remover um produto\n");
     Console.WriteLine("4 - Digite 4 para sair\n");
     string opcaoMenu = Console.ReadLine()!;


     switch(opcaoMenu)
     {
       case "1":
       AdicionarProduto();
       break;
       case "2":
       ConsultarProduto();
       break;
       case "3":
       RemoverProduto();
       break;
       case "4":
       Console.WriteLine("Encerrando...");
       Thread.Sleep(4000);
       Console.Clear();
       break;
       default:
       Console.WriteLine("Opção Inválida!\n\n");
       Thread.Sleep(2000);
       Console.Clear();
       menu();
       break;
     }

 }

 void AdicionarProduto()
 {
   Console.Clear();
   Console.Write("Qual o nome do produto? ");
   string nomeProduto = Console.ReadLine()!;
   Console.Write("Quantas unidades do produto deseja cadastrar? ");
   int qtdProduto = int.Parse(Console.ReadLine()!);
   EstoqueDeProdutos.Add(nomeProduto, qtdProduto);
   Console.WriteLine($"{qtdProduto} unidades do produto {nomeProduto} foi adicionado ao estoque com sucesso!\n");
   Thread.Sleep(2000);
   Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções");
   Console.Clear();
   menu();
 }

 void ConsultarProduto()
 {
   Console.Clear();

   Console.WriteLine("Produtos em estoque: \n");

      Exibir todos os produtos
     foreach (var produto in EstoqueDeProdutos)
     {
         Console.WriteLine(produto.Key + "\n");
     }

   Console.WriteLine("Qual produto deseja consultar no estoque? ");
   string nomeProduto = Console.ReadLine()!;
   if(EstoqueDeProdutos.ContainsKey(nomeProduto))
   {
     Console.WriteLine($"{nomeProduto} - Unidades:{EstoqueDeProdutos[nomeProduto]}");
     Thread.Sleep(4000);
     Console.Clear();
   }else
   {
     Console.WriteLine("Produto não encontrado!");
     Thread.Sleep(2000);
     Console.Clear();
   }
   menu();
 }

 void RemoverProduto()
 {
     Console.Clear();
     Console.WriteLine("Produtos disponíveis para remoção: ");

      Exibir todos os produtos
     foreach (var produto in EstoqueDeProdutos)
     {
         Console.WriteLine(produto.Key);
     }

     Console.Write("Digite o nome do produto que deseja remover: ");
     string nomeProduto = Console.ReadLine()!;

     if (EstoqueDeProdutos.ContainsKey(nomeProduto))
     {
         EstoqueDeProdutos.Remove(nomeProduto);
         Console.WriteLine($"Produto {nomeProduto} foi removido com sucesso!");
     }
     else
     {
         Console.WriteLine($"Produto {nomeProduto} não encontrado no estoque.");
     }

      Aguarde antes de limpar o console e chamar o menu
     Thread.Sleep(4000);
     Console.Clear();
     menu();
 }


 menu();





aplicação de quiz
 Console.WriteLine("Bem-vindo ao QUIZ - Quem sabe, sabe!\n\n");
 Dictionary<string,string> PerguntasERespostas = new Dictionary<string, string>{
   {"Qual é a capital do brasil?", "Brasilia"},
   {"Quem descobriu o Brasil?","Pedro Alvares Cabral"},
   {"Qual personagem do league of legends possui a frase: 'Posso te dar um abraço?'","Amumu"},
   {"Quem inventou o avião?","Santos Dumont"},
   {"Qual é o meio de transporte marítimo mais utilizado?","Navio"},
   {"Qual o livro mais vendido no mundo?","Biblia"},
   {"O que a palavra legend significa em português?","Lenda"}
 };
 int pontuacao = 0;

 foreach(var pergunta in PerguntasERespostas)
 {
   Console.WriteLine(pergunta.Key);
   Console.Write("Sua resposta: ");
   string respostaUsuario = Console.ReadLine()!;

   if(respostaUsuario.ToLower() == pergunta.Value.ToLower())
   {
     Console.WriteLine("\nResposta Correta!\n");
     pontuacao++;
     Thread.Sleep(3000);
     Console.Clear();
   }
   else
   {
     Console.WriteLine($"Incorreto. a resposta correta é: {pergunta.Value}");
     Thread.Sleep(3000);
     Console.Clear();
   }
 }
 Console.WriteLine($"Pontuação final: {pontuacao} de {PerguntasERespostas.Count}");

Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

 Dictionary<string, string> LoginESenha = new();
 void cadastroUser()
 {
   Console.WriteLine("Bem-vindo(a) ao cadastra de usuários!");
   Console.Write("Digite seu usuário: ");
   string user = Console.ReadLine()!;
   Console.Write("Digite uma senha");
   string pass = Console.ReadLine()!;
   login(user,pass);
   Console.WriteLine($"Usuário: {user}\n Password: {pass}");

 }

 void login(string user, string pass)
 {
    if (LoginESenha.ContainsKey(user) || LoginESenha.ContainsKey(pass))
   {
     Console.WriteLine("Erro interno!\n tente novamente!");
     Thread.Sleep(2000);
     Console.Clear();
     cadastroUser();
   }
   else
   {
     LoginESenha.Add(user, pass);
     Console.WriteLine("Usuário Criado com sucesso!");
     Thread.Sleep(2000);
     Console.Clear();
   }
 }


 cadastroUser();


Para manipular elementos na lista em C#, é necessário acessar os elementos usando índices ou chaves, por exemplo. É possível adicionar elementos usando o método Add(), remover elementos usando o método Remove() ou alterar elementos diretamente através do seu índice ou chave. Confira abaixo:


 Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
     { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
     { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
     { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
     { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
     { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
 };

 double mediaDeVendas = vendasCarros["Bugatti Veyron"].Average();
 Console.WriteLine(mediaDeVendas);


 mediaDeVendas = vendasCarros["Koenigsegg Agera RS"].Average();
 Console.WriteLine(mediaDeVendas);

 mediaDeVendas = vendasCarros["Lamborghini Aventador"].Average();
 Console.WriteLine(mediaDeVendas);

 mediaDeVendas = vendasCarros["Pagani Huayra"].Average();
 Console.WriteLine(mediaDeVendas);

 mediaDeVendas = vendasCarros["Ferrari LaFerrari"].Average();
 Console.WriteLine(mediaDeVendas);

 Dictionary<string,int> players = new (){
   {"Roxohq",12},
   {"Melphite",22},
   {"Ghetis",32},
 };

 foreach(var player in players)
 {

   string nomeDoPlayer = player.Key;
   int levelDoPlayer = player.Value;
   Console.Write($"\nNome: {nomeDoPlayer} - Level: {levelDoPlayer}");

 }

 int level = players["Roxohq"];
 Console.WriteLine("\n\nLevel do Roxohq "+level);


