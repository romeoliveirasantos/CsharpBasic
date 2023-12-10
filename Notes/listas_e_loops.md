//interpolação de string sintaxe 
$(onde terá variável usar {})

console.clear(); - limpa o console
Thread.Sleep(segundos); essa função é um timeout, e basea-se em milesegundos.


criando uma lista e instanciando

cria a lista e define o tipo.
*List<string>*

Define nome da lista
*nomes* 

instancia uma nova lista
*= new List<string>();*

outra opção de sintaxe para lista é:
List<string> nomeDaLista = new (){};

para adicionar elementos para a lista utiliza-se
add
nomeDaLista.add("elemento");

O for e o foreach são dois tipos de laços de repetição em C# que podem ser utilizados para percorrer e manipular coleções de elementos, tais como arrays (listas por exemplo), como ilustra o código acima. Sabendo disso, analise as informações abaixo e selecione apenas aquela onde a saída no console usa a estrutura for será igual ao foreach.

Estrutura de um looping *For*
sintaxe:
1 - iniciando o for e declarando o i como 0
2 - condicional enquanto i for menor que o tamanho da lista (usando o .count para identificar o tamanho da lista)
3 - incremento no i
for(int i = 0, i < nomeDaLista.count; i++)
{

}

Estrutura de um looping *Foreach*
sintaxe:

1 - declarando foreach com o nome do elemento 
2 - usando a palavra reservada IN para definir qual lista
3 - indicando o nome da lista no qual o foreach deve percorrer

foreach (elemento in nomeDaLista)
{
  //exibe o elemento na posição do seu indice
  console.writeline(nomeDaLista[i])
}

Qual usar? for ou foreach?
Geralmente, é recomendado utilizar o foreach quando se deseja apenas iterar sobre os elementos de uma coleção, sem a necessidade de acessar um índice numérico específico. Isso torna o código mais legível e menos propenso a erros, além de ser mais simples de implementar.

Já o for é recomendado quando é necessário acessar elementos em posições específicas da coleção ou quando se deseja iterar utilizando um índice numérico específico.


