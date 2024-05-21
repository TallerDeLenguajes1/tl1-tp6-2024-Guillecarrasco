#Tipos por valor vs. tipos por referencia
##String: En C#, string es un tipo por referencia. Aunque string se comporta como un tipo inmutable (no puede cambiar su valor una vez creado), sigue siendo un objeto en el montón (heap) y se pasa por referencia.

#Secuencias de escape del tipo string
###Descripción: Las secuencias de escape se utilizan para representar caracteres especiales dentro de cadenas.

###Uso común:

\n - Nueva línea
\r - Retorno de carro
\t - Tabulación horizontal
\\ - Barra invertida
\" - Comilla doble
\' - Comilla simple
\uXXXX - Carácter Unicode (donde XXXX es el código hexadecimal)
#Uso del carácter @ y $ antes de una cadena de texto
##Carácter @:

###Descripción: Denota una cadena de texto literal, donde las secuencias de escape no son procesadas. Permite incluir comillas dobles dentro de la cadena sin necesidad de escape.
Ejemplo:
string ruta = @"C:\Usuarios\Nombre";  // ruta = "C:\Usuarios\Nombre"
string texto = @"Ella dijo: ""Hola Mundo""";  // texto = "Ella dijo: \"Hola Mundo\""

#####Carácter $:

###Descripción: Indica una cadena interpolada, donde puedes incluir expresiones dentro de llaves {} que serán evaluadas y concatenadas en tiempo de ejecución.
Ejemplo:

int a = 5;
int b = 10;
string resultado = $"La suma de {a} y {b} es {a + b}";  // resultado = "La suma de 5 y 10 es 15"

##Combinación de @ y $:

###Descripción: Permite crear cadenas interpoladas con texto literal.
Ejemplo:

string nombre = "C#";
string ruta = @$"C:\Usuarios\{nombre}\Documentos";  // ruta = "C:\Usuarios\C#\Documentos"
Este texto formateado en Markdown proporciona una descripción clara de los conceptos mencionados y ejemplos de su uso en C#.

nfkjdhbrgjerhuer