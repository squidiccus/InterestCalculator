using Domain;
using ProjectLoanCalculator.Shared;

namespace Services.InternalInterfaces
{
    internal interface IPaymentPlanCalculator
    {
        bool SupportsPaymentPlan(LoanPrinciple context);
        IList<PaymentPlan> CalculatePlan(LoanContext context);
    }
}
