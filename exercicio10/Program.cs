/*
 * 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
 * Número de pessoas do sexo masculino.
 * Número de pessoas do sexo feminino.
 * Número de pessoas com idade inferior a 30 anos.
 * Número de pessoas com idade superior a 60 anos.
 * Média de idade das mulheres.
 */
string nome, sexo;
int qntdSexoF = 0, qntdSexoM = 0, idade30 = 1, idade60 = 0, idade, somaIdadeF = 0;
int i;
double mediaIdadeF = 0;

for (i = 0; i < 2; i++)
{
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite seu sexo: [M ou F]");
    sexo = Console.ReadLine().ToUpper();

    Console.Write("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    
    if (sexo == "F")
    {
        
        qntdSexoF++;
        somaIdadeF = somaIdadeF + idade;
    }
    else if (sexo == "M")
    {
        qntdSexoM++;
    }

    else if (idade < 30)
    {
        idade30++;
    }
    else if (idade > 60)
    {
        idade60++;
    }


}

mediaIdadeF = somaIdadeF / qntdSexoF;

Console.WriteLine("Número de pessoas do sexo masculino: " + qntdSexoM);
Console.WriteLine("Número de pessoas do sexo feminino: " + qntdSexoF);
Console.WriteLine("Número de pessoas com idade inferior a 30: " + idade30);
Console.WriteLine("Número de pessoas com idade superior a 60: " + idade60);
Console.WriteLine("A media de idade de pessoas do sexo feminino é: " + mediaIdadeF);