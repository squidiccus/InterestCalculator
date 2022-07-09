using Microsoft.AspNetCore.Mvc;
using InterestCalculator.Shared;
using InterestCalculator.Services.PublicInterfaces;

namespace InterestCalculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly ILogger<LoanController> _logger;
        private readonly ILoanProvider _provider;

        public LoanController(ILogger<LoanController> logger, ILoanProvider provider)
        {
            _logger = logger;
            _provider = provider;
        }

        [HttpGet("payment-plan")]
        public IEnumerable<PaymentPlan> GetPaymentPlan([FromQuery] LoanProperties query)
        {
            // Some sort of validation framework could be added here (FluentValidation etc. Could also add this as a global actionfilter)
            return _provider.GetPaymentPlan(query);
        }
    }
}