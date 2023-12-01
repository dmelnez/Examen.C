using PruebaRepasoListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Servicios
{

    /// <summary>
    /// Interfaz encargada de los metodos relacionados con los clientes
    /// </summary>
    internal interface ClienteInterfaz
    {


        /// <summary>
        /// Metodo encargado de dar de alta un nuevo cliente. 
        /// Se pediran los datos personales al usuario, y se creara una nueva cuenta con los datos correspondientes a ese usuario
        /// </summary>
        /// <param name="listaAntigua"></param>
        /// <returns>nuevoCliente</returns>


        public AltaClientes darAltaCliente(List<AltaClientes> listaAntigua);


        /// <summary>
        /// Metodo encargado de la Eliminacion de un cliente en el sistema.
        /// Se solicitara al Cliente el DNI, y se recorrera la lista de los clientes hasta llegar a la posicion
        /// </summary>
        public AltaClientes eliminarCliente(List<AltaClientes>listaAntigua);


    }
}
