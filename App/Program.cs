using System.Net;                 
using App;                       
// https://un1ver5e.ru/api/files/5hs0j15l.4si.txt
// C:\Users\stryg\Desktop\Проверочка.txt
var cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, _) => cts.Cancel();//Для чего удалять файл???

var uris = InputData.GetUris();
var dest = InputData.GetOutputFile();
var http = new HttpClient();

Console.Write("Пeрезаписать файл (да/нет)?  ");
var answer = Console.ReadLine()!.ToLower().Trim();
if (answer == "да")
{
    File.WriteAllText(dest.FullName, string.Empty);               
}

var destStream = new StreamWriter(dest.FullName, true);

await Parallel.ForEachAsync(uris, cts.Token, async (uri, ct) =>
{
    try
    {//нужно использовать синхронизацию потоков или lock, чтобы не перемешалось содержимое
        await using var content = await http.GetStreamAsync(uri, ct);
        await content.CopyToAsync(destStream.BaseStream, ct);//Тут короче он копирует данные вначало а не записывает их в конец
    }
    catch
    {
        
    }
});

await destStream.DisposeAsync();

GetNumberOfLinesInFile.GetNumberOfLines(dest);
