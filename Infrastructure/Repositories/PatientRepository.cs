using Application.Modules.Patient.Interfaces;
using Domain.Entities;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PatientRepository(ApplicationDbContext dbContext) : IPatientRepository
    {
        private readonly DbSet<Patient> _patient = dbContext.Set<Patient>();

        public async Task<Patient> GetPatientById(int id, CancellationToken cancellation)
        {
            var patient = await _patient.FindAsync([id, cancellation], cancellationToken: cancellation);

            return patient;
        }

        public async Task<List<Patient>> GetPatients(CancellationToken cancellationToken)
        {
            return await _patient.AsNoTracking().ToListAsync(cancellationToken);
        }
    }
}
