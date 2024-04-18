//FOR-LOOP
//DRY-principle - Do not repeat yourself
/*int i = 0;
for(i = 0; i < 5; i++) //i++ = i + i, samm.  i = 0 on algus. i < 5 seni kestab kuni on väiksem, kui 5
{
    Console.WriteLine("We don't need no education.");
}
Console.WriteLine(i);
Console.WriteLine("Have a nice day.");*/



string userPIN;
while (true)
{
    Console.WriteLine("Enter your PIN");
    userPIN = Console.ReadLine();
    if (userPIN == "1234")
    {
        Console.WriteLine("Welcome!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong PIN. Try again.");
    }
}