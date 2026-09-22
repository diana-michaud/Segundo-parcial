// Challenge 1: Combate por turnos

// Crea un juego en el que el jugador se enfrente a un enemigo en un combate por turnos cumpliendo con las siguientes
// condiciones:

// Participantes: Ambos personajes tienen puntos de vida (con un máximo definido) y ataque.
// Inicio: Elige de forma aleatoria quién hace el primer movimiento.
// Acciones del jugador: En su turno, el jugador puede elegir entre atacar o curarse.
// Daño y combate: El daño provocado puede variar en cada golpe. La pelea continúa turno a turno hasta que uno sea
// derrotado.

// Reglas del juego:
// Valida todas las entradas de datos que ingrese el usuario, pidiéndolas nuevamente si son invalidas.
// La vida nunca puede ser menor a 0 ni superar su valor máximo.
// Si un personaje es derrotado, pierde la oportunidad de seguir atacando.

// Genera valores aleatorios DIFERENTES cada ejercicio.
// var random = new Random ();

// Genera valores aleatorios IGUALES cada ejercicio.
// var random = new Random (1234);

//Mostrar la vida de las jugadoras (no puede nunca ser mayor a 67 o menor a 0) (Jugadora 1 y 2: ataque aleatorio)
//Elegir quien inicia (aleatorio)
//Mostrar que puede atacar o curarse en cada ronda (Si la entrada no es correcta, indicar que vuelva a ingresarla)
//Cuando una sea derrotada mostrar que ya no puede atacar ni curarse


//Mostrar la vida de las jugadoras (no puede nunca ser mayor a 67 o menor a 0) (Jugadora 1 y 2: ataque aleatorio)
Console.WriteLine("\n");
Console.WriteLine("Hola jugadoras, hoy combatiran a muerte, ambas epezarán con 67 porciento de vida, decidiran, en cada turno, si quieren atacar o curarse, quien logrte reducir la vida de la otra a 0 es la ganadora");
Console.WriteLine ("\n");
Console.WriteLine ("Ingresa el nombre de la jugadora 1:");
string jugadora1      = Console.ReadLine();
int    vidajugadora1  = 67;
Random v              = new Random();
var    y              = v.Next(10, 21);
int    ataque1        = v.Next(10, 21);
Console.WriteLine("El ataque de " + jugadora1 + " es: " + ataque1);
int curacion1 = v.Next(10, 21);
Console.WriteLine("La curacion de " + jugadora1 + " es: " + curacion1);
Console.WriteLine("\n");
Console.WriteLine ("Ingresa el nombre de la jugadora 2:");
string jugadora2     = Console.ReadLine();
int    vidajugadora2 = 67;
int    vidajugadora22;
int    ataque2 = v.Next(10, 21);
Console.WriteLine("El ataque de " + jugadora2 + " es: " + ataque2);
int curacion2 = v.Next(10, 21);
Console.WriteLine("La curacion de " + jugadora2 + " es: " + curacion2);
Console.WriteLine ("\n");
Console.WriteLine ("¡Empezamos!, da enter para continuar");
Console.WriteLine("\n\n");
Console.ReadLine();
var r = new Random();
var x = r.Next(1, 3);

//Elegir quien inicia (aleatorio)
while (vidajugadora1 > 0 && vidajugadora2 > 0)
{

    if (x == 1)
    {       Console.WriteLine("\n");
        Console.WriteLine(jugadora1 + " Comienza");
        Console.WriteLine("\n");
        Console.WriteLine(jugadora1 + " deseas atacar o curarte");
        string aoc = Console.ReadLine();
        if (aoc == "atacar")
        {Console.WriteLine("\n");
            vidajugadora2 = vidajugadora2 - ataque1;
            Console.WriteLine("Ahora la vida de " + jugadora2 + " es: " + vidajugadora2);
        }
        else if (aoc == "curar")

        {
            vidajugadora1 = vidajugadora1 + curacion1;
            if (vidajugadora1 > 67)
            {
             vidajugadora1 = 67;
            }
            Console.WriteLine("Ahora la vida de " + jugadora1 + " es: " + vidajugadora1);
        }
        else
        {
            Console.WriteLine("Porfavor ingresa si deseas atacar o curarte");
        }
        Console.WriteLine("\n");
        Console.WriteLine(jugadora2 + " Comienza");
        Console.WriteLine("\n");
        //Mostrar que puede atacar o curarse en cada ronda
        //(Si la entrada no es correcta, indicar que vuelva a ingresarla)
        Console.WriteLine(jugadora2 + " deseas atacar o curarte");
        string aoc1 = Console.ReadLine();

        if (aoc1 == "atacar")

        {   Console.WriteLine("\n");
            vidajugadora1 = vidajugadora1 - ataque2;

            Console.WriteLine("Ahora la vida de " + jugadora1 + " es: " + vidajugadora1);
        }
        else if (aoc1 == "curar")

        {
            vidajugadora2 = vidajugadora2 + curacion2;
            if (vidajugadora2 > 67)
            {
                vidajugadora2 = 67;
            }
            Console.WriteLine("Ahora la vida de " + jugadora2 + " es: " + vidajugadora2);
        }
        else
        {
            Console.WriteLine("Porfavor ingresa si deseas atacar o curarte");
        }
    }
    else if (x == 2)
    {
        Console.WriteLine("\n");
        Console.WriteLine(jugadora2 + " Comienza");
        Console.WriteLine("\n");
        //Mostrar que puede atacar o curarse en cada ronda
        //(Si la entrada no es correcta, indicar que vuelva a ingresarla)
        Console.WriteLine(jugadora2 + " deseas atacar o curarte");
        string aoc1 = Console.ReadLine();
        if (aoc1 == "atacar")

        { Console.WriteLine("\n");
            vidajugadora1 = vidajugadora1 - ataque2;

            Console.WriteLine("Ahora la vida de " + jugadora1 + " es: " + vidajugadora1);
        }
        else if (aoc1 == "curar")

        {
            vidajugadora2 = vidajugadora2 + curacion2;
            if (vidajugadora2 > 67)
            {
                vidajugadora2 = 67;
            }
            Console.WriteLine("Ahora la vida de " + jugadora2 + " es: " + vidajugadora2);
        }
        else
        {
            Console.WriteLine("Porfavor ingresa si deseas atacar o curarte");
        }
        Console.WriteLine("\n");
        Console.WriteLine(jugadora1 + " Comienza");
        Console.WriteLine("\n");
        Console.WriteLine(jugadora1 + " deseas atacar o curarte");
        string aoc = Console.ReadLine();
        if (aoc == "atacar")

        {           Console.WriteLine("\n");
            vidajugadora2 = vidajugadora2 - ataque1;
            Console.WriteLine("Ahora la vida de " + jugadora2 + " es: " + vidajugadora2);
        }
        else if (aoc == "curar")

        {
            vidajugadora1 = vidajugadora1 + curacion1;
            if (vidajugadora1 > 67)
            {
                vidajugadora1 = 67;
            }
            Console.WriteLine("Ahora la vida de " + jugadora1 + " es: " + vidajugadora1);
        }
        else
        {
            Console.WriteLine("Porfavor ingresa si deseas atacar o curarte");
        }
    }
    Console.WriteLine("\n");
}
if (vidajugadora1 < 0)
{
    Console.WriteLine(jugadora1 + " ha perdido");
}
else if (vidajugadora2 < 0)
{
    Console.WriteLine(jugadora2 + " ha perdido");
}
Console.WriteLine("\n\n");
Console.WriteLine("¡GRACIAS POR JUGAR!");

