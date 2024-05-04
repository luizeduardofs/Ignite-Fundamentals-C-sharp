namespace Fundamentals;

public static class Exercises4
{
    public static void WordCount()
    {
        Console.WriteLine("Digite uma ou mais palavras separando-as por um espaço:");
        var palavras = Console.ReadLine();

        var list = palavras?.Split(" ");

        for (int i = 0; i < list?.Length; i++)
        {
            Console.WriteLine($"A palavra: {list?[i]} contem {list?[i].Length} caracteres");
        }
    }
}
