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
                throw new Exception(InterfaceConsole.ErrorInUri1);
            }
            if (!uri.StartsWith("https://"))
            {
                throw new Exception(InterfaceConsole.ErrorInUri2);
            }
            if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
            {
                throw new Exception(InterfaceConsole.ErrorInUri3);
            }
            return true;
        }
        catch(Exception e)
        {
            InterfaceConsole.WriteMessages(e.Message);
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
                throw new Exception(InterfaceConsole.ErrorInPathOfFile1);
            }
            if (!Path.Exists(file.DirectoryName))
            {
                throw new Exception(InterfaceConsole.ErrorInPathOfFile2);
            }
            if (!file.Exists)
            {
                FraudWithFile.Create(file);
            }
            else
            {
                InterfaceConsole.WriteMessages(InterfaceConsole.ThirdQuestion);
                InputData.OverwritingFile(file);
            }
            return true;
        }
        catch(Exception e)
        {
            InterfaceConsole.WriteMessages(e.Message);
            return false;
        }
    }
}