using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocios
{
    public class N_Alertas
    {
        private readonly D_Alertas d_Alertas = new D_Alertas();

        public static DataTable mostrar()
        {
            return new D_Alertas().TablaDatos();
        }
        public void MostrarResultados(E_Alertas ObjetoEntidad, string codigo)
        {
            d_Alertas.Grafiica1(ObjetoEntidad, codigo);
        }
        public void MostrarLblEdad(E_Alertas ObjetoEntidad, string codigo)
        {
            d_Alertas.LabeelEdad(ObjetoEntidad, codigo);
            

        }
        public void MostrarLblGrado(E_Alertas ObjetoEntidad, string codigo)
        {
            d_Alertas.LabeelGrado(ObjetoEntidad, codigo);
            

        }
        public void MostrarLblSexo(E_Alertas ObjetoEntidad, string codigo)
        {
            d_Alertas.LabeelSexo(ObjetoEntidad, codigo);
           

        }
        public void MostrarLblEstrato(E_Alertas ObjetoEntidad, string codigo)
        {
            d_Alertas.LabeelEstrato(ObjetoEntidad, codigo);
            

        }
    }
}
