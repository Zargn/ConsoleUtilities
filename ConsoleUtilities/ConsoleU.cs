namespace ConsoleUtilities;

public static class ConsoleU
{
    /// <summary>
    /// Writes the specified string value, followed by the current line terminator, to the standard output stream in the color specified.
    /// </summary>
    /// <param name="value">value – The value to write.</param>
    /// <param name="color">color - The color to write in.</param>
    public static void WriteLineWithColor(string? value, ConsoleColor color)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(value);
        Console.ForegroundColor = oldColor;
    }
    
    /// <summary>
    /// Writes the specified string value to the standard output stream in the color specified.
    /// </summary>
    /// <param name="value">value – The value to write.</param>
    /// <param name="color">color - The color to write in.</param>
    public static void WriteWithColor(string? value, ConsoleColor color)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(value);
        Console.ForegroundColor = oldColor;
    }
    
    /// <summary>
    /// Combines a WriteLine and ReadLine call into one method that presents the user with a string and then returns the answer provided by the user.
    /// </summary>
    /// <param name="question">question – The question to present to the user.</param>
    /// <param name="color">color - The color of the printed question. Can be left blank for default color.</param>
    /// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
    public static string? RequestStringInput(string question, ConsoleColor? color = null)
    {
        if (color != null)
            WriteWithColor(question, (ConsoleColor) color);
        else
            Console.Write(question);
        return Console.ReadLine();
    }
}