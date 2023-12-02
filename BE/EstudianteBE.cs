using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EstudianteBE
    {
        public int id_estudiante { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }
       
        public DateTime fecha_nacimiento { get; set; }

        public string direccion { get; set; }

        public string email { get; set; }

        public int tutor_id { get; set; }

        public EstudianteBE(int id_estudiante, string nombre, string apellido, DateTime fecha_nacimiento, string direccion, string email, int tutor_id)
        {
            this.id_estudiante = id_estudiante;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.direccion = direccion;
            this.email = email;
            this.tutor_id = tutor_id;
        }

        public EstudianteBE(string nombre, string apellido, DateTime fecha_nacimiento, string direccion, string email, int tutor_id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.direccion = direccion;
            this.email = email;
            this.tutor_id = tutor_id;
        }
        public EstudianteBE()
        {
        }
    }
}
