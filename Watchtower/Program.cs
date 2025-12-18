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
    Console.WriteLine("The enmy is to the south!");
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