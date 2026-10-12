# GUÍA DE PROGRAMACIÓN

### Para qué sirve `Console.Write`, `Console.WriteLine` y `Console.ReadLine`
`Console.Write` y `Console.WriteLine` sirven para mostrar cualquier texto en la pantalla. La diferencia principal es que `Console.Write` deja el cursor en la misma línea, y `Console.WriteLine` te lleva a la siguiente linea de forma automática en cuanto terminas de escribir. `Console.ReadLine` sirve para que el usuario pueda escribir algo en el programa desde su teclado.

CÓDIGO
```csharp
Console.Write("Hola");
Console.Write(", ");
Console.Write("Diana!");

Console.WriteLine("Hola, Diana.");
Console.WriteLine("Bienvenida#");

Console.Write("Escribe tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);

```
-----

### SECUENCIAS DE ESCAPE
Una secuencia de escape se usa para representar caracteres especiales, saltos de linea (Se usan dentro de las cadenas de texto string)

```csharp
\n - Crea un salto de linea.
\t - Inserta una tabulación horizontal (Espacio grande).
\" o \' - Permite usar comillas dobles o simples dentro de un texto delimitado dentro de ellas sin 
necesidad de romper el código.
\\ - Muestra una barra invertida en la pantalla.
```
-----

### COLORES DE FONDO Y TEXTO
Los colores de fondo y texto sirven para dar alertas visuales instantáneas (como rojo para error o verde para éxito) y guiar la vista del usuario para que el programa sea más fácil de leer.

```csharp
- Console.ForegroundColor - Sirve para cambiar el color del texto. Todo lo escrito en la linea
siguiente de este comando, tendrá el color que elija.
- Console.BackgroundColor - Sirve para cambiar el color del fondo de las letras. Funciona como un 
marcador y resaltador de textos.
- ConsoleColor.(Color) - Es la lista de colores predefinidos. Por ejemplo: "ConsoleColor.Yellow", "ConsoleColor.Red", 
"Dark blue", "Green", etc.
- Console.ResetColor() - Apaga el color que estabas usando y regrsa al color base. Te permite pintar
una palabra de un color y asegurarte de que la siguiente palabra vuelva a la normalidad 
automáticamente.
```
-----

### TIPOS DE DATOS, VARIABLES Y CONSTANTES

#### Tipos de Datos `explícitos` e `implícitos`


```csharp
TIPOS DE DATOS EXPLICITOS (Se especifica el tipo de dato antes del nombre). 
    Ejemplos: 
int age = 20;
string name = "John";
char gender = 'M';
bool isStudent = true;
float height = 1.75f;
double cash = 1000;
Dog rover = new Dog("Rover");

TIPOS DE DATOS IMPLÍCITOS (Se pone "var" y asume de forma automática el tipo de dato).
var age = 20;
var name = "John";
var gender = 'M';
var isStudent = true;
var height = 1.75f;
var cash = 1000;
var rover = new Dog("Rover");
```
-----

#### VARIABLES Y CONSTANTES.

`VARIABLES` solo pueden contener un tipo de dato y su valor puede cambiar.                   
`CONSTANTES` su valor no cambia una vez asignado, se defince al inicio y van en mayusculas.           
Ejemplos y uso:

```csharp
VARIABLES
int age = 20;
string name = "John";
char gender = 'M';
bool isStudent = true;
float height = 1.75f;
double cash = 1000;

CONSTANTES
const int AGE = 20;
const string NAME = "John";
const char GENDER = 'M';
const bool IS_STUDENT = true;
const float HEIGHT = 1.75f;
const double CASH = 1000;
```
-----

#### TIPOS DE DATOS NUMÉRICOS `ENTEROS`
ENTEROS: Se usan para recursos, vida de los personajes, edades puntajes, etc.

```csharp
sbyte _ -128 a 127 
byte _ 0 a 255 
short _ -32,768 a 32,767 
ushort _ 0 a 65,535
int _ -2,147,483,648 a 2,147,483,647
uint _ 0 a 4,294,967,295 
long _ -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807 
ulong _ 0 a 18,446,744,073,709,551,615 
```
-----

