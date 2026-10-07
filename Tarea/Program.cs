// TAREA 1
// Ajustar el sistema de generación de valores aleatorios para que las siguientes
// variables trabajen utilizando límites mínimo y máximo:

// - DISTANCIA_PERDIDA_ESPERAR
// - ESCUDO_RECUPERADO
// - DMG_ESCOMBRO_ESCOMBRO
// - COMBUSTIBLE_ESQUIVAR

// Para establecer los rangos se deben tomar como referencia los valores
// utilizados actualmente para el ascenso.

// El gasto de combustible al esquivar debe funcionar de forma similar al
// consumo de combustible durante un ascenso.

// Antes de realizar una acción, se debe comprobar que el valor aleatorio
// obtenido no supere la cantidad de combustible disponible. Si el valor
// generado es mayor al combustible actual, la acción no debe ejecutarse.

// Configuración general de la partida

const int DISTANCIA_AL_ESPACIO = 100;
const int COMBUSTIBLE_MAX = 40;
const float ESCUDO_MAX = 100f;
const float BONUS_ESCUDO_ZONA_CALMA = 1.2f;

// Límites utilizados para generar valores aleatorios

const int DISTANCIA_ASCENSO_MIN         = 5;
const int DISTANCIA_ASENSO_MAX          = 10;
const int COMBUSTIBLE_ASCENSO_MIN       = 3;
const int COMBUSTIBLE_ASCENSO_MAX       = 700000000;

const int DISTANCIA_PERDIDA_ESPERAR_MIN = 3;
const int DISTANCIA_PERDIDA_ESPERAR_MAX = 7;
const int ESCUDO_RECUPERADO_MIN = 5;
const int ESCUDO_RECUPERADO_MAX = 15;
const int DMG_ESCOMBRO_MIN = 3;
const int DMG_ESCOMBRO_MAX = 8;
const int COMBUSTIBLE_ESQUIVAR_MIN = 2;
const int COMBUSTIBLE_ESQUIVAR_MAX = 6;

// Datos actuales de la nave

var distanciaRecorrida = 0;
var combustibleActual = COMBUSTIBLE_MAX;
var escudoActual = ESCUDO_MAX;

var rng = new Random();

const int PROBABLIDIDAD_ZONA_CALMA = 30; // Probabilidad acumulada hasta 30
const int PROBABLIDIDAD_ZONA_ESCOMBROS = 50; // Valores del 31 al 80
const int PROBABLIDIDAD_ZONA_NORMAL = 20; // Valores del 81 al 100

// Desarrollo de la partida
while (distanciaRecorrida < DISTANCIA_AL_ESPACIO && combustibleActual >= COMBUSTIBLE_ASCENSO_MIN && escudoActual > 0)
{
    var zonaAleatoria = rng.Next(0, 100 + 1);

// Determinar el tipo de zona en la que se encuentra la nave
    var esZonaCalma = zonaAleatoria <= PROBABLIDIDAD_ZONA_CALMA;

// Una zona de escombros corresponde al siguiente intervalo
    var esZonaEscombros = !esZonaCalma
                          && zonaAleatoria <=
                          PROBABLIDIDAD_ZONA_CALMA
                          + PROBABLIDIDAD_ZONA_ESCOMBROS;

    // Mostrar información de la partida
    PrintStatistic(
                   "Distancia ",
                   distanciaRecorrida,
                   DISTANCIA_AL_ESPACIO
                  );
    PrintStatistic(
                   "Escudo ",
                   (int)escudoActual,
                   (int)ESCUDO_MAX
                  );
    PrintStatistic(
                   "Combustible",
                   combustibleActual,
                   COMBUSTIBLE_MAX
                  );

    PrintTurn(
              distanciaRecorrida,
              DISTANCIA_AL_ESPACIO,
              esZonaEscombros,
              esZonaCalma
             );

    // Solicitar una acción al jugador
    string opcion;
    bool esOpcionValida;
    do
    {
        if (esZonaCalma)
        {
            Console.WriteLine("¡Has entrado en una zona de calma!");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");
        }
        else if (esZonaEscombros)
        {
            Console.WriteLine("¡Has entrado en una zona de escombros!");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");

            if (combustibleActual >= COMBUSTIBLE_ESQUIVAR_MIN)
            {
                Console.WriteLine("3. Esquivar");
            }
            else
            {
                Console.WriteLine("3. Esquivar (No tienes suficiente combustible para esquivar)");
            }
        }
        else
        {
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");
        }

        opcion = Console.ReadLine() ?? "";

        esOpcionValida = opcion == "1" ||
                         opcion == "2" ||
                         (esZonaEscombros && combustibleActual >= COMBUSTIBLE_ESQUIVAR_MIN && opcion == "3");

        if (!esOpcionValida)
        {
            Console.WriteLine("Opción inválida. Intenta de nuevo.");
        }
    } while (!esOpcionValida);

    switch (opcion)
    {
        case "1":
        {
            if (esZonaEscombros)
            {
                float dmgEscudo = rng.Next(DMG_ESCOMBRO_MIN, DMG_ESCOMBRO_MAX + 1);
                                dmgEscudo = Math.Min(dmgEscudo, escudoActual);
                                escudoActual -= dmgEscudo;

                Console.WriteLine("¡Has recibido " + dmgEscudo + " unidades de daño en el escudo!");

                if (escudoActual <= 0)
                {
                    Console.WriteLine("¡Tu escudo se ha agotado!");
                    break;
                }
            }

            var combustibleReal = rng.Next(
                                           COMBUSTIBLE_ASCENSO_MIN,
                                           COMBUSTIBLE_ASCENSO_MAX + 1
                                          );

            if (combustibleReal > combustibleActual)
            {
                Console.WriteLine("!No tienes suficiente combustible!");
            }
            else
            {
                var distanciaReal = rng.Next(
                                             DISTANCIA_ASCENSO_MIN,
                                             DISTANCIA_ASENSO_MAX + 1
                                            );
                distanciaRecorrida += distanciaReal;

                combustibleActual -= combustibleReal;

                Console.WriteLine("Has ascendido " + distanciaReal + " unidades.");
                Console.WriteLine("Has utilizado " + combustibleReal + " unidades de combustible.");
            }

            break;
        }
        case "2":
        {
            var bonus            = esZonaCalma ? BONUS_ESCUDO_ZONA_CALMA : 1f;
            var escudoBase       = rng.Next(ESCUDO_RECUPERADO_MIN, ESCUDO_RECUPERADO_MAX + 1);
            var escudoRecuperado = escudoBase * bonus;
            escudoRecuperado =  Math.Min(escudoRecuperado, ESCUDO_MAX - escudoActual);
            escudoActual     += escudoRecuperado;
            Console.WriteLine("¡Has recuperado " + escudoRecuperado + " unidades de escudo!");

            if (esZonaEscombros)
            {
                   float dmgEscudo = rng.Next(DMG_ESCOMBRO_MIN, DMG_ESCOMBRO_MAX + 1);
                                dmgEscudo = Math.Min(dmgEscudo, escudoActual);
                                escudoActual -= dmgEscudo;


                Console.WriteLine("¡Has recibido " + dmgEscudo + " unidades de daño en el escudo!");
            }

            var perdidaAleatoria = rng.Next(DISTANCIA_PERDIDA_ESPERAR_MIN, DISTANCIA_PERDIDA_ESPERAR_MAX + 1);
            var distanciaPerdida = Math.Min(perdidaAleatoria, distanciaRecorrida);
            distanciaRecorrida -= distanciaPerdida;
            Console.WriteLine("Has perdido " + distanciaPerdida + " unidades de distancia.");

            break;
        }
        case "3":
        {
            var combustibleEsquivar = rng.Next(COMBUSTIBLE_ESQUIVAR_MIN, COMBUSTIBLE_ESQUIVAR_MAX + 1);

            if (combustibleEsquivar > combustibleActual)
            {
                Console.WriteLine("¡No tienes suficiente combustible para esquivar!");
            }
            else
            {
                combustibleActual -= combustibleEsquivar;

                Console.WriteLine("Has esquivado un obstáculo.");
                Console.WriteLine("Has utilizado " + combustibleEsquivar + " unidades de combustible.");
            }
            break;
        }
    }

    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
}

