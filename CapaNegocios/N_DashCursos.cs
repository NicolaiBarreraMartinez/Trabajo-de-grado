using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocios
{
    public class N_DashCursos
    {
        private readonly D_DashCursos d_DashCursos = new D_DashCursos();

        public void MostrarResultados(E_DashCursos ObjetoEntidad, string ano)
        {
            d_DashCursos.PeoresMaterias(ObjetoEntidad, ano);
            d_DashCursos.MejoresMaterias(ObjetoEntidad, ano);
        }


        public void MostrarCurso(E_DashCursos ObjetoEntidad, string curso, string ano)
        {
            d_DashCursos.CursoEspecifico(ObjetoEntidad, curso, ano);
        }

    }
}