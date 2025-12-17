Console.Write("Target Row? ");
string targetRow = Console.ReadKey().KeyChar.ToString();

Console.Write("\nTarget Column? ");
string targetColumn = Console.ReadKey().KeyChar.ToString();

Console.WriteLine("\nDeploy to:");

int targetColumnMinusOne = int.Parse(targetColumn) - 1;
int targetColumnPlusOne = int.Parse(targetColumn) + 1;

Console.WriteLine($"({targetRow}, {targetColumnMinusOne})");
Console.WriteLine($"({targetRow}, {targetColumnPlusOne})");

int targetRowMinusOne = int.Parse(targetRow) - 1;
int targetRowPlusOne = int.Parse(targetRow) + 1;

Console.WriteLine($"({targetRowMinusOne}, {targetColumn})");
Console.WriteLine($"({targetRowPlusOne}, {targetColumn})");