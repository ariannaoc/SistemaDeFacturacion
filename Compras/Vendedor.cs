//TDA Vendedor

// ATRIBUTOS:

// - Persona                            // los atributos que heredan y defini en Persona, solo lo uso en el constructor 
// - Cadena De Caracteres               Email // informacion del vendedor para la factura  
// - Array de Vendedor                  vendedor // informacion del producto para el usuario 

// METODOS:

// - MostrarVendedores                  // Muestra la lista de vendedores creados
// - MostrarVendedorSeleccionado        //dependiendo del vendedor seleccionado por el usuario, aqui sale
// - CrearInstancia Unica               // buscar metodo para hacer solo una instancia de vendedor


using System;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class Vendedor : Persona // en el documento con las direcciones, dice pedirle los datos al vendedor ya que son parte de la empresa, sin embargo, no me parece correcto pedirlas, sino seleccionar. En cliente si lo hice.
    {
        public string? Email { get; set; }
        public readonly Vendedor[] Vendedores = new Vendedor[3];  // a diferencia del carrito de compras, donde aplique una variable "Capacidad" para cambiar el tamano del array, como aqui solo necesito hacerlo una vez, me di cuenta
                                                                  // que no era necesario, inicialmente habia usado static, pero luego pense en una posible expansion de empresa, y si hay diferentes departamentos, no bastaria con los 3 en la manera en la que habia hecho previamente
        public static Vendedor VendedorCopia { get; set; } = null!;
        private static Vendedor? Instance; //no puedo aplicar las autopropiedades como arriba


        public Vendedor(string nombres, string apellidos, string id, string email)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.ID = id;
            this.Email = email;

        }

        public Vendedor()
        {
            Vendedores[0] = new Vendedor("Ricardo", "Morales", "3101D", "ricardomor001@hotmail.com");
            Vendedores[1] = new Vendedor("Ron", "El Gato", "3222E", "ronelgato@gmail.com");
            Vendedores[2] = new Vendedor("Mica", "Miau", "5011F", "micaelmiau@hotmail.com");
        }
        public Vendedor(Vendedor vendedor)
        {
            Instance = vendedor;
        }

        public static Vendedor GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Vendedor(Instance!);
            }
            return Instance;
        }


        public void MostrarVendedores()
        {
            Console.Clear();
            Console.WriteLine("Elige un cajero de tu preferencia:");
            Console.WriteLine();
            for (int i = 0; i < Vendedores.Length; i++)
            {
                Console.WriteLine($@"{i + 1}.  {Vendedores[i].Nombres} {Vendedores[i].Apellidos}, {Vendedores[i].Email}");

                Console.WriteLine();
                Console.WriteLine();
            }

        }

        public static void MostrarVendedorSeleccionado()
        {
            Console.WriteLine($@" {VendedorCopia?.Nombres} {VendedorCopia?.Apellidos}, {VendedorCopia?.Email}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static Vendedor SeleccionarVendedor(Vendedor vendedor1)
        {

            VendedorCopia = vendedor1;
            return VendedorCopia;

        }
    }
}

