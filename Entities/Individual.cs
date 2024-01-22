namespace Exercicio.Entities
{
    public class Individual : TaxPayer
    {
        public double HealtExpenditures { get; set; }  

        public Individual()
        {

        }   
        public Individual(string name, double anuallincome, double healtexpenditures) : base (name, anuallincome)
        {
            HealtExpenditures = healtexpenditures;
        }
        public override double Tax()
        {
            if (AnuallIncome < 20000)
            {
                return AnuallIncome * 0.15 - HealtExpenditures * 0.5;
            }
            else
            {
                return AnuallIncome * 0.25 - HealtExpenditures * 0.5;
            }
        }
    }
}