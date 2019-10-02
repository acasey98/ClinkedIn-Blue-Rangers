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
                Name = "OJ",
                Service = new List<Services>
                {
                    Services.MakeShiv,
                    Services.FenceContraband
                },
                Interest = new List<Interests>
                {
                    Interests.Arson,
                    Interests.IndecentExposure
                }
            },
            new Clinker
            {
                Name = "Phil Cosby",
                Service = new List<Services>
                {
                    Services.SellsTobacco,
                    Services.TeachToRead
                },
                Interest = new List<Interests>
                {
                    Interests.Murder,
                    Interests.Fraud
                }
            },
            new Clinker
            {
                Name = "Charles Manson",
                Service = new List<Services>
                {
                    Services.FenceContraband,
                    Services.MakeShiv
                },
                Interest = new List<Interests>
                {
                    Interests.UnlicensedSurgeries,
                    Interests.Larceny
                }
            },
            new Clinker
            {
                Name = "Daniel 'tekashi69' Hernandez",
                Service = new List<Services>
                {
                    Services.SellsTobacco
                },
                Interest = new List<Interests>
                {
                    Interests.Arson
                }
            },
        };

        public List<Clinker> GetAll()
        {
            return _clinkers;
        }

        public List<Clinker> GetInterest(string interest)
        {
                var clinkerWithSameInterest = _clinkers.Where(c => c.Interest.ToString() == interest)
                    .ToList();
                return clinkerWithSameInterest;
        }
    }
}
