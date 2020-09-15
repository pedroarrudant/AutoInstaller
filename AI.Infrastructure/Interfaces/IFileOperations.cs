using AI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Infrastructure
{
    public interface IFileOperations
    {
        Task<int> RunProcessAsync(string fileName, string arguments);
        IEnumerable<Software> SerializeApps();
    }
}