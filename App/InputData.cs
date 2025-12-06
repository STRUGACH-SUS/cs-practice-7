namespace App;

/// <summary>
/// Считывает ввод пользователя.
/// </summary>
public static class InputData
{
    /// <summary>
    /// Считывает от пользователя URL файлов из интернета.
    /// </summary>
    public static string[] GetUris()
    {
        string[] result = [];
        var valid = false;
        while (valid is false)
        {
            Console.Write("Введите нужные URL через пробел (Пример: https://un1ver5e.ru/api/files/o1apoh5j.bdw.txt): ");
            result = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            valid = result.Any(x => Validator.IsValidUri(x) is false);// возможен вылет ошибки так как массив может быть пустым
            
            if (valid is false)
            {
                break;
            }
        }
        return result;
    }
    
    public static FileInfo GetOutputFile()
    {
        while (true)
        {
            Console.Write("""Введите путь до файла с результатом (Пример: C:\Users\htcbe\OneDrive\Рабочий стол\jfdgkdjfhgk.txt ): """);
            var file = new FileInfo(Console.ReadLine()!.Trim());
            if (Validator.IsValidFile(file))
            {
                return file;    
            }
        }
    }
}