#### TIPOS DE DATOS NUMÉRICOS `DECIMALES`
DECIMALES/FLOTANTES: Se usan para coordenadas. distancias, medidas, bonus y hit chance.

```csharp
float _ ±1.5x10−45 a ±3.4x1038 
double _ ±5.0×10−324 a ±1.7×10308 
decimal _ ±1.0x10-28 a ±7.9228x1028 
```
-----
### TRYPARSE
 Convierte un texto (string) a número entero (int) sin romper el programa si se escriben letras.
```csharp
Ejemplo:

Console.Write("Escribe tu edad: ");
string entrada = Console.ReadLine();

// TryParse intenta convertir 'entrada' y guarda el número en 'edad'
int edad;
bool funciono = int.TryParse(entrada, out edad);


- Ejemplo conversión imlicita:
    int puntos = 100;
long puntosGrandes = puntos;


- Ejemplo conversión explicita:
    float promedio = 9.8f;
int entero = (int)promedio;


- Parse:
int edad = int.Parse(texto);
```
-----

#### BOOLEANOS
Se usa en condicionales
```csharp
True y false
```
-----
#### CONDICIONALES

```csharp
if (si se cumple)
else (si no se cumple nada)
else if (si no se cumple lo anterior, evalua lo mas reciente). Ej: No tenía un boleto para entrar, pero si dinero, entonces compré un boleto y entré.
switch (coincide exactamente con el valor de la variable)
```
-----

#### CICLOS: Sirven para repetir un bloque de código

```csharp
while (Sigue siempre y cuando se cumpla la condición)
do-while (Ejecuta siempre la primera vez, y luego pregunta al hacer algo)
for (Se usa cuando se sabe cuantas veces se repetirá algo)
foreach (Va de inicio a fin)
```
-----

### OPERACIONES
Las  operaciones aritméticas siempre se usan para los tipos de datos numéricos.   
`División entera:` Solo aplica para tipos de datos enteros.   
`División real:` Se aplica cuando algún numero es decimal y su resultado siempre es decimal.

```csharp
JERARQUÍA DE OPERACIONES
Agrupación _ ()
Unary Negative _ -
Multiplicación y División _ *, /
Resto y Módulo _ %
Suma y Resta _ +, -

Adición Unaria (Prefijo) _ ++
Resta Unaria (Prefijo) _ --
Adición Unaria (Sufijo) _ ++
Resta Unaria (Sufijo) _ --
```
```csharp
### OPERACIONES RELACIONALES Y LÓGICAS
Las operaciones relacionales y lógicas nos permiten comparar operciones y poder obtener un resultado, ya sea verdadero o falso, y este resultado siempre será un bool.

```csharp
JERARQUÍA DE OPERACIONES:
Relacionales <, >, >=, <=
Igualdad ==,!=
NOT !
AND &&
OR ||

OPERACIONES RELACIONALES:
Igualdad == Determina si dos valores son iguales. num1 == num2 4 == 2 => false
Diferente != Determina si dos valores son diferentes. num1 != num2 4 != 2 => true
Mayor que > Determina si un valor es mayor que otro. num1 > num2 4 > 2 => true
Menor que < Determina si un valor es menor que otro num1 < num2 4 < 2 => true
Mayor o igual que >= Determina si un valor es mayor o igual que otro. num1 >= num2 4 >= 2 => true
Menor o igual que <= Determina si un valor es menor o igual que otro. num1 <= num2 4 <= 2 => true"

