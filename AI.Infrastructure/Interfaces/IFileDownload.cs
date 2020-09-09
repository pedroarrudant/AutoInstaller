using AI.Domain;
using System.Threading.Tasks;

namespace AI.Infrastructure
{
    public interface IFileDownload
    {
        Task DownloadFileToMachineAsync(Software software, string DownloadPath);
    }
}