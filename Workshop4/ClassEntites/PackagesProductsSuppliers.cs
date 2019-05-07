/********************************************************************************
* 
* Author: Hayley Mead
* Date: March 25, 2019.
* Course: CPRG 217 OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a Suppliers class definition and forms part of the CPRG 217
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
    public class PackagesProductsSuppliers
    {
        public int PackageId { get; set; }

        public int? ProductSupplierId { get; set; } // nullable db field / property
    }
}
