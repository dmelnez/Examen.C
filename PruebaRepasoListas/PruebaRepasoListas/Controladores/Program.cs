using PruebaRepasoListas.Dtos;
using PruebaRepasoListas.Servicios;
using System.Numerics;


/// <summary>
/// Clase Principal de entrada de la Aplicacion
/// </summary>

class Program
{
    /// <summary>
    /// Metodo principal por el cual La Aplicacion se iniciara
    /// </summary>
    /// <param name="args"></param>


    static void Main(string[] args)

    {

        // Creacion de un Objeto sobre los metodos del Menu Principal
        MenuInterfaz me = new MenuImplementacion();

        // Creacion de un Objeto encargado de todos lo meotodos relacionados con los clientes
        ClienteInterfaz cli = new ClienteImplementacion();

        // Creacion de un Objeto relacionado con los metodos de las Cuentas Bancarias
        CuentasBancariasInterfaz cu = new CuentaBancariaImplementacion();

        // Creacion de las Listas de Clientes
        List<AltaClientes>listaClientes = new List<AltaClientes>();
        
        // Creacion de las Listas de las Cuentas Bancarias
        List<AltaCuentaBancaria>listaCuentasBancarias = new List<AltaCuentaBancaria>();

        bool cerrarMenu = false;


        while (!cerrarMenu)
        {
            // Almacenamiento del valor introducido de la seleccion del menu principal
            int seleccionUsuMenu = me.menuPrincipal();


            // Comprobacion de la seleccion del usuario para el switch. El cual comprobara cada uno de los casos y ejecutara el caso correspondiente
            switch (seleccionUsuMenu)
            {

                //El caso 0, cerrara la Aplicacion cambindo el valor que valida el While a True. 
                case 0:
                    Console.WriteLine("Se cerrara la Aplicacion");
                    cerrarMenu=true;
                    break;

                // Realizara el Alta al cliente
                case 1:
                    Console.WriteLine("Se dara de alta como Cliente");
                    cli.darAltaCliente(listaClientes);
                break; 
                
                //Realizara la Eliminacion del cliente, en base al DNI que el usuario a introducido al darese de alta en el sitema
                case 2:
                    Console.WriteLine("Eliminacion de un Cliente (DNI)");
                    cli.eliminarCliente(listaClientes);
                    break;


                // Se solicitara los campos necesarios para dar de alta una nueva cuenta bancaria. No se solicitaran los datos que vienen preestablecidos
                case 3:
                    Console.WriteLine("Creacion de una Nueva cuenta Bancaria");
                    cu.nuevaCuentaBancaria(listaCuentasBancarias);
                    break;

                // En funcion del id del cliente, se realizara la eliminacion de una cuenta bancaria.
                case 4:
                    Console.WriteLine("Eliminacion de una Nueva Cuenta Bancaria");
                    break;

    
                // Realiza un metodo, el cual llamara al metodo ToString, donde comprueba todos los campos de cada uno de los clientes dados de alta en el sistema
                // Y mostrara todos y cada uno de los campos introducido por el usuario. A este campo, a de tener en cuenta, que para los datos los cuales no se han
                //Solicitado al cliente, se mantendran los datos preestablecidos.
                case 5:
                    Console.WriteLine("Ver los Datos de los Clientes");

                    foreach(AltaClientes clienteNuevo in listaClientes)
                    {

                        Console.WriteLine(clienteNuevo.ToString());

                    }
                    break;


                // Realiza un metodo foreach el cual comprueba que todos los clientes que estan en una lisra, en este caso ""Listade Cuentas Bancarias
.               // Tambien realiza y muestra los datos de todos los clientes. Los Campos los cuales no se han solicitado al usuario, se ,mostraran los datos
                 // Generales y preestablecidos para el usuario, con la finalidad que no trabajar con datos nulos, es decir, campos nulos.
                case 6:
                    Console.WriteLine("Ver los Datos de las Cuentas Bancarias");


                    foreach (AltaCuentaBancaria nuevaCuentnuevaCuentaBancaria in listaCuentasBancarias)
                    {

                        Console.WriteLine(nuevaCuentnuevaCuentaBancaria.ToString());
                    
                    }

                    
                    break;


                    // El default, es el encargado de realizar lo que lo contiene, si el valor introducido en este caso, con la seleccion del usario
                    // No corresponde con un ningun case. Y mostrara que la seleccion no es valida. Y volvera a pedir al usuario que introduzca un nuevo valor
                    // A la vez que se vuelve a mostrar al usuario, el Menu Principal de la Aplicacion
                default:
                    Console.WriteLine("La seleccion no es valida");
                    break;


        } 


        }

    }

}
