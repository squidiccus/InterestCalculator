using InterestCalculator.Shared;

namespace InterestCalculator.Domain
{
    public class LoanContext
    {
        public LoanContext(decimal interest, LoanProperties query)
        {
            Interest = interest;
            Query = query;
        }
        public decimal Interest { get; }
        public LoanProperties Query { get;}
    }
}