namespace Exercicio.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }   
        public Company(string name, double anuallincome, int numberofemployees) : base (name, anuallincome)
        {
            NumberOfEmployees = numberofemployees;
        }
        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return AnuallIncome * 0.14;
            }
            else
            {
                return AnuallIncome * 0.16;
            }
        }
        
    }
}