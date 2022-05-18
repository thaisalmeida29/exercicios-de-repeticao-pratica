/*
 * Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
 * multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
 * (N*3; N*3*3; N*3*3*3; etc).
 */


int n, prod = 0;

Console.Write("Digite um número menor ou igual a 50: ");
n = int.Parse(Console.ReadLine());


if (n <= 50)
{
    prod = n;

    while (prod < 250) {
        Console.WriteLine($"O valor obtido de {prod} ");
        prod = prod * 3;
        
    }

} else
{
    Console.WriteLine("O valor digitado está incorreto");
}

Console.WriteLine($"O valor final obtido = {prod}");