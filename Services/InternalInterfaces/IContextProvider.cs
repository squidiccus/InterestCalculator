using Domain;
using ProjectLoanCalculator.Shared;

namespace Services.InternalInterfaces
{
    internal interface IContextProvider
    {
        /// <summary>
        /// Returning a context instead of just the percentage to make it easier to refactor if we need more parameters
        /// </summary>
        public LoanContext GetContext(LoanProperties props);
    }
}
