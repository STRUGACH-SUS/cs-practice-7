namespace App;

/// <summary>
/// Настройка и работа с файлом перед использованием
/// </summary>
public class FraudWithFile
{
    /// <summary>
    /// Очистка файла
    /// </summary>
    async public static void Overwriting(FileInfo dest)
    {
        InterfaceConsole.WriterMessages("Overwriting");
        await File.WriteAllTextAsync(dest.FullName, string.Empty);
    }
    
    /// <summary>
    /// Создание файла
    /// </summary>
    public static void Create(FileInfo file)
    {
        InterfaceConsole.WriterMessages("Create");
        File.Create(file.FullName).Close();
    } 
    
    /// <summary>
    /// Удаление файла
    /// </summary>
    public static void Delete(FileInfo file)
    {
        InterfaceConsole.WriterMessages("Delete");
        File.Delete(file.FullName);
    } 
}