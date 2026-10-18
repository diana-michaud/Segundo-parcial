// Diana Hernández Michaud y Jimena Guadalupe Contreras Ramírez.

// Ejercicio 2. Personalización de un personaje
// Un videojuego utiliza imágenes construidas con caracteres de texto para representar a sus personajes. El
// jugador puede personalizar su apariencia modificando el color de los diferentes símbolos que componen la
// imagen.
// El personaje se ve así en la consola:

//                       #####
//                      ##+++##
//                     #++@+@++#
//                     #+++++++#
//                     #++###++#
//                      ##+++##
//                        # #

// La imagen se proporciona como un arreglo de cadenas. Cada elemento contiene un carácter de la imagen
// y cada renglón del arreglo corresponde a una línea de la imagen. El elemento "SALTO" al final de cada
// renglón indica que en ese punto debe agregarse un salto de línea.

string[] sprite =
[
" ", " ", "#", "#", "#", "#", "#", " ", " ", "SALTO",
" ", "#", "#", "+", "+", "+", "#", "#", " ", "SALTO",
"#", "+", "+", "@", "+", "@", "+", "+", "#", "SALTO",
"#", "+", "+", "+", "+", "+", "+", "+", "#", "SALTO",
"#", "+", "+", "#", "#", "#", "+", "+", "#", "SALTO",
" ", "#", "#", "+", "+", "+", "#", "#", " ", "SALTO",
" ", " ", "#", " ", " ", " ", "#", " ", " ", "SALTO"
];

// Desarrollen un programa que cumpla con lo siguiente:
// 1. Mostrar la imagen original a partir del arreglo, respetando los símbolos, espacios y saltos de línea.
// 2. Solicitar al usuario el color que desea asignar a cada uno de los tres símbolos: #, + y @.
// 3. Mostrar nuevamente la imagen, utilizando los colores seleccionados para cada símbolo.

// Consideraciones:
// Copien el arreglo tal como se proporciona. Ambas representaciones deben generarse a partir de él, sin
// duplicarlo ni modificarlo.
// El color se aplica al texto de cada símbolo, no al fondo. Los espacios no se colorean.
// Cada símbolo tendrá un color asignado, que deberá mantenerse en todas sus apariciones.
// Los colores disponibles son: rojo (Red), verde (Green), azul (Blue), amarillo (Yellow), cian (Cyan),
// magenta (Magenta) y blanco (White).
// El programa debe mostrarle al usuario cuáles son las opciones disponibles.
// Se puede asignar el mismo color a diferentes símbolos.

// Casos de prueba
// Asignar el mismo color a los tres símbolos.
// Asignar un color diferente a cada símbolo.
// Elegir el primer y el último color de la lista de opciones.

Console.WriteLine("¡Este es tu personaje! A continuación podrás personalizar sus colores.");
Console.WriteLine("       #####        ");
Console.WriteLine("      ##+++##       ");
Console.WriteLine("     #++@+@++#      ");
Console.WriteLine("     #+++++++#      ");
Console.WriteLine("     #++###++#      ");
Console.WriteLine("      ##+++##       ");
Console.WriteLine("        # #         ");

ConsoleColor colorOg = Console.ForegroundColor;

Dictionary<string, ConsoleColor> coloresElegidos = new Dictionary<string, ConsoleColor>();
Console.WriteLine("\n");

// Pedir colores al usuario: rojo (Red), verde (Green), azul (Blue), amarillo (Yellow), cian (Cyan),
// magenta (Magenta) y blanco (White).

Console.WriteLine("Elige un número para seleccionar el color a ´#´");
Console.WriteLine("Los colores disponibles son los siguientes");
Console.WriteLine("1. Red, 2. Green, 3. Blue, 4. Yellow, 5. Cyan, 6. Magenta, 7. White");

string opcion1 = Console.ReadLine();
if (opcion1 == "1") coloresElegidos["#"]      = ConsoleColor.Red;
else if (opcion1 == "2") coloresElegidos["#"] = ConsoleColor.Green;
else if (opcion1 == "3") coloresElegidos["#"] = ConsoleColor.Blue;
else if (opcion1 == "4") coloresElegidos["#"] = ConsoleColor.Yellow;
else if (opcion1 == "5") coloresElegidos["#"] = ConsoleColor.Cyan;
else if (opcion1 == "6") coloresElegidos["#"] = ConsoleColor.Magenta;
else if (opcion1 == "7") coloresElegidos["#"] = ConsoleColor.White;

//----------------------

Console.WriteLine("Elige un número para seleccionar el color a ´+´");
Console.WriteLine("Los colores disponibles son los siguientes");
Console.WriteLine("1. Red, 2. Green, 3. Blue, 4. Yellow, 5. Cyan, 6. Magenta, 7. White");

string opcion2 = Console.ReadLine();
if (opcion2 == "1") coloresElegidos["+"]      = ConsoleColor.Red;
else if (opcion2 == "2") coloresElegidos["+"] = ConsoleColor.Green;
else if (opcion2 == "3") coloresElegidos["+"] = ConsoleColor.Blue;
else if (opcion2 == "4") coloresElegidos["+"] = ConsoleColor.Yellow;
else if (opcion2 == "5") coloresElegidos["+"] = ConsoleColor.Cyan;
else if (opcion2 == "6") coloresElegidos["+"] = ConsoleColor.Magenta;
else if (opcion2 == "7") coloresElegidos["+"] = ConsoleColor.White;

//----------------------

Console.WriteLine("Elige un número para seleccionar el color a ´@´");
Console.WriteLine("Los colores disponibles son los siguientes");
Console.WriteLine("1. Red, 2. Green, 3. Blue, 4. Yellow, 5. Cyan, 6. Magenta, 7. White");

string opcion3 = Console.ReadLine();
if (opcion3 == "1") coloresElegidos["@"]      = ConsoleColor.Red;
else if (opcion3 == "2") coloresElegidos["@"] = ConsoleColor.Green;
else if (opcion3 == "3") coloresElegidos["@"] = ConsoleColor.Blue;
else if (opcion3 == "4") coloresElegidos["@"] = ConsoleColor.Yellow;
else if (opcion3 == "5") coloresElegidos["@"] = ConsoleColor.Cyan;
else if (opcion3 == "6") coloresElegidos["@"] = ConsoleColor.Magenta;
else if (opcion3 == "7") coloresElegidos["@"] = ConsoleColor.White;

//----------------------


Console.WriteLine("¡LISTO! Aquí está tu personaje con colores personalizados:");

foreach (string caracter in sprite)
{
    if (caracter == "SALTO")
    {
        Console.WriteLine();
    }
    else
    {
        if (coloresElegidos.ContainsKey(caracter))
        {
            Console.ForegroundColor = coloresElegidos[caracter];
        }
        else
        {
            Console.ForegroundColor = colorOg;
        }
        Console.Write(caracter);
    }
}

