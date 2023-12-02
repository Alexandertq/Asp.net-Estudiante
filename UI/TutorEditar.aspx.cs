using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class TutorEditar : Utilidades
    {
        private TutorBL tutorBL = new TutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id_tutor = Convert.ToInt32(Request.QueryString["param"]);

                //busqueda
                TutorBE tutorBE = tutorBL.FindById(id_tutor);

                //imprimir
                txtID.Text = tutorBE.id_tutor.ToString();
                txtNombre.Text = tutorBE.nombre_tutor;
                txtRelacion.Text = tutorBE.relacion;
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_tutor = Convert.ToInt32(txtID.Text);
            string nombre_tutor = txtNombre.Text;
            string relacion = txtRelacion.Text;

            TutorBE tutorBE = new TutorBE(id_tutor,nombre_tutor, relacion);
            tutorBL.Update(tutorBE);

            Response.Redirect("~/TutorListar.aspx");
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TutorListar.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int idTutor = Convert.ToInt32(txtID.Text);

            TutorBL tutorBL = new TutorBL();

            if (tutorBL.verificar(idTutor))
            {
                MsgBox("Error, usted no tiene autorización ");
            }
            else
            {
                tutorBL.Delete(idTutor);
                Response.Redirect("~/TutorListar.aspx");
            }
        }
    }
}