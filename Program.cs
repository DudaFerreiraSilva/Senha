const string SenhaCorreta = "1234abcd";
string senha, permissaoAcesso;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Olá, usuário. Por favor, digite sua senha: ");
senha = Console.ReadLine()!;
Console.ResetColor();

permissaoAcesso = senha == SenhaCorreta ? "permitido" : "negado";

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Acesso {permissaoAcesso}");
Console.ResetColor();