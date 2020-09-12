using AI.Domain;
using AI.Infrastructure;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AI.Application
{
    public class Install : IInstall
    {
        private readonly IFileOperations _infrasctructureFileOps;

        public Install(IFileOperations infrasctructureFileOps)
        {
            _infrasctructureFileOps = infrasctructureFileOps;

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
