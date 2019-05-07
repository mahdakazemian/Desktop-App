/********************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 207 OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a SupplierContact class definition and forms part of the CPRG 207
* Threaded Project Workshop 4. This class is a subset of the SupplierContact table fields
* and allows for retention of the appropriate SupplierContactId in case the 
* SupplierContact information is to be deleted.
*
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites
{
    public class SupplierContact
    {
        public int SupplierContactId { get; set; }
        public int? SupplierId { get; set; }
    }
}
