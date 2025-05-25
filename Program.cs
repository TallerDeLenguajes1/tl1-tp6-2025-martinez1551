
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

