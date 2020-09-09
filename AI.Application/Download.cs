using AI.Domain;
using AI.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Application
{
    public class Download : IDownload
    {
        private readonly IFileDownload _infrasctructureFileDownload;
        private readonly IFileOperations _infrasctructureFileOps;

        public Download(IFileDownload infrasctructureFileDownload, IFileOperations infrasctructureFileOps)
        {
            _infrasctructureFileDownload = infrasctructureFileDownload;
            _infrasctructureFileOps = infrasctructureFileOps;

        }

        public async Task<bool> DownloadFileAsync(string SoftwareToDownload)
        {
            string downloadpath = @"C:\Users\Pedro\Downloads\";
            var AvailableSoftwares = _infrasctructureFileOps.SerializeApps();

            foreach (Software software in AvailableSoftwares)
            {
                if (software.nome == SoftwareToDownload)
                {
                    await _infrasctructureFileDownload.DownloadFileToMachineAsync(software, downloadpath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public List<string> ListAvailableSoftwares()
        {
            var AvailableSoftwares = _infrasctructureFileOps.SerializeApps();
            List<string> Softwares = new List<string>();

            foreach (Software software in AvailableSoftwares)
            {
                Softwares.Add(software.nome);
            }

            return Softwares;
        }
    }
}
