using AI.Domain;
using AI.IoC;
using AI.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Application
{
    public class Download : IDownload
    {
        private readonly IInfrastructureFactory _infrasctructureFactory;
        private readonly IFileOperations _infrasctructureFileOps;
        private readonly IFileDownload _infrasctructureFileDownload;

        public Download(IInfrastructureFactory infrasctructureFactory)
        {
            _infrasctructureFactory = infrasctructureFactory;
            _infrasctructureFileOps = _infrasctructureFactory.GetFileOperationsAccess();
            _infrasctructureFileDownload = _infrasctructureFactory.GetFileDownloadAccess();
        }

        public async Task<bool> DownloadFileAsync(string SoftwareToDownload)
        {
            string downloadpath = @"C:\Users\Pedro\Downloads\";
            var AvailableSoftwares = _infrasctructureFileOps.SerializeApps();

            foreach (Software software in AvailableSoftwares)
            {
                if (software.Name == SoftwareToDownload)
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
                Softwares.Add(software.Name);
            }

            return Softwares;
        }
    }
}
