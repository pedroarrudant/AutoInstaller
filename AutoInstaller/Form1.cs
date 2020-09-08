using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInstaller
{
    public partial class Form1 : Form
    {
        private readonly string downloadpath = @"C:\Users\Pedro\Downloads\";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            if (chkNotepadplusplus.Checked == true)
            {
                var softwares = SerializeApps();

                foreach (var software in softwares)
                {
                    if (software.nome == "notepadplusplus")
                    {
                        string remoteUri = software.caminhoweb;
                        string fileName = software.nomearquivo;
                        string myStringWebResource;

                        // Create a new WebClient instance.
                        using (WebClient myWebClient = new WebClient())
                        {
                            myStringWebResource = remoteUri + fileName;
                            // Download the Web resource and save it into the current filesystem folder.
                            myWebClient.DownloadFile(myStringWebResource, downloadpath + fileName);
                        }

                        ProcessStartInfo info = new ProcessStartInfo();

                        info.FileName = downloadpath + fileName;
                        info.Arguments = software.formasileciosa;

                        using (Process exeProcess = Process.Start(info))
                        {
                            exeProcess.WaitForExit();
                        }
                    }
                }
            }
        }

        private List<Software> SerializeApps()
        {
            string filepath = "./AppList.json";
            string text = File.ReadAllText(filepath);

            var deserializedProduct = JsonConvert.DeserializeObject<List<Software>>(text);

            return deserializedProduct;
        }
    }
}
