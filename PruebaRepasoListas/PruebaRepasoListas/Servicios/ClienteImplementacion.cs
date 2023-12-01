using PruebaRepasoListas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {


        public AltaClientes darAltaCliente(List<AltaClientes> listaAntigua)
        {

            AltaClientes clienteNuevo = new AltaClientes();



            Console.WriteLine("Se le Solicitar los Datos Personales");
            Console.Write("ID Cliente: ");
            clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Nombre: ");
            clienteNuevo.NombreCliente = Console.ReadLine();

            Console.WriteLine("Apellidos: ");
            clienteNuevo.ApellidoCliente = Console.ReadLine();

            Console.WriteLine("DNI: ");
            clienteNuevo.DniCliente = Console.ReadLine();

            Console.WriteLine("Nº Telefono");
            clienteNuevo.TelefonoCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fecha de Alta");
            clienteNuevo.AltaCliente = Console.ReadLine();

            Console.WriteLine("Fecha de Baja");
            clienteNuevo.BajaCliente = Console.ReadLine();

            listaAntigua.Add(clienteNuevo);


            return clienteNuevo;


        }

        public AltaClientes eliminarCliente(List<AltaClientes>listaAntigua)
        {
            AltaClientes clienteEliminado = new AltaClientes();

            MenuInterfaz me = new MenuImplementacion();

            string dniABuscar = me.pedirDNI();

            foreach(AltaClientes clienteNuevo in listaAntigua)
            {

                if (clienteNuevo.DniCliente.Equals(dniABuscar))
                {
                    clienteEliminado = clienteNuevo;
                    listaAntigua.Remove(clienteEliminado);
                    break;
                }


            }


            return clienteEliminado;


        }


    }
}
