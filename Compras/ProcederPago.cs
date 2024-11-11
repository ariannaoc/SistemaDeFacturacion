//TDA ProcederPago

// -METODOS:

//- Continuar con la compra //procede a preguntar al usuario si es contribuyente especial o no para generar la factura final
//- Ver datos de nuevo // asegura al usuario que los datos ingresados sean correctos
//- Modificar Informacion // si el usuario ingreso algun dato mal o desea cambiar su informacion, puede hacerlo con este metodo
//- Cancelar compra y salir // termina el programa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class ProcederPago : MenuBase
    {
    
        public ProcederPago(Sistema miSistema) : base(miSistema)
        { 
          
        }

        public override void Correr()
        {
            var cliente1 = new Cliente();
            var cliente = Cliente.GetInstance();
            Console.Clear();
            cliente.MostrarCliente();
            string[] opciones = { "Continuar con la compra","Ver datos de nuevo", "Modificar información", "Cancelar compra y salir" };
            string prompt = "¿Deseas cambiar tu información? "; 
            var menu = new MenuOriginal(prompt, opciones);
            int indexSeleccionado = menu.CorrerPrograma();
            CarritoDeCompras.GetInstance();
            

            switch (indexSeleccionado)
            {
                case 0:
     
                    miSistema.GenerarFactura.Correr();
                    //menu para preguntarle al usuario si desea continuar o no. si lo desea, preguntarle si es 
                    //contribuyente especial
                    break;
                case 1: 

                    miSistema.ProcederPago.Correr();
                    break;

                case 2:
                    cliente.ModificarInformacion();
                    miSistema.ProcederPago.Correr();
                    break;

                case 3:
                    UtilidadesConsola.Salir();
                    break;

            }
        }
    }
}
