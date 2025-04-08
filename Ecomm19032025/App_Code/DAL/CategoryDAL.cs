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
	public class CategoryDAL
	{
            public static List<Category> GetAll()
            {
                // הפונקציה מחזירה רשימת קטגוריות מהטבלה
                string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection Conn = new SqlConnection(ConnStr);
                Conn.Open();
                string Sql = $"SELECT * FROM T_Category";
                SqlCommand Cmd = new SqlCommand(Sql, Conn);
                SqlDataReader Dr = Cmd.ExecuteReader();
                List<Category> lst = new List<Category>();
                while (Dr.Read() == true)
                {
                    Category Tmp = new Category()
                    {
                        Cid = (int)Dr["Cid"],
                        Cname = (string)Dr["Cname"].ToString(),
                        Cdesc = (string)Dr["Cdesc"]
                    };
                    lst.Add(Tmp);
                }
                Conn.Close();
                return lst;
            }

            public static Category GetById(int Cid)
            {
                // הפונקציה מחזירה קטגוריה לפי מזהה אם קיימת
                string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection Conn = new SqlConnection(ConnStr);
                Conn.Open();
                string Sql = $"SELECT * FROM T_Category WHERE Cid = {Cid}";
                SqlCommand Cmd = new SqlCommand(Sql, Conn);
                SqlDataReader Dr = Cmd.ExecuteReader();
                Category Tmp = null;
                if (Dr.Read() == true)
                {
                    Tmp = new Category()
                    {
                        Cid = (int)Dr["Cid"],
                        Cname = (string)Dr["Cname"].ToString(),
                        Cdesc = (string)Dr["Cdesc"]
                    };
                }
                Conn.Close();
                return Tmp;
            }

            public static int DeleteById(int Cid)
            {
                // הפונקציה מוחקת קטגוריה לפי מזהה
                string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection Conn = new SqlConnection(ConnStr);
                Conn.Open();
                string Sql = $"DELETE FROM T_Category WHERE Cid = {Cid}";
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