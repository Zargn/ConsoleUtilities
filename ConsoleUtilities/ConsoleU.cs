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
    /// Writes the specified string value, followed by the current line terminator, to the standard output stream in the color specified.
    /// </summary>
    /// <param name="value">value – The value to write.</param>
    /// <param name="color">color - The color to write in.</param>
    public static void WriteLineWithColor(object? value, ConsoleColor color)
    {
        WriteLineWithColor(value.ToString(), color);
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
    /// Writes the specified string value to the standard output stream in the color specified.
    /// </summary>
    /// <param name="value">value – The value to write.</param>
    /// <param name="color">color - The color to write in.</param>
    public static void WriteWithColor(object? value, ConsoleColor color)
    {
        WriteWithColor(value.ToString(), color);
    }
    
    /// <summary>
    /// Combines a WriteLine and ReadLine call into one method that presents the user with a string and then returns the answer provided by the user.
    /// </summary>
    /// <param name="question">question – The question to present to the user.</param>
    /// <param name="color">color - The color of the printed question. Can be left blank for default color.</param>
    /// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
    public static string? RequestStringInput(string? question, ConsoleColor? color = null)
    {
        WriteWithNullableColor(question, color);
        return Console.ReadLine();
    }
    
    /// <summary>
    /// Combines a WriteLine and ReadLine call into one method that presents the user with a string and then returns the answer provided by the user.
    /// </summary>
    /// <param name="question">question – The question to present to the user.</param>
    /// <param name="color">color - The color of the printed question. Can be left blank for default color.</param>
    /// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
    public static string? RequestStringInput(object? question, ConsoleColor? color = null)
    {
        return RequestStringInput(question.ToString(), color);
    }

    /// <summary>
    /// Asks the user for input in int format and repeats until a valid answer is received.
    /// </summary>
    /// <param name="question">question - The question to present to the user.</param>
    /// <param name="questionColor">questionColor - The color of the printed question. Can be left blank for default color.</param>
    /// <param name="errorColor">errorColor - The color of printed errors on invalid input. Can be left bland for default color.</param>
    /// <returns>A int converted from the users input string.</returns>
    public static int RequestIntInput(string question, ConsoleColor? questionColor = null, ConsoleColor? errorColor = null)
    {
        while (true)
        {
            try
            {
                var answer = RequestStringInput(question, questionColor);
                var number = Int32.Parse(answer);
                return number;
            }
            catch (FormatException)
            {
                WriteLineWithNullableColor("Error: Input may only contain numbers. Please try again.", errorColor);
            }
            catch (NullReferenceException)
            {
                WriteLineWithNullableColor("Error: No input provided. Please try again.", errorColor);
            }
        }
    }
    
    /// <summary>
    /// Asks the user for input in int format and repeats until a valid answer is received.
    /// </summary>
    /// <param name="question">question - The question to present to the user.</param>
    /// <param name="questionColor">questionColor - The color of the printed question. Can be left blank for default color.</param>
    /// <param name="errorColor">errorColor - The color of printed errors on invalid input. Can be left bland for default color.</param>
    /// <returns>A int converted from the users input string.</returns>
    public static int RequestIntInput(object? question, ConsoleColor? questionColor = null, ConsoleColor? errorColor = null)
    {
        return RequestIntInput(question.ToString(), questionColor, errorColor);
    }

    /// <summary>
    /// Checks and calls either WriteLineWithColor or standard WriteLine depending on the input color.
    /// </summary>
    /// <param name="value">value – The value to write.</param>
    /// <param name="color">color - The color to write in. Can be left empty for default color.</param>
    private static void WriteLineWithNullableColor(string? value, ConsoleColor? color)
    {
        if (color != null)
            WriteLineWithColor(value, (ConsoleColor) color);
        else
            Console.WriteLine(value);
    }
    
    /// <summary>
    /// Checks and calls either WriteWithColor or standard Write depending on the input color.
    /// </summary>
    /// <param name="value">value – The value to write.</param>
    /// <param name="color">color - The color to write in. Can be left empty for default color.</param>
    private static void WriteWithNullableColor(string? value, ConsoleColor? color)
    {
        if (color != null)
            WriteWithColor(value, (ConsoleColor) color);
        else
            Console.Write(value);
    }
}