//

int sum = 0;

for(int i=0;i<10;i++)
{
    Console.WriteLine($"i= {i}");
    Console.WriteLine(sum);
    sum=sum+i;
}

Console.WriteLine(sum);


Console.WriteLine("Enter the first letter of your first name:");
char userLetter = Char.Parse(Console.ReadLine().ToLower());

if (userLetter == 'a' || userLetter == 'e' || userLetter == 'i' || userLetter == 'o' || userLetter == 'u')
{
    Console.WriteLine("I can sing it.");
}
else
{
    Console.WriteLine("There is no way I can sing it.");
}
