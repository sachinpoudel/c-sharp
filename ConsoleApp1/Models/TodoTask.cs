enum TaskStatus
{
    Pending,
    Completed
}

class TodoTask
{
    public int Id {get;}
    public string Title {get;}
    public TaskStatus Status {get; private set;}




    public TodoTask (int id, string title)
    {
        Id = id;
        Title = title;
        Status = TaskStatus.Pending;
    }

public void Complete () => Status = TaskStatus.Completed;

    public override string ToString()
    {
        return $"{Id}. {Title} [{Status}]";
    }

}