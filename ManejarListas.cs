using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using System.Text.Json.Serialization;


namespace Parcial2_SistemaDeFacturacion
{
    public static class ClientManager
    {
        private static string filePath = @"..\..\JSONS\FileName.json";
        public static List<Cliente> Clients { get; private set; }

        static ClientManager()
        {
            Clients = LeerClientes();

            // Debugging output para la verificacion de lectura 
            Console.WriteLine("Carga de clientes del JSON:");
            foreach (var client in Clients)
            {
                Console.WriteLine($"ID: {client.ID}, Nombres: {client.Nombres}, Apellidos: {client.Apellidos}, Email: {client.Email}, NumeroTelefono: {client.NumeroTelefono}, ContribuyenteEspecial: {client.ContribuyenteEspecial}, EstadoLegal: {client.EstadoLegal}, Calle: {client.Direccion.Calle}, Ciudad: {client.Direccion.Ciudad}, Estado: {client.Direccion.Estado}");
            }
        }

        public static List<Cliente> LeerClientes()
        {
            try
            {


                if (!File.Exists(filePath))
                {
                    return new List<Cliente>();
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string json = reader.ReadToEnd();
                    if (string.IsNullOrWhiteSpace(json))
                    {
                        return new List<Cliente>();
                    }

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        Converters = { new JsonStringEnumConverter() } // Asegura que los enums sean manejados correctamente
                    };

                    return JsonSerializer.Deserialize<List<Cliente>>(json, options);
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"JSON deserialization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Cliente>();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Acceso negado al file path: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Cliente>();
            }
        }



        public static void WriteClientes()
        {
            try
            {
                string absolutePath = Path.GetFullPath(filePath);
                using (StreamWriter escribir = new StreamWriter(filePath))
                {
                    string json = JsonSerializer.Serialize(Clients, new JsonSerializerOptions { WriteIndented = true });
                    escribir.Write(json);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Acceso negado al file path: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddClient(Cliente client)
        {
            // Check for duplicate ID
            if (Clients.Any(c => c.ID == client.ID))
            {
                MessageBox.Show("Un cliente con esa cedula ya existe. Por favor introduzca una Cedula diferente.", "Duplicate ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clients.Add(client);
            WriteClientes();
        }


        public static void ActualizarCliente(Cliente client)
        {
            var clienteExistente = Clients.FirstOrDefault(c => c.ID == client.ID);
            if (clienteExistente != null)
            {
                clienteExistente.Nombres = client.Nombres;
                clienteExistente.Apellidos = client.Apellidos;
                clienteExistente.Email = client.Email;
                clienteExistente.NumeroTelefono = client.NumeroTelefono;
                clienteExistente.Direccion = client.Direccion;
                clienteExistente.EstadoLegal = client.EstadoLegal;
                clienteExistente.ContribuyenteEspecial = client.ContribuyenteEspecial;

                WriteClientes();
            }
        }

        public static void EliminarCliente(Cliente client)
        {
            var existingClient = Clients.FirstOrDefault(c => c.ID == client.ID);
            if (existingClient != null)
            {
                Clients.Remove(existingClient);
                WriteClientes();
            }
        }
    }
}
