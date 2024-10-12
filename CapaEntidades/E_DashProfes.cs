using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_DashProfes
    {
        public ArrayList Mprofes { get; set; } = new ArrayList();
        public ArrayList MPromedios { get; set; } = new ArrayList();
        public ArrayList Pprofes { get; set; } = new ArrayList();
        public ArrayList Ppromedios { get; set; } = new ArrayList();

        public ArrayList Materias   { get; set; } = new ArrayList();

        public ArrayList PromedioMateria    { get; set; } = new ArrayList();
    }
}
