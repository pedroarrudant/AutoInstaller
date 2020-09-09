using System.Threading.Tasks;

namespace AI.Application
{
    public interface IInstall
    {
        Task InstallSoftwareAsync(string fileName);
    }
}