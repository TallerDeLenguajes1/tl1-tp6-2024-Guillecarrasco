// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//ejercicio1
 Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();
        

        if (int.TryParse(input, out int number))
        {
            if (number > 0)
            {

                char[] arr = input.ToCharArray();
                Array.Reverse(arr);
                string reversedString = new string(arr);

                int reversedNumber = int.Parse(reversedString);

                Console.WriteLine("El número invertido es: " + reversedNumber);
            }
            else
            {
                Console.WriteLine("El número debe ser mayor a 0.");
            }
        }
        else
        {
            Console.WriteLine("Por favor ingrese un número válido.");
        }


