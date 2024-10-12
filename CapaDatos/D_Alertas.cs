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
    public class D_Alertas
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        //variables de uso
        SqlCommand command;
        SqlDataReader dataReader;
        public void Grafiica1(E_Alertas ObjetoEntidad, string codigo)
        {
            string querySting = "select top 4 ano, cast(PromedioFinal as decimal (10,2)) from auxcluster where estudiante ="+codigo+" order by ano desc";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Grafica1x.Add(dataReader[0]);
                ObjetoEntidad.Grafica1y.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }

        public DataTable TablaDatos()
        {
            DataTable dt = new DataTable();
            string querySting = "select ESTUDIANTE, TipoAlterta from auxCluster where ano = 2021 and TipoAlterta is not null";

            command = new SqlCommand(querySting, conectar)
            {
            };
            SqlDataAdapter sqlDat = new SqlDataAdapter(command);
            sqlDat.Fill(dt);
            return dt;
        }
        public void LabeelEdad(E_Alertas ObjetoEntidad, string codigo)
        {
            string querySting = "select Edad from tablaclusterfinal1 where ESTUDIANTE =" + codigo + "and ANO = 2021";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.edad = dataReader[0].ToString();
            }
            dataReader.Close();
            conectar.Close();
        }
        public void LabeelEstrato(E_Alertas ObjetoEntidad, string codigo)
        {
            string querySting = "select ESTRATO from tablaclusterfinal1 where ESTUDIANTE =" + codigo + "and ANO = 2021";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.estrato = dataReader[0].ToString();
            }
            dataReader.Close();
            conectar.Close();
        }
        public void LabeelSexo(E_Alertas ObjetoEntidad, string codigo)
        {
            string querySting = "select Sexo from tablaclusterfinal1 where ESTUDIANTE =" + codigo + "and ANO = 2021";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.sexo = dataReader[0].ToString();
            }
            dataReader.Close();
            conectar.Close();
        }

        public void LabeelGrado(E_Alertas ObjetoEntidad, string codigo)
        {
            string querySting = "select NOMGRADO from tablaclusterfinal1 where ESTUDIANTE =" + codigo + "and ANO = 2021";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.grado = dataReader[0].ToString();
            }
            dataReader.Close();
            conectar.Close();
        }
        

    }
}
