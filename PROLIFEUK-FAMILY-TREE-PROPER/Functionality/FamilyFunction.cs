using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using PROLIFEUK_FAMILY_TREE_PROPER.Models;

namespace PROLIFEUK_FAMILY_TREE_PROPER.Functionality
{
    public class FamilyFunction
    {
        public Person GetPerson(int id)
        {
            Person TargetPerson = new Person();
            //get from 
            string constr ""; //insert oracle connection string here
            using (OracleConnection con = new OracleConnection(constr))
            {
                string selectqry = @"Select PERSON_ID, PERSON_NAME, TREE_ID, MOTHER_ID, FATHER_ID, GENDER From PEOPLE WHERE PERSON_ID = :PERSON_ID";
                OracleCommand cmdselect = new OracleCommand(selectqry, con);
                cmdselect.CommandType = CommandType.Text;
                con.Open();

                OracleParameter oraParameter = new OracleParameter();
                oraParameter.ParameterName = ":PERSON_ID";
                oraParameter.Value = id;
                cmdselect.Parameters.Add(oraParameter);

                OracleDataReader dr = cmdselect.ExecuteReader();
                while (dr.Read())
                {
                    TargetPerson.PERSON_ID = Convert.ToInt32(dr["PERSON_ID"].ToString());
                    TargetPerson.PERSON_NAME = dr["PERSON_NAME"].ToString();
                    TargetPerson.TREE_ID = Convert.ToInt32(dr["TREE_ID"].ToString());
                    TargetPerson.MOTHER_ID = Convert.ToInt32(dr["MOTHER_ID"].ToString());
                    TargetPerson.FATHER_ID = Convert.ToInt32(dr["FATHER_ID"].ToString());
                    TargetPerson.GENDER = dr["GENDER"].ToString();
                }
                con.Close();
                con.Dispose();
            }
            return TargetPerson;
        }
        public Person EditPerson(Person new_details)
        {
            Person TargetPerson = new Person();
            //get from database
            return TargetPerson;
        }
        public Person CreatePerson(Person new_details)
        {
            Person TargetPerson = new Person();
            //give to database
            return TargetPerson;
        }
        public Person DeletePerson(int id)
        {
            Person TargetPerson = new Person();
            //get from database
            using (OracleConnection con = new OracleConnection(constr))
            {
                string selectqry = @"DELETE From PEOPLE WHERE PERSON_ID = :PERSON_ID";
                OracleCommand cmdselect = new OracleCommand(selectqry, con);
                cmdselect.CommandType = CommandType.Text;
                con.Open();

                OracleParameter oraParameter = new OracleParameter();
                oraParameter.ParameterName = ":PERSON_ID";
                oraParameter.Value = id;
                oracleCommand.Parameters.Add(oraParameter)


                oracleCommand.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            return TargetPerson;
        }
        //---------------------------------------------------------------------------------------------------
        public Tree GetTree(int id)
        {
            Tree TargetTree = new Tree();
            //get from database
            return TargetTree;
        }
        public Tree EditTree(Tree new_details)
        {
            Tree TargetTree = new Tree();
            //get from database
            return TargetTree;
        }
        public Tree CreateTree(Tree new_details)
        {
            Tree TargetTree = new Tree();
            //give to database
            return TargetTree;
        }
        public Tree DeleteTree(int id)
        {
            Tree TargetTree = new Tree();
            //remove from database
            return TargetTree;
        }
        //---------------------------------------------------------------------------------------------------
    }
}
