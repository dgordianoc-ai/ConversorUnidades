using System;

namespace ConversorUnidades
{
    public class Program
    {
        public static void Main()
        {
            string opcion;

            do
            {
                opcion = LeerOpcionMenu();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese los grados Celsius: ");
                        bool valorOK1 = decimal.TryParse(Console.ReadLine(), out decimal valor1);

                        if (valorOK1)
                        {
                            decimal convertido = CelsiusAFahrenheit(valor1);
                            MostrarResultado(valor1, convertido, "°C", "°F");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese los grados Fahrenheit: ");
                        bool valorOK2 = decimal.TryParse(Console.ReadLine(), out decimal valor2);

                        if (valorOK2)
                        {
                            decimal convertido = FahrenheitACelsius(valor2);
                            MostrarResultado(valor2, convertido, "°F", "°C");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese los kilómetros: ");
                        bool valorOK3 = decimal.TryParse(Console.ReadLine(), out decimal valor3);

                        if (valorOK3)
                        {
                            decimal convertido = KmAMillas(valor3);
                            MostrarResultado(valor3, convertido, "km", "millas");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "4":
                        Console.Write("Ingrese las millas: ");
                        bool valorOK4 = decimal.TryParse(Console.ReadLine(), out decimal valor4);

                        if (valorOK4)
                        {
                            decimal convertido = MillasAKm(valor4);
                            MostrarResultado(valor4, convertido, "millas", "km");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }
            while (opcion != "5");
        }

        private static string LeerOpcionMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=== CONVERSOR DE UNIDADES ===");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Millas a Kilómetros");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            return Console.ReadLine();
        }

        private static decimal CelsiusAFahrenheit(decimal valor)
        {
            return (valor * 9 / 5) + 32;
        }

        private static decimal FahrenheitACelsius(decimal valor)
        {
            return (valor - 32) * 5 / 9;
        }

        private static decimal KmAMillas(decimal valor)
        {
            return valor * 0.621371m;
        }

        private static decimal MillasAKm(decimal valor)
        {
            return valor * 1.60934m;
        }

        private static void MostrarResultado(
            decimal original,
            decimal convertido,
            string unidadOriginal,
            string unidadConvertida)
        {
            Console.WriteLine(
                $"{original:N2} {unidadOriginal} = {convertido:N2} {unidadConvertida}");
        }
    }
}