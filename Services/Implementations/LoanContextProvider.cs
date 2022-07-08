using Domain;
using ProjectLoanCalculator.Shared;
using Services.InternalInterfaces;

namespace Services.Implementations
{
    internal class LoanContextProvider : IContextProvider
    {
        /// <summary>
        /// To add car loans etc, simply add another prop in the enum, then add it to switch.
        /// </summary>
        /// <param name="props"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public LoanContext GetContext(LoanProperties props){
            // Could make this method async and fetch percentage from an external source (database) if we had one
            return props.LoanType switch
            {
                LoanType.House => new LoanContext(3.5m, props),
                LoanType.Car => new LoanContext(2.5m, props),
                _ => throw new ArgumentException($"{nameof(props.LoanType)}:{props.LoanType}")
            };
        }
    }
}
