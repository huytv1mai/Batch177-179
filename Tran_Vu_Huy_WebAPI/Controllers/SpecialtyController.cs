using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessTestDMA.DAO;
using DataAccessTestDMA.Repository;
using DataAccessTestDMA.Models;


namespace Tran_Vu_Huy_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private ISpecialtyRepository _repository = new SpecialtyRepository();

        // GET: api/<SpecialtyController>
        [HttpGet]
        public ActionResult<IEnumerable<Specialty>> GetSpecialty() => _repository.GetSpecialties();

        [HttpGet("{id}")]
        public ActionResult<Specialty> GetSpecialtyById(int id)
        {
            var Specialty = _repository.GetSpecialtyById(id);
            if (Specialty == null)
            {
                return NotFound(); 
            }

            return Specialty;
        }

        // POST api/<SpecialtyController>
        [HttpPost]

        public IActionResult PostSpecialty(Specialty p)
        {
            try
            {
                /*var context = new MyDbContext();
                context.Specialty.Add(p);
                context.SaveChanges();*/
                _repository.SaveSpecialty(p);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }

        }

        // PUT api/<SpecialtyController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateSpecialty(int id, Specialty p)
        {
            var temp = _repository.GetSpecialtyById(id);
            if (temp == null)
            {
                return NotFound();
            }
            _repository.UpdateSpecialty(p);
            return NoContent();
        }

        // DELETE api/<SpecialtyController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var temp = _repository.GetSpecialtyById(id);
            if (temp == null)
            {
                return NotFound();
            }
            _repository.DeleteSpecialty(temp);
            return NoContent();
        }
    }
}
