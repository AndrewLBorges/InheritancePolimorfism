using System;
using System.Globalization;
using System.Collections.Generic;
using InheritancePolimorfism.Entities;

namespace InheritancePolimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, income, expenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, income, nEmployees));
                }
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");

            double totalTaxes = 0;
            foreach(TaxPayer tp in taxPayers)
            {
                Console.WriteLine($"{tp.Name}: $ {tp.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += tp.Tax();
            }
            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
