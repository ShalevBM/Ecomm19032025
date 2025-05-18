using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025.AdminManage
{
    public partial class OrdersAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Oid = Request["OrderId"] + ""; // מזהה הזמנה מה-URL
                Orders O = null;

                if (!string.IsNullOrEmpty(Oid))
                {
                    O = Orders.GetById(int.Parse(Oid));
                }

                if (O != null && O.OrderId != 0)
                {
                    TxtTotalPrice.Text = O.TotalPrice + "";
                    TxtTotalAmount.Text = O.TotalAmount + "";
                    TxtUid.Text = O.Uid + "";
                    DDLStatus.SelectedValue = O.Status + "";
                    HidPid.Value = O.OrderId + "";
                }
                else
                {
                    HidPid.Value = "-1"; // הזמנה חדשה
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Orders O = new Orders()
            {
                OrderId = int.Parse(HidPid.Value),
                Uid = int.Parse(TxtUid.Text),
                TotalPrice = float.Parse(TxtTotalPrice.Text),
                TotalAmount = float.Parse(TxtTotalAmount.Text),
                Status = DDLStatus.SelectedValue
            };
            O.Save();
            Response.Redirect("OrdersList.aspx");
        }

    }
      
}