using System;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DBhandler
/// </summary>
/// 
public class DBhandler
{
	
     SqlConnection con;
        
        DataTable dt;
        SqlDataAdapter da;
        String datasource = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\inetpub\wwwroot\AM\App_Data\AMDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public DBhandler()
        {
            con = new SqlConnection(datasource);
        }

        public  DataTable GetTable(String str)
        {
            
                da = new SqlDataAdapter(str, con);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
          
        }

        public DataSet ret(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
	
		int id;
        public int max(string s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = s;
            try
            {
                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            }
            catch
            {
                id = 1;
            }
            finally
            {
                con.Close();
            }
            return id;
        }
		

        //public int getmax_id(string tablename, string fieldname)
        //{
            
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "select isnull(max(convert(bigint," + fieldname + ")),'0') from " + tablename + "";
        //    cmd.Connection = con;
        //    int retval = 0;
        //    retval = Convert.ToInt32 (cmd.ExecuteScalar());
            
        //    con.Close();

        //    return retval;


        //}
        
        public string GetValue(String query)
        {
           
            SqlCommand cmd = new SqlCommand();
            con.Open();

            string str;
            try
            {
                cmd = new SqlCommand(query, con);
                str = cmd.ExecuteScalar().ToString();
            }
            catch (Exception x)
            {
                str = "0";
            }
            con.Close();

            return str;
        }
		
        public void Ins_Up_Del(String query)
        {   
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            
            cmd.ExecuteNonQuery();
            con.Close();
        }
       



    }



   

