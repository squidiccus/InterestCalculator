using InterestCalculator.Shared;

namespace InterestCalculator.Domain
{
    public class LoanContext
    {
        public LoanContext(decimal yearlyInterest, int periodsPerYear, LoanProperties query)
        {
            YearlyInterest = yearlyInterest;
            Query = query;
            // Defaulting to monthly payments
            if (!new int[] { 1, 4, 12 }.Contains(periodsPerYear)) throw new ArgumentException($"{nameof( periodsPerYear)}:{periodsPerYear}");
            PeriodsPerYear = periodsPerYear;
        }
        public decimal YearlyInterest { get; }
        public int PeriodsPerYear { get; }
        public LoanProperties Query { get;}
    }
}