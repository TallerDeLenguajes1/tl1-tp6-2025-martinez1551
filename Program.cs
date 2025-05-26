
using System.Diagnostics;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);


Console.WriteLine("ingrese el numero para invertir");
string numeroingresado = Console.ReadLine();
int numero;
int numeroinvertido = 0;
bool esNumero = int.TryParse(numeroingresado, out numero);

if (esNumero)
{
    Console.WriteLine($"El numero es: {numero} ");
    while (numero > 0)
    {
        int digito = numero % 10;
        numeroinvertido = numeroinvertido * 10 + digito;
        numero /= 10;
    }
}
else
{
    Console.WriteLine("No es un numero entero");
}
Console.WriteLine("El numero invertido es: " + numeroinvertido);

//calculadora V1
int num = 1;

do
{
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("Seleccione una operación:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Opción (1-4): ");
    string opcion = Console.ReadLine();

    double num1, num2, resultado = 0;
    bool operacionValida = true;

    Console.Write("Ingrese el primer número: ");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("Entrada inválida. Ingrese un número válido: ");
    }

    Console.Write("Ingrese el segundo número: ");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("Entrada inválida. Ingrese un número válido: ");
    }

    switch (opcion)
    {
        case "1":
            resultado = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
            break;
        case "2":
            resultado = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
            break;
        case "3":
            resultado = num1 * num2;
            Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
            break;
        case "4":
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                operacionValida = false;
            }
            break;
        default:
            Console.WriteLine("Opción inválida.");
            operacionValida = false;
            break;
    }

    if (operacionValida)
    {
        Console.Write("¿Desea realizar otra operación? (1 = sí / 0 = no): ");
        string respuestaStr = Console.ReadLine();

        if (!int.TryParse(respuestaStr, out num) || (num != 0 && num != 1))
        {
            Console.WriteLine("Entrada no válida. Saliendo del programa.");
            num = 0;
        }
    }
    else
    {
        Console.WriteLine("Volviendo al menú principal...\n");
    }

} while (num != 0);
