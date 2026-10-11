Dictionary<string, int> items = new()
                                {
                                    { "Espada", 25 },
                                    { "Cuchillo", 25 },
                                    { "Arco", 15 },
                                    { "Hacha", 35 },
                                };

Console.WriteLine(items["Espada"]);
Console.WriteLine(items["Hacha"]);

if (items.ContainsKey("Cuchillo") == false);
{

}

items["Arco"] = 20;

Console.WriteLine(items["Arco"]);


if(items.ContainsKey("Hoz")) {
    Console.WriteLine("DMG Hoz: " + items["Hoz"]);
}
Console.WriteLine($"El valor es [Hoz]");

if (items.TryGetValue("Hoz", out int dmgHoz))
{
    Console.WriteLine($"DMG hacha: {dmg}");
}
if(items.ContainsKey("Hacha"))
{
    Console.WriteLine($"DMG hacha: {dmg}");
}

Console.WriteLine(items.Count);


// Micro ejercicio 1

// Micro ejercicio 2
