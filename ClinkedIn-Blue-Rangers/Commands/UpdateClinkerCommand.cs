using ClinkedIn_Blue_Rangers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_Blue_Rangers.Commands
{
    public class UpdateClinkerCommand
    {
        public List<Interests> Interest { get; set; }
        public List<Services> Service { get; set; }
        public List<int> Friends { get; set; }
        public List<int> Enemies { get; set; }
    }
}
