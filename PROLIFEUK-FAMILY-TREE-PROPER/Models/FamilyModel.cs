using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROLIFEUK_FAMILY_TREE_PROPER.Models
{
    public class Tree
    {
        public int TREE_ID { get; set; }
        public string TREE_NAME { get; set; }
    }

    public class Person
    {
        public int PERSON_ID { get; set; }
        public string PERSON_NAME { get; set; }
        public int FATHER_ID { get; set; }
        public int MOTHER_ID { get; set; }
        public int TREE_ID { get; set; }
        public string GENDER { get; set; }
    }
    public class TreeMaker
    {
        public int TREE_ID { get; set; }
        public int PERSON_ID_1 { get; set; }
        public string RELATIONSHIP { get; set; }
        public int PERSON_ID_2 { get; set; }
    }
}