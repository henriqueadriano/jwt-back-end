using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ISession _session;

        public ValuesController(ISession session)
        {
            _session = session;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("mytest")]
        public ActionResult MyTest()
        {
            var consoles = _session.QueryOver<model.Console>().List();

            /*ICollection<FoodItem> foodItems = _foodRepository.GetRandomMeal();

            IEnumerable<FoodItemDto> dtos = foodItems
                .Select(x => Mapper.Map<FoodItemDto>(x));

            var links = new List<LinkDto>();

            // self 
            links.Add(new LinkDto(_urlHelper.Link(nameof(GetRandomMeal), null), "self", "GET"));
            */
            return Ok(new
            {
                value = consoles,
                //links = links
            });
        }
    }
}
