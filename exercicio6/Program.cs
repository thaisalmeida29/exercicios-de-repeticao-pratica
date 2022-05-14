/*
 * 6. Faça um programa em VS que solicite ao o usuário que informe a
 * idade e valide a entrada de dados, 
 * ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
 * Ao final, mostre a idade digitada.
 */

int idade;


do
 {
    Console.Write("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());
   

} while (idade < 0);

Console.WriteLine("A idade digitada é: " + idade);




