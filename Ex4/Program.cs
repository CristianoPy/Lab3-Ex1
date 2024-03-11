/*Scrieti un program care va inversa elementele unui vector
   Lungimea vectorului va fi citita de la tastatura
   Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
   Afisarea vectorului se va face printr-o functie de afisare dedicata*/

int i;
int[]vector = new int[100];

Console.Write("Introduceti numarul de elemente de stocat in vector: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Introduceti {0} numar de elemente in vector:\n", num);

for (i = 0; i < num; i++)
{
    Console.Write("element - {0} : ", i);
    vector[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("\nValorile stocate in vector sunt:\n");

for (i = 0; i < num; i++)
{
    Console.Write("{0}  ", vector[i]);
}
Console.Write("\n\nValorile stocate in vector invers sunt:\n");

for (i = num - 1; i >= 0; i--)
{
    Console.Write("{0} ", vector[i]);
}
Console.Write("\n\n");
