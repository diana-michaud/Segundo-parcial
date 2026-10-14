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


Console.WriteLine("       #####        ");
Console.WriteLine("      ##+++##       ");
Console.WriteLine("     #++@+@++#      ");
Console.WriteLine("     #+++++++#      ");
Console.WriteLine("     #++###++#      ");
Console.WriteLine("      ##+++##       ");
Console.WriteLine("        # #         ");


string colorRojo  = "Rojo";
string colorVerde = "Verde";
string colorAzul  = "Azul";


List<char> color = new List<char>() {
                                        '#', '+', '@'
                                    };



Console.Write ("El color del carácter ¨#¨ es rojo");
string       caracter = Console.ReadLine();
Console.WriteLine ("Elijo el color " + colorRojo + " para el caracter: " + caracter + "¨#¨");



Console.Write ("El color del carácter ¨+¨ es verde");
string       Color = Console.ReadLine();
Console.WriteLine ("Elijo el color " + colorVerde + " para el caracter: " + caracter+ "¨+¨");



Console.Write ("El color del carácter ¨@¨ es azul");
string       COLOR = Console.ReadLine();
Console.WriteLine ("Elijo el color " + colorAzul + " para el caracter: " + caracter + "¨@¨");



char         rojo = '#';
ConsoleColor a    = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkRed;

char         verde = '+';
ConsoleColor b     = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;

char         azul = '@';
ConsoleColor c    = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkBlue;


Console.WriteLine("\nResultado:");


Console.WriteLine("       #####        ");
Console.WriteLine("      ##+++##       ");
Console.WriteLine("     #++@+@++#      ");
Console.WriteLine("     #+++++++#      ");
Console.WriteLine("     #++###++#      ");
Console.WriteLine("      ##+++##       ");
Console.WriteLine("        # #         ");
