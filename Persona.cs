using System;


namespace Parcial2_SistemaDeFacturacion
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string ID {  get; set; } //cedula o identificion de usuario
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }

        public Persona () { }

        public Persona(string nombre, string appelidos, string id, string email, string numeroTelefono)
        {
            Nombres = nombre;
            Apellidos = appelidos;
            ID = id;
            Email = email;
            NumeroTelefono = numeroTelefono;

        }
    }
}
