using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TutorBE
    {
        public TutorBE() { }

        public int id_tutor { get; set; }

        public string nombre_tutor { get; set; }

        public string relacion { get; set; }

        public TutorBE(int id_tutor, string nombre_tutor, string relacion)
        {
            this.id_tutor = id_tutor;
            this.nombre_tutor = nombre_tutor;
            this.relacion = relacion;
        }

        public TutorBE(string nombre_tutor, string relacion)
        {
            this.nombre_tutor = nombre_tutor;
            this.relacion = relacion;
        }
    }
}
