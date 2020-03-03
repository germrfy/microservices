using System.Threading;
using System.Threading.Tasks;

namespace SearchDataService.Process.Design
{
    public interface IProcessor 
    {
        Task ProcessAsync(CancellationToken cancellationToken); 
    }
}