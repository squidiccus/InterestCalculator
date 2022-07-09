using Microsoft.AspNetCore.Mvc;
using Shared;
using Services.PublicInterfaces;

namespace Server.Controllers
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
            // Some sort of validation framework could be added here (FluentValidation etc)
            return _provider.GetPaymentPlan(query);
        }
    }
}