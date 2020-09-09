﻿using AI.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AI.Infrastructure
{
    public class FileOperations
    {
        public List<Software> SerializeApps()
        {
            string filepath = "./AppList.json";
            string text = File.ReadAllText(filepath);

            var deserializedProduct = JsonConvert.DeserializeObject<List<Software>>(text);

            return deserializedProduct;
        }

        public async Task RunProcessAsync(string fileName, string arguments)
        {
            string downloadpath = @"C:\Users\Pedro\Downloads\";
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
        }
    }
}
