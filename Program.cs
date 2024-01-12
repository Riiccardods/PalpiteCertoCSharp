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
                        Console.WriteLine($"VOCE ACERTOU!! O NÚMERO ERA {numero}. VOCÊ ACERTOU EM {tentativas} TENTATIVA(S).");
                        acertou = true;
                    }
                    else if (palpite < numero)
                    {
                        Console.WriteLine($"ERROU!! O NÚMERO É MAIOR. TENTATIVAS RESTANTES: {3 - tentativas}");
                    }
                    else
                    {
                        Console.WriteLine($"ERROU!! O NÚMERO É MENOR. TENTATIVAS RESTANTES: {3 - tentativas}");
                    }
                }
                else
                {
                    Console.WriteLine("POR FAVOR, DIGITE APENAS NÚMEROS ENTRE 1 E 10.");
                }
            }

            if (!acertou)
            {
                Console.WriteLine($"VOCÊ EXCEDEU O NÚMERO MÁXIMO DE TENTATIVAS. O NÚMERO ERA {numero}.");
            }
        }
    }
}
