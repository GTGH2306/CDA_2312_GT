namespace CLDomainePersistance
{
    public struct LoanStruct
    {
        public LoanStruct(string _name, decimal _capitalBorrowed, int _duration, int _periodicity, decimal _interest)
        {
            this.Name = _name;
            this.CapitalBorrowed = _capitalBorrowed;
            this.DurationInMonths = _duration;
            this.PeriodicityInMonths = _periodicity;
            this.YearlyInterestPercent = _interest;
        }

        public string Name { get; set; }

        public decimal CapitalBorrowed { get; set; }

        public int DurationInMonths { get; set; }

        public int PeriodicityInMonths { get; set; }

        public decimal YearlyInterestPercent { get; set; }
    }
}
