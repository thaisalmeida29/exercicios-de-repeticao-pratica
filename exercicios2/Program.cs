/*
 * 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
 * informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 * 
 * Exemplo:
 * Digite um número inteiro positivo: 8
 * Numero digitado: 8
 * Números inteiros pares entre 1 e 8: 2, 4, 6.
 * Deseja informar outro número (s/n)? S
 * Digite um número inteiro positivo: 12
 * Numero digitado: 20
 * Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 * Deseja informar outro número (s/n)? N 
 */

string desejaContinuar = "";

do
{

    int numeroPositivo = 0, i = 0;
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


    for (i = 1; i < numeroPositivo; i++)
    {
        if (i % 2 == 0)
        {
            numerosPares.Add(i);
        }
    }
    Console.WriteLine($"Números inteiros pares entre 1 e {numeroPositivo} : {String.Join(", ", numerosPares)}");

    Console.Write("Deseja informar outro numero? [s/n] ");
    desejaContinuar = Console.ReadLine().ToUpper();

    while (desejaContinuar != "S" && desejaContinuar != "N")
    {
        Console.WriteLine("Você so pode digitar S ou N, digite novamente: ");
        desejaContinuar = Console.ReadLine().ToUpper();

    }

} while (desejaContinuar == "S");