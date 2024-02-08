

using EF_CORE_Query_Homework.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EF_CORE_Query_Homework.Contexts;

public class DebtorDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3HBTQMT\SQLEXPRESS01;Initial Catalog=DebtorDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Debtor> Debtors { get; set; }

 }
