using AI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Infrastructure
{
    public interface IFileOperations
    {
        Task RunProcessAsync(string fileName, string arguments);
        List<Software> SerializeApps();
    }
}