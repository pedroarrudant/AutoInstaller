using AI.Domain;
using AI.Infrastructure;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AI.Application
{
    public class Install
    {
        readonly FileOperations fileOps = new FileOperations();
        public async Task InstallSoftwareAsync(string fileName)
        {
            var AvailableSoftwares = fileOps.SerializeApps();

            foreach (Software software in AvailableSoftwares)
            {
                if (fileName == software.nome)
                {
                    await fileOps.RunProcessAsync(software.nomearquivo, software.formasileciosa);
                }
            }
        }
    }
}
