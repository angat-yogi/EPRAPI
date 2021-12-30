using LSStudentEmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace LSStudentEmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _context;
        //private readonly IMapper _mapper;
        public UserController(ApplicationDbContext context)
        {
            _context=context;
            //_mapper=mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.wheniwork.com/2/");
            //Add an accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("W-Token", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJhcHAiOjEsImlhdCI6MTUwOTQ5Mjk5OSwibG9naW4iOiI5OTMyNzU3IiwicGlkIjoiOTkzMjc1NyJ9.Zuw42ZLnHKN45QgJWB6O--4WxGlpfKhbRm-Wur9vl2Y5dyw8nAL5okfzj9N9OniwUVBszyU-QJW79TNl1PC_fbRc72His62wGo4rsLkspy2OqiRUrgMqH7G-axs2NkYhE9MtMeC18u-kIvNX7GZTDk1gb6fXhRP64GGiM21Zt-e2rkx6MY39_Q3hFRZwh7m3-ot0jAVMOmHAF12UlHd4OBkUtSuCigAkVdLsVyK_AD2i1qJ_gKwLJNMtZ0x8OXT_ZeNDtJe8tUPOI4nTNWEVaKFaivS_sn3G0_md_bp10LLjXtAfm8-K7sr5NIDvthOeSvpiYCqPqP7nIerX9ycXGQ");
            //List all Users
            var response = client.GetStringAsync("users").Result;

            if (response !=null)
            {

                var joke = JsonConvert.DeserializeObject<WIWResponse>(response);
                foreach (var item in joke.Users)
                {
                    if (_context.Users.Find(item.id)==null)
                    {
                        
                        _context.Users.Add(item);
                        _context.SaveChanges();
                    
                    }
                }
                var a = await _context.Users.ToListAsync();
                return a;
            }
            else
            {
                Console.WriteLine("Error");
                return NoContent();
            }
        }

        //public async GetAll()
        //{
        //    GetUsers()
        //}

        
    //    [HttpGet]
    //    public IEnumerable<string> GetString()
    //    {
    //        return new string[] {
    //    "Api Data 1",
    //    "Api Data 2"
    //};
    //    }

    }
}
