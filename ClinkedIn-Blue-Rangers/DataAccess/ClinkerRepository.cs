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
                Id = Guid.NewGuid(),
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
                Id = Guid.NewGuid(),
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
                Id = Guid.NewGuid(),
                Name = "Daniel 'tekashi69' Hernandez",
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

        public List<Clinker> GetInterest(string interest)
        {
                var clinkerWithSameInterest = _clinkers.Where(c => c.Interest.ToString() == interest)
                    .ToList();
                return clinkerWithSameInterest;

        }
    }
}
