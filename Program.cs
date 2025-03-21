Console.Clear();
Console.WriteLine("Escreva o que vai ser criptografado");
string x = Console.ReadLine()!.ToLower();
string y = x .Replace("a","4")
             .Replace("e","3")
             .Replace("i","1")
             .Replace("l","1")
             .Replace("o","0")
             .Replace("t","7")
             .Replace("s","5")

;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"tu escreveu {x}");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"agora está assim {y}");