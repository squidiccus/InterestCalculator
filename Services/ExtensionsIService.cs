using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.InternalInterfaces;
using Services.PublicInterfaces;

namespace Services
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
