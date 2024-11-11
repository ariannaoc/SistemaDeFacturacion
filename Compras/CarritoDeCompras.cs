//TDA CarritoDeCompras

// ATRIBUTOS:

// - Array de Producto                  Producto // productos anadidos en el carrito usando metodo de anadir
// - Array de Entero                    Cantidades // como es un array de producto lo necesario para anadir, debemos tener un array de cantidades para distinguir las cantidades de c/producto
// - Entero                             Capacidad // capacidad del array inicial donde se almacenan los productos
// - Array de Float                     Precio  // necesario para actualizar los precios dependiendo del producto y su cantidad
// - Entero                             ContarProductos //ennumera la lista del carrito y permite actualizar el carrito en diferentes metodos

// METODOS:

// - Vacio                              AumentarCapacidad()// aumenta la capacidad del array que contiene los productos si se llena con su capacidad inicial
// - Vacio                              AnadirProducto(Producto producto, Entero Cantidad) // agrega al carrito el producto seleccionado
// -                                    CrearInstancia Unica // instancia unica del carrito a lo largo del programa
// - Vacio                              RemoverProducto // remueve del carrito el producto seleccionado
// - Vacio                              CambiarCantidad // cambia la cantidad de un producto seleccionado del carrito
// - Vacio                              MostrarCarrito // muestra los productos seleccionados por el usuario a comprar
// - Vacio                              ResetCarrito // si el usuario desea hacer una nueva compra se aplica este metodo para resetear los valores del carrito

