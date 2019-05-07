
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites
{

    /*
    * Term 2 Threaded Project 
    * Author : Mahda Kazemian
    * Date : March 19,2019
    * Course Name : Threaded Project for OOSD
    * Module : PROJ-207-OOSD
    * Purpose :public variables for PackageDB class
    */
    public class Package
    {

        public int PackageId { get; set; }

        public string PkgName { get; set; }

        public DateTime? PkgStartDate { get; set; } 

        public DateTime? PkgEndDate { get; set; } 

        public string PkgDesc { get; set; }

        public decimal PkgBasePrice { get; set; }

        public decimal? PkgAgencyCommission { get; set; }

    }
}
