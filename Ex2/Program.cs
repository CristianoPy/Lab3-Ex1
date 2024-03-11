/*Scrieti o functie care va determina daca un numar este sau nu patrat perfect. 
   Apelati-o si afisati-i rezultatul*/


Console.WriteLine("Introduceti un numar: ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsPerfectSquare(num))
{
    Console.WriteLine("Numarul " + num + " este un patratu perfect.");
}
else
{
    Console.WriteLine("Numarul " + num + " nu este un patratu perfect.");
}
static bool IsPerfectSquare(int num)
{
    return Math.Sqrt(num) == (int)Math.Sqrt(num);
}
Console.ReadLine();
