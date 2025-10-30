namespace Application.Modules.Patient.Interfaces
{
    public interface IPatientRepository
    {
        Task<Domain.Entities.Patient> GetPatientById(int id, CancellationToken cancellation);
        Task<List<Domain.Entities.Patient>> GetPatients(CancellationToken cancellationToken);
    }
}
