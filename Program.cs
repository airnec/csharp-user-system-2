using UserSystem2.Services;

UserService userService = new UserService();

Console.Write("E-mail: ");
string email = Console.ReadLine() ?? "";

Console.Write("Password: ");
string password = Console.ReadLine() ?? "";

bool isAuthenticated = userService.LoginUser(email, password);

if (isAuthenticated)
{
    Console.WriteLine("Login successful!");
}
else
{
    Console.WriteLine("Login unsuccessful!");
}
