declarando uma variável do tipo string vazia e adicionando caracteres nela

string stringVazia = string.empty

adicionando valor a esquerda na string vazia

PadLeft recebe dois argumentos, valor da quantidade de letras que você quer adicionar e a letra que você quer adicionar
string.empty.PadLeft(valor,caractere)

Dicionário

criando um dicionário baseado em chave e valor

declarando
Dictionary<>

tipando
O dicionário recebe 2 argumentos, o primeiro é Tkey(chave) e o segundo é Tvalue(valor)
então no exemplo abaixo eu digo que meu dicionário vai ter
chave do tipo string e valor do tipo lista de inteiros
Dictionary<string, List<int>>

sintaxe:

Dictionary<string, List<int>> nomeDoDicionario = new Dictionary<string, List<int>>();

é possível criar um dicionário dentro de um dicionário.

no exemplo abaixo, o código cria um dicionário para armazenar o nome do aluno e as notas do aluno.

Dictionary<string,List<int>> NotasPorAluno = new Dictionary<string, List<int>>();
NotasPorAluno.Add("Roberto", new List<int>{5,6,7,10});

em seguida o código usa .average() para calcular a média e exibir no console.

List<int> notasRoberto = NotasPorAluno["Roberto"];
double mediaRoberto = notasRoberto.Average();
Console.WriteLine(mediaRoberto);

Para manipular elementos na lista em C#, é necessário acessar os elementos usando índices ou chaves, por exemplo. É possível adicionar elementos usando o método Add(), remover elementos usando o método Remove() ou alterar elementos diretamente através do seu índice ou chave. Confira abaixo:

sintaxe 

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

//declarando variável mediaDeVendas e acessando o elemento bugatti e pegando a média com o método average()
double mediaDeVendas = vendasCarros["Bugatti Veyron"].Average();
Console.WriteLine(mediaDeVendas);

O método Any() é usado para verificar se há pelo menos um elemento na lista 

sintaxe

List<int> valoresDaBanda = bandasRegistradas[nomeDaBanda];

    if (valoresDaBanda.Any())