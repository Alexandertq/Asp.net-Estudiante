using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DB;

using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class EstudianteBL
    {
        public void Insert(EstudianteBE estudianteBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL INSERT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "INSERT INTO Estudiantes(nombre,apellido,fecha_nacimiento,direccion,email,tutor_id) " +
                                     "VALUES(@nombre,@apellido,@fecha_nacimiento,@direccion,@email,@tutor_id)";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@nombre", estudianteBE.nombre);
                sqlCMD.Parameters.AddWithValue("@apellido", estudianteBE.apellido);
                sqlCMD.Parameters.AddWithValue("@fecha_nacimiento", estudianteBE.fecha_nacimiento);
                sqlCMD.Parameters.AddWithValue("@direccion", estudianteBE.direccion);
                sqlCMD.Parameters.AddWithValue("@email", estudianteBE.email);
                sqlCMD.Parameters.AddWithValue("@tutor_id", estudianteBE.tutor_id);

                //Ejecutar SQL Insert
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }
        public void Update(EstudianteBE estudianteBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                
                sqlConn.Open();

                //preparar SQL UPDATE
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "update Estudiantes set nombre=@nombre,apellido=@apellido,fecha_nacimiento=@fecha_nacimiento,direccion=@direccion,email=@email,tutor_id=@tutor_id " +
                                     "where id_estudiante=@id_estudiante";

                //cargar parámetros
                sqlCMD.Parameters.AddWithValue("@nombre", estudianteBE.nombre);
                sqlCMD.Parameters.AddWithValue("@apellido", estudianteBE.apellido);
                sqlCMD.Parameters.AddWithValue("@fecha_nacimiento", estudianteBE.fecha_nacimiento);
                sqlCMD.Parameters.AddWithValue("@direccion", estudianteBE.direccion);
                sqlCMD.Parameters.AddWithValue("@email", estudianteBE.email);
                sqlCMD.Parameters.AddWithValue("@tutor_id", estudianteBE.tutor_id);
                sqlCMD.Parameters.AddWithValue("@id_estudiante", estudianteBE.id_estudiante);

                //ejecutar SQL UPDATE
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public void Delete(int id_estudiante)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //preparar SQL DELETE
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "delete from Estudiantes where id_estudiante=@id_estudiante";

                //cargar parámetros
                sqlCMD.Parameters.AddWithValue("@id_estudiante", id_estudiante);

                //ejecutar SQL DELETE
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public EstudianteBE FindById(int id_estudiante)
        {
            EstudianteBE estudianteBE = null;

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //preparar SQL SELECT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "select * from Estudiantes where id_estudiante=@id_estudiante";

                //cargar parámetros
                sqlCMD.Parameters.AddWithValue("@id_estudiante", id_estudiante);

                //ejecutar SQL DELETE
                SqlDataReader sqlDR = sqlCMD.ExecuteReader();

                if (sqlDR.Read())
                {
                    estudianteBE = new EstudianteBE();

                    estudianteBE.id_estudiante = sqlDR.GetInt32(0);
                    estudianteBE.nombre = sqlDR.GetString(1);
                    estudianteBE.apellido = sqlDR.GetString(2);
                    estudianteBE.fecha_nacimiento = sqlDR.GetDateTime(3);
                    estudianteBE.direccion = sqlDR.GetString(4);
                    estudianteBE.email = sqlDR.GetString(5); ;
                    estudianteBE.tutor_id = sqlDR.GetInt32(6);
                }

                sqlConn.Close();
            }

            return estudianteBE;
        }

        public DataTable FindAll_DataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                string SQL = "select * from VistaEstudiante";

                SqlDataAdapter sqlDA = new SqlDataAdapter(SQL, sqlConn);
                sqlDA.Fill(dataTable);

                sqlConn.Close();
            }

            return dataTable;
        }



        public DataTable FindAllDD(string relacion)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                //Preparar SQL Select
                string query = "select * from estuxtutor where relacion=@relacion";

                SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                da.SelectCommand.Parameters.AddWithValue("@relacion", relacion);

                //Ejecutar SQL Select y llenar DataTable
                da.Fill(dt);
            }

            return dt;
        }

    }
}
