using System;
using System.Globalization;

namespace Desafio05082022
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horas * valor;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
