using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class User
    {
        public int id               {get; set;}
        public int account_id       {get; set;}
        public int login_id         {get; set;}
        public string timezone_id   {get; set;}
        public int created_by       {get; set;}
        public int role             {get; set;}
        public bool is_payroll      {get; set;}
        public int is_trusted       {get; set;}
        public int type             {get; set;}
        public string email         {get; set;}
        public string first_name    {get; set;}
        public string last_name     {get; set;}
        public string phone_number  {get; set;}
        public string employee_code {get; set;}
        public bool activated       {get; set;}
        public bool is_hidden       {get; set;}
        public string uuid          {get; set;}
        public string notes         {get; set;}
        public bool is_private      {get; set;}
        public int hours_preferred  {get; set;}
        public int hours_max        {get; set;}
        public int hourly_rate { get; set; }
    }
}
