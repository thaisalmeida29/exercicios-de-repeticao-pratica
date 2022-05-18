/*
 * 14. Mostrar as potências de 2 variando de 0 a 10.
 */

int poten = 2 ;
int i;

for (i = 0; i <= 10; i++)
{

    Console.WriteLine($"{poten}^{i} = {(long)Math.Pow(poten, i)}");
}
   