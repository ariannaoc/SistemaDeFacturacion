using System;


namespace Parcial2_SistemaDeFacturacion
{
    public enum EstadoLegal
    {
        Nacional,
        Extranjero
    }

    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }

        // Parameterless constructor for JSON deserialization
        public Direccion() { }

        public Direccion(string calle, string ciudad, string estado)
        {
            Calle = calle;
            Ciudad = ciudad;
            Estado = estado;
        }
    }

    public class Cliente : Persona
    {
        public bool ContribuyenteEspecial { get; set; }
        public EstadoLegal EstadoLegal { get; set; }
        public Direccion Direccion { get; set; }

        public Cliente() { } 

        public Cliente(Direccion direccion, EstadoLegal estadoLegal, bool contribuyente, string nombres, string apellidos, string id, string email, string numeroTelefono)
        : base(nombres, apellidos, id, email, numeroTelefono)
        {
        Direccion = direccion;
        EstadoLegal = estadoLegal;
        ContribuyenteEspecial = contribuyente;
        }
    }
}
  

    //public void MostrarCliente()
    //{

    //    Console.WriteLine("Tus datos:");
    //    Console.WriteLine();
    //    Console.WriteLine($"Nombre:   {Nombres}");
    //    Console.WriteLine($"Apellido: {Apellidos}");
    //    Console.WriteLine($"Cédula:   V-{ID}");
    //    Console.WriteLine($"Direccion:");
    //    Direccion.MostrarDireccion(Direccion);
    //    UtilidadesConsola.EsperaPresionarTecla();
    //}

    //public void ModificarInformacion()
    //{
    //    Console.Clear();
    //    Console.WriteLine("Por favor Ingresa los siguientes datos:");
    //    Console.CursorVisible = true;
    //    Console.WriteLine();

    //    Nombres = UtilidadesConsola.ValidarPalabra("Ingresa por favor tu Nombre completo: ");

    //    Apellidos = UtilidadesConsola.ValidarPalabra("Ingresa por favor tu Apellido completo: ");

    //    ID = UtilidadesConsola.ValidarCedula();

    //    Direccion.Calle = UtilidadesConsola.ValidarPalabra("Ingresa por favor Calle: ");

    //    Direccion.Ciudad = UtilidadesConsola.ValidarPalabra("Ingresa por favor Ciudad: ");

    //    Direccion.Estado = UtilidadesConsola.ValidarPalabra("Ingresa por favor Estado: ");

    //    //Direccion.ZipCode = IngresarCodigo("Ingresa por favor tu Codigo Postal: ");

    //    Console.CursorVisible = false;

    //}


    //public static int IngresarCodigo(string pregunta)
    //{
    //    while (true)
    //    {
    //        if (!string.IsNullOrWhiteSpace(pregunta))
    //        {
    //            Console.Write(pregunta);

    //        }

    //        if (int.TryParse(Console.ReadLine(), out int result) &&
    //            result >= 0 && result.ToString().Length == 4)
    //        {
    //            return result;
    //        }
    //        Console.Clear();
    //        Console.ForegroundColor = ConsoleColor.Yellow;
    //        Console.WriteLine("Ingresa por favor tu Codigo Postal de Venezuela (4 digitos): ");
    //        Console.ResetColor();
    //        UtilidadesConsola.EsperaPresionarTecla();
    //        Console.Clear();
    //    }
    //}


//public class Direccion
//{
//    public string Calle { get; set; }  //ARREGLAR 
//    public string Ciudad { get; set; }
//    public string Estado { get; set; }
//    //public int ZipCode { get; set; }

//    public Direccion(string calle, string ciudad, string estado)
//    {
//        Calle = calle;
//        Ciudad = ciudad;
//        Estado = estado;
//    }
//    public static void MostrarDireccion(Direccion direccion)
//    {

//        Console.WriteLine($" - Calle:  {direccion.Calle}");
//        Console.WriteLine($" - Ciudad: {direccion.Ciudad}");
//        Console.WriteLine($" - Estado: {direccion.Estado}");
//        //Console.WriteLine($" - Codigo Postal: {direccion.ZipCode}");

//    }
//}

//}
