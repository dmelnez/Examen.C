using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRepasoListas.Dtos
{
    internal class AltaCuentaBancaria
    {
        long idCuentaBancaria;

        string switchh = "DMN";

        string isBan = "aaaaa";

        string fechaDeAlta = "9999/12/31";

        string fechaDeBaja = "9999/12/31";


        public long IdCuentaBancaria { get => idCuentaBancaria; set => idCuentaBancaria = value; }
        public string Switchh { get => switchh; set => switchh = value; }
        public string IsBan { get => isBan; set => isBan = value; }
        public string FechaDeAlta { get => fechaDeAlta; set => fechaDeAlta = value; }
        public string FechaDeBaja { get => fechaDeBaja; set => fechaDeBaja = value; }



        public AltaCuentaBancaria() { }


        public AltaCuentaBancaria(long idCuentaBancaria, string switchh, string isBan, string fechaDeAlta, string fechaDeBaja)
        {
            this.idCuentaBancaria = idCuentaBancaria;
            this.switchh = switchh;
            this.isBan = isBan;
            this.fechaDeAlta = fechaDeAlta;
            this.fechaDeBaja = fechaDeBaja;
        }


        override

        public string ToString()
        {

            string datosCuentasBancarias =
                " ID Cuenta Bancaria: " + this.idCuentaBancaria +
                " Switch: " + this.switchh +
                " isBan: " + this.isBan +
                " Fecha de Alta: " + this.fechaDeAlta +
                " Fecha de Baja: " + this.fechaDeBaja;

            return datosCuentasBancarias;




        }



    }
}
