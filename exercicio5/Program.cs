/*
 * 5. Modifique o programa em VS anterior para aceitar votos nulos 
 * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
 * Ao final, informe o nome do candidato vencedor, o número de votos nulos 
 * e o número de pessoas que votaram.
 */

string voto; //ZECA, JOAO, BRANCO, NULOS
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;
int totalVotosNulos = 0;
int totalVotos;
int numeroAleatorio = 0;

do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato, ou BRANCO, ou FIM para encerrar: ");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            totalVotosJoao++;
  
            break;
        case "ZECA":
            totalVotosZeca++;
            break;
        case "BRANCO":
            totalVotosBranco++;
           numeroAleatorio = new Random().Next(1, 2);
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            totalVotosNulos++;
            break;
    }
   
    Console.WriteLine("Obrigado por votar nessas eleições");
    Console.ReadKey();
} while (voto != "FIM");


if (totalVotosJoao > totalVotosZeca)
{
    Console.WriteLine("O candidato João venceu!!");
}
if (totalVotosZeca > totalVotosJoao)
{
    Console.WriteLine("O candidato Zeca venceu!!");
}

if (numeroAleatorio == 1)
{
    totalVotosZeca++;
}
else if (numeroAleatorio == 2)
{
    totalVotosJoao++;
}
else if (totalVotosJoao == totalVotosZeca)
{
    Console.WriteLine("Empate, vamos para o segundo turno!!");
}

totalVotos = totalVotosJoao + totalVotosZeca + totalVotosNulos + totalVotosBranco;


Console.WriteLine("Total de votos Nulos: " + totalVotosNulos);
Console.WriteLine("O total de votos foi de: " + totalVotos);
