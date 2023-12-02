using BE;
using DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BL
{
    public class TutorBL
    {
        public void Insert(TutorBE tutorBE)
        {

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //Preparar SQL INSERT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "insert into Tutores(nombre_tutor,relacion) " +
                                     "values(@nombre_tutor,@relacion)";

                //Cargar parámetros
                sqlCMD.Parameters.AddWithValue("@nombre_tutor", tutorBE.nombre_tutor);
                sqlCMD.Parameters.AddWithValue("@relacion", tutorBE.relacion);


                //Ejecutar SQL Insert
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }

        public void Update(TutorBE tutorBE)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                
                sqlConn.Open();

                //preparar SQL UPDATE
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "update Tutores set nombre_tutor=@nombre_tutor,relacion=@relacion " +
                                     "where id_tutor=@id_tutor";

                //cargar parámetros
                sqlCMD.Parameters.AddWithValue("@nombre_tutor", tutorBE.nombre_tutor);
                sqlCMD.Parameters.AddWithValue("@relacion", tutorBE.relacion);
                sqlCMD.Parameters.AddWithValue("@id_tutor", tutorBE.id_tutor);

                //ejecutar SQL UPDATE
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();

            }
        }

        public void Delete(int id_tutor)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //preparar SQL DELETE
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "delete from Tutores where id_tutor=@id_tutor";

                //cargar parámetros
                sqlCMD.Parameters.AddWithValue("@id_tutor", id_tutor);

                //ejecutar SQL DELETE
                sqlCMD.ExecuteNonQuery();

                sqlConn.Close();
            }
        }
        public DataTable FindAll_DataTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                string SQL = "select * from Tutores";

                SqlDataAdapter sqlDA = new SqlDataAdapter(SQL, sqlConn);
                sqlDA.Fill(dataTable);

                sqlConn.Close();
            }
            return dataTable;
        }

        public TutorBE FindById(int id_tutor)
        {
            TutorBE tutorBE = null;

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //preparar SQL SELECT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "select * from Tutores where id_tutor=@id_tutor";

                //cargar parámetros
                sqlCMD.Parameters.AddWithValue("@id_tutor", id_tutor);

                //ejecutar SQL SELECT
                SqlDataReader sqlDR = sqlCMD.ExecuteReader();

                if (sqlDR.Read())
                {
                    tutorBE = new TutorBE();

                    tutorBE.id_tutor = sqlDR.GetInt32(0);
                    tutorBE.nombre_tutor = sqlDR.GetString(1);
                    tutorBE.relacion = sqlDR.GetString(2);
                }

                sqlConn.Close();
            }

            return tutorBE;
        }

        public List<TutorBE> FindAll()
        {
            List<TutorBE> tutorList = new List<TutorBE>();

            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                //preparar SQL SELECT
                SqlCommand sqlCMD = sqlConn.CreateCommand();
                sqlCMD.CommandText = "select * from Tutores order by id_tutor";

                //ejecutar SQL SELECT
                SqlDataReader sqlDR = sqlCMD.ExecuteReader();

                while (sqlDR.Read())
                {
                    TutorBE tutorBE = new TutorBE();

                    tutorBE.id_tutor = sqlDR.GetInt32(0);
                    tutorBE.nombre_tutor = sqlDR.GetString(1);
                    tutorBE.relacion = sqlDR.GetString(2);


                    tutorList.Add(tutorBE);
                }

                sqlConn.Close();
            }

            return tutorList;
        }
        public bool verificar(int idTutor)
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionDB.SQLServer()))
            {
                sqlConn.Open();

                string query = "SELECT COUNT(*) FROM Estudiantes WHERE tutor_id = @tutorId";
                SqlCommand command = new SqlCommand(query, sqlConn);
                command.Parameters.AddWithValue("@tutorId", idTutor);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }



    }
}
