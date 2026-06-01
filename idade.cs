int ano = 0;
int atual = 2026;

Console.WriteLine("Verificador de Idade");

Console.WriteLine("Informe o ano em que você nasceu: ");
ano = Convert.ToInt16(Console.ReadLine());

int idade = (atual - ano);

if (idade >= 18)
    Console.WriteLine($"Você nasceu em {ano}, sua idade é {idade} e você já é maior de idade, ou seja, pode tirar CNH.");
else 
    Console.WriteLine($"Você nasceu em {ano}, sua idade é {idade} e você é menor de idade, ou seja, ainda não pode tirar sua CNH.");