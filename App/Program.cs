using App;

var cts = new CancellationTokenSource();

InterfaceConsole.WriterMessages("FirstQuestion");
var uris = InputData.GetUris();

InterfaceConsole.WriterMessages("SecondQuestion");
var dest = InputData.GetOutputPathOfFile();

var http = new HttpClient();

var destStream = new StreamWriter(dest.FullName, true);

Console.CancelKeyPress += (_,_) =>
{
    cts.Cancel();
    InterfaceConsole.WriterMessages("Cancellation");
    destStream.Close();
    FraudWithFile.Delete(dest);
    
};

InterfaceConsole.WriterMessages("RecordStart");

var tasks = new List<Task>();

var semaphore = new SemaphoreSlim(1, 1);

foreach (var uri in uris)
{
    var task = ProcessData(uri, cts.Token);
    tasks.Add(task);
}
await Task.WhenAll(tasks);

async Task ProcessData(string uri, CancellationToken ct)
{
    try
    {
        await using var content = await http.GetStreamAsync(uri, ct);
        await semaphore.WaitAsync(ct);
        try
        {
            await content.CopyToAsync(destStream.BaseStream, ct);
        }
        finally
        {
            semaphore.Release();
        }
    }
    catch
    {
        InterfaceConsole.WriterMessages("Error");
        throw;
    }
}
await destStream.DisposeAsync();

InterfaceConsole.WriterMessages("RecordEnd");

GetNumberOfLinesInFile.GetNumberOfLines(dest);