namespace Fundamentals;

public static class Exercises5
{
    public static void CarPlate()
    {
        Console.Write("Digite a placa do carro para verificação: ");
        var placa = Console.ReadLine();

        string success = "verdadeiro";
        string failure = "False";

        if (placa?.Length < 7 || placa == null)
        {
            Console.WriteLine(failure);
        } else if (!char.IsLetter(placa[0]) || !char.IsLetter(placa[1]) || !char.IsLetter(placa[2]))
        {
            Console.WriteLine(failure);
        } else if (!char.IsNumber(placa[3]) || !char.IsNumber(placa[4]) || !char.IsNumber(placa[5]) || !char.IsNumber(placa[6]))
        {
            Console.WriteLine(failure);
        } else
        {
            Console.WriteLine(success);
        }
    }
}
