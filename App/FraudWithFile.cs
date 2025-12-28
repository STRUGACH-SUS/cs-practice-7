namespace App;

/// <summary>
/// Настройка и работа с файлом перед использованием
/// </summary>
public class FraudWithFile
{
    /// <summary>
    /// Очистка файла
    /// </summary>
    async public static void Overwrite(FileInfo dest)
    {
        InterfaceConsole.WriteMessages(InterfaceConsole.Overwrite);
        await File.WriteAllTextAsync(dest.FullName, string.Empty);
    }
    
    /// <summary>
    /// Создание файла
    /// </summary>
    public static void Create(FileInfo file)
    {
        InterfaceConsole.WriteMessages(InterfaceConsole.Create);
        File.Create(file.FullName).Close();
    } 
    
    /// <summary>
    /// Удаление файла
    /// </summary>
    public static void Delete(FileInfo file)
    {
        InterfaceConsole.WriteMessages(InterfaceConsole.Delete);
        File.Delete(file.FullName);
    } 
}