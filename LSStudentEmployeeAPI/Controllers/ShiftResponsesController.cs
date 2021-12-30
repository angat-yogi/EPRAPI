using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LSStudentEmployeeAPI.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace LSStudentEmployeeAPI.Controllers
{
    [Route("api/shifts")]
    [ApiController]
    public class ShiftResponsesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShiftResponsesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShiftResponses
        //public async Task<IActionResult> GetShifts()
        //{

        //    var client = new HttpClient();
        //    client.BaseAddress = new Uri("https://api.wheniwork.com/2/shifts");
        //    //Add an accept header for JSON format
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    client.DefaultRequestHeaders.Add("W-Token", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJhcHAiOjEsImlhdCI6MTUwOTQ5Mjk5OSwibG9naW4iOiI5OTMyNzU3IiwicGlkIjoiOTkzMjc1NyJ9.Zuw42ZLnHKN45QgJWB6O--4WxGlpfKhbRm-Wur9vl2Y5dyw8nAL5okfzj9N9OniwUVBszyU-QJW79TNl1PC_fbRc72His62wGo4rsLkspy2OqiRUrgMqH7G-axs2NkYhE9MtMeC18u-kIvNX7GZTDk1gb6fXhRP64GGiM21Zt-e2rkx6MY39_Q3hFRZwh7m3-ot0jAVMOmHAF12UlHd4OBkUtSuCigAkVdLsVyK_AD2i1qJ_gKwLJNMtZ0x8OXT_ZeNDtJe8tUPOI4nTNWEVaKFaivS_sn3G0_md_bp10LLjXtAfm8-K7sr5NIDvthOeSvpiYCqPqP7nIerX9ycXGQ");
        //    //List all Users
        //    var response = client.GetStringAsync("users").Result;

        //    if (response !=null)
        //    {

        //        var joke = JsonConvert.DeserializeObject<ShiftResponse>(response);
        //        foreach (var item in joke.Shifts)
        //        {
        //            if (_context.ShiftResponses.Find(item.id)==null)
        //            {

        //                _context.ShiftResponses.Add(item);
        //                _context.SaveChanges();

        //            }
        //        }

        //    }
        //    return await _context.ShiftResponses.ToListAsync();
        //}


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Shift>>> GetShifts()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.wheniwork.com/2/");
            //Add an accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("W-Token", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJhcHAiOjEsImlhdCI6MTUwOTQ5Mjk5OSwibG9naW4iOiI5OTMyNzU3IiwicGlkIjoiOTkzMjc1NyJ9.Zuw42ZLnHKN45QgJWB6O--4WxGlpfKhbRm-Wur9vl2Y5dyw8nAL5okfzj9N9OniwUVBszyU-QJW79TNl1PC_fbRc72His62wGo4rsLkspy2OqiRUrgMqH7G-axs2NkYhE9MtMeC18u-kIvNX7GZTDk1gb6fXhRP64GGiM21Zt-e2rkx6MY39_Q3hFRZwh7m3-ot0jAVMOmHAF12UlHd4OBkUtSuCigAkVdLsVyK_AD2i1qJ_gKwLJNMtZ0x8OXT_ZeNDtJe8tUPOI4nTNWEVaKFaivS_sn3G0_md_bp10LLjXtAfm8-K7sr5NIDvthOeSvpiYCqPqP7nIerX9ycXGQ");
            //List all Users
            var response = client.GetStringAsync("shifts").Result;

            if (response !=null)
            {

                var joke = JsonConvert.DeserializeObject<ShiftResponse>(response);
                foreach (var item in joke.Shifts)
                {
                    if (_context.Shifts.Find(item.id)==null)
                    {

                        _context.Shifts.Add(item);
                        _context.SaveChanges();

                    }
                }
                var a = await _context.Shifts.ToListAsync();
                return a;
            }
            else
            {
                Console.WriteLine("Error");
                return NoContent();
            }
        }



        private bool ShiftResponseExists(int id)
        {
            return _context.ShiftResponses.Any(e => e.Id == id);
        }
    }
}
