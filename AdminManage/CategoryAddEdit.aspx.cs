using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025.AdminManage
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Cid = Request["Cid"] + ""; // מזהה הזמנה מה-URL
                Category C = null;

                if (!string.IsNullOrEmpty(Cid))
                {
                    C = Category.GetById(int.Parse(Cid));
                }

                if (C != null && C.Cid != 0)
                {
                    TxtCid.Text = C.Cid + "";
                    TxtCName.Text = C.CName + "";
                    HidPid.Value = C.Cid + "";
                }
                else
                {
                    HidPid.Value = "-1"; // הזמנה חדשה
                }
            }
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Category C = new Category()
            {
                Cid = int.Parse(HidPid.Value),
                CName = (TxtCName.Text)
            };
            C.Save();
            Response.Redirect("CategoryList.aspx");
        }
    }
}