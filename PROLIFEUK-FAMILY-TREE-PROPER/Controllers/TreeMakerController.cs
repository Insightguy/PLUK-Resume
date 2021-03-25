using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROLIFEUK_FAMILY_TREE_PROPER.Models;
using PROLIFEUK_FAMILY_TREE_PROPER.Functionality;

namespace PROLIFEUK_FAMILY_TREE_PROPER.Controllers
{
    [Route("TreeMaker/[controller]")]
    [ApiController]
    public class TreeMakerController : ControllerBase
    {

        // POST api/values
        [HttpGet("{id}")]
        public List<Person> Get(int id)
        {
            List<Person> TreePopulation = new List<Person>();
            //function to get tree population here
            return TreePopulation;
        }

        [HttpPost]
        public string Post([FromBody] TreeMaker value)
        {
            Person TargetPerson1 = new Person();
            Person TargetPerson2 = new Person();
            Tree TargetTree = new Tree();

            //get from database

            if (TargetPerson1.TREE_ID != TargetPerson2.TREE_ID && TargetPerson1.TREE_ID != 0 && TargetPerson2.TREE_ID != 0)
            {
                return "action unable to be done, both people are present in different family trees";
            }
            else if (value.RELATIONSHIP.ToUpper() != "SON"
                  && value.RELATIONSHIP.ToUpper() != "DAUGHTER"
                  && value.RELATIONSHIP.ToUpper() != "FATHER"
                  && value.RELATIONSHIP.ToUpper() != "MOTHER")
            {
                return "action unable to be done, invalid selector";
            }

            switch (value.RELATIONSHIP.ToUpper())
            {
                case "SON":
                    if (TargetPerson1.GENDER != "M")
                        {   return "action unable to be done, the son can't be female";    }

                    if (TargetPerson2.GENDER == "M")
                    {
                        TargetPerson1.FATHER_ID = TargetPerson2.PERSON_ID;
                    }  else  {
                        TargetPerson1.MOTHER_ID = TargetPerson2.PERSON_ID;
                    }
                    break;
                case "DAUGHTER":
                    if (TargetPerson1.GENDER != "F")
                        {   return "action unable to be done, the daughter can't be male";    }


                    if (TargetPerson2.GENDER == "M")
                    {
                        TargetPerson1.FATHER_ID = TargetPerson2.PERSON_ID;
                    }
                    else
                    {
                        TargetPerson1.MOTHER_ID = TargetPerson2.PERSON_ID;
                    }
                    break;
                case "FATHER":
                    if (TargetPerson1.GENDER != "M")
                        {   return "action unable to be done, the father can't be female";    }
                    TargetPerson2.FATHER_ID = TargetPerson1.PERSON_ID;
                    break;
                case "MOTHER":
                    if (TargetPerson1.GENDER != "F")
                        {   return "action unable to be done, the mother can't be male"; }
                    TargetPerson2.MOTHER_ID = TargetPerson1.PERSON_ID;
                    break;
                default:
                    return "action unable to be done, invalid selector";
            }

            new FamilyFunction().EditPerson(TargetPerson1);
            new FamilyFunction().EditPerson(TargetPerson2);

            return TargetPerson1.PERSON_NAME + " is listed as the " + value.RELATIONSHIP + " of " + TargetPerson2.PERSON_NAME;
        }
    }
}
