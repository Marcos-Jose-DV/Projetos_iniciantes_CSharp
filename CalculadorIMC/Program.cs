using CalculadoEMC.Indece;
namespace CarculadorIMC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Calculado de IMC");
            Console.WriteLine();

            Console.Write("Digite sua Peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua Altura: ");
            double altura = double.Parse(Console.ReadLine());

            Resultado(peso, altura);
        }
        static void Resultado(double peso, double altura)
        {
            var indece = new IndiceIMC();
            double imc = peso / (altura * altura);

            if (imc > 40)
            {
                Console.WriteLine($"Seu IMC = {imc:F2} - {indece.Grau3}");
            }
            else if(imc > 35)
            {
                Console.WriteLine($"Seu IMC = {imc:F2} - {indece.Grau2}");
            }
            else if (imc > 30)
            {
                Console.WriteLine($"Seu IMC = {imc:F2} - {indece.Grau1}");
            }
            else if (imc > 25)
            {
                Console.WriteLine($"Seu IMC = {imc:F2} - {indece.Sobpeso}");
            }
            else if (imc > 18.5)
            {
                Console.WriteLine($"Seu IMC = {imc:F2} - {indece.PesoNormal}");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine($"Seu IMC = {imc:F2} - {indece.AbaixoPeso}");
            }
            Console.ReadKey();
        }
    }
}