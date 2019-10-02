using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_Blue_Rangers.DataAccess;
using ClinkedIn_Blue_Rangers.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn_Blue_Rangers.Controllers
{
    [Route("api/clinkers")]
    [ApiController]
    public class ClinkersController : ControllerBase
    {
        [HttpGet("{interest}")]
        public ActionResult <List<Clinker>> GetByInterest(int interest)
        {
            var repo = new ClinkerRepository();
            return repo.GetInterest(interest);
        }

        [HttpGet("{id}")]
        public IActionResult GetClinkersServices(Guid id)
        {
            var repo = new ClinkerRepository();

            var clinker = repo.GetById(id);
            return Ok(clinker.Service);
        }

    }
}
