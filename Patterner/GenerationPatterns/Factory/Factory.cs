class Factory
{
    public static void Run()
    {
        IComputer pc = ComputerFactory.createPC();
        IComputer srv = ComputerFactory.createServer();

        pc.turnOn();
        srv.turnOn();
        pc.turnOff();
        srv.turnOff();
    }
}