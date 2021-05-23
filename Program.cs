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
            Console.WriteLine("[+] . Adição");
            Console.WriteLine("[-] . Subtração");
            Console.WriteLine("[X] . Multiplicação");
            Console.WriteLine("[÷] . Divisão");
            Console.WriteLine("[x²]. Exponenciação");
            Console.WriteLine("[√] . Radiciação");
            Console.WriteLine("[?] . Bonus");
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
            double n1, n2, resultado = 0;
            string op = Console.ReadLine();
            Console.Write ("Digite um valor: ");
            //n1 = Convert.ToDouble(Console.ReadLine());
             bool numero1 = double.TryParse(Console.ReadLine(), out n1);
             if (!numero1 || n1 < 0 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Caracter Invalido");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.Write ("Digite um valor: ");
            //n2 = Convert.ToDouble(Console.ReadLine());
           
            bool numero2 = double.TryParse(Console.ReadLine(), out n2);
            if (!numero2 || n2 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Caracter Invalido");
                Console.ResetColor();
                Environment.Exit(-1);
            }
                          
            else
            {
               
                
            switch(op)
            {
                case "+":
                resultado = n1 + n2;
                break;

                case "-":
                resultado = n1 - n2;
                break;

                case "*":
                resultado = n1 * n2;
                break;

                case "/":
                resultado = n1 / n2;
                break;

                default:
                Console.WriteLine("opção invalida!!");
                break;
                
            }
            
            Console.WriteLine("{0} {1} {2} = {3}", n1, op, n2, resultado);

            }
        }
    }
}