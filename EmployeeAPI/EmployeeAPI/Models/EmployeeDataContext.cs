using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Models;

public partial class EmployeeDataContext : DbContext
{
    public EmployeeDataContext()
    {
    }

    public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;User ID=sa;Password=Passw0rd@2024;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Initial Catalog=EmployeeData");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Employees_pk");

            entity.Property(e => e.Firstname).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
