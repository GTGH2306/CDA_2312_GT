using System;
using System.Collections.Generic;

namespace WpfLoan.Models;

public partial class Loan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal CapitalBorrowed { get; set; }

    public int DurationInMonths { get; set; }

    public int PeriodicityInMonths { get; set; }

    public decimal YearlyInterestPercent { get; set; }
}
