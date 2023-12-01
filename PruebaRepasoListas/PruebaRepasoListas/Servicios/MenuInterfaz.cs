using PruebaRepasoListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Servicios
{
    /// <summary>
    /// Interfaz encargada de los metodos relacionados con el menu Principal
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el Menu Principal al usuario
        /// Recogera El valor Introducido por el usuario, y lo devolvera al Main
        /// </summary>
        /// <returns></returns>
        public int menuPrincipal();

        /// <summary>
        /// Metodo encarhado de solicitar al Cliente el DNI.
        /// </summary>
        /// <returns></returns>
        public string pedirDNI();
    }
}
