/*
 * 8. Faça um programa em VS que solicite um numero inteiro. S
 * e o numero não for inteiro, solicite-o até que seja. após, 
 * informe se ele é par ou impar. 
 * Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
 */

string desejaContinuar = "";

do
{
    int numeroInteiro;

    Console.Write("Digite um numero inteiro: ");

    string numeroDigitado = Console.ReadLine();

    while (!(int.TryParse(numeroDigitado, out numeroInteiro)
            && numeroInteiro % 1 == 0))
    {
        Console.WriteLine("Numero invalido, digite novamente.");
        numeroDigitado = Console.ReadLine();

    }

    if (numeroInteiro % 2 == 0)
    {
        Console.WriteLine(numeroInteiro+ " é par");
    }
    else
    {
        Console.WriteLine(numeroInteiro + " é impar");
    }

    while (desejaContinuar != "S" && desejaContinuar != "N")
    {
        Console.WriteLine("Você so pode digitar S ou N, digite novamente: ");
        desejaContinuar = Console.ReadLine().ToUpper();

    }

} while (desejaContinuar == "S");