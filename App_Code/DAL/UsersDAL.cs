using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    public class UsersDAL
    {

        public static Users GetById(int Uid)
        {
            DbContext Db = new DbContext();
            string sql = $"SELECT * FROM T_Users Where Uid={Uid}";
            DataTable Dt = Db.Execute(sql);
            Users Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Users()
                {
                    Uid = (int)Dt.Rows[0]["Uid"],
                    FullName = (string)Dt.Rows[0]["FullName"],
                    Pass = (string)Dt.Rows[0]["Pass"],
                    Email = (string)Dt.Rows[0]["Email"],
                    Phone = (string)Dt.Rows[0]["Phone"],
                    Address = (string)Dt.Rows[0]["Address"]
                    
                };

                Db.Close();//סגירת החיבור לבסיס הנתונים
                return Tmp;
            }
            return new Users();
        }

       public static List<Users> GetAll()
       {
            DbContext Db = new DbContext();
            string sql = "SELECT * FROM T_Users";
            DataTable Dt = Db.Execute(sql);
            List<Users> lst = new List<Users>();

            foreach (DataRow row in Dt.Rows)
            {
                Users Tmp = new Users()
                {
                    Uid = Convert.ToInt32(row["Uid"]),
                    FullName = row["FullName"].ToString(),
                    Pass = row["Pass"].ToString(),
                    Email = row["Email"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Address = row["Address"].ToString()
                    
                };

                lst.Add(Tmp);
            }

            Db.Close();
            return lst;
       }


        public static int Save(Users Tmp)//שומר את היוזר
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג דאטה בייס
            string sql;
            if (Tmp.Uid == -1)//אם קוד היוזר שווה ל-1 כלומר יוזר חדש
            {
                sql = $"INSERT INTO T_Users(FullName, Pass, Email, Phone, Address)";
                sql += $" VALUES(N'{Tmp.FullName}',N'{Tmp.Pass}',N'{Tmp.Email}',N'{Tmp.Phone}',N'{Tmp.Address}')";
            }

            else

            {
                sql = $"UPDATE T_Users SET ";
                sql += $"FullName=N'{Tmp.FullName}',";
                sql += $"Pass=N'{Tmp.Pass}',";
                sql += $"Email=N'{Tmp.Email}',";
                sql += $"Phone=N'{Tmp.Phone}',";
                sql += $"Address=N'{Tmp.Address}'";
                sql += $" WHERE Uid={Tmp.Uid}";
            }
            int i = Db.ExecuteNonQuery(sql);//מחזירה מספר שורות שהוסרו מהמסד נתונים
            if (Tmp.Uid == -1)//אם קוד היוזר שווה ל-1 כלומר יוזר חדש
            {
                sql = $"SELECT Max(Uid) FROM T_Users Where FullName='{Tmp.FullName}'";
                Tmp.Uid = (int)Db.ExecuteScalar(sql);//מחזירה את היוזר שנשמר
            }
            Db.Close();//סגירת החיבור לבסיס הנתונים
            return i;//מחזירה את היוזר שנשמר
        }

        public static int DeleteById(int Uid)//מוחקת את היוזר לפי קוד
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג דאטה בייס
            string sql = $"DELETE FROM T_Users WHERE Uid={Uid}";
            int i = Db.ExecuteNonQuery(sql);//מחזירה מספר שורות שהוסרו מהמסד נתונים
            Db.Close();//סגירת החיבור לבסיס הנתונים
            return i;//מחזירה את היוזר שנמחק
        }
    }
}