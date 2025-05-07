using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DATA;

namespace DAL
{
    public class ProductDAL
    {
        public static Product GetById(int Pid)
        {
            DbContext Db = new DbContext();
            string sql = $"SELECT * FROM T_Product WHERE Pid = {Pid}";
            DataTable Dt = Db.Execute(sql);
            Product Tmp = null;

            if (Dt.Rows.Count > 0)
            {
                DataRow row = Dt.Rows[0];

                Tmp = new Product()
                {
                    Pid = Convert.ToInt32(row["Pid"]),
                    Pname = row["Pname"].ToString(),
                    Pdesc = row["Pdesc"].ToString(),
                    Price = Convert.ToSingle(row["Price"]),
                    Cid = Convert.ToInt32(row["Cid"])
                };
            }

            Db.Close();
            return Tmp ?? new Product();
        }

        public static List<Product> GetAll()
        {
            DbContext Db = new DbContext();
            string sql = "SELECT * FROM T_Product";
            DataTable Dt = Db.Execute(sql);
            List<Product> lst = new List<Product>();

            foreach (DataRow row in Dt.Rows)
            {
                Product Tmp = new Product()
                {
                    Pid = Convert.ToInt32(row["Pid"]),
                    Pname = row["Pname"].ToString(),
                    Pdesc = row["Pdesc"].ToString(),
                    Price = Convert.ToSingle(row["Price"]),
                    Cid = Convert.ToInt32(row["Cid"])
                };

                lst.Add(Tmp);
            }

            Db.Close();
            return lst;
        }

        public static int Save(Product Tmp)
        {
            DbContext Db = new DbContext();
            string sql;

            if (Tmp.Pid == -1)
            {
                sql = $@"
                    INSERT INTO T_Product (Pname, Pdesc, Price, Cid, PicName, Status)
                    VALUES (N'{Tmp.Pname}', N'{Tmp.Pdesc}', {Tmp.Price}, {Tmp.Cid}, '{Tmp.Picname}', '{Tmp.Status}')";
            }
            else
            {
                sql = $@"
                    UPDATE T_Product SET
                        Pname = N'{Tmp.Pname}',
                        Pdesc = N'{Tmp.Pdesc}',
                        Price = {Tmp.Price},
                        Cid = {Tmp.Cid},
                        PicName = '{Tmp.Picname}',
                        Status = '{Tmp.Status}'
                    WHERE Pid = {Tmp.Pid}";
            }

            int i = Db.ExecuteNonQuery(sql);

            if (Tmp.Pid == -1)
            {
                string getIdSql = $"SELECT MAX(Pid) FROM T_Product WHERE Pname = N'{Tmp.Pname}'";
                Tmp.Pid = Convert.ToInt32(Db.ExecuteScalar(getIdSql));
            }

            Db.Close();
            return i;
        }

        public static int DeleteById(int Pid)
        {
            DbContext Db = new DbContext();
            string sql = $"DELETE FROM T_Product WHERE Pid = {Pid}";
            int i = Db.ExecuteNonQuery(sql);
            Db.Close();
            return i;
        }
    }
}
