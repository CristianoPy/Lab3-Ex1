/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul 
  sau citit de la tastatura. Scrieti functii care vor returna
  Cel mai mare numar din vector
  Cel mai mic numar din vector
  Numerele divizibile cu 3
 Dificultate ridicata
  Numerele patrate perfecte din vector
 Apelati functiile si afisati-le rezultatele.*/


int[] vector = new int[] { 1, 9, 30, 53, 23, 21 };

int Max = vector[0];

for (int i = 1; i < vector.Length; i++)
{
    if (vector[i] > Max)
    {
        Max = vector[i];
    }

}
Console.WriteLine("Cel mai mare numar din vector este: " + Max);

int Min = vector[0];

for (int i = 1; i > vector.Length; i++)
{
    if (vector[i] < Min)
    {
        Min = vector[i];
    }

}
Console.WriteLine("Cel mai mic numar din vector este: " + Min);


int n = vector.Length;
    int k = 3;
static int CountTheElements(int[] vector, int n, int k)
{
    int counter = 0;

    for (int i = 0; i < n; i++)
    {
        if (vector[i] % k == 0)
            counter++;
    }

    return counter;
}
Console.WriteLine(CountTheElements(vector, n, k));

//patratu perfect
// I dont know how to make it this one.
Console.ReadLine();

