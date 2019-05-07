/***************************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 207  OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a collection of methods to manage the Supplier class objects
* and interaction with the databse and forms part of the CPRG 207
* Threaded Project Workshop 4.
* 
****************************************************************************************/
using ClassEntites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    // class contains database interaction methods for the Supplier entities
    public class SupplierDB
    {
        // This method returns a list of Supplier objects from the database. (T. Leslie)
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT SupplierId, SupName " +
                "FROM Suppliers";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // while product record exists
                {
                    Supplier supplier = new Supplier(); // instantiate Supplier object
                    // set properties of new object from database record
                    supplier.SupplierId = (int)sr["SupplierId"];

                    if (sr["SupName"] is DBNull)
                        supplier.SupName = null;
                    else
                        supplier.SupName = (string)(sr["SupName"]);

                    suppliers.Add(supplier);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return suppliers;
        }

        // Method to return a Supplier object for the given supplierid. (T. Leslie)
        public static Supplier GetSupplier(int supplierid)
        {
            Supplier supplier = null;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT SupplierId, SupName " +
                "FROM Suppliers " +
                "WHERE SupplierId = @SupplierId";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@SupplierId", supplierid);
            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (sr.Read()) // product record exists
                {
                    supplier = new Supplier();
                    supplier.SupplierId = (int)sr["SupplierId"];
                    if (sr["SupName"] is DBNull)
                        supplier.SupName = null;
                    else
                        supplier.SupName = (string)(sr["SupName"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return supplier;
        }
        
        // Method returns the index of a given Supplier object in a list of objects. (T. Leslie)
        public static int FindIndexofId(List<Supplier> suppliers, int id)
        {
            int tmpIndex = 0;
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].SupplierId == id)
                    tmpIndex = i;
            }
            return tmpIndex;
        }


        // Method to add a new product to the Suppliers table of Travel Experts
        // and return the auto-generated SupplierId. (T. Leslie)
        public static bool AddSupplier(Supplier supplier)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                     "VALUES(@SupplierId, @SupName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            insertCommand.Parameters.AddWithValue("@SupName", supplier.SupName);

            try
            {
                conn.Open();

                insertCommand.ExecuteNonQuery();

           }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        // Method to update an existing Supplier record in the database.
        // This method compares the 'old' product which was 'SELECT'ed 
        // originally against the product record at the time of 'UPDATE'ing
        // to ensure that no changes have occurred. In other words, this is
        // a concurrency check prior to updating the record.
        public static bool UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string updateStatement = "UPDATE Suppliers SET " +
                                     "SupName = @NewSupName " +
                                     "WHERE SupplierId = @OldSupplierId " + // to identify record to update
                                     "AND SupName = @OldSupName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@NewSupName", newSupplier.SupName);
            updateCommand.Parameters.AddWithValue("@OldSupplierId", oldSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@OldSupName", oldSupplier.SupName);

            try
            {
                conn.Open();
                int rowsUpdated = updateCommand.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        // Method to delete the passed supplier from the database. (T. Leslie)
        public static bool DeleteSupplier(Supplier supplier)
        {
            bool success = true;

            // Delete SupplierContacts record for the supplier first
            if (IsInSupplierContacts(supplier))
                DeleteSupplierContacts(supplier);            

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // prepare a delete statement
            string deleteStatement = "DELETE FROM Suppliers " +
                                     "WHERE SupplierId = @SupplierId " +
                                     "AND SupName = @SupName";

            // prepare a delete command
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            deleteCommand.Parameters.AddWithValue("@SupName", supplier.SupName);

            try
            {
                conn.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 0)
                    success = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        // Method to check if passed supplier is in the List of SupplierContacts. (T. Leslie)
        private static bool IsInSupplierContacts(Supplier supplier)
        {
            bool result = false;

            List<SupplierContact> suppliercontacts = new List<SupplierContact>();
            suppliercontacts = GetSupplierContacts();

            foreach(SupplierContact suppliercontact in suppliercontacts)
            {
                if (suppliercontact.SupplierId == supplier.SupplierId)
                    result = true;
            }
            return result;
        }

        // Method to return a List of SupplierContacts. (T. Leslie)
        private static List<SupplierContact> GetSupplierContacts()
        {
            List<SupplierContact> suppliercontacts = new List<SupplierContact>();

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT SupplierContactId, SupplierId " +
                "FROM SupplierContacts";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    SupplierContact suppliercontact = new SupplierContact();
                    suppliercontact.SupplierContactId = (int)sr["SupplierContactId"];
                    suppliercontact.SupplierId = (int)sr["SupplierId"];
                    if (sr["SupplierId"] is DBNull)
                        suppliercontact.SupplierId = null;
                    else
                        suppliercontact.SupplierId = (int)(sr["SupplierId"]);

                    suppliercontacts.Add(suppliercontact);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return suppliercontacts;
        }


        // Method to delete a SupplierContact record for a given supplier. (T. Leslie)
        public static bool DeleteSupplierContacts(Supplier supplier)
        {
            bool success = true;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string deleteStatement = "DELETE FROM SupplierContacts " +
                                     "WHERE SupplierId = @SupplierId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);

            try
            {
                conn.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 0)
                    success = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        // Method to check if a supplier is in the Products_Suppliers table.
        public static bool IsInProductsSuppliers(Supplier supplier)
        {
            bool result = false;
            List<ProductsSupplier> prodSuppliers = ProductsSupplierDB.GetAllProductsSuppliers();

            foreach (ProductsSupplier ps in prodSuppliers)
            {
                if (ps.SupplierId == supplier.SupplierId)
                    result = true;
            }
            return result;
        }

        // Method to find the maximum SupplierId in a List of suppliers. (T. Leslie)
        public static int FindMaxSupplierId(List<Supplier> suppliers)            
        {
            int maxId = 0;
            foreach (Supplier supplier in suppliers)
            {
                if (supplier.SupplierId > maxId)
                    maxId = supplier.SupplierId;
            }
            return maxId;
        }
    }
}
