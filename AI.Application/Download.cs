using AI.Domain;
using AI.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Application
{
    public class Download
    {
        private FileOperations _infraFileOps = new FileOperations();
        private FileDownload _infraFileDownload = new FileDownload();

        public async Task<bool> DownloadFileAsync(string SoftwareToDownload)
        {
            string downloadpath = @"C:\Users\Pedro\Downloads\";
            var AvailableSoftwares = _infraFileOps.SerializeApps();

            foreach (Software software in AvailableSoftwares)
            {
                if (software.nome == SoftwareToDownload)
                {
                    await _infraFileDownload.DownloadFileToMachineAsync(software, downloadpath);
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
            var AvailableSoftwares = _infraFileOps.SerializeApps();
            List<string> Softwares = new List<string>();

            foreach (Software software in AvailableSoftwares)
            {
                Softwares.Add(software.nome);
            }

            return Softwares;
        }
    }
}
