namespace App;
/// <summary>
/// Валидирует ввод пользователя
/// </summary>
public class Validator
{
    /// <summary>
    /// Проверка URL.
    /// </summary>
    public static bool IsValidUri(string uri)//не хватает проверки URI
    {
        try
        {
            if (uri == null)
            {
                throw new("Произошла ошибка, URI не может быть пустым.");
            }
            if (!uri.StartsWith("https://"))
            {
                throw new("Произошла ошибка, URI должен начинаться с ( https:// ).");
            }
            if (!uri.EndsWith(".txt"))
            {
                throw new("Произошла ошибка, URI должен заканчиваться на ( .txt ).");
            }
            return true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message + " Попробуйте ещё раз.");
            return false;
        }
    }
    
    /// <summary>
    /// Проверка пути до файла.
    /// </summary>
    public static bool IsValidFile(FileInfo file)
    {
        try
        {
            if (file == null)
            {
                throw new("Произошла ошибка, путь к фалу не может быть пустым.");
            }
            if (!file.Exists)
            {
                throw new("Произошла ошибка, файла по указанному пути не существует.");
            }
            if (file.Extension != ".txt")
            {
                throw new("Произошла ошибка, нужно ввести файл с расширением (.txt).");
            }
            return true;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message + " Попробуйте ещё раз.");
            return false;
        }
    }
}