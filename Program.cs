using ProgAvanSistema_AulaTratamentoErro_Exercicio03;

Console.Write("Login: ");
string login = Console.ReadLine()!;
Console.Write("Senha: ");
string senha = Console.ReadLine()!;

Login novologin = new(login, senha);
novologin.fazerLogin(login, senha);

