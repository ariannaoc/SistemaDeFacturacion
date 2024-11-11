//TDA SeleccionCajero

// -METODOS:

// - SeleccionarCajero
// - Salir



using System;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class SeleccionCajero : MenuBase
    {
        public SeleccionCajero(Sistema miSistema) : base(miSistema)
        {
        }

        public override void Correr()
        {
            var vendedor = new Vendedor();
            vendedor.MostrarVendedores();
            UtilidadesConsola.EsperaPresionarTecla();
            string[] opciones = { "Caja 1", "Caja 2", "Caja 3", "Cancelar Compra" }; //selecciona los vendedores disponibles y los guarda para la factura 
            string prompt = "Por favor elige a un vendedor: ";
            var menu = new MenuOriginal(prompt, opciones);
            int indexSeleccionado = menu.CorrerPrograma();


            switch (indexSeleccionado)
            {
                case 0:

                    Vendedor.SeleccionarVendedor(vendedor.Vendedores[0]);
                    miSistema.MenuDespuesCajero.Correr();

                    break;

                case 1:
                    //Vendedor.MostrarVendedores(Vendedor.ListaDeVendedores.vendedor2);
                    Vendedor.SeleccionarVendedor(vendedor.Vendedores[1]);
                    miSistema.MenuDespuesCajero.Correr();
                    break;

                case 2:
                    //Vendedor.MostrarVendedores(Vendedor.ListaDeVendedores.vendedor3);
                    Vendedor.SeleccionarVendedor(vendedor.Vendedores[2]);
                    miSistema.MenuDespuesCajero.Correr();

                    break;
                case 3:
                    miSistema.CarritoCompras.Correr();
                    break;


            }
        }
    }
}
