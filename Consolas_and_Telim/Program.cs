// See https://aka.ms/new-console-template for more information

int a;
int b;
a = 5;
b = 2;
b = a;
a = -3;

Console.BackgroundColor = ConsoleColor.Yellow; 
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

Console.WriteLine("Bread is ready.");
Console.WriteLine("Who is the bread for?");
string name = Console.ReadLine();
Console.WriteLine(name + " got bread.");

Console.WriteLine("What kind of thing are we talking about?");
string x = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string y = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + y + " " + x + " of " + c + " " + d + "!");