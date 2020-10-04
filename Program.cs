using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- Data e hora atual do sistema");
            DateTime horaSistema = DateTime.Now;
            Console.WriteLine($"Data e hora do sistema {horaSistema}");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
