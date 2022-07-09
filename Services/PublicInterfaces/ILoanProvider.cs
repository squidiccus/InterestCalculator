using Shared;

namespace Services.PublicInterfaces
{
    public interface ILoanProvider
    {
        public IList<PaymentPlan> GetPaymentPlan(LoanProperties query);
    }
}
