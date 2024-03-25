using System.Runtime.CompilerServices;

namespace Apoio01ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apoio_01 | Academia de programação 2024!\n");

            obterValor("Escreva");

            estruturaDiamante(entrada);

        }

        static void estruturaDiamante(int tamanhoDoDiamante)
        {
            int espaco = (tamanhoDoDiamante - 1) / 2;  // Pra deixar PAR  e FACILITAR A DIVISÃO
            int quantidadeDeX = 1;


            //Topo
            for (int coluna = 1; espaco > 0; coluna++)
            {

                for (int i = 0; i < espaco; i++)
                    Console.Write(" ");


                for (int i = 0; i < quantidadeDeX; i++)
                    Console.Write("X");

                Console.WriteLine();

                espaco--; //espaco = 3 --> espaco = 2 --> espaco = 1 --> espaco = 0
                quantidadeDeX += 2; //X == 3 --> X == 5 -->  X == 7 --> X == 9
            }

            // Meio
            for (int eixoX = 0; eixoX < tamanhoDoDiamante; eixoX++)
            {
                Console.Write("X");
            }
            Console.Write("\tTamanho do diamante");
            Console.WriteLine("");


            // Base

            //espaco--; //espaco = 3 --> espaco = 2 --> espaco = 1 --> espaco = 0
            //quantidadeDeX += 2; //X == 3 --> X == 5 -->  X == 7 --> X == 9

            for (int coluna = 0; quantidadeDeX > 0; coluna++) // X == 5 
            {

                for (int i = 0; i < espaco + 1; i++) //espaço == 2
                    Console.Write(" ");

                for (int i = 0; i < quantidadeDeX - 2; i++) //X == 5
                    Console.Write("X");

                Console.WriteLine("");

                espaco++; //espaco = 2 --> espaco = 3 -->
                quantidadeDeX -= 2; // X == 5 --> X == 3 --> X == 2 > 1 > 0
            }

            static int obterValor(string texto)
            {
                Console.WriteLine(texto);

                int input = Convert.ToInt32(Console.ReadLine());

                return input;
            }

            //static Dinamico obterValores<Dinamico>(string texto)
            //{
            //    Console.WriteLine(texto);

            //}
        }
    }
}
