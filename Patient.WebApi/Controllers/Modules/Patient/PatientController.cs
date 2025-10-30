using Microsoft.AspNetCore.Mvc;
using Application.Modules.Patient.Queries.GetPatient;

namespace Patient.WebApi.Controllers.Modules.Patient
{
    [Route("api/[controller]")]
    public class PatientController : BaseApiController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await Mediator.Send(new GetPatientByIdQuery(id));

            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
            => Ok(await Mediator.Send(new GetPatientsQuery()));
    }
}
