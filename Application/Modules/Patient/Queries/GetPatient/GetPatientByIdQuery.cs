using Application.Modules.Patient.Interfaces;
using MediatR;

namespace Application.Modules.Patient.Queries.GetPatient
{
    public record GetPatientByIdQuery(int Id) : IRequest<Domain.Entities.Patient>;

    public class GetPatientByIdQueryHandler(IPatientService patientService) : IRequestHandler<GetPatientByIdQuery, Domain.Entities.Patient>
    {
        public async Task<Domain.Entities.Patient> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
            => await patientService.GetPatientData(request.Id, cancellationToken);
    }
}
