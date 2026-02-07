static class FileService
{
    public static async Task SaveAsync(List<TodoTask> tasks)
    {
        var lines = tasks.Select((t) => $"{t.Id} | {t.Title} | {t.Status}");

        await File.WriteAllLinesAsync("tasks.txt", lines);
    }

    public static async Task<List<TodoTask>> LoadAsync()
    {
        if (!File.Exists("tasks.txt")) return new List<TodoTask>();


        var lines = await File.ReadAllLinesAsync("tasks.txt");
        return lines.Select(l =>
               {
                   var p = l.Split('|');
                   var task = new TodoTask(int.Parse(p[0]), p[1]);
                   if (p[2] == "Completed") task.Complete();
                   return task;
               }).ToList();

    }
}