using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class ShiftLead
    {
        [Key]
        public int SLID { get; set; }
        public string SLName { get; set; }
        public DateTime Date { get; set; }
        public string Block { get; set; }

    }
}
