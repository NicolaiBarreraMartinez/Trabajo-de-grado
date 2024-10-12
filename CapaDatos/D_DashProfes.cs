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
    public class D_DashProfes
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        //variables de uso
        SqlCommand command;
        SqlDataReader dataReader;

        //Metodos

        public void PeoresProfes(E_DashProfes ObjetoEntidad, string ano)
        {
            string querySting = "select TOP 9 replace(PROFESOR, ' ', ' ') , cast(avg(Acumulado) as decimal(10, 2)) as Acumulado from VistaProfesores where Acumulado != 0 AND ano = "+ano+" group by replace(PROFESOR, ' ', ' '), ANO order by Acumulado;";
            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Pprofes.Add(dataReader[0]);
                ObjetoEntidad.Ppromedios.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }
        public void MejoresProfes(E_DashProfes ObjetoEntidad, string ano)
        {
            string querySting = "select TOP 9 replace(PROFESOR, ' ', ' ') , cast(avg(Acumulado) as decimal(10, 2)) as Acumulado from VistaProfesores where Acumulado != 0 AND ano = " + ano + " group by replace(PROFESOR, ' ', ' '), ANO order by Acumulado desc;";
            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Mprofes.Add(dataReader[0]);
                ObjetoEntidad.MPromedios.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }

        public void ProfeEspecifico(E_DashProfes ObjetoEntidad, string ano, string nombre)
        {
            string queryProfes = "select TOP (9) ASIGNATURA, Acumulado from VistaProfesores where replace(PROFESOR, ' ', ' ') like '" + nombre + "%' AND ANO = " + ano +";";
            command = new SqlCommand(queryProfes, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Materias.Add(dataReader[0]);
                ObjetoEntidad.PromedioMateria.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }

    }
 }
