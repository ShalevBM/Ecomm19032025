using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;//קישור לספריית השאילתות ועהעובדה מול בסיס הנתונים
using System.Data;//קישור לספריית עבודה מול מבני נתונים שונים

namespace DAL
{
	public class ProductDAL
	{
        public static Product GetById(int Pid)
        {
            //הפונקציה מקבלת קוד מוצר ומחזירה אובייקט עם פרטי המוצר במידה ונמצא אחרת תחזיר ריק
            //נגדיר עבודה מול בסיס הנתונים
            //נגדיר מחרוזת התחברות לבסיס הנתונים
            //ניצור אובייקט מסוג קונקשן ונאתחל אותו במחרוזת ההתחברות
            //נפתח את הקונקשן
            //ניצור אובייקט מסוג פקודה ונאתחל אותו בקונקשן ובמשפט שאילתה
            //נפעיל את אובייקט הפקודה ונקבל את התוצאות שחזרו
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn=new SqlConnection(ConnStr);// יצירת אובייקט מסוג קונקשן שמקבל את מחרוזת ההתחברות לבסיס הנתונים
            Conn.Open();//פתיחת הקונקשן לבסיס הנתונים , כעת יש לנו צינור זמין לשאילתות
            string Sql =$"SELECT * FROM T_Product Where Pid{Pid}=";//שאילתה אותה יש להריץ מול בסיס הנתונים
            SqlCommand Cmd= new SqlCommand(Sql,Conn);//יצירת אובייקט פקודה שמאותחל בשאילתה וקונקשן
            //Cmd.ExecuteNonQuery();
            SqlDataReader Dr =Cmd.ExecuteReader();//יצרנו אובייקט מסוג קורא נתונים והפעלנו את השאילתה מול בסיס הנתונים
            Product Tmp = null;//יצירת משתנה ייחוס מסוג מוצר מאותחל בריק
            if(Dr.Read()==true)
            {
                //המוצר נמצא
                Tmp = new Product()//יצירת אובייקט מסוג מוצר ומילוי השדות שלו עם הערכים שנשלפו מבסיס הנתונים
                {
                    Pid = (int)Dr["Pid"],
                    Pname = (string)Dr["Pname"].ToString(),
                    Price = (float)Dr["Price"],
                    Pdesc = (string)Dr["Pdesc"]
                };
            }
            Conn.Close();//סגירת חיבור לבסיס הנתונים
            return Tmp;//החזרת אובייקט המוצר
        }

        public static List<Product> GetAll()
        {
            //הפונקציה מקבלת קוד מוצר ומחזירה אובייקט עם פרטי המוצר במידה ונמצא אחרת תחזיר ריק
            //נגדיר עבודה מול בסיס הנתונים
            //נגדיר מחרוזת התחברות לבסיס הנתונים
            //ניצור אובייקט מסוג קונקשן ונאתחל אותו במחרוזת ההתחברות
            //נפתח את הקונקשן
            //ניצור אובייקט מסוג פקודה ונאתחל אותו בקונקשן ובמשפט שאילתה
            //נפעיל את אובייקט הפקודה ונקבל את התוצאות שחזרו
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnStr);// יצירת אובייקט מסוג קונקשן שמקבל את מחרוזת ההתחברות לבסיס הנתונים
            Conn.Open();//פתיחת הקונקשן לבסיס הנתונים , כעת יש לנו צינור זמין לשאילתות
            string Sql = $"SELECT * FROM T_Product";//שאילתה אותה יש להריץ מול בסיס הנתונים
            SqlCommand Cmd = new SqlCommand(Sql, Conn);//יצירת אובייקט פקודה שמאותחל בשאילתה וקונקשן
            //Cmd.ExecuteNonQuery();
            SqlDataReader Dr = Cmd.ExecuteReader();//יצרנו אובייקט מסוג קורא נתונים והפעלנו את השאילתה מול בסיס הנתונים
            List <Product> lst =new List <Product>();//יצירת משתנה ייחוס מסוג מוצר מאותחל בריק
            while (Dr.Read() == true)
            {
                //המוצר נמצא
                Product Tmp = new Product();
                Tmp = new Product()//יצירת אובייקט מסוג מוצר ומילוי השדות שלו עם הערכים שנשלפו מבסיס הנתונים
                {
                    Pid = (int)Dr["Pid"],
                    Pname = (string)Dr["Pname"].ToString(),
                    Price = (float)Dr["Price"],
                    Pdesc = (string)Dr["Pdesc"]
                };
                lst.Add(Tmp);//הוספת האובייקט לרשימה
            }
            Conn.Close();//סגירת חיבור לבסיס הנתונים
            return lst;//החזרת רשימת אובייקט המוצר
        }

        public static int DeleteById(int pid)
        {
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open(); 
            string Sql = $"DELETE FROM T_Product WHERE Pid = {pid}";
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