using System;

class Calculadora
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Seleccione la operación que desea realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Valor absoluto de un número");
            Console.WriteLine("6. Cuadrado de un número");
            Console.WriteLine("7. Raíz cuadrada de un número");
            Console.WriteLine("8. Seno de un número");
            Console.WriteLine("9. Coseno de un número");
            Console.WriteLine("10. Parte entera de un número float");
            Console.WriteLine("11. Máximo entre dos números");
            Console.WriteLine("12. Mínimo entre dos números");
            Console.Write("Ingrese una opción (1-12): ");
            string opcion = Console.ReadLine();

            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" ||
                opcion == "11" || opcion == "12")
            {
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado de la suma es: {resultado}");
                        break;
                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado de la resta es: {resultado}");
                        break;
                    case "3":
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"El resultado de la división es: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;
                    case "11":
                        resultado = Math.Max(num1, num2);
                        Console.WriteLine($"El máximo entre {num1} y {num2} es: {resultado}");
                        break;
                    case "12":
                        resultado = Math.Min(num1, num2);
                        Console.WriteLine($"El mínimo entre {num1} y {num2} es: {resultado}");
                        break;
                }
            }
            else if (opcion == "5" || opcion == "6" || opcion == "7" || opcion == "8" || opcion == "9" || opcion == "10")
            {
                Console.Write("Ingrese un número: ");
                double num = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "5":
                        Console.WriteLine($"El valor absoluto de {num} es: {Math.Abs(num)}");
                        break;
                    case "6":
                        Console.WriteLine($"El cuadrado de {num} es: {num * num}");
                        break;
                    case "7":
                        if (num >= 0)
                        {
                            Console.WriteLine($"La raíz cuadrada de {num} es: {Math.Sqrt(num)}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                        }
                        break;
                    case "8":
                        Console.WriteLine($"El seno de {num} es: {Math.Sin(num)}");
                        break;
                    case "9":
                        Console.WriteLine($"El coseno de {num} es: {Math.Cos(num)}");
                        break;
                    case "10":
                        Console.WriteLine($"La parte entera de {num} es: {Math.Truncate(num)}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor seleccione una opción del 1 al 12.");
            }

            Console.Write("¿Desea realizar otra operación? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            continuar = (respuesta == "s");
        }

        Console.WriteLine("Gracias por usar la calculadora. ¡Adiós!");
    }
}
