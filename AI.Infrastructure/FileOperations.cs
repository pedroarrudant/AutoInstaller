using AI.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AI.Infrastructure
{
    public class FileOperations : IFileOperations
    {
        private readonly string downloadpath = @"C:\Users\Pedro\Downloads\";
        public List<Software> SerializeApps()
        {
            string filepath = "./AppList.json";
            string text = File.ReadAllText(filepath);

            var deserializedProduct = JsonConvert.DeserializeObject<List<Software>>(text);

            return deserializedProduct;
        } 

        public Task<int> RunProcessAsync(string fileName, string arguments)
        {
            var tcs = new TaskCompletionSource<int>();

            var process = new Process
            {
                StartInfo = { FileName = downloadpath + fileName, Arguments = arguments },
                EnableRaisingEvents = true
            };

            process.Exited += (sender, args) =>
            {
                tcs.SetResult(process.ExitCode);
                process.Dispose();
            };

            process.Start();

            return tcs.Task;
        }
    }
}
