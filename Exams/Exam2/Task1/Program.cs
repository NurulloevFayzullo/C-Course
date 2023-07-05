int x=int.Parse(Console.ReadLine());
int y=int.Parse(Console.ReadLine());
for (int i = x; i <= y; i++)
{
    System.Console.WriteLine("--------------------------------");
    for (int j = 1; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
}