if (distanciaRecorrida >= DISTANCIA_AL_ESPACIO)
{
    Console.WriteLine("¡Felicidades! Has llegado al espacio.");
}
else if (combustibleActual < COMBUSTIBLE_ASCENSO_MIN)
{
    Console.WriteLine("¡No tienes suficiente combustible para ascender! Has perdido.");
}
else if (escudoActual <= 0)
{
    Console.WriteLine("¡Tu escudo se ha agotado! Has perdido.");
}

return;

void PrintStatistic(string prefix, int value, int maxValue) {
    var (filledBar, emptyBar) = ProgressBar(value, maxValue);
    var (textColor, bgColor) = ColorGradient(value, maxValue);

    Console.ResetColor();
    Console.Write($"{prefix} [");
    Console.BackgroundColor = bgColor;
    Console.ForegroundColor = textColor;
    Console.Write($"{filledBar}{emptyBar}");
    Console.ResetColor();
    Console.Write($"] {value}/{maxValue}");
    Console.WriteLine();
}

void PrintTurn(int height, int maxHeight, bool debrisZone, bool calmZone, int maxRows = 10, int maxCols = 20)
{
    Console.WriteLine("=========================");

    var shipRow = (int)Math.Round((float)height / maxHeight * maxRows);

    for (var row = maxRows; row >= 0; row--)
    {
        var lane = GetSpaceLane(row == shipRow, debrisZone, calmZone, maxCols);
        Console.WriteLine(lane);
    }

    Console.WriteLine("=========================");
}

(ConsoleColor, ConsoleColor) ColorGradient(int value, int maxValue) {
    var percentage = (float)value / maxValue;
    return percentage switch
           {
               < 0.5f => (ConsoleColor.Red, ConsoleColor.Black),
               < 0.75f => (ConsoleColor.Yellow, ConsoleColor.Black),
               _ => (ConsoleColor.Green, ConsoleColor.Black)
           };
}

(string, string) ProgressBar(int value, int maxValue, int barLength = 20) {
    var percentage = (float)value / maxValue;
    var filledLength = (int)(barLength * percentage);
    var emptyLength = barLength - filledLength;

    var filledBar = new string('█', filledLength);
    var emptyBar = new string('░', emptyLength);

    return (filledBar, emptyBar);
}

string GetSpaceLane(bool ship, bool debris, bool calm, int maxCols) {
    if (!ship) return "| " + new string('.', maxCols - 2);

    var lane = new char[maxCols];
    lane[0] = '|';
    lane[1] = ' ';

    for (var i = 2; i < maxCols; i++)
    {
        if (i == maxCols / 2)
        {
            lane[i] = '^';
        }
        else if (debris && i % 2 == 0)
        {
            lane[i] = 'x';
        }
        else if (calm && i % 2 == 0)
        {
            lane[i] = '~';
        }
        else
        {
            lane[i] = ' ';
        }
    }

    return new string(lane);
}
