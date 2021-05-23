using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {                   
            NomePrograma();

            MinhaEscolha();

            Operando();

                      
        }
        
        static void MinhaEscolha()
        { 
            //double n1, n2, resultado;
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("1. Adição [+]");
            Console.WriteLine("2. Subtração [-]");
            Console.WriteLine("3. Multiplicação [X]");
            Console.WriteLine("4. Divisão [÷]");
            Console.WriteLine("5. Exponenciação [x²]");
            Console.WriteLine("6. Radiciação [√]");
            Console.WriteLine("7. Bonus [?]");
            Console.WriteLine("----------------------");
                       
            Console.WriteLine("0. Sair");
            Console.WriteLine("----------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Escolha uma das opções : ");
            //int op = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
                 
           
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
        static void Operando()
        {
            double n1, n2, resultado;
            int op = Convert.ToInt32(Console.ReadLine());
            if(op == 1)
            {
                Console.Write ("Digite um valor: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                 Console.Write ("Digite um valor: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                resultado = n1 + n2;
                Console.WriteLine($"A soma de {n1} + {n2} = {resultado}");
            }
        }
    }
}