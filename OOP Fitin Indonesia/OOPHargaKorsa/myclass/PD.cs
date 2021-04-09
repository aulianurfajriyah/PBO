using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OOPHargaKorsa.myclass
{
    class PD
    {
        public MySqlConnection con;

        public PD()
        {
            string host = " localhost";
            string db = "fitin";
            string port = "3306";
            string user = "Aulia";
            string pass = "jQPS03wSO5*dsao*";
            string constring = "datasource = "+host+"; database = "+db+"; port = "+port+"; username = "+user+"; password = "+ pass +"; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

    class Production:PD
    {
        //Properties
        public string Name { set; get; }
        public string Company { set; get; }
        public string Contact { set; get; }
        public string ID { set; get; }

        //Read
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet(); 

        //Create Function
        public void Create_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `production`(`Id`, `Name`, `Company`, `Contact`) VALUES(@id,@name,@company,@contact)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@company", MySqlDbType.VarChar).Value = Company;
                cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = Contact;

                cmd.ExecuteNonQuery();
                con.Close();

            } 
        }

        //Update Function
        public void Update_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE production SET Name =@name, Company =@company, Contact = @contact WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@company", MySqlDbType.VarChar).Value = Company;
                cmd.Parameters.Add("@contact", MySqlDbType.VarChar).Value = Contact;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //Delete Function
        public void Delete_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM `production` WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        //Read Function
        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `production`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
