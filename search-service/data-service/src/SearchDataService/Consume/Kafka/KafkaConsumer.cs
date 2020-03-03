using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SearchDataService.Consume.Design;
using SearchDataService.Process.Design;

namespace SearchDataService.Consume.Kafka
{
    public class KafkaConsumer : IConsumer
    {
        private readonly IProcessorFactory _processorFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<KafkaConsumer> _logger;

        public KafkaConsumer(IProcessorFactory processorFactory, IConfiguration configuration, ILogger<KafkaConsumer> logger) 
        {
            _processorFactory = processorFactory;
            _configuration = configuration;
            _logger = logger;
        }

        public Task ConsumeAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}