/***************************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 207 OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a collection of methods that manages Product entities and interaction
* with the database and forms part of the CPRG 207 Threaded Project Workshop 4.
* This class contains several public static methods which allows manipulation of the
* Products table and Product entity class.
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
    public class ProductDB
    {
        // This method will return a list of Product objects from the database. (T. Leslie)
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT ProductId, ProdName " +
                "FROM Products";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    Product product = new Product();
                    product.ProductId = (int)sr["ProductId"];
                    product.ProdName = sr["ProdName"].ToString();
                    products.Add(product);
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
            return products;
        }


        // This method will return the maximum ProductId within a List of products. (T. Leslie)
        public static int FindMaxProductId(List<Product> products)
        {
            int tempMax = 0;
            foreach (Product product in products)
            {
                if (product.ProductId > tempMax)
                    tempMax = product.ProductId;
            }
            return tempMax;
        }

        // This method will return the index for a given id within a list of Products. (T. Leslie)
        public static int FindIndexofId(List<Product> products, int id)
        {
            int tmpIndex = 0;
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == id)
                    tmpIndex = i;
            }
            return tmpIndex;
        }

        // Method to return a Product object for the given ProductId. (T. Leslie)
        public static Product GetProduct(int productid)
        {
            Product product = null;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement = 
                "SELECT ProductId, ProdName " +
                "FROM Products " +
                "WHERE ProductId = @ProductId";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@ProductId", productid);
            try
            {
                conn.Open();// open connection

                SqlDataReader pr = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (pr.Read()) // product record exists
                {
                    product = new Product();
                    product.ProductId = (int)pr["ProductId"];
                    product.ProdName = pr["ProdName"].ToString();
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
            return product;
        }

        // Method to add a new product to the Products table of Travel Experts
        // and return the auto-generated ProductId. (T. Leslie)
        public static int AddProduct(Product product)
        {
            int productid = 0;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO Products (ProdName) " +
                                     "VALUES (@ProdName); SELECT SCOPE_IDENTITY()";

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@ProdName", product.ProdName);

            try
            {
                conn.Open();

                // insertCommand.ExecuteNonQuery();
                productid = Convert.ToInt32(insertCommand.ExecuteScalar());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return productid;
        }

        // Method to update an existing Product record in the database.
        // This method compares the 'old' product which was 'SELECT'ed 
        // originally against the product record at the time of 'UPDATE'ing
        // to ensure that no changes have occurred. In other words, this is
        // a concurrency check prior to updating the record. (T. Leslie)
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string updateStatement = "UPDATE Products SET " +
                                     "ProdName = @NewProdName " +
                                     "WHERE ProductId = @OldProductId " + // to identify record to update
                                     "AND ProdName = @OldProdName"; 

            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@NewProdName", newProduct.ProdName);
            updateCommand.Parameters.AddWithValue("@OldProductId", oldProduct.ProductId);
            updateCommand.Parameters.AddWithValue("@OldProdName", oldProduct.ProdName);

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

        // This method will delete the passed Product from the TravelExperts database. (T. Leslie)
        public static bool DeleteProduct(Product product)
        {
            bool success = true;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProductId = @ProductId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@ProductId", product.ProductId);
            // deleteCommand.Parameters.AddWithValue("@ProdName", product.ProdName);

            try
            {
                conn.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 0) // optimistic concurrency violation
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

        // This method returns true if the passed Product object exists in this Product table. (T. Leslie)
        public static bool IsInProductsSuppliers(Product product)
        {
            bool result = false;
            List<ProductsSupplier> prodSuppliers = ProductsSupplierDB.GetAllProductsSuppliers();

            foreach (ProductsSupplier ps in prodSuppliers)
            {
                if (ps.ProductId == product.ProductId)
                    result = true;
            }
            return result;
        }
    }
}
