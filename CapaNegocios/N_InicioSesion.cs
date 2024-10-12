using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
namespace CapaNegocios
{
    public class N_InicioSesion
    {
        readonly D_inicioSesion ObjInisioSesion = new D_inicioSesion();
        public Boolean IniciioSesion(string nombre, string pass)
        {
            return ObjInisioSesion.InicioSesion(nombre, pass);
        }


    }
}
