int a = 0, b = 1, c = 0;
int numOfFibs;
Console.Write("How many fib numbers do you want? ");
#pragma warning disable CS8604 // get rid of "Possible null reference argument"
numOfFibs = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 
Console.Write("{0}, {1},", a, b);
for (int x = 2; x < numOfFibs; x++)
{
    c = a + b;
    Console.Write(" {0},", c);
    a = b;
    b = c;
}
