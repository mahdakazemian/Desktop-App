/********************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 207 OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a Product class definition and forms part of the CPRG 207
* Threaded Project Workshop 4.
*
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites
{
    // Product class definition mirroring the Travel Experts product table.
    public class Product
    {
        public int ProductId { get; set; }

        public string ProdName { get; set; }

        public override string ToString()
        {
            return "Product Id: " + ProductId.ToString() + ",   " + "Product Name: " + ProdName;
        }
    }
}
