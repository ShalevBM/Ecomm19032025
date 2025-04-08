using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
	public class Category
	{
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cdesc { get; set; }

        public static Category GetById(int Cid)
        {
            return CategoryDAL.GetById(Cid);
        }
        public static List<Category> GetAll()
        {
            return CategoryDAL.GetAll();
        }
        public int Save()
        {
            return 0;
        }
        public static int DeleteById(int Cid)
        {
            return CategoryDAL.DeleteById(Cid);
        }
    }
}