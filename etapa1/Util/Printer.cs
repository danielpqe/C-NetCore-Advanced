using static System.Console;
public static class Printer
{
    public static void DrawLine(int tam = 10)
    {
        WriteLine("".PadLeft(tam, '='));
    }

    public static void WriteTitle(string title)
    {
        var lenght = title.Length + 4;
        DrawLine(lenght);
        WriteLine($"| {title} |");
        DrawLine(lenght);
    }
}