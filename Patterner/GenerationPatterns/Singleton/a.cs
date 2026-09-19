public class A
{
    public ILogger logger;
    public A()
    {
        logger = Logger.getInstance();
        logger.Log("Initialized class A");
    }
}