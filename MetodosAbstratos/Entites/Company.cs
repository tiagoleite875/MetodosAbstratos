﻿
namespace MetodosAbstratos.Entites
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployee)
            :base(name,anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }
        public override double Tax()
        {
            if (NumberOfEmployee > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
