using System.Collections.Generic;


delegate void TaskNotification(TodoTask task);
class TaskService
{
    private readonly List<TodoTask> _tasks = new();


    public event TaskNotification? TaskCompleted;

public void AddTask(TodoTask task)
    {
        _tasks.Add(task);
    }
public void CompleteTask(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);

        if(task == null) return;

        task.Complete();
        TaskCompleted?.Invoke(task);
    }

public List<TodoTask> GetPendingTasks () => _tasks.Where((t) => t.Status == TaskStatus.Pending).ToList();

public List<TodoTask> GetAllTasks () => _tasks;


public async Task<List<TodoTask>> LoadTaskAsync()
    {
        await Task.Delay(500);
        return _tasks;
    }

}