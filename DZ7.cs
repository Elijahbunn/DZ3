void FillArray(int[] array, int minimum, int maximum)
{
Random random = new Random();
int i=0;
while(i<array.Length)
{
array[i] = random.Next(minimum,maximum);
i++;
}
}
void PrintArray(int[] array)
{
foreach(int element in array)
Console.Write($"{element} ");
Console.WriteLine();
}

int[] array = new int[12];
FillArray(array,-9,9);
PrintArray(array);

int sum1 = 0;
int sum2 = 0;
for (int i=0; i < array.Length; i++)
{
if (array[i] >= 0)
{
sum1 = sum1 + array[i];
}

else if (array[i] < 0)
{
sum2 = sum2 + array[i];
}
}
Console.WriteLine($"Сумма элементов больше нуля {sum1}");
Console.WriteLine($"Сумма элементов меньше нуля {sum2}");