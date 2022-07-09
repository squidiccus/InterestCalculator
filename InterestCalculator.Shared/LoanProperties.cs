using System.ComponentModel.DataAnnotations;

namespace InterestCalculator.Shared
{
    public enum LoanPrinciple
    {
        Series = 0,
        Annuity = 1
    }
    public enum LoanType
    {
        House = 0,
        Car = 1,
    }
    public class LoanProperties
    {
        [Required]
        [Range(0.25,100)]
        public decimal YearsToPayback { get; set; }
        [Required]
        [Range(1, double.MaxValue)]
        public decimal Amount { get; set; }
        public LoanPrinciple Principle { get; set; } = LoanPrinciple.Series;
        public LoanType LoanType { get; set; } = LoanType.House;
    }    
}
