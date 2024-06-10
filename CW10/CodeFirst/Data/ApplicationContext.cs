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

        modelBuilder.Entity<Medicament>().HasData(new List<Medicament>
        {
            new Medicament
            {
                Description = "Na wszytsko",
                IdMedicament = 1,
                Name = "Superix",
                Type = "Przeciwbólowy"
            },
            new Medicament
            {
                Description = "Na noge",
                IdMedicament = 2,
                Name = "Nogix",
                Type = "Przeciwzapalny"
            }
        });
        modelBuilder.Entity<Prescription>().HasData(new List<Prescription>
        {
            new Prescription
            {
                Date = DateTime.Parse("2024-05-28"),
                DueDate = DateTime.Parse("2024-05-30"),
                IdDoctor = 1,
                IdPatient = 1,
                IdPrescription = 1,
            },
            new Prescription
            {
                Date = DateTime.Parse("2024-06-28"),
                DueDate = DateTime.Parse("2024-06-30"),
                IdDoctor = 2,
                IdPatient = 2,
                IdPrescription = 2,
            }
        });
        modelBuilder.Entity<PrescriptionMedicament>().HasData(new List<PrescriptionMedicament>
        {
            new PrescriptionMedicament
            {
                Details = "Brac rano i wieczorem",
                Dose = 2,
                IdMedicament = 2,
                IdPrescription = 1,
            },
            new PrescriptionMedicament
            {
                Details = "Kiedykolwiek",
                Dose = 1,
                IdMedicament = 1,
                IdPrescription = 2,
            }
        });

        modelBuilder.Entity<Doctor>().HasData(new List<Doctor>
        {
            new Doctor
            {
                Email = "superDoktorek@gmail.com",
                FirstName = "Doktorek",
                LastName = "Super",
                IdDoctor = 1
            },   
            new Doctor
            {
                Email = "slabyDoktorek@wp.pl",
                FirstName = "Doktorek",
                LastName = "Slaby",
                IdDoctor = 2
            }
        });
        modelBuilder.Entity<Patient>().HasData(new List<Patient>
        {
            new Patient
            {
                BirthDate = DateTime.Parse("26.08.2004"),
                FirstName = "Klaus",
                LastName = "Nowak"
            },
            new Patient
            {
                BirthDate = DateTime.Parse("6-07-2010"),
                FirstName = "Michał",
                LastName = "Truba"
            }
        });
    }
}