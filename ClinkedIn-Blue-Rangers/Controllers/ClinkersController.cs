using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_Blue_Rangers.Commands;
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

        [HttpGet("friends/{id}")]
        public ActionResult<List<Clinker>> GetClinkersFriends(int id)
        {
            var repo = new ClinkerRepository();
            var clinker = repo.GetById(id);
            var clinkerFriends = new List<Clinker>();
            foreach(int friendId in clinker.Friends)
            {
                clinkerFriends.Add(repo.GetById(friendId));
            }
            return clinkerFriends;
        }
   
        [HttpGet("enemies/{id}")]
        public ActionResult<List<Clinker>> GetClinkersEnemies(int id)
        {
            var repo = new ClinkerRepository();
            var clinker = repo.GetById(id);
            var clinkerEnemies = new List<Clinker>();
            foreach(int enemyId in clinker.Enemies)
            {
                clinkerEnemies.Add(repo.GetById(enemyId));
            }
            return clinkerEnemies;
        }

        [HttpGet("interest/{interest}")]
        public ActionResult <List<Clinker>> GetByInterest(int interest)
        {
            var repo = new ClinkerRepository();
            return repo.GetInterest(interest);
        }

        [HttpGet("services/{id}")]
        public IActionResult GetClinkersServices(int id)
        {
            var repo = new ClinkerRepository();

            var clinker = repo.GetById(id);
            return Ok(clinker.Service);
        }
        [HttpGet("sentence/{id}")]
        public ActionResult<int> GetDaysLeftInSentence(int id)
        {
            var repo = new ClinkerRepository();
            var clinker = repo.GetById(id);
            var today = DateTime.Now;
            TimeSpan daysServed = clinker.DateConvicted - today;
            var daysServedAbs = Math.Abs(daysServed.Days);
            var daysLeft = (clinker.DaysSentenced - daysServedAbs);
            return daysLeft;
        }

        [HttpPut("{id}")]
        public void updateClinkerCommand(UpdateClinkerCommand updatedClinkerCommand, Guid)
        {
            var updatedClinker = new Clinker();
            


        }

    }
}
