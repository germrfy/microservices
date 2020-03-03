using System.Threading;
using System.Threading.Tasks;

namespace SearchDataService.Consume.Design
{
    public interface IConsumer
    {
        Task ConsumeAsync(CancellationToken cancellationToken);
    }
}