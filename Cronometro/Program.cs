namespace Cronometro;

public class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("'S' --> 10S = 10 segundos");
        Console.WriteLine("'M' --> 1M = 60 segundos");
        Console.WriteLine("'0' --> sair");
        Console.WriteLine("Quanto tempo deseja conta contar");

        string data = Console.ReadLine().ToLower();
        char tipo = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int mult = 1;
        if (tipo == 'm')
        {
            mult = 60;
        }

        if (time == 0)
        {
            System.Environment.Exit(0);
        }
        Console.Clear();
        Contador(time * mult);
    }
    static void Contador(int time)
    {
        int cont = 0;
        while (cont != time)
        {
            Console.Clear();
            cont++;
            Console.Write(cont);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronometro finalizado");
        Thread.Sleep(2000);
        Menu();
    }
}