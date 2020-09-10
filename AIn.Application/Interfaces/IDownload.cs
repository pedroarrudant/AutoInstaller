using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Application
{
    public interface IDownload
    {
        Task<bool> DownloadFileAsync(string SoftwareToDownload);
        List<string> ListAvailableSoftwares();
    }
}