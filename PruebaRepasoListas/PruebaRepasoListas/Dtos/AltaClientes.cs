using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Dtos
{
    internal class AltaClientes
    {

        //Estos campos denominados Atributos. Son los campos que definen una lista. En esta ocasion, son los datos que definenen
        // A un cliente. Cada bez que se cree un nuevo cliente, contendra todos los campos.
        // Los campos preedeterminados, son aquellos campos, los cuales contendran un valor en su defecto, el cual todo campos que 
        // No haya sido introducido por el usuario, con la finalidad de no trabajar con campos nulos.

        long idCliente;

        string nombreCliente = "aaaaaa";

        string apellidoCliente = "aaaaaa";

        string dniCliente = "aaaaaa";

        int telefonoCliente = 1111111;

        string altaCliente = "9999/12/31";

        string bajaCliente = "9999/12/31";



        // Metodos encargados que dar o recoger los datos de cada uno de los campos. Estos metodos no hay que establecerlos, sino que
        // Son entendidos por contexto

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public int TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }
        public string AltaCliente { get => altaCliente; set => altaCliente = value; }
        public string BajaCliente { get => bajaCliente; set => bajaCliente = value; }


        // El constructor personal, es alquel el cual se contruye, con los campos que definen a un cliente, en este caso son los campoos
        // Y datos de los clientes.

        public AltaClientes(long idCliente, string nombreCliente, string apellidoCliente, string dniCliente, int telefonoCliente, string altaCliente, string bajaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.dniCliente = dniCliente;
            this.telefonoCliente = telefonoCliente;
            this.altaCliente = altaCliente;
            this.bajaCliente = bajaCliente;
        }



        // Se crea un Contructor vacion con la finalidad de poder trabajar con el, al momento de la realizacion de un nuevo objeto de cualquier tipo.
        public AltaClientes() { 
        }





        // El metodo ToString, ya viene establecido en la arquitectura de C#, en este caso se sobreescribe, con la finalidad de al momento de llamarlo
        // Muestra todos los datos (Campos), de los clientes
        override

        public string ToString()
        {

            string mostrarClientes =

                " ID Cliente:" + this.idCliente +
                " Nombre:" + this.nombreCliente +
                " Apellidos:" + this.apellidoCliente +
                " DNI:" + this.dniCliente +
                " Nº Telefono:" + this.telefonoCliente +
                " Fecha de Alta:" + this.altaCliente +
                " Fecha de Baja:" + this.bajaCliente;


            return mostrarClientes;




        }
    }
}
