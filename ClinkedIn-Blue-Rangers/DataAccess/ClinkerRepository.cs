using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_Blue_Rangers.Models;

namespace ClinkedIn_Blue_Rangers.DataAccess
{
    public class ClinkerRepository
    {
        static List<Clinker> _clinkers = new List<Clinker>();
        public ClinkerRepository()
        {
            Clinker inmateOJ = new Clinker
            {
                Id = 0,
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
            },
                Friends = new List<int>
            {
                1,
                2
            },
                Enemies = new List<int>
            {
                3
            },
                DateConvicted = new DateTime(2010, 10, 06),
                DaysSentenced = 7300
            };
            Clinker inmateBill = new Clinker
            {
                Id = 1,
                Name = "Bill Cosby",
                Service = new List<Services>
            {
                Services.SellsTobacco,
                Services.TeachToRead
            },
                Interest = new List<Interests>
            {
                Interests.Murder,
                Interests.Fraud
            },
                Friends = new List<int>
            {
                0,
                3
            },
                Enemies = new List<int>
            {
                2
            },
                DateConvicted = new DateTime(2015, 08, 04),
                DaysSentenced = 8200
            };
            Clinker inmateCharles = new Clinker
            {
                Id = 2,
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
            },
                Friends = new List<int>
            {
                0
            },
                Enemies = new List<int>
            {
                1,
                3
            },
                DateConvicted = new DateTime(1969, 07, 25),
                DaysSentenced = 900000
            };
            Clinker inmateSnitchBitch = new Clinker
            {
                Id = 3,
                Name = "Daniel 'tekashi69' Hernandez",
                Service = new List<Services>
            {
                Services.SellsTobacco,
                Services.TeachToRead
            },
                Interest = new List<Interests>
            {
                Interests.Arson,
                Interests.UnlicensedSurgeries
            },
                Friends = new List<int>
            {
                1
            },
                Enemies = new List<int>
            {
                0,
                2
            },
                DateConvicted = new DateTime(2018, 11, 02),
                DaysSentenced = 4000
            };
            _clinkers.Add(inmateOJ);
            _clinkers.Add(inmateBill);
            _clinkers.Add(inmateCharles);
            _clinkers.Add(inmateSnitchBitch);
        }
      
        public Clinker GetById(int id)
        {
            var clinker =_clinkers.FirstOrDefault(c => c.Id == id);
            return clinker;

        }

        public List<Clinker> GetAll()
        {
            return _clinkers;
        }

        public List<Clinker> GetInterest(int interest)
        {
                var clinkerWithSameInterest = _clinkers.Where(c => c.Interest.Contains((Interests)interest))
                    .ToList();
                return clinkerWithSameInterest;
        }

        public void UpdateClinker(Clinker updatedClinker, Guid id)
        {
            Clinker clinkerToUpdate = _clinkers.First(clinkers => clinkers.Id == null);
        }
    }

}
