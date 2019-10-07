using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_Blue_Rangers.Models
{
    public class Clinker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Services> Service { get; set; }
        public List<Interests> Interest { get; set; }
        public List<int> Friends { get; set; }
        public List<int> Enemies { get; set; }
        public DateTime DateConvicted { get; set; }
        public int DaysSentenced { get; set; }
    }

    public enum Services
    {
        SellsTobacco,
        FenceContraband,
        MakeShiv,
        TeachToRead
    }

    public enum Interests
    {
        Murder,
        IndecentExposure,
        Fraud,
        UnlicensedSurgeries,
        Larceny,
        Arson
    }
}