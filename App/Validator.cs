namespace App;
/// <summary>
/// Валидирует ввод пользователя
/// </summary>
public class Validator
{
    /// <summary>
    /// Проверка URI
    /// </summary>
    public static bool IsValidUri(string uri)//не хватает проверки URI
    {
        try
        {
            if (uri is null)
            {
                throw new Exception("ErrorInURI_1");
            }
            if (!uri.StartsWith("https://"))
            {
                throw new Exception("ErrorInURI_2");
            }
            if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
            {
                throw new Exception("ErrorInURI_3");
            }
            return true;
        }
        catch(Exception e)
        {
            InterfaceConsole.WriterMessages(e.Message);
            return false;
        }
    }
    
    /// <summary>
    /// Проверка пути до файла
    /// </summary>
    public static bool IsValidFile(FileInfo file)
    {
        try
        {
            if (file is null)
            {
                throw new Exception("ErrorInPathOfFile_1");
            }
            if (!Path.Exists(file.DirectoryName))
            {
                throw new Exception("ErrorInPathOfFile_4");
            }
            if (!file.Exists)
            {
                FraudWithFile.Create(file);
            }
            else
            {
                InterfaceConsole.WriterMessages("ThirdQuestion");
                InputData.OverwritingFile(file);
            }
            return true;
        }
        catch(Exception e)
        {
            InterfaceConsole.WriterMessages(e.Message);
            return false;
        }
    }
}