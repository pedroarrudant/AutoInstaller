using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Application.Domain
{
    public interface IFileOperations
    {
        Task<int> RunProcessAsync(string fileName, string arguments);
        List<Software> SerializeApps();
    }
}