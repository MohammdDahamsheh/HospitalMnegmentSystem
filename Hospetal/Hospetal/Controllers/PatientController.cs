using Appleacation.DTO;
using Appleacation.Responses;
using Appleacation.service.comannd.Patient;
using Appleacation.service.query.Patient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospetalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private PatientQueryService patientQueryService;
        private PatientCommandService patientCommandService;

        public PatientController(PatientQueryService patientQueryService, PatientCommandService patientCommandService)
        {
            this.patientQueryService = patientQueryService;
            this.patientCommandService = patientCommandService;
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                var patient =await patientQueryService.GetPatientById(id);
                return Ok(patient);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PatientDTO patientDTO)
        {
            try
            {
                await patientCommandService.addPatient(patientDTO);
                return Ok("Patient added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var patients = await patientQueryService.GetAllPatients();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
