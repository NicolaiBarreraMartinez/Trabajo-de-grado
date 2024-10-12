using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_DashMaterias
    {
        private readonly D_DashMaterias d_DashMaterias = new D_DashMaterias();
        public void MostrarResultados(E_DashMaterias ObjetoEntidad, string ano)
        {
            d_DashMaterias.PeoresMaterias(ObjetoEntidad, ano);
            d_DashMaterias.MejoresMaterias(ObjetoEntidad, ano);

        }

        public void Mostrarfechas(E_DashMaterias ObjetoEntidad, string materia)
        {
            d_DashMaterias.HistoricoMaterias(ObjetoEntidad, materia);
        }

    }
}