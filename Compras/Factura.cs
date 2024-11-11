//TDA Factura

// ATRIBUTOS:

// - Cliente                            cliente //solo habra una instancia unica por compra
// - Double                             IVA // impuesto a pagar sobre toda la compra
// - Double                             IGTF // impuesto para contribuyentes especiales, segun lo investigado. Aqui en Venezuela, es para aquellos que ganan una cantidad especifica de dinero y no extranjeros o empresas necesariamente
// - DateTime                           FechaActual // Genera automaticamente la fecha y hora actual de la compra del usuario
// METODOS:

// - Vacio                              GenerarFactura(Carrito carrito, Cliente cliente, Vendedor vendedor) //corre la logica necesaria para mostrar los diferentes datos que deben de aparecer en la factura requerida
// - Vacio                              CorrerPrograma //corre la logica necesaria para poder mostrar Generacion de factura




using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class Factura : MenuBase
    {
        
        public const double IVA = 0.16; //esta es la unica informacion que copie de mi companero 
        public const double IGTF = 0.03; //esta es la unica informacion que copie de mi companero 

        public Factura(Sistema miSistema) : base(miSistema)
        {
          
        }

        public override void Correr()
        {
            
            string[] opciones = ["Si", "No"];//anadir los vendedores creados
            string prompt = "¿Eres Contribuyente Especial? "; //explicado en el TDA arriba
            var menu = new MenuOriginal(prompt, opciones);
            int indexSeleccionado = menu.CorrerPrograma(); //la misma logica de menu original a lo largo del programa 
            var cliente = Cliente.GetInstance(); //poder acceder a esos datos e imprimirlos por pantalla
            var carrito = CarritoDeCompras.GetInstance(); //poder acceder a esos datos e imprimirlos por pantalla
            var vendedor = Vendedor.GetInstance(); //poder acceder a esos datos e imprimirlos por pantalla

            switch (indexSeleccionado)
            {
                case 0:
                    cliente.ContribuyenteEspecial = true;
                    GenerarFactura(cliente, carrito,vendedor);
                    miSistema.MenuComprarDeNuevo.Correr();
                    break;

                case 1:
                    GenerarFactura(cliente, carrito,vendedor);
                    miSistema.MenuComprarDeNuevo.Correr();
                    break;

                case 2:
                    UtilidadesConsola.Salir();
                    break;

            } 
        }
        public static void GenerarFactura(Cliente Cliente, CarritoDeCompras carrito, Vendedor vendedor)
        {
            double subTotal  = carrito.SubTotal();
            double ivaTotal = subTotal * IVA;
            double igtfTotal = Cliente.ContribuyenteEspecial ? subTotal * IGTF : 0; //esta es la unica informacion que copie de mi companero, el operador ternario
            double total = subTotal + ivaTotal + igtfTotal;
            

            DateTime fechaActual = DateTime.Now;
            DateOnly fechaSola = DateOnly.FromDateTime(fechaActual);
            TimeOnly horaSola = TimeOnly.FromDateTime(fechaActual);


            Console.Clear();
            //AGREGAR LOGO DE TU HIJO DE 4 PATAS AQUI 
            Console.WriteLine("                                  TU HIJO DE 4 PATAS");
            Console.WriteLine();
            Console.WriteLine("________________________________________ FACTURA _________________________________________");
            Console.WriteLine($"Fecha: {fechaSola}  Hora: {horaSola}");
            Console.WriteLine("__________________________________________________________________________________________");
            carrito.CarritoFactura();
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine($"IVA ({IVA*100}%): Bs {ivaTotal:N2}");
            Console.WriteLine("__________________________________________________________________________________________");
            if (Cliente.ContribuyenteEspecial)
            {
                Console.WriteLine($"IGTF ({IGTF*100}%): Bs {igtfTotal:N2}");
                Console.WriteLine("__________________________________________________________________________________________");
            }    
            Console.WriteLine(@$"{"TOTAL (Bs):",36}            {total,16:N2}");
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"Vendedor:  {Vendedor.VendedorCopia.Nombres} {Vendedor.VendedorCopia.Apellidos}, {Vendedor.VendedorCopia.Email}.");
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine($"Cliente:   {Cliente.Nombres} {Cliente.Apellidos}"); //no aplique mostrarCliente porque no queria el mismo formato que en ese 
            Console.WriteLine($"Cédula:    V-{Cliente.ID}");
            Console.WriteLine($"Direccion:");
            Console.WriteLine($" - Calle:  {Cliente.Direccion.Calle}");
            Console.WriteLine($" - Ciudad: {Cliente.Direccion.Ciudad}");
            Console.WriteLine($" - Estado: {Cliente.Direccion.Estado}");
            Console.WriteLine($" - Codigo Postal: {Cliente.Direccion.ZipCode}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("GRACIAS POR SU COMPRA!");
            UtilidadesConsola.EsperaPresionarTecla();
        }
    }
}
