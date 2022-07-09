namespace Shared
{
    public class PaymentPlan
    {
        public PaymentPlan(int periodNr, decimal deduction, decimal interest, decimal remaining)
        {
            PeriodNr = periodNr;
            Deduction = deduction;
            Interest = interest;
            Remaining = remaining;
        }

        public int PeriodNr { get; }
        public decimal ToPay => Deduction + Interest;
        public decimal Deduction { get; }
        public decimal Interest { get; }
        public decimal Remaining { get; }
    }
}