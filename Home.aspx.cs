using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    
    public partial class Home : System.Web.UI.Page
    {
        HttpCookie cookie = new HttpCookie("Dati_Utente");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["Dati_Utente"]!=null)
            {
                Response.Redirect("~/Login.aspx");
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            cookie.Values["username"] = txtLogin.Text;
            cookie.Values["password"] = txtPassw.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Login.aspx");
        }
    }
}