public class B
{
    public ILogger logger;
    public B() {
        logger = Logger.getInstance();

        logger.Log("Initialized class B");
    }
}