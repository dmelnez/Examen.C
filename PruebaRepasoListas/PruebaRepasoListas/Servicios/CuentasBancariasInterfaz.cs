using PruebaRepasoListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Servicios
{
    internal interface CuentasBancariasInterfaz
    {
        /// <summary>
        /// Metodo encargado de solicitar los datos al cliente y la creacion de una nueva cuenta bancaria
        /// </summary>
        /// <param name="listaAntigua"></param>
        /// <returns>nuevaCuentaBancaria</returns>
        public AltaCuentaBancaria nuevaCuentaBancaria(List<AltaCuentaBancaria> listaAntigua);
    }
}
