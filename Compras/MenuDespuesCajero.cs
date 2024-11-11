using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class MenuDespuesCajero : MenuBase
    {

        public MenuDespuesCajero(Sistema sistema) : base(sistema)
        {
            //vacio
        }

        public override void Correr()
        {
            Console.WriteLine();
            Console.WriteLine();
            string prompt = $"Que quieres hacer ahora?";
            string[] opciones = { "Proceder", "Regresar a Cajeros disponibles", "Salir" };
            var MenuPrincipal = new MenuOriginal(prompt, opciones);
            int indexSeleccionado = MenuPrincipal.CorrerPrograma();
            Vendedor.GetInstance();

            switch (indexSeleccionado)
            {

                case 0:
                    var cliente = Cliente.GetInstance();
                    cliente.PedirDatos();                
                    miSistema.ProcederPago.Correr(); //continua con la compra y le pide los datos al cliente que seran usados despues 
                   
                    break;
                case 1:
                    miSistema.Cajero.Correr(); // muestra el menu de seleccion de los cajeros si desea cambiar de cajero
                    break;
                case 2:
                    UtilidadesConsola.Salir(); //sale
                    break;

            }
            UtilidadesConsola.EsperaPresionarTecla();
        }
    }
}
