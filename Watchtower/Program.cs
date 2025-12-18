// See https://aka.ms/new-console-template for more information
Console.Write("Write value for x: ");
string xValue = Console.ReadLine();

Console.Write("Write value for y: ");
string yValue = Console.ReadLine();

int x = int.Parse(xValue);
int y = int.Parse(yValue);

if ( x == 0 && y == 0)
    Console.WriteLine("The enemy is here!");
else if (x == 0 &&  y > 0)
    Console.WriteLine("The enemy is to the north!");
else if (x == 0 && y < 0)
    Console.WriteLine("The enemy is to the south!");
else if (x < 0 && y > 0)
    Console.WriteLine("The enemy is to the northwest");
else if (x < 0 && y == 0)
    Console.WriteLine("The enemy is to the west");
else if (x < 0 && y < 0)
    Console.WriteLine("The enemy is to the southwest");
else if (x > 0 && y > 0)
    Console.WriteLine("The enemy is to the northeast");
else if (x > 0 && y == 0)
    Console.WriteLine("The enemy is to the east");
else if (x > 0 && y < 0)
    Console.WriteLine("The enemy is to the southeast");



// Otra opcion para usar menos anidaciones

if (x == 0)
{
    // Aquí dentro solo te preocupas por Y
    if (y == 0) { /* Aquí */ }
    else if (y > 0) { /* Norte */ }
    else { /* Sur */ }
}
else if (x > 0)
{
    // Aquí dentro ya sabes que X es positivo (Este)
    // Solo falta decidir si es Noreste, Sureste o Este puro
    if (y > 0) { /* ... */ }
    // ... sigue tú aquí
}
else // Aquí ya sabes que X es negativo (Oeste)
{
    // Solo falta decidir si es Noroeste, Suroeste u Oeste puro
    // ... y aquí
}