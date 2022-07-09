using Microsoft.Extensions.DependencyInjection;
using InterestCalculator.Services.Implementations;
using InterestCalculator.Services.InternalInterfaces;
using InterestCalculator.Services.PublicInterfaces;

namespace InterestCalculator.Services
{
    public static class ExtensionsIService
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentPlanCalculator, SeriesPlanCalculator>();
            services.AddScoped<IContextProvider, LoanContextProvider>();
            services.AddScoped<ILoanProvider, LoanProvider>();
        }
    }
}
