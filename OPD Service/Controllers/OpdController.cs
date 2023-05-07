using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OPD_Service.Models;
using OPD_Service.Services;

namespace OPD_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpdController : ControllerBase
    {
        private readonly IOpdService _opdService;

        public OpdController(IOpdService opdService)
        {
            _opdService = opdService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Treatment>> GetTreatmentList()
        {
            return Ok(_opdService.GetTreatmentList());
        }

        [HttpGet("{id}")]
        public ActionResult<Treatment> GetTreatmentById(int id)
        {
            Treatment treatment = _opdService.GetTreatmentById(id);
            if (treatment == null)
            {
                return NotFound();
            }
            return Ok(treatment);
        }

        [HttpPost]
        public ActionResult CreateTreatment(Treatment treatment)
        {
            _opdService.CreateTreatment(treatment);
            return CreatedAtAction(nameof(GetTreatmentById), new { id = treatment.Id }, treatment);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTreatment(int id, Treatment treatment)
        {
            if (id != treatment.Id)
            {
                return BadRequest();
            }
            _opdService.UpdateTreatment(treatment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTreatment(int id)
        {
            _opdService.DeleteTreatment(id);
            return NoContent();
        }
    }
}
