using System;
using System.Net;
using System.Threading.Tasks;
using AI.Domain;

namespace AI.Infrastructure
{
    public class FileDownload : IFileDownload
    {
        public async Task DownloadFileToMachineAsync(Software software, string DownloadPath)
        {
            Uri remoteUri = new Uri(software.caminhoweb);
            string fileName = software.nomearquivo;

            using (WebClient myWebClient = new WebClient())
            {
                await myWebClient.DownloadFileTaskAsync(remoteUri, DownloadPath + fileName);
            }
        }
    }
}
