using System.Globalization;
using Exercicio.Entities;

namespace Atividade
{
    class Program
    {
        static void Main (string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payer: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Indidual or company? (i/c) ");
                char letter = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (letter == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anual, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anual, employee));
                } 
            }
            double sum = 0;
            foreach (TaxPayer tax in list)
                {
                    double taxa = tax.Tax();
                    System.Console.WriteLine();
                    System.Console.WriteLine("Taxes Paid: ");
                    System.Console.WriteLine(tax.Name + ": $" + taxa.ToString("F2", CultureInfo.InvariantCulture));
                    System.Console.WriteLine();
                    sum += taxa;   
                }
            System.Console.WriteLine();
            System.Console.WriteLine("Total Taxes: "+ sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}