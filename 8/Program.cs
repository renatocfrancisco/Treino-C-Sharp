//            8.Construir um algoritmo que leia dois números e efetue a adição. Caso o valor somado seja maior que 20,
//                      este devera ser apresentado somando - se a ele mais 8; caso o valor somado seja menor ou igual a 20, este
//                      devera ser apresentado subtraindo - se 5.


int adicao = 0;
Console.WriteLine("Primero Número:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Segundo Número:");
int y = int.Parse(Console.ReadLine());
adicao = x + y;

if (adicao > 20)
{
    adicao += 8;
    Console.WriteLine(adicao);
}
else if (adicao <= 20)
{
    adicao -= 5;
    Console.WriteLine(adicao);
}