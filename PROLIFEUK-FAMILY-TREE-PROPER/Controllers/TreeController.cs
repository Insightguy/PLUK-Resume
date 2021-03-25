using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROLIFEUK_FAMILY_TREE_PROPER.Models;
using PROLIFEUK_FAMILY_TREE_PROPER.Functionality;

namespace PROLIFEUK_FAMILY_TREE_PROPER.Controllers
{
    [Route("Tree/[controller]")]
    [ApiController]
    public class TreeController : ControllerBase
    {
        //public string test = "this is a tes";
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return "please add a tree id";

        //}

        // GET api/values/5
        FamilyFunction familyFunction = new FamilyFunction();


        [HttpGet("{id}")]
        public Tree Get(int id)
        {
            Tree TargetTree = new Tree();
            return familyFunction.GetTree(id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Tree value)
        {
            Tree tree_info = familyFunction.CreateTree(value);
            return "Tree " + value.TREE_NAME + " was successfuly created";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Tree value)
        {
            Tree tree_info = familyFunction.EditTree(value);
            return "Tree " + value.TREE_NAME + " was successfuly edited";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Person person_info = familyFunction.DeleteTree(id);
            return "Tree was successfuly deleted";
        }
    }
}
