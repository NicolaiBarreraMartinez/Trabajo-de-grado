using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_DashCursos
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        //variables de uso
        SqlCommand command;
        SqlDataReader dataReader;

        //Metodos
        public void PeoresMaterias(E_DashCursos ObjetoEntidad, string ano)
        {
            string queryString = "select TOP 5 NOMGRADO, cast(avg(Acumulado)as decimal(10,2)) as Acumulado from VistaCursos where Acumulado > 1 AND ANO = " + ano + "group by NOMGRADO,ANO order by Acumulado;";
            command = new SqlCommand(queryString, conectar)
            {

            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Cursos.Add(dataReader[0]);
                ObjetoEntidad.Promedios.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }
        public void MejoresMaterias(E_DashCursos ObjetoEntidad, string ano)
        {
            string queryString = "select TOP 5 NOMGRADO, cast(avg(Acumulado)as decimal(10,2)) as Acumulado from VistaCursos where Acumulado > 1 AND ANO = " + ano + " group by NOMGRADO,ANO order by Acumulado desc;";
            command = new SqlCommand(queryString, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.cantidadCursos.Add(dataReader[0]);
                ObjetoEntidad.cantidadPromedios.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }

        public void CursoEspecifico(E_DashCursos ObjetoEntidad, string curso, string ano)
        {
            string queryCursos = "select GRUPO, cast(avg(Acumulado)as decimal(10,2)) as Acumulado from VistaCursos where Acumulado > 1 AND ANO = " + ano + " AND NOMGRADO = '"+ curso + "' group by GRUPO,ANO order by Acumulado desc;";
            command = new SqlCommand(queryCursos, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.cantidadGrupos.Add(dataReader[0]);
                ObjetoEntidad.promedioCurso.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }



    }
}