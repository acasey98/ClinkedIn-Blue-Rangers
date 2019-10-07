using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn_Blue_Rangers.Commands;
using ClinkedIn_Blue_Rangers.Models;
using ClinkedIn_Blue_Rangers.DataAccess;

namespace ClinkedIn_Blue_Rangers.Controllers
{
    [Route("api/clinkers")]
    [ApiController]
    public class ClinkersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetAllClinkers()
        {
            var repo = new ClinkerRepository();
            return repo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult CreateClinker(AddClinkerCommand newClinkerCommand)
        {
            var newClinker = new Clinker
            {
                Id = Guid.NewGuid(),
                Name = newClinkerCommand.Name,
                Service = newClinkerCommand.Service,
                Interest = newClinkerCommand.Interest,
                Friends = newClinkerCommand.Friends,
                Enemies = newClinkerCommand.Enemies
            };

            var repo = new ClinkerRepository();
            var createdClinker = repo.Add(newClinker);

            return Created($"api/clinkers/{createdClinker.Name}", createdClinker);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
