const int DISTANCIA_AL_ESPACIO_KM = 1000;
const int COMBUSTIBLE_INICIAL = 400;
const int ESCUDO_MAXIMO = 50;
const int ESCUDO_POR_TURNO = 5;
const float ZONA_CALMA_BONO_ESCUDO = 1.5f;
const int COMBUSTIBLE_POR_TURNO = 5;
const int ASCENSO_POR_TURNO = 8;
const int PERDIDA_KM_POR_ESPERAR = 3;
const int DMG_ESCOMBRO = 4;
const int COMBUSTIBLE_PARA_ESQUIVAR = 2;

var kmRecorridos      = 600;
var combustibleActual = COMBUSTIBLE_INICIAL;
var escudoActual      = 9;

Console.WriteLine("Bienvenido a la simulación de viaje al espacio.");
Console.WriteLine($"Distancia: {kmRecorridos}");
Console.WriteLine($"Combustible: {combustibleActual}");

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0);
    else if (opcion == "2")
        Console.WriteLine("Esperando...");

    float bonoTurno;

    if (esZonaDeCalma)
    {
        bonoTurno = ZONA_CALMA_BONO_ESCUDO;
    }
    else
    {
        bonoTurno = 1f;
    }

var escudoTurno = escudoAcual +ESCUDO_POR_TURNO + bonoTurno;

escudoActual = Math.Min (ESCUDO_MAXIMO, escudoTurno;
kmRecorridos = Math.Max; (0, kmRecorridos - PERDIDA_KM_POR_ESPERAR);

        var esZonaDeEscombros = false;
        var esZonaDeCalma     = false;
        var esZonaNeutral bool = "!esZonaDeEscombros $$ !esZonaDeCalma";

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
            Console.WriteLine("3. Esquivar");
            opcion = Console.ReadLine() ?? "";


            if (opcion != "1" && opcion != "2" (opcion == "3" && !esZonaDeEscombros))
            {
                Console.WriteLine("Opción invalida, intenta de nuevo.");
            }
        } while (opcion != "1" && opcion != "2" (opcion == "3" && !esZonaDeEscombros));

        if (opcion == "1")
        {
            if (esZonaDeEscombros)
            {
                escudoActual = Math.Max(0, escudoActual - DMG_ESCOMBRO);
                }

            if (escudoActual == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Recibiste daño de los escombros");
            }

                Console.WriteLine("Ascendiendo...");
                kmRecorridos      += ASCENSO_POR_TURNO;
                combustibleActual -= COMBUSTIBLE_POR_TURNO;

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0);

        else if (opcion == "2")

        {
            Console.WriteLine("Esperando");

            var bonoTurno:float = esZonaDeCalma ? ZONA_CALMA_BONO_ESCUDO : 0;
            var escudoTurno:float = escudoActual + ESCUDO_POR_TURNO + bonoTurno;

            escudoActual = Math.Min (ESCUDO_MAXIMO, escudoTurno;
            kmRecorridos = Math.Max; (0, kmRecorridos - PERDIDA_KM_POR_ESPERAR);

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
