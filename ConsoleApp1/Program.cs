// EJERCICIO 4: Depuración de un sistema de equipos
// Un videojuego multijugador utiliza un sistema que distribuye aleatoriamente a los participantes en
// diferentes equipos.
// El programa solicita la cantidad de jugadores, sus nombres y el número máximo de integrantes que puede
// tener cada equipo. Después, mezcla los nombres y muestra los equipos generados.
// El programa debe cumplir las siguientes condiciones:
// Código proporcionado
// Solicitar y registrar los nombres de todos los jugadores.
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
Console.Write("Integrantes por equipo: ");
int teamSize = int.Parse(Console.ReadLine());
Random.Shared.Shuffle(players);
int team = 1;
Console.WriteLine($"Equipo {team}:");
for (int i = 0; i < players.Length - 1; i++)
{
    if (i > 0 && i % teamSize == 1)
    {
        team++;
        Console.WriteLine($"Equipo {team}:");
        Console.WriteLine(players[i % teamSize]);
    } }

