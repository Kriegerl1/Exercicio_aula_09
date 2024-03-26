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


            int[] numerosJaOrdenados = ordenadorDeArray(); //Valor da minha ARRAY; int[] foiMalONome = {-6, -5, -2, 0, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, };

            Console.WriteLine($"\n\nO numero de posições da minha ARRAY é: {numerosJaOrdenados.Length}");

            maiorValor(numerosJaOrdenados);

            menorValor(numerosJaOrdenados);

            calculoDeMedia(numerosJaOrdenados);

            topTresMaioresValores(numerosJaOrdenados);

            valoresNegativos(numerosJaOrdenados);

            removeValor(numerosJaOrdenados);

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

        static void calculoDeMedia(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("O valor da soma total é: ");

            int soma = 0;

            foreach (int numero in numeros)
                soma += numero;

            Console.WriteLine(soma);
            double media = soma / numeros.Length;
            Console.Write("A média dos valores é: ");
            Console.WriteLine(media);
        }

        static void valoresNegativos(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Os valores negativos são: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    //Console.Write($"A posição [{i}] tem o valor:  ");
                    Console.Write($"{numeros[i]} ");
                }
            }

        }

        static void topTresMaioresValores(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("O maior valor do Array é: ");
            for (int j = numeros.Length - 3; j < numeros.Length; j++)
                Console.Write($"{numeros[j]} ");

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
            Console.WriteLine($"O mair valor do Array é: {maiorNumero[15]}");
        }

        static int[] ordenadorDeArray()
        {
            int[] arrayDesordenado = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            Array.Sort(arrayDesordenado);


            Console.Write("Os Itens do array ordenados são: ");

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

        static void removeValor(int[] numeros)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite o valor que deseja remover do Array.\n");
            Console.Write($"Valores disponíveis: \n");

            for (int i = 0; i < numeros.Length; i++)
                Console.Write($"Posição [ {i} ] Valor {numeros[i]}\n");

            int inputRemovedor = obterValor("\nDigite o valor que será removido: ");
            do
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (inputRemovedor == numeros[i])
                    {
                        numeros[i] = -1; 
                        Console.WriteLine();
                        Console.Write("Array atualizado: \n");
                        for (int j = 0; j < numeros.Length; j++)
                        {
                            if (numeros[j] != -1)
                                Console.Write($"Posição [{j}] Valor {numeros[j]}\n");
                            else
                                Console.WriteLine($"O index [{j}] foi removido!");
                        }
                    }
                }
                Console.WriteLine("\n\nPara finalizar a operação aperte ENTER!");
                inputRemovedor = obterValor("\nDigite o valor que será removido: ");
            } while (inputRemovedor != null);


        }

        static int obterValor(string texto)
        {
            Console.WriteLine(texto);

            int input = Convert.ToInt32(Console.ReadLine());

            return input;
        }
    }
}

