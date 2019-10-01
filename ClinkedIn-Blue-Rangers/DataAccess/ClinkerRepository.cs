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
                Service = Services.MakeShiv,
                Interest = Interests.Murder
            },
            new Clinker
            {
                Name = "Phil Cosby",
                Service = Services.TeachToRead,
                Interest = Interests.IndecentExposure
            },
            new Clinker
            {
                Name = "Charles Manson",
                Service = Services.FenceContraband,
                Interest = Interests.Fraud
            },
        };
    }
}
