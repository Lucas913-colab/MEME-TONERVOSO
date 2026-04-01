string Mensagem, MemeToNervoso;
Console.WriteLine("Usuário, o que você pensa sobre mim? ");
Mensagem = Console.ReadLine()!;

MemeToNervoso = $"{Mensagem.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(MemeToNervoso);