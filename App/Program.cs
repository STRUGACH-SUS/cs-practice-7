using App;

var cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, _) => cts.Cancel();//тут короче нужно как раз сделать при нажатии ctrl + c выход и очистку файла

var uris = InputData.GetUris();
var dest = InputData.GetOutputFile();
var destStream = dest.OpenWrite();

await Parallel.ForEachAsync(uris, cts.Token, async (uri, ct) =>
{
    try
    {
        using var http = new HttpClient();
        await using var content = await http.GetStreamAsync(uri, ct);
        await content.CopyToAsync(destStream, ct);//Тут короче он копирует данные вначало а не записывает их в конец
    }
    catch
    {
        Console.WriteLine($"При чтении файла произошла ошибка.");
        throw new OperationCanceledException();//Фигня скорее всего
    }
});

await destStream.DisposeAsync();

GetNumberOfLinesInFile.GetNumberOfLines(dest);
