namespace Fundamentals;

public static class Exercises1
{
    public static void PersonalMessage()
    {
        Console.Write("Digite seu nome: ");
        var name = Console.ReadLine();
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}
