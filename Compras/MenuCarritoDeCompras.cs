
namespace Tienda.Menus.Compras
{

    public class MenuCarritoDeCompras : MenuBase
    {
        public MenuCarritoDeCompras(Sistema sistema) : base(sistema)
        {

        }

        public override void Correr()
        {
            string[] opciones = { "Añadir otros productos", "Remover productos del carrito", "Cambiar cantidad de productos", "Ver Carrito","Proceder al pago", "Salir" };
            string prompt = "OPCIONES PARA TU CARRITO";
            var menu = new MenuOriginal(prompt, opciones);
            int indexSeleccionado = menu.CorrerPrograma();
            var carrito = CarritoDeCompras.GetInstance();


            switch (indexSeleccionado)
            {
                case 0:
                    miSistema.miMenuAnimales.Correr(); //lleva al menu de selecciones de animal y sus productos
                    break;
                case 1:
                    carrito.MostrarCarrito();  
                    carrito.RemoverProducto();
                    break;
                case 2:
                    carrito.MostrarCarrito();
                    carrito.CambiarCantidad();
                    break;
                case 3:
                    carrito.MostrarCarrito();
                    break;
                case 4:       
                    if(carrito.SubTotal() == 0) //no le deja al usuario seguir  si no tiene ningun producto en su carrito
                    {
                        Console.Clear();    
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hay 0 productos en tu carrito. Por favor añade un producto para continuar.");
                        UtilidadesConsola.EsperaPresionarTecla();
                        miSistema.CarritoCompras.Correr();
                    }
                    else
                    miSistema.Cajero.Correr(); //procede a mostrar los diferentes vendedores para continuar con la compra
                    break;
                case 5:
                    UtilidadesConsola.Salir();
                    break;
            }
            carrito.MostrarCarrito();
            UtilidadesConsola.EsperaPresionarTecla();
            miSistema.CarritoCompras.Correr();
        }

    }
}

