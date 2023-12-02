using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace UI
{
    public class Utilidades: Page
    {
        public void MsgBox(string text)
        {
            string script = "<script language='javascript'>alert('" + text + "')</script>";
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Mensaje", script);
        }
    }
}