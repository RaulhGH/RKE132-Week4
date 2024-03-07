Random rnd = new Random();

int cpuRandom;

bool loopActive = true;

while (loopActive)
{

    cpuRandom = rnd.Next(0, 4);

    Console.WriteLine("Paku nr:");
    int userNumber = Int32.Parse(Console.ReadLine());


    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Võisid");
        break;
    }
    else
    {
        Console.WriteLine("Proovi veel");
    }
}

