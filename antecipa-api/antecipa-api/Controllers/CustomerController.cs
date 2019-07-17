using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace antecipaapi.Controllers
{
    [Route("api/[controller]")]
    public class CostumerController : Controller
    {


        // GET api/values/5
        [HttpGet("{id}")]
        public Models.Customer Get(int id)
        {
            return new Models.Customer();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Models.Customer _customer)
        {
        }


    }
}
