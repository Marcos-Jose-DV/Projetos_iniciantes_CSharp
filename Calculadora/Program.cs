using System.ComponentModel.Design;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Para sair - 0");
            Console.WriteLine("Para somar - 1");
            Console.WriteLine("Para Subtrair - 2");
            Console.WriteLine("Para Multiplicar - 3");
            Console.WriteLine("Para dividir - 4");

            int opercao = int.Parse(Console.ReadLine());
            Operecao(opercao);
        }
        static void Operecao(int operecao)
        {
            if (operecao >= 0 && operecao <= 4)
            {
                switch (operecao)
                {
                    case 1: Somar(); break;
                    case 2: Sub(); break;
                    case 3: Mult(); break;
                    case 4: Div(); break;
                    case 0: Console.ReadKey(); break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Operação invalida");
                Menu();
            }
        }
        static void Somar()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Resultado(num1 + num2);
        }

        static void Sub()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Resultado(num1 - num2);
        }

        static void Mult()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Resultado(num1 * num2);
        }

        static void Div()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Resultado(num1 / num2);
        }
        static void Resultado(double res)
        {
            Console.WriteLine($"Resultado = {res}");
            Menu();
            Console.WriteLine();
        }


    }
}