using AI.Domain;
using AI.Infrastructure;
using AI.Infrastructure.IoC;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AI.Application
{
    public class Install : IInstall
    {
        private readonly IInfrastructureFactory _infrasctructureFactory;
        private readonly IFileOperations _infrasctructureFileOps;
        private readonly IFileDownload _infrasctructureFileDownload;
        public Install(IInfrastructureFactory infrasctructureFactory)
        {
            _infrasctructureFactory = infrasctructureFactory;
            _infrasctructureFileOps = _infrasctructureFactory.GetFileOperationsAccess();
            _infrasctructureFileDownload = _infrasctructureFactory.GetFileDownloadAccess();
        }
        public async Task InstallSoftwareAsync(string fileName)
        {
            var AvailableSoftwares = _infrasctructureFileOps.SerializeApps();

            foreach (Software software in AvailableSoftwares)
            {
                if (fileName == software.Name)
                {
                    await _infrasctructureFileOps.RunProcessAsync(software.FileName, software.Silent);
                }
            }
        }
    }
}
