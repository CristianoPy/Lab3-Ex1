// Scrieti o functie care va calcula suma cifrelor unui numar

Console.WriteLine("Introduceti un numar: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int reminder;

while (num > 0)
{
    reminder = num % 10;
    sum = sum + reminder;
    num = num / 10;
}
Console.WriteLine($"Suma cifrelor este: {sum}");
Console.ReadLine();
