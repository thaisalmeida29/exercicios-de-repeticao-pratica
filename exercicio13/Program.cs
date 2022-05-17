/*
 * Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500.
 */

int n1 = 0;
int i;

for (i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        n1 = n1 + i;
    }

}

Console.WriteLine("A soma dos números de 1 a 500 é: " + n1);