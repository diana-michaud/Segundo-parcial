const int DISTANCIA_AL_ESPACIO_KM = 1000;
const int COMBUSTIBLE_INICIAL = 400;
const int ESCUDO_POR_TURNO = 5;
const int COMBUSTIBLE_POR_TURNO = 5;
const int ASCENSO_POR_TURNO = 8;
const int PERDIDA_KM_POR_ESPERAR = 3;

var kmRecorridos      = 600;
var combustibleActual = COMBUSTIBLE_INICIAL;

Console.WriteLine("Bienvenido a la simulación de viaje al espacio.");
Console.WriteLine($"Distancia: {kmRecorridos}");
Console.WriteLine($"Combustible: {combustibleActual}");

    {
        var esZonaDeEscombros = false;
        var esZonaDeCalma     = false;

        string opcion;

        do
        {
            if(esZonaDeEscombros)
            {
                Console.WriteLine("Estás en una zona de escombros.");
            }
            else if(esZonaDeCalma)
            {
                Console.WriteLine("Estás en una zona de calma.");
            }
            else if (esZonaNeutral)
            {
                Console.WriteLine("Estás en una zona neutral.");
            }

            Console.WriteLine("¿Qué acción quieres realizar?: ");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");
            opcion = Console.ReadLine() ?? "";


            {
                Console.WriteLine("Opción invalida, intenta de nuevo.");
            }

        if (opcion == "1")
        {
                Console.WriteLine("Ascendiendo...");
                kmRecorridos      += ASCENSO_POR_TURNO;
                combustibleActual -= COMBUSTIBLE_POR_TURNO;

        else if (opcion == "2")
        {
            Console.WriteLine("Esperando");
        }

        Console.WriteLine($"Distancia: {kmRecorridos}");
        Console.WriteLine($"Combustible: {combustibleActual}");
        Console.WriteLine($"Escudo: {escudoActual}");
    }

if (kmRecorridos >= DISTANCIA_AL_ESPACIO_KM)
{
 Console.WriteLine("¡LLEGASTE AL ESPACIO!");
}
else
{
    Console.WriteLine("NO LLEGASTE AL ESPACIO");
}
