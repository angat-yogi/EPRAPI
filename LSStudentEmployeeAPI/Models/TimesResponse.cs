using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSStudentEmployeeAPI.Models
{
    public class TimesResponse
    {
        [Key]
        public int TRId { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public List<Time> times { get; set; }
        public List<Shift> shifts { get; set; }
        public List<User> users { get; set; }
        public List<Site> sites { get; set; }

    }
}
