using System.Globalization;

namespace Fundamentals;

public static class Exercises3
{
    public static void NumberOperation()
    {
        Console.Write("Digite um número de sua preferência [Ex: 10 ou 5.3]: ");
        double firstNumber = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Digite mais um número [Ex: 10 ou 5.3]: ");
        double secondNumber = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        string errorMessage = "Operação inválida";

        Console.WriteLine($"A SOMA entre {firstNumber} + {secondNumber} é: {firstNumber + secondNumber}");
        Console.WriteLine($"A SUBTRAÇÃO entre {firstNumber} + {(secondNumber > firstNumber ? errorMessage : firstNumber - secondNumber)}");
        Console.WriteLine($"A MULTIPLICAÇÃO {firstNumber} + {secondNumber} é: {firstNumber * secondNumber}");
        Console.WriteLine($"A DIVISÃO entre {firstNumber} + {secondNumber} é: {(secondNumber != 0 ? firstNumber / secondNumber : errorMessage)}");
    }
}