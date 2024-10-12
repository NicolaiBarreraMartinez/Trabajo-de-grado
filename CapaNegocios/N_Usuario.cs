using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Usuario
    {
        readonly D_usuario ObjCiudades = new D_usuario();

        public static DataTable MostrarUsuarios()
        {
            return new D_usuario().MostrarUsuarios();  
        }

        public String verificarConexion()
        {
            return ObjCiudades.verificarConexion();
        }

    }
}
