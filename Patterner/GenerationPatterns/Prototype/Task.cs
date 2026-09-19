class Task : ITask
{
    public string description { get; set; }

    public ITask Clone()
    {
        Task clone = new Task();
        clone.description = description;
        return clone;
    }

    public string getDescription()
    {
        return description;
    }
    public override bool Equals(object obj)
    {
        return description.Equals(((Task)obj).description);
    }
}