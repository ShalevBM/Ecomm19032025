using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
	public class Product
	{
		public int Pid { get; set; }
		public string Pname { get; set; }
		public float Price { get; set; }
		public string Picname { get; set; }
		public string Pdesc { get; set; }
		public int Cid { get; set; }

	    public static Product GetById(int Pid)
	    {
			return ProductDAL.GetById(Pid);
	    }
		public static List<Product> GetAll()
		{
			return ProductDAL.GetAll();
		}
		public int Save()
		{
			return 0;
		}
		public static int DeleteById(int Pid)
		{
			return ProductDAL.DeleteById(Pid);
		}



	}
}