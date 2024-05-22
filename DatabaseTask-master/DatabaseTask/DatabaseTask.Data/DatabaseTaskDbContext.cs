using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<JobTenure> JobTenures { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Loaning> Loanings { get; set; }
        public DbSet<LoanableItem> LoanableItems { get; set; }
    }
}
