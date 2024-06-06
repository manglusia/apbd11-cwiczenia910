namespace CodeFirst.DTOs.Responses;

public class PrescriptionResponse
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public DoctorResponse Doctor { get; set; } = null!;
    public List<MedicamentResponse> Medicaments { get; set; } = new();
}