using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class CarritoDeCompras
    {
        private Producto[] Productos;
        private int[] Cantidades;
        public int Capacidad { get; private set; } 
        public int ContarProductos { get; private set; } //uso private en la propiedad por como funciona el metodo  de aumentarCapacidad
        public float[] Precio { get; private set; }
        private static CarritoDeCompras? Instance;


        public CarritoDeCompras()
        {
            Capacidad = 20;
            Productos = new Producto[Capacidad];
            Cantidades = new int[Capacidad];
            Precio = new float[Capacidad];
            ContarProductos = 0;
        }

        public static CarritoDeCompras GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CarritoDeCompras();
            }
            return Instance; //para que haya una unica instancia en toda la compra
        }

        public void AnadirProducto(Producto producto, int cantidad)
        {
            // Verifica si el producto ya existe
            for (int i = 0; i < ContarProductos; i++)
            {
                if (Productos[i].Nombre == producto.Nombre)
                {
                    Cantidades[i] += cantidad;
                    Precio[i] += Productos[i].Precio * cantidad;
                    return;
                }
            }

            // Si el carrito está lleno, aumenta la capacidad
            if (ContarProductos == Capacidad)
            {
                AumentarCapacidad();
            }

            //actualiza todo 
            Productos[ContarProductos] = producto; 
            Cantidades[ContarProductos] = cantidad;
            Precio[ContarProductos] = Productos[ContarProductos].Precio * cantidad;
            ContarProductos++;
        }

        private void AumentarCapacidad()
        {
            Capacidad *= 2;
            Array.Resize(ref Productos, Capacidad); //es por esto que no podemos usar autopropiedades normales. Estamos pasando referencia y los autopropiedades son valores
            Array.Resize(ref Cantidades, Capacidad);
        }

        public void RemoverProducto()
        {
            int index;
            var carrito = GetInstance(); //para poder mostrar el carrito despues
            Console.CursorVisible = true;
            while (true)
            {
                if(SubTotal() == 0)
                {
                    Console.WriteLine("No hay productos disponibles en el carrito!!!"); //solo deberia de aparecer esto si hice algo mal
                    return;
                }
                Console.WriteLine();
                
                Console.Write("Ingresa el index del producto el cual quieres remover del carrito de compras: ");
                if (int.TryParse(Console.ReadLine(), out index))
                {

                    if (index >= 1 && index <= ContarProductos)
                    {
                        for (int i = index - 1; i < ContarProductos - 1; i++)
                        {
                            Productos[i] = Productos[i + 1];
                            Cantidades[i] = Cantidades[i + 1];

                        }
                        ContarProductos--;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No existe en el carrito de compras un producto con ese index. Por favor" +
                            " ingresa un numero del 1 al {0}.", ContarProductos);
                        UtilidadesConsola.EsperaPresionarTecla();
                        Console.Clear();
                        carrito.MostrarCarrito();
                    }
                }
                else
                {
                    Console.WriteLine("No es valido. Por favor ingresa un numero.");
                    UtilidadesConsola.EsperaPresionarTecla();
                    Console.Clear();
                    carrito.MostrarCarrito();
                }
                Console.CursorVisible = false;
            }


        }

        public void CambiarCantidad()
        {
            int index;
            int nuevaCantidad;
            var carrito = GetInstance();
            Console.CursorVisible = true;

            while (true)
            {
                if (SubTotal() == 0)
                {
                    Console.WriteLine("NO DEBERIA DE APARECER ESTO SI ESTA BIEN TODO"); //chequeo solamente
                  
                    return;
                }
                Console.WriteLine();
                Console.Write("Ingresa el index del producto que deseas cambiar en cantidad: ");
                if (int.TryParse(Console.ReadLine(), out index))
                {
                    if (index >= 1 && index <= ContarProductos)
                    {
                        Console.Write("Ingresa la nueva cantidad que deseas: ");
                        if (int.TryParse(Console.ReadLine(), out nuevaCantidad))
                        {
                            if (nuevaCantidad > 0)
                            {
                                Cantidades[index - 1] = nuevaCantidad;
                                Precio[index - 1] = Productos[index - 1].Precio * nuevaCantidad;
                                Console.Clear();
                                break;

                            }

                            else if(nuevaCantidad == 0)
                            {
                                for (int i = index - 1; i < ContarProductos - 1; i++)
                                {
                                    Productos[i] = Productos[i + 1];
                                    Cantidades[i] = Cantidades[i + 1];

                                }
                                ContarProductos--;
                                Console.Clear();
                                break;


                            }

                            else
                            {
                                Console.WriteLine("Numero de producto invalido. Intenta de nuevo");
                                UtilidadesConsola.EsperaPresionarTecla();
                                Console.Clear();
                                carrito.MostrarCarrito();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalido. Por favor ingresa un numero");
                            UtilidadesConsola.EsperaPresionarTecla();
                            Console.Clear();
                            carrito.MostrarCarrito();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalido. Por favor ingresa un numero del 1 al {0}", ContarProductos);
                        UtilidadesConsola.EsperaPresionarTecla();
                        Console.Clear();
                        carrito.MostrarCarrito();
                    }
                }

                else
                {
                    Console.WriteLine("Invalido. Por favor ingresa un numero");
                    UtilidadesConsola.EsperaPresionarTecla();
                    Console.Clear();
                    carrito.MostrarCarrito();
                }

                Console.CursorVisible = false;
            }
        }

        public float SubTotal()
        {
            float subTotal = 0f;

            for (int i = 0; i < ContarProductos; i++)
            {
                subTotal += Precio[i];
               
            }
            
            subTotal = (float)Math.Round(subTotal, 2);
            return subTotal;
        }

        public void MostrarCarrito()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("Tu carrito de compras actual:");
            Console.WriteLine();
            Console.WriteLine();
            CarritoFactura(); //para no escribir mas, puse el mismo formato de los productos que se muestran en factura como aca
        }
       
        public void CarritoFactura()
        {
            if (SubTotal() == 0)
            {
                Console.WriteLine("TU CARRITO ESTA VACIO"); //mensaje que solo aparece si el carrito no tiene nada

            }

            else
               
            {
                Console.WriteLine(@$"{"       PRODUCTO",-30} {"CANTIDAD",15} {"PRECIO (Bs)",18}");
                Console.WriteLine();
            for (int i = 0; i < ContarProductos; i++)
            {
               
                Console.WriteLine(@$"{i + 1}. {Productos[i].Nombre,-30} {"x" + Cantidades[i],9}{Precio[i],21:N2}");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(@$"{"SubTotal:",36}            {SubTotal(),16:N2}");

            }
        }

        public void ResetCarrito()
        {
            // reinicia los arrays y cuentas en general
            Productos = new Producto[Capacidad];
            Cantidades = new int[Capacidad];
            Precio = new float[Capacidad];
            ContarProductos = 0;
        }
    }

}

