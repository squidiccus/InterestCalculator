using InterestCalculator.Shared;

namespace InterestCalculator.Services.PublicInterfaces
{
    public interface ILoanProvider
    {
        public IList<PaymentPlan> GetPaymentPlan(LoanProperties query);
    }
}
