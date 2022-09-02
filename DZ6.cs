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

int[] array = new int[8];
FillArray(array,0,2);
PrintArray(array);