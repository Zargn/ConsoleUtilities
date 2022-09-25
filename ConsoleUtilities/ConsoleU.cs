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
}