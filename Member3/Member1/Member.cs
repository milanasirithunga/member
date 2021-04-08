using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member3.Member1
{
    class Member
    {
        //Getters and Setters
        //Act as data carrier in our application
        public int numofworkingdays { get; set; }
       // public String MondaycheckBox { get; set; }
       // public string TuesdaycheckBox { get; set; }
        //public string WednesdaycheckBox { get; set; }
        //public string ThursdaycheckBox { get; set; }
        //public string FridaycheckBox { get; set; }
        public string days { get; set; }
        public string workingHours { get; set; }
        public String ID { get; set; }
        // public int Hoursnumeric { get; set; }
        ///public int Minutenumeric { get; set; }


        static string myconnection = ConfigurationManager.ConnectionStrings["connection1"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            ///sp01 databse connection
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                //stp 2 Writin sql Query
                string sql = "SELECT FROM  Days_Hours";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating SQL DATABSE using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
            
        }

        //inserting data into databse
        public bool Insert (Member c)
        {
            //creatinig a default type and setting its value to false
            bool isSuccess = false;
            //stp1 Connet databse
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                //stp 2 create a SQl Query to insert Data
                string sql = "INSERT INTO Days_Hours (NoofWorkingDays, WorkingDays, daysandhours) VALUSES (@NoofWorkingDays, @WorkingDays, @daysandhours)";
                //CREATING SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data to db
                Console.WriteLine(c.numofworkingdays);
                Console.WriteLine(c.workingHours);

                cmd.Parameters.AddWithValue("@NoofWorkingDays", c.numofworkingdays);
                cmd.Parameters.AddWithValue("@WorkingDays", c.days);
                cmd.Parameters.AddWithValue("@daysandhours", c.workingHours);

                //connection oepn here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs susscessfully then the value of the rows willl be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        
        //method to update data in databse from our application
        public bool Update(Member c)
        {
            //create a default return type and its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                //SQL to update data in our Databse
                string sql = "UPDATE DaysandHours SET NoofWorkingDays=@NoofWorkingDays, WorkingDays=@WorkingDays, daysandhours=@daysandhours WHERE id=@id";

                //creating SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@NoofWorkingDays", c.numofworkingdays);
                cmd.Parameters.AddWithValue("@WorkingDays", c.days);
                cmd.Parameters.AddWithValue("@daysandhours", c.workingHours);
                cmd.Parameters.AddWithValue("@id", c.ID);
                //open databse connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                ////if the query runs susscessfully then the value of the rows willl be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //method to delete data from databse
        public bool Delete(Member c)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;
            //Create sql connection
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                //SQL to Delete data
                string sql = "DELETE FROM DaysandHours WHERE id=@id ";

                //CREATE sqL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.ID);
                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                ////if the query runs susscessfully then the value of the rows willl be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