OPERACIONES LÓGICAS:
AND && -true-, si ambos valores son -true-
OR || -true-, si cualquier valor es -true-
NOT ! Convierte el valor es su opuesto -true- <-> -false-
```
-----

### ANLISIS Y RESOLUCIÓN DE PROBLEMAS

```csharp
1. Leer el problema e identificar los datos: Entradas y salidas
2. Escribir los pasos en pseudocódigo antes de empezar con el algoritmo
3. Traducir el pseudocódigo a C#
```
-----

### DEBUGGING
¿Qué hacer si mi programa no funciona?

```csharp
Lineas rojas (Errores) = El código está mal escrito y son errores críticos, puede ser algo como que falte un 
parentesis, comillas, ortografía, etc.
Lineas amarillas (Advertencias) = Pueden causar problemas o tal vez no, pero no evitan que el programa corra.
Lineas verdes (Sugerencias) = Sugerencias o recomendaciones de escritura o forma de aplciar los estandares.

1. Identificar entradas y salidas
2. Buen diseño en pseudocódigo
3. Traducir al lenguage de programación

DIAGNÓSTICO RAPIDO DE ERRORES:
¿Qué esperaba que pasara?
¿Qué pasó realmente?
¿Dónde falló?
¿Qué valores tienen las variables?

Inspeccionar las variables
Aislar el problema
Probar la correción
```
-----

### CICLOS

Ciclos/Loops: Permiten repetir acciones

```csharp
1. Ciclo While (DEPENDE DE UNA CONDICIÓN)
- Se usa al inicio antes de cada iteración y cuando no se sabe cuantas veces se repetirá, depende de datos dinámicos.
- Cuando no se sabe cuantos intentos tomara algo.

Ejemplo: 
* SE DETIENE AL LLEGAR A 0
int vida = 3;
while (vida > 0)
{
 vida--;
}
 
2. Ciclo Do-While (SE EJECUTA AL MENOS UNA VEZ)
- Se usa al final después de haber ejecutado el bloque, su uso más común es para hacer menus de opciones o validaciones de entrada.
- Se usa cuando necesito que las instrucciones ocurran al menos una vez antes de saber si debes continuar o no.

