double nota1 = 0.0;
double nota2 = 0.0;
double nota3 = 0.0;
double nota4 = 0.0;

Console.WriteLine("Média Escolar");

Console.WriteLine("Escreva a nota do seu 1º Bimestre");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreva a nota do seu 2º Bimestre");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreva a nota do seu 3º Bimestre");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreva a nota do seu 4º Bimestre");
nota4 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if (media >= 7)
            Console.WriteLine($"Sua média é {media}, e você foi aprovado!");
        else if (media >= 5)
            Console.WriteLine($" Sua média é {media}, e você está de recuperação.");
        else
            Console.WriteLine($"Sua média é {media}, e você foi reprovado.");