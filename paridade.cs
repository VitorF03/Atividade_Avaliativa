double n = 0.0;

Console.WriteLine("Verificador de Paridade");

Console.WriteLine("Digite seu número: ");
n = Convert.ToDouble(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine($"O número {n} é par!");
else 
    Console.WriteLine($"O número {n} é ímpar!"); 