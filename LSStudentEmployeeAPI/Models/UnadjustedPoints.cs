using System.ComponentModel.DataAnnotations.Schema;

namespace LSStudentEmployeeAPI.Models
{
    public class UnadjustedPoints
    {
        public int Id { get; set; }
        public int Point { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public Shift ShiftAssigned { get; set; }
        public Time TimeInAndOut { get; set; }
        
    }
}
