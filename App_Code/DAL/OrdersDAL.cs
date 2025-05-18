using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class OrdersDAL
    {
        // מחזירה הזמנה לפי מזהה
        public static Orders GetById(int OrderId)
        {
            DbContext Db = new DbContext();
            string sql = $"SELECT * FROM T_Orders WHERE OrderId={OrderId}";
            DataTable Dt = Db.Execute(sql);
            Orders Tmp = null;

            if (Dt.Rows.Count > 0)
            {
                Tmp = new Orders()
                {
                    OrderId = Convert.ToInt32(Dt.Rows[0]["OrderId"]),
                    Uid = Convert.ToInt32(Dt.Rows[0]["Uid"]),
                    TotalPrice = Convert.ToSingle(Dt.Rows[0]["TotalPrice"]),
                    TotalAmount = Convert.ToSingle(Dt.Rows[0]["TotalAmount"]),
                    Status = Dt.Rows[0]["Status"].ToString()
                };
            }

            Db.Close();
            return Tmp ?? new Orders();
        }

        // מחזירה את כל ההזמנות
        public static List<Orders> GetAll()
        {
            DbContext Db = new DbContext();
            string sql = "SELECT * FROM T_Orders";
            DataTable Dt = Db.Execute(sql);
            List<Orders> lst = new List<Orders>();

            foreach (DataRow row in Dt.Rows)
            {
                Orders Tmp = new Orders()
                {
                    OrderId = Convert.ToInt32(row["OrderId"]),
                    Uid = Convert.ToInt32(row["Uid"]),
                    TotalPrice = Convert.ToSingle(row["TotalPrice"]),
                    TotalAmount = Convert.ToSingle(row["TotalAmount"]),
                    Status = row["Status"].ToString()
                };

                lst.Add(Tmp);
            }

            Db.Close();
            return lst;
        }

        // שומר הזמנה (הוספה או עדכון)
        public static int Save(Orders Tmp)
        {
            DbContext Db = new DbContext();
            string sql;

            if (Tmp.OrderId == -1) // הזמנה חדשה
            {
                sql = $"INSERT INTO T_Orders(Uid, TotalPrice, TotalAmount, Status) " +
                      $"VALUES(N'{Tmp.Uid}', N'{Tmp.TotalPrice}', N'{Tmp.TotalAmount}', N'{Tmp.Status}')";
            }
            else // עדכון הזמנה קיימת
            {
                sql = $"UPDATE T_Orders SET " +
                      $"Uid = N'{Tmp.Uid}', " +
                      $"TotalPrice = N'{Tmp.TotalPrice}', " +
                      $"TotalAmount = N'{Tmp.TotalAmount}', " +
                      $"Status = N'{Tmp.Status}' " +
                      $"WHERE OrderId = {Tmp.OrderId}";
            }

            int i = Db.ExecuteNonQuery(sql);

            if (Tmp.OrderId == -1) // אם זו הוספה - נמשוך את ה־ID
            {
                sql = "SELECT MAX(OrderId) FROM T_Orders";
                Tmp.OrderId = (int)Db.ExecuteScalar(sql);
            }

            Db.Close();
            return i;
        }

        // מוחקת הזמנה לפי מזהה
        public static int DeleteById(int OrderId)
        {
            DbContext Db = new DbContext();
            string sql = $"DELETE FROM T_Orders WHERE OrderId = {OrderId}";
            int i = Db.ExecuteNonQuery(sql);
            Db.Close();
            return i;
        }
    }
}
