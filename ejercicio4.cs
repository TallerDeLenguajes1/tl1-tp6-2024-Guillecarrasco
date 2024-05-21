using System;

class Ejercicio4
{
    static void Main()
    {
        string cadena = ObtenerCadena();
        MostrarLongitud(cadena);

        string segundaCadena = ObtenerSegundaCadena();
        string concatenada = ConcatenarCadenas(cadena, segundaCadena);
        Console.WriteLine($"Las cadenas concatenadas son: {concatenada}");

        string subcadena = ObtenerSubcadena(cadena);
        Console.WriteLine($"La subcadena extraída es: {subcadena}");

        RealizarOperacionesMatematicas();

        RecorrerCadena(cadena);

        BuscarPalabra(cadena);

        ConvertirMayusculasMinusculas(cadena);

        SepararCadenaPorCaracteres();

        ResolverEcuacion();
    }

    static string ObtenerCadena()
    {
        Console.Write("Ingrese una cadena de texto: ");
        return Console.ReadLine();
    }

    static void MostrarLongitud(string cadena)
    {
        int longitud = cadena.Length;
        Console.WriteLine($"La longitud de la cadena es: {longitud}");
    }

    static string ObtenerSegundaCadena()
    {
        Console.Write("Ingrese otra cadena de texto para concatenar: ");
        return Console.ReadLine();
    }

    static string ConcatenarCadenas(string cadena, string segundaCadena)
    {
        return cadena + segundaCadena;
    }

    static string ObtenerSubcadena(string cadena)
    {
        Console.Write("Ingrese el índice de inicio para la subcadena: ");
        int inicio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la longitud de la subcadena: ");
        int longitudSubcadena = Convert.ToInt32(Console.ReadLine());
        return cadena.Substring(inicio, longitudSubcadena);
    }

    static void RealizarOperacionesMatematicas()
    {
        Console.WriteLine("Ahora realizaremos operaciones matemáticas con la calculadora.");
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultadoSuma = num1 + num2;
        double resultadoResta = num1 - num2;
        double resultadoMultiplicacion = num1 * num2;
        double resultadoDivision = num1 / num2;

        Console.WriteLine($"La suma de {num1} y {num2} es igual a: {resultadoSuma}");
        Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resultadoResta}");
        Console.WriteLine($"El producto de {num1} y {num2} es igual a: {resultadoMultiplicacion}");
        Console.WriteLine($"La división de {num1} y {num2} es igual a: {resultadoDivision}");
    }

    static void RecorrerCadena(string cadena)
    {
        Console.WriteLine("Recorriendo la cadena de texto elemento por elemento:");
        foreach (char caracter in cadena)
        {
            Console.WriteLine(caracter);
        }
    }

    static void BuscarPalabra(string cadena)
    {
        Console.Write("Ingrese la palabra que desea buscar: ");
        string palabraBuscada = Console.ReadLine();
        bool palabraEncontrada = cadena.Contains(palabraBuscada);
        if (palabraEncontrada)
        {
            Console.WriteLine($"La palabra '{palabraBuscada}' fue encontrada en la cadena.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabraBuscada}' no fue encontrada en la cadena.");
        }
    }

    static void ConvertirMayusculasMinusculas(string cadena)
    {
        string mayusculas = cadena.ToUpper();
        string minusculas = cadena.ToLower();
        Console.WriteLine($"Cadena en mayúsculas: {mayusculas}");
        Console.WriteLine($"Cadena en minúsculas: {minusculas}");
    }

    static void SepararCadenaPorCaracteres()
    {
        Console.Write("Ingrese una cadena separada por caracteres: ");
        string cadenaSeparada = Console.ReadLine();
        string[] caracteres = cadenaSeparada.Split(',');
        Console.WriteLine("Caracteres separados:");
        foreach (string caracter in caracteres)
        {
            Console.WriteLine(caracter.Trim());
        }
    }

    static void ResolverEcuacion()
    {
        Console.Write("Ingrese una ecuación simple (por ejemplo, '582+2'): ");
        string ecuacion = Console.ReadLine();
        string[] partes = ecuacion.Split('+');
        if (partes.Length == 2 && double.TryParse(partes[0], out double num1) && double.TryParse(partes[1], out double num2))
        {
            double resultado = num1 + num2;
            Console.WriteLine($"El resultado de la ecuación es: {resultado}");
        }
        else
        {
            Console.WriteLine("Formato de ecuación incorrecto. Por favor ingrese una ecuación en el formato 'num1+num2'.");
        }
    }
}
