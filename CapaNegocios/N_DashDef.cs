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
    public class N_DashDef
    {
        private readonly D_DashDefi d_dashDefi = new D_DashDefi();
        public static DataTable mostrar(string ano)
        {
            return new D_DashDefi().TablaDatos(ano);
        }
        public void MostrarResultados(E_DashboardDef ObjetoEntidad, string ano)
        {
            d_dashDefi.Grafiica1(ObjetoEntidad, ano);
            d_dashDefi.Grafiica2(ObjetoEntidad, ano);
            
            
        }
        public void MostrarLbl1(E_DashboardDef ObjetoEntidad, string ano)
        {
            d_dashDefi.Labeel1(ObjetoEntidad, ano);
            string str = "";
            
        }
        public void MostrarLbl2(E_DashboardDef ObjetoEntidad, string ano)
        {
            d_dashDefi.Labeel2(ObjetoEntidad, ano);
            string str = "";
            
        }
    }
}
