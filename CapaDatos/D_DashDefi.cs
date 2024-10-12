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
    public class D_DashDefi
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        //variables de uso
        SqlCommand command;
        SqlDataReader dataReader;
        E_DashboardDef DTO = new E_DashboardDef();
        //Metodos
        public void Grafiica1(E_DashboardDef ObjetoEntidad, string ano)
        {
            string querySting = "select categoria, count(categoria) as cantidad from auxcluster1 where ano ="+ano+ " and numgrado >= 7 group by categoria order by cantidad desc";

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

        public void Grafiica2(E_DashboardDef ObjetoEntidad, string ano)
        {
            string querySting = "select categoria, count(categoria) as cantidad from auxcluster1 where ano =" + ano + " and numgrado < 7 group by categoria order by cantidad desc";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.Grafica2x.Add(dataReader[0]);
                ObjetoEntidad.Grafica2y.Add(dataReader[1]);
                
            }
            dataReader.Close();
            conectar.Close();

        }
        public DataTable TablaDatos(string ano)
        {
            DataTable dt = new DataTable();
            string querySting = "select NOMGRADO,cast((AVG(PROMEDIO1)) as decimal(10,2)) as Promedio1,cast((AVG(PROMEDIO2)) as decimal(10,2)) as Promedio2, cast((AVG(PROMEDIO3)) as decimal(10, 2)) as Promedio3, cast((AVG(PROMEDIO4)) as decimal(10, 2)) as Promedio4 from TablaCursos where ano = "+ano+" GROUP BY NOMGRADO,ANO,Numero order by Numero asc";

            command = new SqlCommand(querySting, conectar)
            {
            };
            SqlDataAdapter sqlDat = new SqlDataAdapter(command);
            sqlDat.Fill(dt);
            return dt;
        }

        public void Labeel1(E_DashboardDef ObjetoEntidad, string ano)
        {
            string querySting = "Select  count(ESTUDIANTE) as cantidad  from VistaEstudiantesIndividual where Retirado = ANO AND Retirado != 'No' and ANO = "+ano+" group by ANO";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.TOTALPERDIDOS = dataReader[0].ToString();
            }
            dataReader.Close();
            conectar.Close();
        }
        public void Labeel2(E_DashboardDef ObjetoEntidad, string ano)
        {
            int resta = Int32.Parse(ano) - 1;
            
            string querySting = "Select  count(ESTUDIANTE) as cantidad  from VistaEstudiantesIndividual where Retirado = ANO AND Retirado != 'No' and ANO = " + resta.ToString() + " group by ANO";

            command = new SqlCommand(querySting, conectar)
            {
            };
            conectar.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ObjetoEntidad.TOTALPERDIDOSPASADO = dataReader[0].ToString();
            }
            dataReader.Close();
            conectar.Close();
        }
    }
}
