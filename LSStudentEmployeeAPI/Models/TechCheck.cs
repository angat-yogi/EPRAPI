using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class TechCheck
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string Sector { get; set; }
        public string Building { get; set; }
        public string Room { get; set; }
        public string Status { get; set; }
    }
}
