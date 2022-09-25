using ConsoleUtilities;

public class Program
{
    public static void Main()
    {
        ConsoleU.WriteWithColor("Hello ", ConsoleColor.Magenta);
        ConsoleU.WriteLineWithColor("there!", ConsoleColor.Cyan);
        
        
        var answer = ConsoleU.RequestStringInput("Please enter your name: ");
        
        ConsoleU.WriteLineWithColor($"Your name is {answer}", ConsoleColor.Green);

        Console.WriteLine("That is great!");

        var answer2 = ConsoleU.RequestStringInput("Please enter your second name: ", ConsoleColor.DarkBlue);

        Console.WriteLine($"So your full name is {answer} {answer2}");

        var age = ConsoleU.RequestIntInput("Please enter your age: ", ConsoleColor.Blue, ConsoleColor.Red);


        ConsoleU.WriteWithColor(answer + " ", ConsoleColor.Blue);
        ConsoleU.WriteWithColor(answer2 + " ", ConsoleColor.Cyan);
        ConsoleU.WriteLineWithColor(age, ConsoleColor.Green);
    }
}