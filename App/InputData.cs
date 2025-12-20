namespace App;

/// <summary>
/// Считывает ввод пользователя
/// </summary>
public static class InputData
{
    
    /// <summary>
    /// Считывает от пользователя URL файлов из интернета
    /// </summary>
    public static string[] GetUris()
    {
        string[] result = [];
        var valid = false;
        while (valid is false)
        {
            result = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            valid = result.Any(x => Validator.IsValidUri(x) is false);// возможен вылет ошибки так как массив может быть пустым
            if (valid is false)
            {
                break;
            }
        }
        return result;
    }
    
    /// <summary>
    /// Считывает от пользователя путь до файла в который будет записана информация
    /// </summary>
    public static FileInfo GetOutputPathOfFile()
    {
        while (true)
        {
            var file = new FileInfo(Console.ReadLine()!.Trim());
            if (Validator.IsValidFile(file))
            {
                return file;
            }
        }
    }

    /// <summary>
    /// Считывает от пользователя разрешение на перезапись файла
    /// </summary>
    public static void OverwritingFile(FileInfo dest)
    {
        var answer = Console.ReadLine()!.ToLower().Trim();
        if (answer is "да")
        {
            FraudWithFile.Overwriting(dest);             
        }
    }
}