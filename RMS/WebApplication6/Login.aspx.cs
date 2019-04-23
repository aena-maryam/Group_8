using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            String email = u_name.Text;
            String password = password_.Text;

            myDAL obj = new myDAL();
            bool result = obj.isValidLogin(email, password);

            if (result == true)
                Server.Transfer("Home.aspx");

            else
                Response.Write("<script>alert('Invalid username or password')</script>");
        }
    }
}