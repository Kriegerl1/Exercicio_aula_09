namespace Jogo_De_Adivinhacao_ConsoleApp
{
    internal class Program
    {
        static int chances;
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de adivinhação | Academia de Programação 2024!\n");

            int[] numeros = new int[10];
            int numeroChutado, numero;
            double pontuacao = 1000;
            numero = 0;


            int dificuldade = valor<int>("Escolha a dificuldade:\n1 - Fácil.\n2 - Médio.\n3 - Difícil.");

            switch (dificuldade)
            {
                case 1:
                    chances = 15;
                    break;

                case 2:
                    chances = 10;
                    break;

                case 3:
                    chances = 5;

                    break;

                default:
                    Console.WriteLine("Escolha uma dificuldade");
                    break;
            }
            Console.Clear();
            Console.WriteLine($"Sua pontuação: {pontuacao}Pts.");
            Console.WriteLine($"Você tem: {chances} chutes.");

            Console.Write("Escolha um numero entre: [ ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numero++;
                Console.Write($"\t\t\t\t O Numero correto é: {numero}");
                if (numero != numeros.Length)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine(" ]");


            Random rdn = new();
            int adivinhar = rdn.Next(numero);
            Console.WriteLine($"Numero sorteado: {adivinhar}");


            numeroChutado = valor<int>("Digite um número: ");

            if (numeroChutado == adivinhar)
            {
                Console.WriteLine("Acertou!");
            }
            else
            {

                //double calculoErro = (numeroChutado - adivinhar) / 2;
                //pontuacao = -calculoErro;
                //chances--;
                //Console.WriteLine($"Você perdeu {calculoErro}");
                Console.WriteLine("Errou!");
            }

        }
        // (numero chutado – numero aleatório) / 2 formula do erro
        static bool continua(string texto)
        {
            Console.WriteLine(texto);

            string A = Console.ReadLine().ToUpper();

            return A == "S";
        }


        static T valor<T>(string texto)
        {

            Console.WriteLine(texto);

            string input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido!");
                return valor<T>(texto);
            }
        }
    }
}
