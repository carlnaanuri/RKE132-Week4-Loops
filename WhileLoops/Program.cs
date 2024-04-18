
Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool võib olla true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated: {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number from 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());
    
    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false; //Kui on õige vastus valitud, siis programm edasi ei küsi sama küsimust
    }
    else
    {
        Console.WriteLine("Oops. Try again!");
    }
}

Console.WriteLine("Have a nice day!");