using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn_Blue_Rangers.Models;

namespace ClinkedIn_Blue_Rangers.Commands
{
    public class AddClinkerCommand
    {
        public string Name { get; set; }
        public Services Service { get; set; }
        public Interests Interest { get; set; }
        public List<Clinker> Friends { get; set; }
        public List<Clinker> Enemies { get; set; }
    }
}
