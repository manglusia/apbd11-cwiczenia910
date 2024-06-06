﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models;

public class PrescriptionMedicament
{
    [Key, Column(Order = 0)]
    public int IdMedicament { get; set; }
        
    [Key, Column(Order = 1)]
    public int IdPrescription { get; set; }
        
    public int Dose { get; set; }
    [MaxLength(100)]
    public string? Details { get; set; }
        
    [ForeignKey(nameof(IdMedicament))]
    public Medicament Medicament { get; set; } = null!;
        
    [ForeignKey(nameof(IdPrescription))]
    public Prescription Prescription { get; set; } = null!;
}