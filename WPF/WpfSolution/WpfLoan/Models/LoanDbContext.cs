using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfLoan.Models;

public partial class LoanDbContext : DbContext
{
    public LoanDbContext()
    {
    }

    public LoanDbContext(DbContextOptions<LoanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Loan> Loans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=LoanDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loan>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CapitalBorrowed)
                .HasColumnType("money")
                .HasColumnName("capital_borrowed");
            entity.Property(e => e.DurationInMonths).HasColumnName("duration_in_months");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PeriodicityInMonths).HasColumnName("periodicity_in_months");
            entity.Property(e => e.YearlyInterestPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("yearly_interest_percent");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
