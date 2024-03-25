using System.Drawing;

namespace Atividade_aula_09_ConsoleApp
{
    #region Requisitos

    //    Atividade sobre Arrays, Funções
    //e Programação Estruturada

    //Desenvolver um programa que receba 10 valores inteiros,

    //-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6   <-- OK

    //Permita: 

    //Encontrar o Maior Valor da sequência <-- OK
    //Encontrar o Menor Valor da sequência <-- OK
    //Encontrar o Valor Médio da sequência <-- OK
    //Encontrar os 3 maiores valores da sequência <-- OK
    //Encontrar os valores negativos da sequência <-- OK
    //Mostrar na Tela os valores da sequência <-- OK
    //Remover um item da sequência <-- 

    //Critérios de Aceite da Atividade: 

    //Deve utilizar arrays
    //Deve utilizar funções
    //Pode utilizar a classe “Array” do Framework
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios arrays ala 09 | Academia de Programação 2024!\n");


            int[] numerosJaOrdenados = ordenadorDeArray(); //Valor da minha ARRAY; int[] meuPau = {-6, -5, -2, 0, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, };

            Console.WriteLine($"O numero de posições da minha ARRAY é: {numerosJaOrdenados.Length}");

            menorValor(ordenadorDeArray());

            topTresMaioresValores(ordenadorDeArray());

            valoresNegativos(numerosJaOrdenados);

            calculoDeMedia(numerosJaOrdenados);

            //removeValor(ref numeros);

            maiorValor(numerosJaOrdenados);

            //    int[] numerosAula = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    Console.Write("Tamanho do meu array: ");
            //    Console.WriteLine(numerosAula.Length);
            //    Console.Write("Valores do meu Array: ");
            //    Console.WriteLine($" O numero da minha INDEX ZERO É:    {numerosAula[0]}");
            //    Console.WriteLine("Meu array contem os valores: ");
            //    for (int posicao = 5    ;     posicao <= numerosAula.Length    ;     posicao++)
            //    {
            //        Console.WriteLine($"Posição [{posicao}] Valor = {numerosAula[posicao]}");
            //    }

        }


        static void removeValor(ref int[] numeros)
        {
            int[] numerosCopy = { };
            Array.Copy(numeros, numerosCopy, numeros.Length);
            Console.WriteLine(numerosCopy.ToString());
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"O Array copiado é: {numeros[i].ToString()}\nO copia do array: {numerosCopy[i].ToString()}\n\n");
            }
        }
        static void calculoDeMedia(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("O valor da soma total é: ");

            int soma = 0;

            foreach (int numero in numeros)
            {
                soma += numero;
            }

            Console.WriteLine(soma);
            double media = soma / numeros.Length;
            Console.Write("A média dos valores é: ");
            Console.WriteLine(media);
        }

        static void valoresNegativos(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Os valores negativos são: \n");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.Write($"A posição [{i}] tem o valor:  ");
                    Console.Write($"{numeros[i]}, \n");
                }
            }

        }

        static void topTresMaioresValores(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("O maior valor do Array é: \n");
            for (int j = numeros.Length - 3; j < numeros.Length; j++)
            {
                Console.Write($"{numeros[j]}\n");
            }

        }

        static void menorValor(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"O menor valor do Array é: {numeros[0]}");
        }

        static void maiorValor(int[] maiorNumero)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"O mair valor do Array é: {maiorNumero[17]}");
        }

        static int[] ordenadorDeArray()
        {
            int[] arrayDesordenado = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2,-20, 6, 7, 8, 0,999, -6 };

            Array.Sort(arrayDesordenado);


            Console.Write("Os Itens do array ordenados são: \n");

            for (int i = 0; i < arrayDesordenado.Length; i++)
            {
                if (arrayDesordenado[i] != arrayDesordenado.Length)
                {
                    //Console.Write($"Posição [{i}], valor[");
                    Console.Write($"{arrayDesordenado[i]}, ");

                }
                else
                {
                    Console.Write($"{arrayDesordenado[i]}");
                }
            }

            return arrayDesordenado;

        }
    }
}

//Está bagunçado por que estou explicando o conteúdo