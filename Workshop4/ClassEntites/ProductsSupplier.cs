/********************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 207 OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a ProductSupplier class definition and forms part of
* the CPRG 207 Threaded Project Workshop 4.
*
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites
{
    public class ProductsSupplier
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; } // Can be NULL
        public int? SupplierId { get; set; } // Can be NULL
    }
}
