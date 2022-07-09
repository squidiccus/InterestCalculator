using InterestCalculator.Domain;
using InterestCalculator.Shared;

namespace InterestCalculator.Services.InternalInterfaces
{
    internal interface IPaymentPlanCalculator
    {
        bool SupportsPaymentPlan(LoanPrinciple context);
        IList<PaymentPlan> CalculatePlan(LoanContext context);
    }
}
