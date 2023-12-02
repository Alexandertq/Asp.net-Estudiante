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
    public partial class EstutList_xTutor : Utilidades
    {

        private EstudianteBL estudianteBL = new EstudianteBL();
        private TutorBL tutorBL = new TutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    if (User.IsInRole("ADMIN"))
                    {
                        this.LoadTutores();
                        this.LoadEstudiante("Madre");
                    }
                    else
                    {
                        MsgBox("Error, usted no tiene permiso");
                    }
                }
                else
                {
                    MsgBox("Error, usted no ha iniciado sesión");
                }
            }

        }
        public void LoadTutores()
        {
            ddlTutor.DataSource = tutorBL.FindAll();
            ddlTutor.DataValueField = "id_tutor";
            ddlTutor.DataTextField = "relacion";
            ddlTutor.DataBind();
        }

        public void LoadEstudiante(string relacion)
        {
            gvEstudiante.DataSource = estudianteBL.FindAllDD(relacion);
            gvEstudiante.DataBind();
        }

        protected void gvEstudiante_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEstudiante.PageIndex = e.NewPageIndex;

            string relacion = ddlTutor.SelectedItem.Text; 
            this.LoadEstudiante(relacion);
        }

        protected void ddlTutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string relacion = ddlTutor.SelectedItem.Text;
            this.LoadEstudiante(relacion);
        }
    }
}