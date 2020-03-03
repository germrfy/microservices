namespace SearchDataService.Consume.Design
{
    public interface IConsumerFactory
    {
        IConsumer GetConsumer();
    }
}