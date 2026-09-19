class ComputerFactory
{
    public static IComputer createPC()
    {
        return new PC1();
    }
    public static IComputer createServer()
    {
        return new Server();
    }
}