Random rnd1 = new Random();

int myRandomNum;
int randomSum=0;

for (int i = 0; i < 10; i++)
{
    myRandomNum = rnd1.Next(0, 11);
    Console.WriteLine(myRandomNum);
    randomSum = randomSum + myRandomNum;    
}
Console.WriteLine($"kokku{randomSum}");