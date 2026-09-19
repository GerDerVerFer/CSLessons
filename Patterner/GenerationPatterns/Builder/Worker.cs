class Worker
{
    private Building currentWork;
    public Worker()
    {
        currentWork = new Building();
    }
    public Building build()
    {
        return currentWork;
    }
    public Worker foundation(string f)
    {
        currentWork.foundation = f;
        return this;
    }

    public Worker walls(string w) 
    {
        currentWork.walls = w;
        return this;
    }
    public Worker roof(string r)
    {
        currentWork.roof = r;
        return this;
    }
    public Worker interior (string i)
    {
        currentWork.interior = i;
        return this;
    }
}