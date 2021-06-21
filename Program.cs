using System;
using Figgle;
namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcaoUsuario = "";
            do
            {
                Console.Clear();
                Console.Beep();
                Console.Title = "Calculadora - Versão 1.0";
                string banner = FiggleFonts.Ogre.Render("Calculadora");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(banner);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("╔═══════════════════ MENU DE OPÇÃO ═══════════════════╗");
                Console.WriteLine("║ 1.ADIÇÃO                           5.EXPONENCIAÇÃO  ║");
                Console.WriteLine("║ 2.SUBTRAÇÃO                        6.RADICIAÇÃO     ║");
                Console.WriteLine("║ 3.MULTIPLICAÇÃO                    7.BÔNUS          ║");
                Console.WriteLine("║ 4.DIVISÃO                          8.SOBRE          ║");
                Console.WriteLine("║                                    0.SAIR           ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Escolha uma opção.: ");
                Console.ForegroundColor = ConsoleColor.Green;
                opcaoUsuario = Console.ReadLine();
                Console.ResetColor();

                if (opcaoUsuario == "1")
                {
                    Adicao();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "2")
                {
                    Subtracao();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "3")
                {
                    Multiplicacao();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "4")
                {
                    Divisao();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "5")
                {
                    Potencia();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "6")
                {
                    RaizQuadrada();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "7")
                {
                    Bonus();
                    Console.ReadKey();
                }

                if (opcaoUsuario == "8")
                {
                    Sobre();
                    Console.ReadKey();
                }


            } while (opcaoUsuario != "0");

            Console.Write("OBRIGADO POR USAR O PROGRAMA");

        }
        static void Adicao()
        {

            double n1, n2, resultado;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com um número....: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com outro número.: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            resultado = n1 + n2;


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"O Resultado de {n1} + {n2} = {resultado}\n");
            Console.ResetColor();

        }
        static void Subtracao()
        {
            double n1, n2, resultado;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com um número....: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com outro número.: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            resultado = n1 - n2;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"O Resultado de {n1} - {n2} = {resultado}\n");
            Console.ResetColor();
        }
        static void Multiplicacao()
        {
            double n1, n2, resultado;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com um número....: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com outro número.: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            resultado = n1 * n2;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"O Resultado de {n1} * {n2} = {resultado}\n");
            Console.ResetColor();
        }

        static void Divisao()
        {
            double n1, n2, resultado;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com um número....: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com outro número.: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            if (n2 != 0)
            {
                resultado = n1 / n2;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write($"O Resultado de {n1} / {n2} = {resultado}\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Impossivel dividir por {n2}, digite um número valido.");
                Console.ResetColor();
            }


        }
        static void Potencia()
        {
            double n1, n2, resultado;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Entre com um número....: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"O nº {n1} elevado a.: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            if (n1 != 0 && n2 != 0)
            {
                resultado = Math.Pow(n1, n2);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write($"O Resultado de {n1} ^ {n2} = {resultado}\n");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número invalido!");
                Console.ResetColor();
            }


        }
        static void RaizQuadrada()
        {
            double n1, raiz;
            n1 = -1;

            while (n1 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("Entre com um número positivo .: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();
                if (n1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor Invalido!");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            raiz = Math.Sqrt(n1);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"A raiz quadrada de {n1} é = {raiz}\n");
            Console.ResetColor();
        }
        static void Sobre()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("╔══════════════ Projeto Final C Sharp - Calculadora V 1.0 ════════════════╗");
            Console.ResetColor();
            Console.WriteLine("║ Projeto final ETEC 1º Semestre. Calculadora Versão 1.0 - 20/06/2021     ║");
            Console.WriteLine("║ onde sera aplicado todo conhecimento estudado até o momento. Calculo    ║");
            Console.WriteLine("║ das quatro operações aritméticas básicas juntamente com mais um bonus   ║");
            Console.WriteLine("║ soma, subtração, multiplicação, divisão, exponenciação, radiciação e ?  ║");
            Console.WriteLine("║      Todos direitos reservados a Fabiano Nascimento de Souza ®          ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");

        }
        static void Bonus()
        {

            decimal luz, condominio, agua, internet, compra, gasolina, outrosGastos, total;

            Console.Write("Entre com o mês desejado: ");
            string mes = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gastos referente ao mês de {mes}");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Valor da Luz R$ ");
            luz = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Valor do condominio R$ ");
            condominio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Valor da água R$ ");
            agua = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Valor da Internet R$ ");
            internet = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Valor das compras R$ ");
            compra = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Gasto com gasolina R$ ");
            gasolina = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Outros gastos R$ ");
            outrosGastos = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            total = luz + condominio + agua + internet + compra + gasolina + outrosGastos;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine($"Seus gastos no mês de {mes} foi de {total:C}");
            Console.ResetColor();

        }
    }


}