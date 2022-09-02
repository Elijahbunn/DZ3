Console.WriteLine("Enter a string:");
string userString = Console.ReadLine();

int sum = 0;
for(int i=0; i<userString.Length; i++)
{
sum = sum + Convert.ToInt32(Convert.ToString(userString[i]));
}
Console.WriteLine("The sum of the digits is " + sum);