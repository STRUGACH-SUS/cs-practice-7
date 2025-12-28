namespace App;

/// <summary>
/// выводит заранее заготовленный текст в консоль пользователю
/// </summary>
public class InterfaceConsole
{
    public const string FirstQuestion =
            "Введите нужные URI через пробел (Пример: https://un1ver5e.ru/api/files/o1apoh5j.bdw.txt): ",
        SecondQuestion =
            """Введите путь до файла В который будет записан результат (Пример: C:\Users\htcbe\OneDrive\Рабочий стол\jfdgkdjfhgk.txt): """,
        ThirdQuestion = "Пeрезаписать файл (да/нет)?  ",
        ErrorInUri1 = "Произошла ошибка, URI не может быть пустым. Попробуйте ещё раз.",
        ErrorInUri2 = "Произошла ошибка, URI должен начинаться с (https://). Попробуйте ещё раз.",
        ErrorInUri3 = "Произошла ошибка, URI неккоректный. Попробуйте ещё раз.",
        ErrorInPathOfFile1 = "Произошла ошибка, путь к файлу не может быть пустым. Попробуйте ещё раз.",
        ErrorInPathOfFile2 = "Произошла ошибка, папка по указанному пути не существует. Попробуйте ещё раз.",
        Overwrite = "Очистка файла.",
        Delete = "Удаление файла.",
        Create = "Создание файла.",
        Cancellation = "Отменяем процесс.",
        Error = "Произошла ошибка.",
        RecordStart = "Началась запись.",
        RecordEnd = "Запись окончена.";
    /// <summary>
    /// Получаее ключ к фразе и выводит ее
    /// </summary>
    public static void WriteMessages(string key)
    {
        Console.WriteLine(key);//метод фигня, но если что-то можно дополнить
    }
}