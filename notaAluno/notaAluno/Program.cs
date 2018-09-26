using System;
using System.Globalization;
namespace nota_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, soma;
            string[] vet = Console.ReadLine().Split(' ');
            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            soma = N1 + N2 + N3;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            if (soma < 60.0)
            {
                Console.WriteLine("DEPENDENCIA");
            }
            Console.ReadLine();
        }
    }
}