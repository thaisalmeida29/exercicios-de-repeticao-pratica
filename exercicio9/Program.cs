/*
 * 9. Faça um programa em VS para ler a quantidade de filhos de 
 * cada uma das 30 pessoas que visitaram 
 * o zoológico num determinado dia, imprimindo:
 * Quantas pessoas tem entre 1 e 3 filhos.
 * Quantas pessoas tem entre 4 e 7 filhos.
 * Quantas pessoas tem mais de 8 filhos.
 * Quantas pessoas não tem filhos.
 */

int filhos13 = 0, filhos47 = 0, filhos8 = 0, semFilhos = 0, qntdFilhos;
int i;

for (i = 0; i < 30; i++)
{
    
    Console.Write("Digite a quantidade de filhos: ");
    qntdFilhos = int.Parse(Console.ReadLine()); 

    if (qntdFilhos >= 1 && qntdFilhos < 3)
    {
        filhos13++;
    }
    else if (qntdFilhos >= 4 && qntdFilhos <= 7)
    {
        filhos47++;
    }
    else if (qntdFilhos >= 8)
    {
        filhos8++;
    }
    else if (qntdFilhos == 0)
    {
        semFilhos++;
    }
    

}
Console.WriteLine("Quantidade de filhos entre 1 e 3: " + filhos13);
Console.WriteLine("Quantidade de filhos entre 4 e 7: " + filhos47);
Console.WriteLine("Quantidade de filhos maior que 8: " + filhos8);
Console.WriteLine("Quantidade de pessoas sem filhos: " + semFilhos);