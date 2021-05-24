using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {                   
            NomePrograma();

           // MinhaEscolha();

            Operando();

                      
        }
        static void NomePrograma()
        {
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■ ■ ■ ■  C A L C U L A D O R A  ■ ■ ■ ■");
            Console.WriteLine("■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■\n");
            Console.ResetColor();

            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine().ToUpper();
            Console.Clear();
            Console.WriteLine($"SEJA BEM VINDO {nome}");
            
        }

        static void MinhaEscolha()
        { 
                        
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
           
        }
        static void Operando()
        {
            string op ;       
            do
            {
            MinhaEscolha();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Escolha uma das opções : ");
            op = Console.ReadLine().ToUpper();
            Console.ResetColor();
            double n1, n2, resultado = 0;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write ("Entre com um número:    ");
            Console.ResetColor();
             bool numero1 = double.TryParse(Console.ReadLine(), out n1);
             if (!numero1 || n1 < 0 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Caracter Invalido");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write ("Entre com outro número: ");
            Console.ResetColor();
           
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

                case "S":
                case "N":
                break;

                case "0":
                break;

                default:
                Console.WriteLine("opção invalida!!");
                break;
                
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("O resultado da conta: {0} {1} {2} = {3}", n1, op, n2, resultado);
            Console.ResetColor();
            Console.WriteLine();

            }
            }while(op != "S" || op == "N");
        }
    }
}
