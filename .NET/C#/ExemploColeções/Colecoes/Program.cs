using System;
using Colecoes.Helper;
using System.Collections.Generic;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Trabalhando com arrays Unidimensional
            // int [] arrayInteiros = new int [3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");
            // /*arrayInteiros[4] = 40; //Teste inserção posição fora do tamanho permitido na declaração do Array */
     
            // System.Console.WriteLine($"Percorrendo o Array com o laço FOR: ");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine($"Posição {i} : {arrayInteiros[i]}");
            // }

            // System.Console.WriteLine($"Percorrendo o Array com o laço FOREACH: ");
            // int contador = 0;
            // foreach (var item in arrayInteiros)
            // {
            //     System.Console.WriteLine($"Posição {contador} : {item}"); 
            //     contador++;
            // }

            #endregion

            #region Array Multidimensionais (Matrizes)
            
            // int [,] matriz = new int[4,2]
            // {
            //     {10, 5},
            //     {10, 20},
            //     {50, 100},
            //     {90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }
                 
            #endregion

            #region Algorítimos de Ordenação
            // int [] array = new int[5] {6, 3, 8, 1, 9};
            // OperacoesArray opArray = new OperacoesArray();

            // int valorProcurado = 10;

            /* Convertendo um array de um tipo para outro tipo. Ex.: array[int] para array[string]*/
            //string [] arrayString = opArray.ConverterParaArrayString(array);


            /* Redimensionando um array em tempo de Execução*/
            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
            
            // opArray.Redimensionar(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

            // opArray.ImprimirArray(array);

            /* Encontrando um elemento no array */
            // int valorAchado = opArray.ObterValor(array, valorProcurado);
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor!");
            // } else {
            //     System.Console.WriteLine("Não encontrei o valor!");
            // }

            /* Encontrando o índice de um valor */
            // int indice = opArray.ObterIndice(array, valorProcurado);

            // if(indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é : {1}",valorProcurado, indice);
            // }  
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array!");
            // }
            
            /* Verificando se todos os valores do array são maiores que o valor procurado usando o método TrueForAll da classe Array */
            // bool todosMaiorQue = opArray.TodosMaiorQue(array, valorProcurado);
            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine($"Todos os valores são maiores que: {valorProcurado}");
            // } else {
            //     System.Console.WriteLine($"Existem valores maiores que: {valorProcurado}");
            // }
            

            // /* Consultando se existe ou não um valor específico em um array */
            // bool existe = opArray.Existe(array, valorProcurado);
            // if(existe)
            // {
            //     System.Console.WriteLine($"Encontrei o valor: {valorProcurado}");
            // } else {
            //     System.Console.WriteLine($"Não encontrei o valor: {valorProcurado}");
            // }

            
            //Array original
            // System.Console.WriteLine("Array original: ");
            // opArray.ImprimirArray(array);

            // //Call do Método para fazer a ordenação
            // opArray.OrdenarBubbleSort(ref array);

            // //Mostra os dados após a ordenação
            //System.Console.WriteLine("Array ordenado: ");
            // opArray.ImprimirArray(array);

            //Método Ordenar com chamada para o método Sort da classe Array
            //opArray.Ordenar(ref array);

            //Copiando um Array através da classe Array
            //int [] arrayCopia = new int[10];
            // System.Console.WriteLine("Array Antes da Cópia: ");
            // opArray.ImprimirArray(array);

            // System.Console.WriteLine("Array Depois da Cópia: ");
            // opArray.Copiar(ref array, ref arrayCopia);
            // opArray.ImprimirArray(arrayCopia);

            #endregion

            #region Trabalhando com coleções genéricas

            /* - Declarando e acessando uma lista  */
            // OperacoesLista op = new OperacoesLista();
            // List<string> estados = new List<string> {"SP", "BA", "RJ", "MG"};
            // string[] estadosArray = new string[2] {"SC", "MT"};

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            // op.ImprimirListaString(estados);

            /* Removendo elemento da lista */
            // System.Console.WriteLine("Removendo um item da lista Estados:");
            // estados.Remove("MG");

            /* Adicionando coleções na lista existente */
            //estados.AddRange(estadosArray);

            /* Adicionando elemento por índice */
            //estados.Insert(1, "CE");

            //op.ImprimirListaString(estados);

            /* Trabalhando com Dicionário */
            // Dictionary<string, string> estados = new Dictionary<string, string>();
            // estados.Add("SP", "São Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (KeyValuePair<string, string> estado in estados)
            // {
            //     estados.Remove("BA");
            //     System.Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
            // }
            
            //var teste = estados["SC"]; //Tentando acessar uma chave inexistente
            // string valorProcurado = "SC";
            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // } 
            // else 
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário!");
            // }

            #endregion

            #region Trabalhando com Coleções Específicas
            
            /* Coleção do tipo Fila */
            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");
            
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atedido.");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            /* Coleção do tipo Pilha */
            // Stack<string> pilhaLivros = new Stack<string>();
            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("Bootstrap");
            // pilhaLivros.Push("Java");

            // System.Console.WriteLine($"Livros na pilha: {pilhaLivros.Count}");

            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso.");
            // }
            
            // System.Console.WriteLine($"Livros na pilha: {pilhaLivros.Count}");
            
            #endregion

            #region Obtendo e ordenando valores com LINQ

            int[] numbers = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var minimo = numbers.Min();
            var maximo = numbers.Max();
            var medio = numbers.Average();
            var soma = numbers.Sum();
            var arrayUnico = numbers.Distinct().ToArray();

            var numerosParesMetodo = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            System.Console.WriteLine($"Números pares método: {string.Join(", ", numerosParesMetodo)}");

            System.Console.WriteLine($"Valor Mínimo: {minimo}");
            System.Console.WriteLine($"Valor Máximo: {maximo}");
            System.Console.WriteLine($"Valor Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array Original: {string.Join(", ", numbers)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");
                
            #endregion



        }
    }
}
