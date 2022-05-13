using System;

public static class Program
{
	public static void Main()
	{
        /*
 * 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
 * Se o usuário digitar 0 o programa em VS deve parar. 
 * Caso contrário, o programa em VS deve informar se 
 * o número é par ou ímpar e se ele é um número primo.   
 */
        int num = 0;

        do
        {
            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {

                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " é par");
                }
                else
                {
                    Console.WriteLine(num + " é impar");
                }

                if(IsPrime(num))
                {
                    Console.WriteLine("O numero " + num + " é um numero primo");
                }
            }

        } while (num != 0);
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));
          
        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;
    
        return true;        
    }
}