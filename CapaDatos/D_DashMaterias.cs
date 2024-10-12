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
    public class D_DashMaterias
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //variables de uso
        SqlCommand command;
        SqlDataReader dataReader;

        //Metodos
        public void PeoresMaterias(E_DashMaterias ObjetoEntidad, string ano)
        {
            string queryMaterias = "select TOP 9 Asignatura, cast(avg(Acumulado)as decimal(10,2)) as Acumulado from VistaMaterias where Acumulado > 1 AND ano =" + ano + " group by ASIGNATURA,ANO order by Acumulado ";
            command = new SqlCommand(queryMaterias, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                
                ObjetoEntidad.Materias.Add(dataReader[0]);
                ObjetoEntidad.cantidadMaterias.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }
        public void MejoresMaterias(E_DashMaterias ObjetoEntidad, string ano)
        {
            string queryString = "select TOP 9 Asignatura, cast(avg(Acumulado)as decimal(10,2)) as Acumulado from VistaMaterias where Acumulado > 1 AND ano =" + ano + " group by ASIGNATURA,ANO order by Acumulado desc";
            command = new SqlCommand(queryString, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Promedios.Add(dataReader[0]);
                ObjetoEntidad.cantidadPromedios.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }

        public void HistoricoMaterias(E_DashMaterias ObjetoEntidad, string nombre)
        {
            string queryMaterias = "select top 6  ano, cast(avg(Acumulado)as decimal(10,2)) as Acumulado from VistaMaterias where Acumulado > 1  AND ASIGNATURA = '" + nombre + "' group by ASIGNATURA,ANO order by ano desc";
            command = new SqlCommand(queryMaterias, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.anos.Add(dataReader[0]);
                ObjetoEntidad.PromedioHistorico.Add(dataReader[1]);
            }
            dataReader.Close();
            conectar.Close();
        }
    }


    }
