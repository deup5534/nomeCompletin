string nomezin, sobrenome;
Console.WriteLine("escreva seu nome aí...");
nomezin = Console.ReadLine()!;

Console.WriteLine("agora, seu sobrenome...");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"seu nome completo: {nomezin} {sobrenome} ^^ ");
Console.WriteLine($"seu nome catálogo: {sobrenome.ToUpper()}, {nomezin} ^^");