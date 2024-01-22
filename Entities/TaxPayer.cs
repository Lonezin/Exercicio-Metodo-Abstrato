namespace Exercicio.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnuallIncome { get; set; }

        public TaxPayer()
        {
        }
        public TaxPayer(string name, double anuallincome)
        {
            Name = name;
            AnuallIncome = anuallincome;
        }
        public abstract double Tax();
    }
}