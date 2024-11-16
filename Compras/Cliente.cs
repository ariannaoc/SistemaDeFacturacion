//TDA Cliente

// ATRIBUTOS:

// - Persona                            // los atributos que heredan y defini en Persona, solo lo uso en el constructor 
// - Direccion                          Direccion // informacion del cliente para la factura 
// - Boolean                            ContribuyenteEspecial // ver si el cliente es ContribuyenteEspecial para ajustar los impuestos de compra

// METODOS:

// - PedirDatos                         // Pide informacion al cliente
// - MostrarCliente                     //Muestra informacion ingresada por el cliente
// - ModificarInformacion               //si el cliente quiere cambiar informacion
// - CrearInstancia Unica               // buscar metodo para hacer solo una instancia de vendedor
// - ReiniciarCliente                   // para el final si el usuario desea hacer nueva compra no le salga la informacion anterior

using System;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class Cliente : Persona
    {
        public bool ContribuyenteEspecial = false;
        public Direccion Direccion {  get; set; } = null!;

        private static Cliente? Instance;

      
     
        public void PedirDatos()
        {
           
            Console.Clear();
            Console.WriteLine("Por favor Ingresa los siguientes datos:");
            Console.CursorVisible = true;
            Console.WriteLine();
            
            Nombres = UtilidadesConsola.ValidarPalabra("Ingresa por favor tu Nombre completo: ");

            Apellidos = UtilidadesConsola.ValidarPalabra("Ingresa por favor tu Apellido completo: ");

            ID = UtilidadesConsola.ValidarCedula();


            Direccion = new Direccion
            {
                Calle = UtilidadesConsola.ValidarPalabra("Ingresa por favor Calle: "),

                Ciudad = UtilidadesConsola.ValidarPalabra("Ingresa por favor Ciudad: "),

                Estado = UtilidadesConsola.ValidarPalabra("Ingresa por favor Estado: "),

                ZipCode = IngresarCodigo("Ingresa por favor tu Codigo Postal: ")
            };
            Console.CursorVisible = false;
        }

        public static Cliente GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Cliente();
            }
            return Instance;    
        }

        public void MostrarCliente()
        {
               
            Console.WriteLine("Tus datos:");
            Console.WriteLine();
            Console.WriteLine($"Nombre:   {Nombres}");
            Console.WriteLine($"Apellido: {Apellidos}");
            Console.WriteLine($"Cédula:   V-{ID}");
            Console.WriteLine($"Direccion:");
            Direccion.MostrarDireccion(Direccion);
            UtilidadesConsola.EsperaPresionarTecla();
        }

        public void ModificarInformacion()
        {
            Console.Clear();
            Console.WriteLine("Por favor Ingresa los siguientes datos:");
            Console.CursorVisible = true;
            Console.WriteLine();

            Nombres = UtilidadesConsola.ValidarPalabra("Ingresa por favor tu Nombre completo: ");

            Apellidos = UtilidadesConsola.ValidarPalabra("Ingresa por favor tu Apellido completo: ");

            ID = UtilidadesConsola.ValidarCedula();

            Direccion.Calle = UtilidadesConsola.ValidarPalabra("Ingresa por favor Calle: ");

            Direccion.Ciudad = UtilidadesConsola.ValidarPalabra("Ingresa por favor Ciudad: ");

            Direccion.Estado = UtilidadesConsola.ValidarPalabra("Ingresa por favor Estado: ");

            Direccion.ZipCode = IngresarCodigo("Ingresa por favor tu Codigo Postal: ");

            Console.CursorVisible = false;

        }

        public static void ResetCliente()
        {
           Instance = new Cliente();
        }

        public static int IngresarCodigo(string pregunta)
        {
            while (true)
            {
                if (!string.IsNullOrWhiteSpace(pregunta))
                {
                    Console.Write(pregunta);
                    
                }

                if (int.TryParse(Console.ReadLine(), out int result) &&
                    result >= 0 && result.ToString().Length == 4)
                {
                    return result;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingresa por favor tu Codigo Postal de Venezuela (4 digitos): ");
                Console.ResetColor();
                UtilidadesConsola.EsperaPresionarTecla();
                Console.Clear();
            }
        }
    }

    public class Direccion
    {
        public string? Calle { get; set; }  //ARREGLAR 
        public string? Ciudad { get; set; }
        public string? Estado { get; set; }
        public int ZipCode { get; set; }

        public static void MostrarDireccion(Direccion direccion)
        {

            Console.WriteLine($" - Calle:  {direccion.Calle}");
            Console.WriteLine($" - Ciudad: {direccion.Ciudad}");
            Console.WriteLine($" - Estado: {direccion.Estado}");
            Console.WriteLine($" - Codigo Postal: {direccion.ZipCode}");

        }
    }

}
