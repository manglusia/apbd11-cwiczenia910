using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data;

public class ApplicationContext : DbContext
{
    protected ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Medicament> Medicaments { get; set; } = null!;
    public DbSet<Prescription> Prescriptions { get; set; } = null!;
    public DbSet<Doctor> Doctors { get; set; } = null!;
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PrescriptionMedicament>().HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });
        
        modelBuilder.Entity<Medicament>().ToTable("Medicaments");
        modelBuilder.Entity<Prescription>().ToTable("Prescriptions");
        modelBuilder.Entity<PrescriptionMedicament>().ToTable("PrescriptionMedicaments");
        modelBuilder.Entity<Doctor>().ToTable("Doctors");
        modelBuilder.Entity<Patient>().ToTable("Patients");

    }
}