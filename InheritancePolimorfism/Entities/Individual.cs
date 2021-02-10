
namespace InheritancePolimorfism.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpeditures * 0.5;
            } else
            {
                return AnualIncome * 0.25 - HealthExpeditures * 0.5;
            }
        }
    }
}
