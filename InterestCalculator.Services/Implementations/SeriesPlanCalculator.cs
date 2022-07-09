using InterestCalculator.Domain;
using InterestCalculator.Shared;
using InterestCalculator.Services.InternalInterfaces;

namespace InterestCalculator.Services.Implementations
{
    internal class SeriesPlanCalculator : IPaymentPlanCalculator
    {
        public bool SupportsPaymentPlan(LoanPrinciple principle)
        {
            return principle == LoanPrinciple.Series;
        }
        public IList<PaymentPlan> CalculatePlan(LoanContext context)
        {
            var periods = context.Query.YearsToPayback * context.PeriodsPerYear;
            var periodInterest = context.YearlyInterest/(context.PeriodsPerYear*100);
            var remaining = context.Query.Amount;
            var result = new List<PaymentPlan> { new PaymentPlan(0, 0, 0, remaining,0) };
            var periodRepayment = remaining / periods;
            var totalPaid = 0m;
            for(var i = 0; i < periods; i++)
            {
                var interestToPay = periodInterest * remaining;
                remaining -= periodRepayment;
                totalPaid = interestToPay + periodRepayment + totalPaid;
                result.Add(new PaymentPlan(i + 1, periodRepayment, interestToPay, remaining, totalPaid));
            }
            return result;
        }
    }
}
