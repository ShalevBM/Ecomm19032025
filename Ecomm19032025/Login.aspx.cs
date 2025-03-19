using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "abc" && TxtPass.Text == "123")
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}