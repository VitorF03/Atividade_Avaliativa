double n = 0.0;
int i = 0;

Console.WriteLine("Tabuada Dinâmica");

Console.WriteLine("Digite seu número: ");
n = Convert.ToDouble(Console.ReadLine());

while (i <= 10)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
    i++;
}