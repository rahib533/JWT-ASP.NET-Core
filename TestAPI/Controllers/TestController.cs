using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new string[]
            {
                "Rahib", "Rahib2", "Rahib3", "Rahib4"
            };
            return Ok(data);
        }

        Random rnd;
        List<int> arry;

        [HttpPost("a")]
        public IActionResult Get(int a)
        {
            if (arry == null)
            {
                arry = new List<int>();
            }
            else
            {
                arry.Clear();
            }
            if (rnd is null)
            {
                rnd = new Random();
            }
            if (a>=3)
            {
                for (int i = 0; i < a; i++)
                {
                    int b = rnd.Next(0, 100);
                    arry.Add(b);
                }
                return Ok(arry);
            }
            return BadRequest("3 den boyuk olmalidir.");  
        }
    }
}
