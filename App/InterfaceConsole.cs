namespace App;

/// <summary>
/// выводит заранее заготовленный текст в консоль пользователю
/// </summary>
public class InterfaceConsole
{
    /// <summary>
    /// Получаее ключ к фразе и выводит ее
    /// </summary>
    public static void WriterMessages(string key)
    { 
        Dictionary<string, string> Messages = new Dictionary<string, string>()
        {
            ["FirstQuestion"] = "Введите нужные URI через пробел (Пример: https://un1ver5e.ru/api/files/o1apoh5j.bdw.txt): ",
            ["SecondQuestion"] = """Введите путь до файла В который будет записан результат (Пример: C:\Users\htcbe\OneDrive\Рабочий стол\jfdgkdjfhgk.txt): """,
            ["ThirdQuestion"] = "Пeрезаписать файл (да/нет)?  ",
            
            ["ErrorInURI_1"] = "Произошла ошибка, URI не может быть пустым. Попробуйте ещё раз.",
            ["ErrorInURI_2"] = "Произошла ошибка, URI должен начинаться с (https://). Попробуйте ещё раз.",
            ["ErrorInURI_3"] = "Произошла ошибка, URI неккоректный. Попробуйте ещё раз.",
            
            ["ErrorInPathOfFile_1"] = "Произошла ошибка, путь к файлу не может быть пустым. Попробуйте ещё раз.",
            ["ErrorInPathOfFile_2"] = "Произошла ошибка, файла по указанному пути не существует. Попробуйте ещё раз.",
            ["ErrorInPathOfFile_3"] = "Произошла ошибка, файл уже используется другим процессом. Попробуйте ещё раз.",
            ["ErrorInPathOfFile_4"] = "Произошла ошибка, папка по указанному пути не существует. Попробуйте ещё раз.",
            
            ["Overwriting"] = "Очистка файла.",
            ["Delete"] = "Удаление файла.",
            ["Create"] = "Создание файла.",
            ["Cancellation"] = "Отменяем процесс.",
            ["Error"] = "Произошла ошибка.",
            ["RecordStart"] = "Началась запись.",
            ["RecordEnd"] = "Запись окончена."
        };
        Console.WriteLine(Messages[key]);
    }
}