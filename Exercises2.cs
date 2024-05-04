namespace Fundamentals;

public static class Exercises2
{
    public static void FullName()
    {
        Console.Write("Digite seu primeiro nome: ");
        var firstName = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        var lastName = Console.ReadLine();

        Console.WriteLine("Seu nome completo é:");
        Console.Write($"{firstName} {lastName}");
    }
}
