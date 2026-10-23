// Ejercicio 1
static void MiFuncion()
{
    Console.WriteLine("Patricio");
}

// Ejercicio 2
int[] numeros = { 2, 4, 6, 9, 12, 15, 19, 23, 27 };

for (int i = 0; i < 9; i++)
{
    Console.WriteLine(numeros[i]);
}

// Ejercicio 3
int inicio = 2;
int limite = 5;

if (inicio * limite < 8 && inicio > limite)
{
    for (int i = 9; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int i = inicio; i <= limite; i++)
    {
        Console.WriteLine(i);
    }
}

// Ejercicio 4 
static bool EsMultiploDe5(int numero)
{
    return numero % 5 == 0;
}

int numero = 25;
bool resultado = EsMultiploDe5(numero);

Console.WriteLine($"¿Es múltiplo de 5? {resultado}");

// Ejercicio 5
static void Imprimir()
{
    Console.WriteLine("Examen");
}

Imprimir("Programación III");