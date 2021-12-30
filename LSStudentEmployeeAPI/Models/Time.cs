namespace LSStudentEmployeeAPI.Models
{
    public class Time
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public int user_id { get; set; }
        public int creator_id { get; set; }
        public int position_id { get; set; }
        public int location_id { get; set; }
        public int site_id { get; set; }
        public long shift_id { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string notes { get; set; }
        public double length { get; set; }
        public double hourly_rate { get; set; }
        public int alert_type { get; set; }
        public bool is_approved { get; set; }
        public int modified_by { get; set; }
        public string sync_id { get; set; }
        public string sync_hash { get; set; }
        public string updated_at { get; set; }
        public string created_at { get; set; }
        public string split_time { get; set; }
        public int break_hours { get; set; }
        public bool is_alerted { get; set; }
    }
}
