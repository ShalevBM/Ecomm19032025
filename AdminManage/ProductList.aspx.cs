using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace Ecomm19032025.AdminManage
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // שלב 1: בדיקה אם יש בקשת מחיקה ב-URL
                string removeId = Request.QueryString["remove"];
                if (!string.IsNullOrEmpty(removeId))
                {
                    int pid;
                    if (int.TryParse(removeId, out pid))
                    {
                        // קריאה לפונקציית מחיקה
                        Product.DeleteById(pid);
                    }

                    // ריענון הדף כדי למחוק את הפרמטר מה-URL ולמנוע מחיקה כפולה ב-F5
                    Response.Redirect("ProductList.aspx");
                    return; // חשוב - שלא ימשיך ויעשה DataBind עם רשימה ישנה
                }

                // שלב 2: טעינת המוצרים
                List<Product> Lst = Product.GetAll();
                RptProds.DataSource = Lst;
                RptProds.DataBind();
            }
        }


    }
}