using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace RMS.DAL
{
    public class myDAL
    {

        private static readonly string connString =
        System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;


        public void sign_up(String fname, String lname, String uname, String email, String password, String gender, String security)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Insert into USERS values (" + getNewId() + ",'" + fname + "','" + lname + "','" + uname + "','" + email + "','" + password + "','" + gender + "','" + security "')", conn);
                DataSet ds = new DataSet();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                conn.Close();
               
            }
            catch (SqlException e)
            {
                //
            }
        }

        public String getNewId()
        {
            try
            {
                DataTable dt;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select max(UID) from _USERS", conn);
                DataSet ds = new DataSet();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();

                int newid = (int)Convert.ToInt64(dt.Rows[0][0].ToString()) + 1;

                return newid.ToString();
            }
            catch (SqlException e)
            {
                //do nothing
                return "";
            }
        }

        
        public bool check(String fname, String lname, String uname, String email, String password, String gender, String security)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("Select Username from USERS where FirstName = '" + fname + "', LastName = '" + lname + "', Email = '" + email + "', password = '" + password + "', security = '" + security + "'", conn);

                DataSet ds = new DataSet();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                conn.Close();

                if (ds.Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }


        public bool isValidLogin(String email_add, String password)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from  USERS where Email = '" + email_add + "' and [password_] = '" + Password + "'", conn);
                DataSet ds = new DataSet();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                conn.Close();

                if (ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

     
    }

}