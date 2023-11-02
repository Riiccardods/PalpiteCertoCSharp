namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool acertou = false;
            int tentativas = 0;

            Console.WriteLine("BEM VINDO AO JOGO ADIVINHE UM NUMERO");
            Console.WriteLine("");

            Random random = new Random();
            int numero = random.Next(1, 10);

            while (!acertou && tentativas < 3)
            {
                Console.Write("DIGITE UM NUMERO ENTRE 1 E 10: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int palpite) && palpite >= 1 && palpite <= 10)
                {
                    tentativas++;

                    if (numero == palpite)
                    {
                        Console.WriteLine($"VOCE ACERTOU!! O número era {numero}. Você acertou em {tentativas} tentativa(s).");
                        acertou = true;
                    }
                    else if (palpite < numero)
                    {
                        Console.WriteLine($"ERROU!! O número é maior. Tentativas restantes: {3 - tentativas}");
                    }
                    else
                    {
                        Console.WriteLine($"ERROU!! O número é menor. Tentativas restantes: {3 - tentativas}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite apenas números entre 1 e 10.");
                }
            }

            if (!acertou)
            {
                Console.WriteLine($"Você excedeu o número máximo de tentativas. O número era {numero}.");
            }
        }
    }
}