Ejemplo:
while (enemyHp < 10) {
* Combate hasta que el enemigo muera

3. Ciclo For ( SE CUANTAS VECES SE REPITE)
- Se usa al inicio antes de cada iteración.
- Es ideal para listras, arreglos o cuando ya se sabe exactamente cuantas veces se repetirá el programa.

Ejemplo:
* REPETIR 10 VECES
for (var i = 0; i < 10; i++) {
```

-----

### BREAK Y CONTINUE

`Break:` Termina inmediatamente el ciclo actual, sin realizar ninguna otra acción.   
```csharp
// CICLO INFINITO
    
    while (true)
    {
        string input = Console.ReadLine();
        
        // Termina al escribir salir
        
        if (input = "salir")
        {
            break;
        }    
    }
```
`Continue:` Omite el resto de la iteración y continúa con la siguiente iteración del ciclo.

```csharp
// Cuenta del 1 al 10

for (int i = 1; i < 10; i++)
{
    
    // Se salta el 5
    
    if (i = 5)
    {
        continue;
    }
    
    Console.WriteLine(i);
}
```

-----

### JERARQUÍA DE OPERACIONES

```csharp
While: Repetir mientras algo ocurra (0+).
Do-While: Ejecutar al menos una vez (+1).
For: Repetir una cantidad conocida.
Break: Terminar el ciclo inmediatamente.
Continue: Saltar sólo la iteración actual.
```

-----

### ARREGLOS Y LISTAS
`Variables`
```csharp
- Las variables pueden almacenar un valor individual, que puede cambiar a lo largo del programa.
- No hay limite de variables, pero el problema crece.
```
`Estructura de datos`
```csharp
- Nos permite almacenar y organizar varios valores que tengan relación entre ellos.
- Almacena 0 o más valores que pueden cambiar a lo largo del programa.
```
`Arreglos`
```csharp
- Es una estructura de datos que almacena una cantidad definida de elementos del mismo tipo.
- Su tamaño es definido, no cambia despues de haberlo creado, los elementos tiene una posicion y las
posiciones se identifican mediante un índice.

Ejemplo:

// Tipo de dato + corchetes + identificador
string[] enemies;

// Longitud
enemies = new string[4];

// Inicialización por valores
Levels = [
    "Forest",
    "Cave",
    "Castle",
    ];
```
```csharp
LONGITUD DEL ARREGLO:
- La longitud del arreglo se debe establecer antes de usarlo por 1ra vez.
- Propiedad: Lenght
- Representa la cantidad de elementos que puede contener al momento de crearlo.
- Los elementos de los arreglos se obtienen mediante el índice dentro de crochetes: ARREGLO [INDICE]
```
```csharp
RECORRER UN ARREGLO

- FOR: Se usa cuando se necesita conocer el índice o controlar el recorrido.
* Ejemplo: 
for (int i = 0; i < enemies.Length; i++)
{
Console.Write.Line($"{i}: [enemies[i]}");
}

- FOREACH: Se usa cuando solo se necesita el elemeto.
*Ejemplo:
foreach (string enemy in enemies)
{
Console.WriteLine(enemy);
}
```
`Listas`
```csharp
- Es una estructura de datos que almacena una cantidad variable de elementos del mismo tipo.
- Puede tener una capacidad inicial predefinida.
- El tamaño cambia de forma dinámica según se requiera.
- Los elementos tienen una posición.
- Las posiciones se identifican mediante un índice.

EJEMPLOS:
// Lista sin capacidad inicial definida
List<string> enemies = new List<string>();
List<int> scores = new();
List<int> ranks = [];

// Lista con capacidad inicial de 5
List<string> levels = new List<string>(5);
List<int> worlds = new(5);

// Lista con valores iniciales y capacidad de 3
List<char> letters = new List<char>() {
'A', 'B', 'C'
};

// Lista con valores iniciales y capacidad de 4
List<bool> answers = [
true, false, false, true
];
```
`Capacidad y conteo`
```csharp
CAPACIDAD: Es la capacidad de elementos que puede guardar al lista antes de crecer y se obtiene mediante la 
propiedad: Capacity.
CONTEO: La cantidad de elementos que tiene la lista actualmente y se obtiene mediante la propiedad: Count.
```
### DICCIONARIOS
Un diccionario es una estructura de datos que almacena partes de Clave a Valor
```csharp
INDICE: Un índice nos indica en dónde está ubicado un elemento.
CLAVE: La clave nos indíca como identificar el valor.
CONTEO: Es la cantidad de elementos que contiene el diccionario.
CAPACIDAD: Es la capacidad del diccionario antes de necesitar crecer.

¿CÓMO CREAR DICCIONARIOS?

// Lista sin capacidad inicial definida
List<string> enemies = new List<string>();
List<int> scores = new();
List<int> ranks = [];

// Lista con capacidad inicial de 5
List<string> levels = new List<string>(5);
List<int> worlds = new(5);

// Lista con valores iniciales y capacidad de 3
List<char> letters = new List<char>() {
'A', 'B', 'C'
};

// Lista con valores iniciales y capacidad de 4
List<bool> answers = [
true, false, false, true
];
```

```csharp
// Agregar elementos
Add (CLAVE, VALOR);

// Agregar elementos cuando se desconoce si ya existe clave
TryAdd (CLAVE, VALOR);

// Obtener elementos de un diccionario
DICC[CLAVE]
    
// Verificar si existe una llave
ConstainsKey(CLAVE);

// Obtener un elemento cuando se desconoce si existe clave
TryGetValue(CLAVE, out VALOR);

// Para eliminar un elemento
Remove (CLAVE);

// Vaciar diccionario
Clear()
    
// Recorrer un diccionario
Ej: 

// Lista sin capacidad inicial definida
List<string> enemies = new List<string>();
List<int> scores = new();
List<int> ranks = [];

// Lista con capacidad inicial de 5
List<string> levels = new List<string>(5);
List<int> worlds = new(5);

// Lista con valores iniciales y capacidad de 3
List<char> letters = new List<char>() {
'A', 'B', 'C'
};

// Lista con valores iniciales y capacidad de 4
List<bool> answers = [
true, false, false, true
];
```
