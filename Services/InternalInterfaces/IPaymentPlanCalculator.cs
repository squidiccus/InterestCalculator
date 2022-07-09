using Domain;
using Shared;

namespace Services.InternalInterfaces
{
    internal interface IPaymentPlanCalculator
    {
        bool SupportsPaymentPlan(LoanPrinciple context);
        IList<PaymentPlan> CalculatePlan(LoanContext context);
    }
}
