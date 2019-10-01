using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_Blue_Rangers.Models
{
    public class Clinker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Clinker> Friends { get; set; }
        public List<Clinker> Enemies { get; set; }
    }

    public enum Service
    {
        SellsTobacco,
        FenceContraband,
        MakeShiv,
        TeachToRead
    }

    public enum Interest
    {
        Murder,
        IndecentExposure,
        Fraud,
        UnlicensedSurgeries,
        Larceny,
        Arson
    }
}