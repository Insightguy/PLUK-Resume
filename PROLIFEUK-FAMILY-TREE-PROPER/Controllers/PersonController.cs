using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROLIFEUK_FAMILY_TREE_PROPER.Functionality;
using PROLIFEUK_FAMILY_TREE_PROPER.Models;

namespace PROLIFEUK_FAMILY_TREE_PROPER.Controllers
{
    [Route("Person/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //public string test = "this is a tes";
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return "please add a tree id";

        //}
        FamilyFunction familyFunction = new FamilyFunction();

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            Person person_info = new Person();
            //find person using ID
            return familyFunction.GetPerson(id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Person value)
        {
            Person person_info = familyFunction.CreatePerson(value);
            return "person " + person_info.PERSON_NAME + " was successfuly created";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Person value)
        {
            Person person_info = familyFunction.EditPerson(value);
            return "Person " + person_info.PERSON_NAME + " was successfuly edited";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Person person_info = familyFunction.DeletePerson(id);
            return "Person " + person_info.PERSON_NAME + " was successfuly deleted";
        }
    }
}
