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
    public partial class EstudianteRegistrar : System.Web.UI.Page
    {
        private EstudianteBL estudianteBL = new EstudianteBL();
        private TutorBL tutorBL = new TutorBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.LoadTutores();
            }
        }
        public void LoadTutores()
        {
            ddlTutor.DataSource = tutorBL.FindAll();
            ddlTutor.DataValueField = "id_tutor";
            ddlTutor.DataTextField = "nombre_tutor";
            ddlTutor.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fecha_nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;
            int tutor_id = Convert.ToInt32(ddlTutor.Text);

            EstudianteBE estudianteBE = new EstudianteBE(nombre, apellido, fecha_nacimiento, direccion, email, tutor_id);
            estudianteBL.Insert(estudianteBE);

            Response.Redirect("~/EstudianteListar.aspx"); 
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EstudianteListar.aspx");
        }
    }
}