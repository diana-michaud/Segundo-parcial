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
Console.WriteLine("Hola jugadoras, hoy combatiran a muerte, ambas epezarán con 67 porciento de vida, decidiran, en cada turno, si quieren atacar o curarse, quien logrte reducir la vida de la otra a 0 es la ganadora");
Console.WriteLine ("\n");
Console.WriteLine ("Ingresa el nombre de la jugadora 1:");
string jugadora1 = Console.ReadLine();
int vidajugadora1 = 67;
Random v = new Random();
var y = v.Next(10, 21);
int ataque1 = v.Next(10, 21);
Console.WriteLine("El ataque de " + jugadora1 + " es: " + ataque1);
int curacion1 = v.Next(10, 21);
Console.WriteLine("La curacion de " + jugadora1 + " es: " + curacion1);
Console.WriteLine ("Ingresa el nombre de la jugadora 2:");
string jugadora2 = Console.ReadLine();
int vidajugadora2 = 67;
int ataque2 = v.Next(10, 21);
Console.WriteLine("El ataque de " + jugadora2 + " es: " + ataque2);
int curacion2 = v.Next(10, 21);
Console.WriteLine("La curacion de " + jugadora2 + " es: " + curacion2);
Console.WriteLine ("\n");
Console.WriteLine ("¡Empezamos!, da enter para continuar");
Console.ReadLine();
var r = new Random();
var x = r.Next(1, 3);

if (x == 1)
{
    Console.WriteLine( jugadora1 + " Comienza");
}
else
{
    Console.WriteLine( jugadora2 + " Comienza");
    Console.WriteLine(jugadora2 + "Deseas atacar o curarte");
    string aoc =Console.ReadLine();

    if (aoc == "atacar")
    {
        vidajugadora1 = vidajugadora1 - ataque2;
    }
    else if(aoc == "curar")

    {
        vidajugadora2 = vidajugadora2 +
    }

}

//Elegir quien inicia (aleatorio)


