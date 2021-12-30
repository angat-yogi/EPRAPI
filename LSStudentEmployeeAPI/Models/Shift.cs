using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class Shift
    {
            public long id       {get; set;} 
            public int account_id {get; set;}
            public int user_id {get; set;}
            public int location_id {get; set;}
            public int position_id {get; set;}
            public int site_id   {get; set;}
            public string start_time  {get; set;}
            public string end_time      {get; set;}
            public int  break_time {get; set;}
            public string color {get; set;}
            public string notes {get; set;}
            public bool alerted {get; set;}
            public string linked_users {get; set;}
            public string shiftchain_key {get; set;}
            public bool published {get; set;}
            public string published_date {get; set;}
            public string notified_at {get; set;}
            public int instances {get; set;}
            public string created_at  {get; set;}
            public string updated_at  {get; set;}
            public int acknowledged   {get; set;}
            public string acknowledged_at {get; set;}
            public int creator_id {get; set;}
            public bool is_open {get; set;}
            public bool actionable {get; set;}
            public int block_id  {get; set;}



    }
}
