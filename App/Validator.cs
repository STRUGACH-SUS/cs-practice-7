namespace App;
/// <summary>
/// Валидирует ввод пользователя
/// </summary>
public class Validator
{
    /// <summary>
    /// Проверка URL.
    /// </summary>
    public static bool IsValidUri(string url)
    {
        try
        {
            if (url == null)
            {
                throw new("Произошла ошибка, URL не может быть пустым.");
            }
            if (!url.StartsWith("https://"))
            {
                throw new("Произошла ошибка, URL должен начинаться с ( https:// ).");
            }
            if (!url.EndsWith(".txt"))
            {
                throw new("Произошла ошибка, URL должен заканчиваться на ( .txt ).");
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
                throw new("Произошла ошибка, нужно ввести файл с расщирением (.txt).");
            }
            if (file.Exists)
            {
                Console.Write("Пeрезаписать файл (да/нет)?  ");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "да")
                {
                    File.WriteAllText(file.FullName, string.Empty);
                }
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