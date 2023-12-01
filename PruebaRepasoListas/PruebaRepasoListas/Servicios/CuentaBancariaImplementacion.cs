using PruebaRepasoListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Servicios
{
    internal class CuentaBancariaImplementacion : CuentasBancariasInterfaz
    {

        public AltaCuentaBancaria nuevaCuentaBancaria(List<AltaCuentaBancaria> listaAntigua)
        {
            AltaCuentaBancaria nuevaCuentaBancaria = new AltaCuentaBancaria();

            Console.WriteLine("Introduzca los datos para la cuenta bancaria");

            Console.WriteLine("ID Cliente");
            nuevaCuentaBancaria.IdCuentaBancaria = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("IsBan");
            nuevaCuentaBancaria.IsBan = Console.ReadLine();

            Console.WriteLine("Fecha de Alta");
            nuevaCuentaBancaria.FechaDeAlta = Console.ReadLine();

            listaAntigua.Add(nuevaCuentaBancaria);


            return nuevaCuentaBancaria;

        }

    }
}
