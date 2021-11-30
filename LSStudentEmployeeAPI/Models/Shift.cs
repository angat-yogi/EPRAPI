using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        public string start { get; set; }
    
        public string end { get; set; }
        
        public User[] users { get; set; }
        
        
    }
}
