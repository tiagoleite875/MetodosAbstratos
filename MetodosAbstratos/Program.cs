using MetodosAbstratos.Entites;
using System;
using System.Globalization;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax Payer #"+i+" data:");
                Console.Write("Individual or Company [i/c]? ");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

                if(x == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employee: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name +" $ "+ tax.Tax().ToString("f2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach(TaxPayer tax in list)
            {
                sum = sum + tax.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $"+sum.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}