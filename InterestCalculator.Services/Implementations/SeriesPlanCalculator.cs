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
            var months = context.Query.YearsToPayback * 12;
            var periodInterest = context.Interest/1200;
            var remaining = context.Query.Amount;
            var result = new List<PaymentPlan> { new PaymentPlan(0, 0, 0, remaining,0) };
            var monthlyRepayment = remaining / months;
            var totalPaid = 0m;
            for(var i = 0; i < months; i++)
            {
                var monthlyInterest = periodInterest * remaining;
                remaining -= monthlyRepayment;
                totalPaid = monthlyInterest + monthlyRepayment + totalPaid;
                result.Add(new PaymentPlan(i + 1, monthlyRepayment, monthlyInterest, remaining, totalPaid));
            }
            return result;
        }
    }
}
