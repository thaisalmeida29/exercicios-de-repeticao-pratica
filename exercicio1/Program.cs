
/*
 * 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
 * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
 * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
 * 
 * Exemplo:
 * Digite um número inteiro positivo: -8
 * Valor incorreto!
 * Digite um número inteiro positivo: 8
 * Numero digitado: 8
 * Números inteiros pares entre 1 e 8: 2, 4, 6.
 */

int numeroPositivo, i = 0;



do
{
    Console.Write("Digite um numero positivo: ");
    numeroPositivo = int.Parse(Console.ReadLine());

    if (numeroPositivo < 0)
    {
        Console.WriteLine("Valor incorreto, digite novamente: ");
    }
} while (numeroPositivo < 0);

List<int> numerosPares = new List<int>();

for ( i = 1; i < numeroPositivo; i++)
{
    if (i % 2 == 0)
    {
        numerosPares.Add(i);
    }
}

Console.WriteLine($"Números inteiros pares entre 1 e {numeroPositivo} : {String.Join(", ", numerosPares)}");


