namespace Fundamentals;

public static class Exercises6
{
    public static void DatePicker()
    {
        Console.WriteLine("Digite o número da opção de formatação da data atual: ");
        Console.WriteLine("[1] Formato completo Ex. 'Sexta-feira de Março de Dois mil e um'");
        Console.WriteLine("[2] Apenas a data Ex. '01/01/2000'");
        Console.WriteLine("[3] Apenas a hora no formato de 24 horas Ex. '18 horas'");
        Console.WriteLine("[4] A data com o mês por extenso Ex. '01 de Dezembro de 2021'");
        Console.Write("Sua escolha é: ");
        var option = int.Parse(Console.ReadLine()!);

        DateTime dataAtual = DateTime.Now;

        switch (option)
        {
            case 1:
                string formatoCompleto = dataAtual.ToString("dddd 'de' MMMM 'de' yyyy");
                Console.WriteLine("[1] Formato completo: " + formatoCompleto);
                break;
            case 2:
                string apenasData = dataAtual.ToString("dd/MM/yyyy");
                Console.WriteLine("[2] Apenas a data: " + apenasData);
                break;
            case 3:
                string apenasHora = dataAtual.ToString("HH 'horas'");
                Console.WriteLine("[3] Apenas a hora: " + apenasHora);
                break;
            case 4:
                string dataComMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
                Console.WriteLine("[4] A data com o mês por extenso: " + dataComMesExtenso);
                break;
            default:
                Console.WriteLine("Você digitou uma opção inválida, degite apenas números e de 1 à 4...");
                break;
        }
    }
}
