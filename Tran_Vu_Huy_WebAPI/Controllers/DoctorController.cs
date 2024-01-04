using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessTestDMA.DAO;
using DataAccessTestDMA.Repository;
using DataAccessTestDMA.Models;


namespace Tran_Vu_Huy_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private IDoctorRepository _repository = new DoctorRepository();

        // GET: api/<DoctorController>
        [HttpGet]
        public ActionResult<IEnumerable<Doctor>> GetDoctor() => _repository.GetDoctors();

        [HttpGet("{id}")]
        public ActionResult<Doctor> GetDoctorById(int id)
        {
            var Doctor = _repository.GetDoctorById(id);
            if (Doctor == null)
            {
                return NotFound(); 
            }

            return Doctor;
        }

        // POST api/<DoctorController>
        [HttpPost]

        public IActionResult PostDoctor([FromBody] Doctor p)
        {
            try
            {
           
                _repository.SaveDoctor(p);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }

        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, Doctor p)
        {
            var temp = _repository.GetDoctorById(id);
            if (temp == null)
            {
                return NotFound();
            }
            _repository.UpdateDoctor(p);
            return NoContent();
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var temp = _repository.GetDoctorById(id);
            if (temp == null)
            {
                return NotFound();
            }
            _repository.DeleteDoctor(temp);
            return NoContent();
        }
    }
}
