namespace SearchDataService.Process.Design
{
    public interface IProcessorFactory
    {
        IProcessor GetSubscriber();
    }
}