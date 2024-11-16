using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Menus.Compras
{
    public class MenuComprarDeNuevo : MenuBase
    {
        public MenuComprarDeNuevo (Sistema miSistema) : base (miSistema)
        { 
        }

        public override void Correr()
        {
            string[] opciones = ["Nueva compra", "Finalizar"];//anadir los vendedores creados
            string prompt = "¿Deseas hacer otra compra? "; //revisar si es divisas o no
            var menu = new MenuOriginal(prompt, opciones);
            int indexSeleccionado = menu.CorrerPrograma();
            
            var carrito = CarritoDeCompras.GetInstance();

            switch (indexSeleccionado)
            {
                case 0:
                    carrito.ResetCarrito();
                    Cliente.ResetCliente();
                    miSistema.Inicio();
                    break;

                case 1:
                    UtilidadesConsola.Salir(); 
                    break;
            }
        }
    }
}
