//TDA Persona

// ATRIBUTOS:

// - Cadena De Caracteres               Nombres //identificacion de la persona, puede incluir mas de un nombre, ejemplo: Ricardo Omar
// - Cadena De Caracteres               Apellidos // igual que arriba
// - Cadena De Caracteres               ID // el id en cliente es cedula y el id en vendedor es definido por la empresa

// METODOS:

//No tiene, se usa como clase base para cliente y vendedor


using System;
using TuHijoDe4Patas;

namespace Tienda.Menus.Compras
{
    public class Persona
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? ID {  get; set; } 
       
        public Persona() { }
    }
}
