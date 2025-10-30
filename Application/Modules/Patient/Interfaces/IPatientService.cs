namespace Application.Modules.Patient.Interfaces
{
    public interface IPatientService
    {
        Task<Domain.Entities.Patient> GetPatientData(int id, CancellationToken cancellation);
        Task<List<Domain.Entities.Patient>> GetPatientsData(CancellationToken cancellationToken);
    }
}
