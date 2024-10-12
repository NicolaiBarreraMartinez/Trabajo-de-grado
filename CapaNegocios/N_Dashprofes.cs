using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Dashprofes
    {
        private readonly D_DashProfes d_DashProfes = new D_DashProfes();
        public void MostrarResultados(E_DashProfes ObjetoEntidad,string ano)
        {
            d_DashProfes.PeoresProfes(ObjetoEntidad, ano);
            d_DashProfes.MejoresProfes(ObjetoEntidad,ano);

        }

        public void MostrarHistoricoProfes(E_DashProfes ObjetoEntidad, string ano, string profe)
        {
            d_DashProfes.ProfeEspecifico(ObjetoEntidad, ano, profe);
        }
    }
}
