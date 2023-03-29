int userPin;
int triesUsed = 0;

while(triesUsed != 3)
{
    
    Console.WriteLine("Enter your pin:");
    userPin = Int32.Parse(Console.ReadLine());
}if(userPin == 1234)
{
    Console.WriteLine("Welcome");
    triesUsed = 3;
}else
{
    Console.WriteLine($"Wrong PIN. Try again {triesUsed}");
    triesUsed++;
}