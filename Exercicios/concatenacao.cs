string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

Console.WriteLine(greeting + " " + firstName + "!");

string mensagem = $"{greeting} {firstName}!";
Console.WriteLine(mensagem);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectNome = "ACME";
string englisMessage = "View English output:";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";

Console.WriteLine($@"{englisMessage}
c:\Exercise\{projectNome}\data.txt");

Console.WriteLine($@"{russianMessage}
c:\Exercise\{projectNome}\ru-RU\data.txt");
