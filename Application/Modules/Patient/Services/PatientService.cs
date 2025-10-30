using Application.Modules.Patient.Interfaces;

namespace Application.Modules.Patient.Services
{
    public class PatientService(IPatientRepository patientRepository) : IPatientService
    {
        private readonly IPatientRepository _patientRepository = patientRepository;

        public async Task<Domain.Entities.Patient> GetPatientData(int id, CancellationToken cancellation)
        {
            return await _patientRepository.GetPatientById(id, cancellation);
        }
        public async Task<List<Domain.Entities.Patient>> GetPatientsData(CancellationToken cancellationToken)
        {
            return await _patientRepository.GetPatients(cancellationToken);
        }
    }
}
