using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parcial2_SistemaDeFacturacion
{
    public static class Utils
    {
        public static string MayusculaPrimeraLetra(string palabra)
        {
            if (palabra != null)
            {
                if (palabra.Length == 0)
                {
                    return "-----------";
                }

                StringBuilder result = new StringBuilder(); // Clase perteneciente a system.Text
                bool SigMayuscula = true;

                foreach (char c in palabra)
                {
                    if (SigMayuscula)
                    {
                        result.Append(char.ToUpper(c)); // Solo hace mayuscula a la primera letra de cada palabra
                        SigMayuscula = false;
                    }
                    else
                    {
                        result.Append(char.ToLower(c));
                    }

                    if (c == ' ')
                    {
                        SigMayuscula = true; // Hace letra mayuscula luego de un espacio
                    }
                }

                return result.ToString();
            }
            else // Si es null, ya que el usuario no quiere contestar un campo, regresa esas lineas para indicar que es un campo no lleno
            {
                return "-----------";
            }
        }

        public static string ValidarPalabra(string pregunta)
        {
            bool esValido = false;
            string palabra = "";

            while (!esValido)
            {
                Console.Write(pregunta);
                palabra = Console.ReadLine();
                palabra = MayusculaPrimeraLetra(palabra);
                Console.Clear();

                if (palabra == "-----------")
                {
                    return palabra;
                }
                else
                {
                    esValido = ChecarPalabras(palabra);

                    if (palabra.Length == 1)
                    {
                        esValido = false;
                    }

                    if (!esValido)
                    {
                        Console.WriteLine("Por favor ingresa solo palabras.");
                        EsperaPresionarTecla();
                        Console.Clear();
                    }
                }
            }

            return palabra;
        }

        public static bool ChecarPalabras(string palabra)
        {
            return MyRegex.IsMatch(palabra);
        }

        public static readonly Regex MyRegex = new Regex(@"^[a-zA-Z\s]+$");

        public static string ValidarCedula(string cedula, EstadoLegal nacionalidad)
        {
            if (!MyRegex1.IsMatch(cedula))
            {
                Console.WriteLine("Por favor ingresa solo números y un máximo de 7 u 8 cifras para que tu cédula sea valida (Ejemplo: 28037034)");
                return "-----------";
            }

            if (nacionalidad == EstadoLegal.Nacional)
            {
                return "V-" + cedula;
            }
            else if (nacionalidad == EstadoLegal.Extranjero)
            {
                return "E-" + cedula;
            }
            else
            {
                return "-----------";
            }
        }

        public static readonly Regex MyRegex1 = new Regex(@"^\d{7,8}$");

        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static string ValidarNumeroTelefono(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return "numero de telefono invalido";

            if (phoneNumber.StartsWith("+"))
            {
                return MyRegexPhoneNumber.IsMatch(phoneNumber) ? phoneNumber : "numero de telefono invalido";
            }
            else
            {
                string phoneWithPrefix = "+58 " + phoneNumber;
                return MyRegexPhoneNumber.IsMatch(phoneWithPrefix) ? phoneWithPrefix : "numero de telefono invalidor";
            }
        }

        public static readonly Regex MyRegexPhoneNumber = new Regex(@"^\+?[0-9]{1,15}$");

        private static void EsperaPresionarTecla()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }


}
