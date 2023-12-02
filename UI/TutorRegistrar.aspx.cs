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
    public partial class TutorRegistrar : System.Web.UI.Page
    {
        private TutorBL tutorBL = new TutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre_tutor = txtNombre.Text;
            string relacion = txtRelacion.Text;

            TutorBE tutorBE = new TutorBE(nombre_tutor,relacion);
            tutorBL.Insert(tutorBE);

            //SALIDA
            Response.Redirect("~/TutorListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TutorListar.aspx");
        }
    }
}