using ClassEntites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess {
    /*
    * Term 2 Threaded Project 
    * Author : Dao
    * Date : March 19,2019
    * Course Name : Threaded Project for OOSD
    * Module : PROJ-207-OOSD
    * Purpose :
    */
    public static class AgentDB {
        // Get Agent details by Agent First Name and Last Name
        public static List<Agent> GetAllAgents () {
            List<Agent> agents = new List<Agent>();
            string selectStatement = "SELECT AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, " +
                                     "AgtBusPhone, AgtEmail, AgtPosition, AgencyId " +
                                     "FROM Agents";

            // Get connection to Travel Experts DB
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // Create a select command object
            SqlCommand selectCmd = new SqlCommand(selectStatement, connection);

            // Execute command
            try {
                connection.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read()) {
                    Agent agent = new Agent();
                    agent.AgentId = (int)dr["AgentId"];
                    if (dr["AgtFirstName"] is DBNull)
                        agent.AgtFirstName = null;
                    else
                        agent.AgtFirstName = dr["AgtFirstName"].ToString();

                    if (dr["AgtMiddleInitial"] is DBNull)
                        agent.AgtMiddleInitial = null;
                    else
                        agent.AgtMiddleInitial = dr["AgtMiddleInitial"].ToString();

                    if (dr["AgtLastName"] is DBNull)
                        agent.AgtLastName = null;
                    else
                        agent.AgtLastName = dr["AgtLastName"].ToString();

                    if (dr["AgtBusPhone"] is DBNull)
                        agent.AgtBusPhone = null;
                    else
                        agent.AgtBusPhone = dr["AgtBusPhone"].ToString();

                    if (dr["AgtEmail"] is DBNull)
                        agent.AgtEmail = null;
                    else
                        agent.AgtEmail = dr["AgtEmail"].ToString();

                    if (dr["AgtPosition"] is DBNull)
                        agent.AgtPosition = null;
                    else
                        agent.AgtPosition = dr["AgtPosition"].ToString();

                    if (dr["AgencyId"] is DBNull)
                        agent.AgencyId = null;
                    else
                        agent.AgencyId = (int)dr["AgencyId"];

                    agents.Add(agent);
                }

            } catch (Exception ex) {
                throw ex;
            } finally {
                connection.Close();
            }

            return agents;
        }
    }
}
