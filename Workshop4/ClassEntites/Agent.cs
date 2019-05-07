using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    * Term 2 Threaded Project 
    * Author : Dao
    * Date : March 19,2019
    * Course Name : Threaded Project for OOSD
    * Module : PROJ-207-OOSD
    * Purpose :
    */
namespace ClassEntites {
    public class Agent {
        public int AgentId { get; set; }
        public string AgtFirstName { get; set; }
        public string AgtMiddleInitial { get; set; }
        public string AgtLastName { get; set; }
        public string AgtBusPhone { get; set; }
        public string AgtEmail { get; set; }
        public string AgtPosition { get; set; }
        public int? AgencyId { get; set; }
    }
}
