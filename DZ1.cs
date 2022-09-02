Console.Write("Enter length of array: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
Console.Write(array);
int i = 0;

for (i = 0; i < length; i++)
{
array[i] = i + 1;
Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
Console.WriteLine("Кубы чисел массива: ");
int size = length;
int current = 1;

for (i = 0; i < size; i++)
{
current = array[i];
double Deep = Math.Pow(current, 3);

Console.WriteLine(current + " " + Deep);
}
