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
            Console.Write("Ingrese una opción (1-4): ");
            string opcion = Console.ReadLine();

            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
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
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor seleccione una opción del 1 al 4.");
            }

            Console.Write("¿Desea realizar otro cálculo? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            continuar = (respuesta == "s");
        }
    }
}
