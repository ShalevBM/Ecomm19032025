using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
	public class User
	{
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Uemail { get; set; }
        public string Upassl { get; set; }

        public static User GetById(int Uid)
        {
            return UserDAL.GetById(Uid);
        }
        public static List <User> GetAll()
        {
            return UserDAL.GetAll();
        }
        public int Save()
        {
            return 0;
        }
        public static int DeleteById(int Uid)
        {
            return UserDAL.DeleteById(Uid);
        }
    }
}