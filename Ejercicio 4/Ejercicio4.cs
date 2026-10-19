// Diana Hernández Michaud y Jimena Guadalupe Contreras Ramírez.

// EJERCICIO 4: Depuración de un sistema de equipos.

// Un videojuego multijugador utiliza un sistema que distribuye aleatoriamente a los participantes en
// diferentes equipos.
// El programa solicita la cantidad de jugadores, sus nombres y el número máximo de integrantes que puede
// tener cada equipo. Después, mezcla los nombres y muestra los equipos generados.
// El programa debe cumplir las siguientes condiciones:
// Código proporcionado
// 1. Solicitar y registrar los nombres de todos los jugadores.
// 2. Organizar aleatoriamente a los participantes en equipos.
// 3. Respetar la cantidad máxima de integrantes por equipo.
// 4. Incluir a todos los jugadores exactamente una vez, sin repetir ni omitir nombres.
// 5. Numerar los equipos consecutivamente, comenzando en 1.
// 6. Cuando la cantidad de jugadores no permita formar exclusivamente equipos completos, el último
// equipo tendrá menos integrantes.


Console.Write("Cantidad de jugadores: ");
int      playerCount = int.Parse(Console.ReadLine());
string[] players     = new string[playerCount];
for (int i = 0; i < playerCount; i++)
{
    Console.Write($"Nombre {i + 1}: ");
    players[i] = Console.ReadLine();
}
List<string> equipos = new List<string>();
List<int>    scores  = new();
List<int>    ranks   = [];

Console.Write("Integrantes por equipo: ");
int teamSize = int.Parse(Console.ReadLine());
Random.Shared.Shuffle(players);
int team = 1;
Console.WriteLine($"Equipo {team}:");
// 1er error de sintaxis: Eliminé este símbolo ")" no era necesario, estaba de sobra.

for (int i = 0; i < players.Length; i++)
    // 1er error de lógica: Quité el -1 después de "players.Length" porque hacía que el ciclo se detuviera cuando no era momento.
{
    if (i > 0 && i % teamSize == 0)
// 2do error de lógica: Cambié el "== 1" por el "== 0". El "== 1" hacía que el programa empezara a ejecutar la parte del equipo 2 antes de tiempo. Al cambiarlo a "== 0", el programa espera a que el equipo se llene antes de empezar a ejecutar el siguiente.
    {
        team++;
        Console.WriteLine($"Equipo {team}:");
    }
    Console.WriteLine(players[i]);
    // 3er error de lógica: Este error era el más grave, si dejaba este "Console.WriteLine(players[i]);" dentro del corchete, el programa se trababa y no avanzaba.

}
// 2do error de sintaxis: Agregué de nuevo este símbolo "}" al final para poder hacer correcto el código.
