﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025.AdminManage
{
    public partial class ProductAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // התנאי מתבצע רק בטעינה הראשונה ולא אחרי לחיצה על כפתור
            {
                string Pid = Request["Pid"] + ""; // מקבל את מזהה המוצר מהשורת כתובת אם יש
                Product p = null; // מגדיר משתנה שיחזיק את המוצר

                if (!string.IsNullOrEmpty(Pid)) // אם יש מזהה מוצר בכתובת
                {
                    p = Product.GetById(int.Parse(Pid)); // מביא את המוצר לפי מזהה
                }
                // קודם כל ממלא את רשימת הקטגוריות
                List<Category> LstCat = Category.GetAll(); // מביא את כל הקטגוריות מהמסד
                DDLCategory.DataSource = LstCat; // קובע את המקור נתונים של ה-DropDown
                DDLCategory.DataValueField = "Cid"; // קובע את השדה שישמש כערך
                DDLCategory.DataTextField = "CName"; // קובע את השדה שיוצג למשתמש
                DDLCategory.DataBind(); // טוען את הנתונים לרשימה

                if (p != null) // אם נמצא מוצר (לא חדש)
                {
                    TxtPName.Text = p.Pname; // ממלא את שם המוצר
                    TxtPdesc.Text = p.Pdesc; // ממלא את תיאור המוצר
                    TxtPrice.Text = p.Price + ""; // ממלא את המחיר
                    DDLStatus.SelectedValue = p.Status + " ";// ממלא את שם הקובץ של התמונה
                    HidPid.Value = p.Pid + ""; // שם את מזהה המוצר בשדה מוסתר

                    // אם הקטגוריה קיימת ברשימה, קובעת אותה כבחירה
                    if (DDLCategory.Items.FindByValue(p.Cid + "") != null)
                    {
                        DDLCategory.SelectedValue = p.Cid + ""; // בוחר את הקטגוריה של המוצר
                    }
                }
                else
                {
                    HidPid.Value = "-1"; // אם לא נמצא מוצר – נחשב כמוצר חדש
                }

            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string x = GlobFunc.GetRandStr(6);
            string Picname = "";
            if (UplPic.HasFile)
            {
                string FileName = GlobFunc.GetRandStr(8);
                int ind = UplPic.FileName.LastIndexOf('.');
                string Ext=UplPic.FileName.Substring(ind);
                Picname=FileName+Ext;
                UplPic.SaveAs(Server.MapPath("/Uploads/Prods/img/" + Picname));
                TxtPicname.Text = Picname;
            }
            Product p = new Product()
            {
                Pid = int.Parse(HidPid.Value),
                Pdesc = TxtPdesc.Text,
                Price = float.Parse(TxtPrice.Text),
                Pname = TxtPName.Text,
                Picname= TxtPicname.Text,
                Status = int.Parse(DDLStatus.SelectedValue)
            };
            p.Save();
            Response.Redirect("ProductList.aspx");

        }
    }
}