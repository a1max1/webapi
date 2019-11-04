using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using justapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace justapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailValidateController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EmailValidateController> _logger;

        public EmailValidateController(ILogger<EmailValidateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
    //    public IEnumerable<EmailValidate> Get()
  //      {
//            var rng = new Random();
           // return Enumerable.Range(1, 5).Select(index => new EmailValidate
           // {
             //   Date = DateTime.Now.AddDays(index),
               // TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
           // })
            //.ToArray();
      //  }

public ActionResult Get()
{
    return Ok("email good");
}


        [HttpPost]
       // public ActionResult Post([FromBody] string value)
       public ActionResult Post()
        {
            //do some testing on email address
            return Ok("email good");
        }


    }
}
