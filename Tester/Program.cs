using ConsoleUtilities;

public class Program
{
    public static void Main()
    {
        SimpleConsoleHelpers.WriteWithColor("Hello ", ConsoleColor.Magenta);
        SimpleConsoleHelpers.WriteLineWithColor("there!", ConsoleColor.Cyan);
        
        
        var answer = SimpleConsoleHelpers.RequestStringInput("Please enter your name: ");
        
        SimpleConsoleHelpers.WriteLineWithColor($"Your name is {answer}", ConsoleColor.Green);

        Console.WriteLine("That is great!");

        var answer2 = SimpleConsoleHelpers.RequestStringInput("Please enter your second name: ", ConsoleColor.DarkBlue);

        Console.WriteLine($"So your full name is {answer} {answer2}");

        var age = SimpleConsoleHelpers.RequestIntInput("Please enter your age: ", ConsoleColor.Blue, ConsoleColor.Red);


        SimpleConsoleHelpers.WriteWithColor(answer + " ", ConsoleColor.Blue);
        SimpleConsoleHelpers.WriteWithColor(answer2 + " ", ConsoleColor.Cyan);
        SimpleConsoleHelpers.WriteLineWithColor(age, ConsoleColor.Green);
    }
}