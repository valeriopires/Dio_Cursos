using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int [] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int [] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int [] array)
        {
            Array.Sort(array);
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        public void Copiar(ref int [] arrayOrigem, ref int [] arrayDestino)
        {
            Array.Copy(arrayOrigem, arrayDestino, arrayOrigem.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, x => x == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, x => x > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, x => x == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            //return Array.FindIndex(array, x => x == valor);
            return Array.IndexOf(array, valor);
        }

        public void Redimensionar(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, x => x.ToString());
        }


    }
}