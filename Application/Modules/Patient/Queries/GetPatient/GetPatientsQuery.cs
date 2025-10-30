using Application.Modules.Patient.Interfaces;
using MediatR;

namespace Application.Modules.Patient.Queries.GetPatient
{
    public record GetPatientsQuery() : IRequest<List<Domain.Entities.Patient>>;

    public class GetPatientsQueryHandler(IPatientService patientService) : IRequestHandler<GetPatientsQuery, List<Domain.Entities.Patient>>
    {
        public async Task<List<Domain.Entities.Patient>> Handle(GetPatientsQuery request, CancellationToken cancellationToken)
           => await patientService.GetPatientsData(cancellationToken);
    }
}
