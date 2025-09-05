namespace CalculatorApp.Models
{
    public static class Repository
    {
        private static List<Calc> calculators = new List<Calc>();
        public static IEnumerable<Calc> Calculators
        {
            get { return calculators; }
        }

        public static void AddCalculator(Calc calc)
        {
            calculators.Add(calc);
        }
    }
}
