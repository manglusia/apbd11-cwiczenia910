namespace CodeFirst.DTOs.Responses;

public class PatientResponse
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public List<PrescriptionResponse> Prescriptions { get; set; } = new();
}