namespace InterestCalculator.Shared
{
    public class PaymentPlan
    {
        public PaymentPlan(int periodNr, decimal repayment, decimal interest, decimal remaining, decimal totalPaid)
        {
            PeriodNr = periodNr;
            Repayment = repayment;
            Interest = interest;
            Remaining = remaining;
            TotalPaid = totalPaid;
        }

        public int PeriodNr { get; }
        public decimal ToPay => Repayment + Interest;
        public decimal Repayment { get; }
        public decimal Interest { get; }
        public decimal Remaining { get; }
        public decimal TotalPaid { get; }
    }
}