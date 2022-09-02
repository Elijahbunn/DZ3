Console.Write("Введите проверяемое число: ");
int current = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int degr = int.Parse(Console.ReadLine());

double Deep = current;

for (int numb = 2; numb <= degr; numb++)
{
Deep = Deep * current;
}

Console.WriteLine(Deep); 