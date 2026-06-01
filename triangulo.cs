double a = 0.0;
double b = 0.0;
double c = 0.0;

Console.WriteLine("Classificador de Triângulos");

Console.WriteLine("Informe o primeiro lado do triângulo: ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo lado do triângulo: ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o terceiro lado do triângulo: ");
c = Convert.ToDouble(Console.ReadLine());

switch (true)
    {
        case true when a == b && b == c:
            Console.WriteLine("Equilátero"); break;
        case true when a == b || b == c || a == c:
            Console.WriteLine("Isósceles"); break;
        default:
            Console.WriteLine("Escaleno"); break;
    }