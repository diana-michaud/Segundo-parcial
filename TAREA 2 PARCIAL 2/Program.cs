// Tarea de Programación - Ejercicios de Arreglos y Listas

// Micro-ejercicio #1
// Registro manual de los eventos del combate:
// ¿Arreglo o lista?: Arreglo descriptivo

string[] historialBatalla = new string[6]
                            {
                                "Jugador ataca por 5",
                                "El enemigo ataca por 6",
                                "Jugador ataca por 7 (crit)",
                                "¡Enemigo aturdido!",
                                "Jugador ataca por 5",
                                "¡El enemigo ha muerto!"
                            };

// Se usa un ciclo for en lugar de foreach para recorrer el arreglo
for (int posicion = 0; posicion < 6; posicion++)
{
    Console.WriteLine(historialBatalla[posicion]);
}

Console.WriteLine("\n\n\n");


// Micro-ejercicio #2
// Control de las criaturas activas en la partida:
// Lista dinámica

List<string> monstruos = new List<string>() { "Slime", "Goblin", "Skeleton" };

Console.WriteLine($"Capacity: {monstruos.Capacity}");
Console.WriteLine($"Count: {monstruos.Count}");
Console.WriteLine("\n");

// Paso 2: Sumar un Orc
monstruos.Add("Orc");
foreach (string info in monstruos)
{
    Console.WriteLine(info);
}
Console.WriteLine("\n");

// Paso 3: Restar el Slime
monstruos.Remove("Slime");
foreach (string info in monstruos)
{
    Console.WriteLine(info);
}
Console.WriteLine("\n");

// Paso 4: Sumar otro Orc
monstruos.Add("Orc");
foreach (string info in monstruos)
{
    Console.WriteLine(info);
}
Console.WriteLine("\n");

// Paso 5: Restar el primer Orc que encuentre
monstruos.Remove("Orc");
foreach (string info in monstruos)
{
    Console.WriteLine(info);
}

