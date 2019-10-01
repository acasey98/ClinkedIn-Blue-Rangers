using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_Blue_Rangers.Models;

namespace ClinkedIn_Blue_Rangers.DataAccess
{
    public class ClinkerRepository
    {
        static List<Clinker> _clinkers = new List<Clinker>
        {
            new Clinker
            {
                Id = Guid.NewGuid(),
                Name = "OJ",
                Service = Services.MakeShiv,
                Interest = Interests.Murder
            },
            new Clinker
            {
                Id = Guid.NewGuid(),
                Name = "Phil Cosby",
                Service = Services.TeachToRead,
                Interest = Interests.IndecentExposure
            },
            new Clinker
            {
                Id = Guid.NewGuid(),
                Name = "Charles Manson",
                Service = Services.FenceContraband,
                Interest = Interests.Fraud
            },
            new Clinker
            {
                Id = Guid.NewGuid(),
                Name = "Daniel 'tekashi69' Hernandez",
                Service = Services.SellsTobacco,
                Interest = Interests.Arson
            }
        };

        public List<Clinker> GetAll()
        {
            return _clinkers;
        }

        public Clinker Add(Clinker newClinker)
        {
            _clinkers.Add(newClinker);

            return newClinker;
        }
    }
}
