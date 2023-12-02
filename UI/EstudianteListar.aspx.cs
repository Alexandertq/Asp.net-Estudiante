using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;
namespace UI
{
    public partial class EstudianteListar : Utilidades
    {
        private EstudianteBL estudianteBL = new EstudianteBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                if ((User.Identity.Name == "admin3@gmail.com") || (User.IsInRole("ADMIN")))
                {
                    gvEstudiante.DataSource = estudianteBL.FindAll_DataTable();
                    gvEstudiante.DataBind();
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
        protected void gvEstudiantes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEstudiante.PageIndex = e.NewPageIndex;

            gvEstudiante.DataSource = estudianteBL.FindAll_DataTable();
            gvEstudiante.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idEstudiante = Convert.ToInt32(txtID.Text);
            Response.Redirect("~/EstudianteEditar.aspx?param=" + idEstudiante);
        }
    }
}