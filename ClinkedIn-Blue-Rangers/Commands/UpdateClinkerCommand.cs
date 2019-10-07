using ClinkedIn_Blue_Rangers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_Blue_Rangers.Commands
{
    public class UpdateClinkerCommand
    {
        List<Interests> Interests { get; set; }
        List<Services> Services { get; set; }
        List<Clinker> Enemies { get; set; }
    }
}
