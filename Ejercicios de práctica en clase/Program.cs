// Micro-ejercicio 1
// Genera un programa que muestre un log de combate, donde el jugador realiza 5 puntos de daño al enemigo cada turno
// Prueba con diferentes valores iniciales de vida:
// -50
// -5
// -0

int vidaDeEnemigo = 50;
Console.WriteLine("Vida Del Enemigo" + vidaDeEnemigo);
Console.Write("Presiona enter para atacar");
while (vidaDeEnemigo > 0)
{Console.ReadLine ();
    vidaDeEnemigo = vidaDeEnemigo - 5;
    Console.Write("Al enemigo le resta " + vidaDeEnemigo + " de vida");
}
Console.WriteLine("");
Console.WriteLine("¡¡Derrotaste al enemigo!!");

Console.WriteLine("------------------------------");

// Micro-ejerciciooo 2
// Genera un programa que pida al usuario un número entero.
// Sigue pidiendo valroes hasta que el usuario ingrese un valor correcto, mostrando un mensaje de error o éxito según
// sea el caso.
// Intenta con los sigueintes valores poara comprobar:
// 9.5 = Error
// H = error
// 5 = Correcto

string num;
int    NUM;
do
{
    Console.WriteLine("Escribe un número entero");
    num = Console.ReadLine();
} while (!int.TryParse(num, out NUM));

Console.WriteLine("------------------------------");

// Micro-ejercicio 3
// Crea una tabla del 7 que vaya del 0 al 100 de forma ordenada.

Console.WriteLine("Para ver la tabla de 7, presiona enter");
Console.ReadLine();
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine($"[{i*7}");
}
