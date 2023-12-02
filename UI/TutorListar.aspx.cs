using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
namespace UI
{
    public partial class TutorListar : Utilidades
    {
        private TutorBL tutorBL = new TutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                if ((User.Identity.Name == "admin2@gmail.com") || (User.IsInRole("ADMIN")))
                {
                    gvTutor.DataSource = tutorBL.FindAll_DataTable();
                    gvTutor.DataBind();
                }
                else
                {
                    MsgBox("Error, usted no tiene autorización ");
                }
            }
            else
            {
                MsgBox("Error, usted no ha iniciado sesión");
            }

        }
        protected void gvTutores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTutor.PageIndex = e.NewPageIndex;

            gvTutor.DataSource = tutorBL.FindAll_DataTable();
            gvTutor.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id_tutor = Convert.ToInt32(txtID.Text);
            Response.Redirect("~/TutorEditar.aspx?param=" + id_tutor);
        }
    }
}