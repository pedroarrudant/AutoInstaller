using AI.Infrastructure;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AI.IoC
{
    public interface IInfrastructureFactory
    {
        IFileDownload GetFileDownloadAccess();
        IFileOperations GetFileOperationsAccess();
    }
    public class InfrastructureFactory : IInfrastructureFactory
    {
        public IFileDownload GetFileDownloadAccess()
            {
                return new FileDownload();
            }

        public IFileOperations GetFileOperationsAccess()
        {
            return new FileOperations();
        }
    }
}
