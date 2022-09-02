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
Console.WriteLine("Произведение чисел массива: ");
int size = length;
int product = 1;

for (i = 0; i < size; i++)
{
//int current = array[i];
product = product * array[i];
//Console.WriteLine(current + " " + Deep);
}
Console.WriteLine(product);