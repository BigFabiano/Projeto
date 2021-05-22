using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            NomePrograma();

            MinhaEscolha();

           
        }
        
        static void MinhaEscolha()
        {
            Console.WriteLine("1 - SOMAR [ + ]");
            Console.WriteLine("2 - SUBTRAIR [ - ]");
            Console.WriteLine("3 - MULTIPLICAR [ X ]");
            Console.WriteLine("4 - DIVIDIR [ ÷ ]");
            Console.WriteLine("5 - Exponenciação [ x² ]");
            Console.WriteLine("6 - radiciação [ √ ]");
            Console.WriteLine("7 - Bonus [ ÷ ]");
        }
        static void NomePrograma()
        {
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■ ■ ■ ■  C A L C U L A D O R A  ■ ■ ■ ■");
            Console.WriteLine("■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escolha uma das opções :");
            Console.ResetColor();
        }
        static int EscolhaOpcao(int p)
        
        {
            int n1, n2, soma;
            switch (p)
            {
                case 1:
                Console.Write("Somar");
                Console.Write($"Nº  + ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                break;
            }
        }
    }
}
