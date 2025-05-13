using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025.AdminManage
{
    public partial class UserAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // התנאי מתבצע רק בטעינה הראשונה ולא אחרי לחיצה על כפתור
            {
                string Uid = Request["Uid"] + ""; // מקבל את מזהה המוצר מהשורת כתובת אם יש
                Users U = null; // מגדיר משתנה שיחזיק את המוצר

                if (!string.IsNullOrEmpty(Uid)) // אם יש מזהה מוצר בכתובת
                {
                    U = Users.GetById(int.Parse(Uid)); // מביא את המוצר לפי מזהה
                }
                if (U != null) // אם נמצא מוצר (לא חדש)
                {
                    TxtFullName.Text = U.FullName; 
                    TxtPass.Text = U.Pass; 
                    TxtEmail.Text = U.Email; 
                    TxtPhone.Text = U.Phone;
                    TxtAddress.Text = U.Address;
                    DDLStatus.SelectedValue = U.Status + " ";
                    HidPid.Value = U.Uid + "";

                }
                else
                {
                    HidPid.Value = "-1"; // אם לא נמצא מוצר – נחשב כמוצר חדש
                }

            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Users U = new Users()
            {
                Uid = int.Parse(HidPid.Value),
                FullName = TxtFullName.Text,
                Pass = TxtPass.Text,
                Email = (TxtEmail.Text),
                Phone = TxtPhone.Text,
                Address = TxtAddress.Text,
                Status = int.Parse(DDLStatus.SelectedValue)
            };
            U.Save();
            Response.Redirect("UserList.aspx");

        }
    }
}