using Confluent.Kafka;

namespace SearchDataService.Consume.Kafka
{
    public class KafkaConsumerFactory
    {
        public IConsumer<Ignore, T> GetKafkaConsumer<T>()
        {
            var conf = new ConsumerConfig
            { 
                GroupId = "test-consumer-group",
                BootstrapServers = "localhost:9092",
                AutoOffsetReset = AutoOffsetReset.Earliest,
            };

            return new ConsumerBuilder<Ignore, T>(conf).Build();
        }
    }
}