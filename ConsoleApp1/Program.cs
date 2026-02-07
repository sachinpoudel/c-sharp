class Program
{
    static async Task Main()
    {
        User user = new User(1, "sachin");

        TaskService service = new TaskService();

        service.TaskCompleted += task =>
        {
            Console.WriteLine($"Task completed {task.Title}");
        };

        var savedTasks = await FileService.LoadAsync();

        foreach (var t in savedTasks) service.AddTask(t);

        service.AddTask(new TodoTask(1, "learn c#"));
        service.AddTask(new TodoTask(2, "learn f#"));

        Console.WriteLine("processing tasks in parallel");

        Parallel.ForEach(service.GetAllTasks(), task =>
        {
            Console.WriteLine(task);
        });

        await FileService.SaveAsync(service.GetAllTasks());
    }
}