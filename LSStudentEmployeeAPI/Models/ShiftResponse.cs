using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSStudentEmployeeAPI.Models
{
    public class ShiftResponse
    {

        [Key]
        public int Id { get; set; }
        public string start { get; set; }

        public string end { get; set; }

        public User[] users { get; set; }

        public Shift[] Shifts { get; set; }
    }
}
