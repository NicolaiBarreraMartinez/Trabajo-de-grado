using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_DashMaterias
    {
        //ATRIBUTOS Y PROPIEDADES
        public ArrayList Materias { get; set; } = new ArrayList();
        public ArrayList cantidadMaterias { get; set; } = new ArrayList();
        public ArrayList Promedios { get; set; } = new ArrayList();
        public ArrayList cantidadPromedios { get; set; } = new ArrayList();

        public ArrayList anos { get; set; } = new ArrayList();
        public ArrayList PromedioHistorico  { get; set; } = new ArrayList();


    }
}
