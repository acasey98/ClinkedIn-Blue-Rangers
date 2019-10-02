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
        [HttpGet]
        public ActionResult<List<Clinker>> Get()
        {
            var repo = new ClinkerRepository();
            return repo.GetAll();
        }
    /*    [HttpGet("{id}")]
        ActionResult<List<Clinker>> GetClinkersFriends(Guid id)
        {
            var repo = new ClinkerRepository();
            var clinker = repo.GetById(id);
            return clinker.Friends;
        }*/
   
    }
}
