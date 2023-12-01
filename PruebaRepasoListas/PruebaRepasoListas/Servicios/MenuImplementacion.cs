using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Servicios
{
    internal class MenuImplementacion: MenuInterfaz
    {

        //Metodo encargado de mostrar al usuario por pantalla, el menu Principal. Este menu contiene, todas las opciones que puede seleccionar
        public int menuPrincipal() {

            Console.WriteLine("Seleccione un Opcion");
            Console.WriteLine("0 -> Cerrar Aplicacion");
            Console.WriteLine("1 -> Darse de Alta como Cliente");
            Console.WriteLine("2 -> Eliminar un Cliente (DNI)");
            Console.WriteLine("3 -> Creacion de una nueva cuenta Bancaria");
            Console.WriteLine("4 -> Eliminar una cuenta Bancaria Existente");
            Console.WriteLine("---------------------------------------------");          
            Console.WriteLine("5 -> Ver datos de los Clientes");
            Console.WriteLine("6 -> Ver datos de las cuentas Bancarias");
            Console.WriteLine("---------------------------------------------");
            int seleccionMenuUsu = Convert.ToInt32(Console.ReadLine());
            return seleccionMenuUsu;

        }

        public string pedirDNI()
        {

            Console.WriteLine("Introduza el DNI del Cliente");
            string dniCliente = Console.ReadLine();
            return dniCliente;



        }





    }
}
