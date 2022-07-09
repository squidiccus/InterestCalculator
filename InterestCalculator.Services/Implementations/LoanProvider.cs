using InterestCalculator.Shared;
using InterestCalculator.Services.InternalInterfaces;
using InterestCalculator.Services.PublicInterfaces;

namespace InterestCalculator.Services.Implementations
{
    internal class LoanProvider : ILoanProvider
    {
        private readonly IEnumerable<IPaymentPlanCalculator> _paymentCalculators;
        private readonly IContextProvider _contextProvider;

        public LoanProvider(IEnumerable<IPaymentPlanCalculator> paymentCalculators, IContextProvider contextProvider)
        {
            _paymentCalculators = paymentCalculators ?? throw new ArgumentNullException(nameof(paymentCalculators));
            _contextProvider = contextProvider ?? throw new ArgumentNullException(nameof(contextProvider));
        }

        public IList<PaymentPlan> GetPaymentPlan(LoanProperties query)
        {
            var context = _contextProvider.GetContext(query);
            var calculator = GetCalculator(query.Principle);
            var paymentPlan = calculator.CalculatePlan(context);
            return paymentPlan;
        }

        private IPaymentPlanCalculator GetCalculator(LoanPrinciple principle)
        {
            return _paymentCalculators.FirstOrDefault(c => c.SupportsPaymentPlan(principle)) ?? throw new ArgumentOutOfRangeException($"Payment plan not supported:{principle}");
        }
    }
}
