using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.SqlClient;//קישור לספריית השאילתות ועהעובדה מול בסיס הנתונים
using System.Data;//קישור לספריית עבודה מול מבני נתונים שונים

namespace DAL
{
	public class UserDAL
	{
        public static List<User> GetAll()
        {
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();
            string Sql = "SELECT * FROM T_User";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            SqlDataReader Dr = Cmd.ExecuteReader();
            List<User> lst = new List<User>();
            while (Dr.Read() == true)
            {
                User Tmp = new User()
                {
                    Uid = (int)Dr["Uid"],
                    Uname = (string)Dr["Uname"].ToString(),
                    Uemail = (string)Dr["Uemail"],
                    Upassl = (string)Dr["Upassl"]
                };
                lst.Add(Tmp);
            }
            Conn.Close();
            return lst;
        }

        public static User GetById(int Uid)
        {
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();
            string Sql = $"SELECT * FROM T_User WHERE Uid = {Uid}";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            SqlDataReader Dr = Cmd.ExecuteReader();
            User Tmp = null;
            if (Dr.Read() == true)
            {
                Tmp = new User()
                {
                    Uid = (int)Dr["Uid"],
                    Uname = (string)Dr["Uname"].ToString(),
                    Uemail = (string)Dr["Uemail"],
                    Upassl = (string)Dr["Upassl"]
                };
            }
            Conn.Close();
            return Tmp;
        }

        public static int DeleteById(int Uid)
        {
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();
            string Sql = $"DELETE FROM T_User WHERE Uid = {Uid}";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            int rowsAffected = Cmd.ExecuteNonQuery();
            Conn.Close();
            if (rowsAffected > 0)
                return 1;
            else
                return 0;
        }
    }
}