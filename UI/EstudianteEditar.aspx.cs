using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using BE;
namespace UI
{
    public partial class EstudianteEditar : System.Web.UI.Page
    {
        private EstudianteBL estudianteBL = new EstudianteBL();
        private TutorBL tutorBL = new TutorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id_estudiante = Convert.ToInt32(Request.QueryString["param"]);

                //busqueda
                EstudianteBE estudianteBE = estudianteBL.FindById(id_estudiante);

                //imprimir
                txtIdEstudiante.Text = estudianteBE.id_estudiante.ToString();
                txtNombre.Text = estudianteBE.nombre;
                txtApellido.Text = estudianteBE.apellido;
                txtFechaNacimiento.Text = estudianteBE.fecha_nacimiento.ToString();
                txtDireccion.Text = estudianteBE.direccion.ToString();
                txtEmail.Text = estudianteBE.email.ToString();
                ddlTutor.Text = estudianteBE.tutor_id.ToString();

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

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            int id_estudiante = Convert.ToInt32(txtIdEstudiante.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fecha_nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;
            int tutor_id = Convert.ToInt32(ddlTutor.Text);

            EstudianteBE estudianteBE = new EstudianteBE(id_estudiante, nombre, apellido, fecha_nacimiento, direccion, email, tutor_id);
            estudianteBL.Update(estudianteBE);

            Response.Redirect("~/EstudianteListar.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int id_estudiante = Convert.ToInt32(txtIdEstudiante.Text);

            //PROCESO
            estudianteBL.Delete(id_estudiante);

            //SALIDA
            Response.Redirect("~/EstudianteListar.aspx");

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EstudianteListar.aspx");
        }
    }
}