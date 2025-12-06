namespace App;
/// <summary>
/// Получаем количество строк в итоговом файле
/// </summary>
public class GetNumberOfLinesInFile
{
    public static void GetNumberOfLines(FileInfo filePath)
    {
        using var reader = new StreamReader(filePath.FullName);
        long lineCount = 0;
        while (reader.ReadLine() != null)
        {
            lineCount++;
        }
        Console.WriteLine( $"В вашем файле {lineCount} строк.");
    }
}