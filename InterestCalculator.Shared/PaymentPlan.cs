namespace InterestCalculator.Shared
{
    public class PaymentPlan
    {
        public PaymentPlan(int periodNr, decimal repayment, decimal interest, decimal remaining)
        {
            PeriodNr = periodNr;
            Repayment = repayment;
            Interest = interest;
            Remaining = remaining;
        }

        public int PeriodNr { get; }
        public decimal ToPay => Repayment + Interest;
        public decimal Repayment { get; }
        public decimal Interest { get; }
        public decimal Remaining { get; }
    }
}