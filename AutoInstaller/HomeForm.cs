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
    public partial class HomeForm : Form
    {
        private readonly string downloadpath = @"C:\Users\Pedro\Downloads\";
        private readonly List<Software> softwares;
        public HomeForm()
        {
            InitializeComponent();

            this.softwares = SerializeApps();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Install",
                Name = "chkinstall"
            };

            var columnName = new DataGridViewColumn
            {
                HeaderText = "Software Name",
                Name = "columnName",
                CellTemplate = cell
            };

            var columnSize = new DataGridViewColumn
            {
                HeaderText = "Software Size",
                Name = "columnSize",
                CellTemplate = cell
            };

            dgvSoftwares.Columns.Add(chk);
            dgvSoftwares.Columns.Add(columnName);
            dgvSoftwares.Columns.Add(columnSize);

            foreach (var software in softwares)
            {
                object[] row = new object[] { false, software.nome, "0" + " MB" };
                dgvSoftwares.Rows.Add(row);
            }
        }

        private async void btnInstalar_Click(object sender, EventArgs e)
        {
            progressInstallation.Maximum = dgvSoftwares.RowCount;
            foreach (DataGridViewRow row in dgvSoftwares.Rows)
            {
                foreach (var software in softwares)
                {
                    if (software.nome == row.Cells[1].Value.ToString() && row.Cells[0].Value.ToString() == "True")
                    {
                        lblStatus.Text = "Instalando " + software.nome + "...";
                        Uri remoteUri = new Uri(software.caminhoweb);
                        string fileName = software.nomearquivo;

                        // Create a new WebClient instance.
                        using (WebClient myWebClient = new WebClient())
                        {
                            // Download the Web resource and save it into the current filesystem folder.
                            await myWebClient.DownloadFileTaskAsync(remoteUri, downloadpath + fileName);
                        }

                        //ProcessStartInfo info = new ProcessStartInfo();

                        //info.FileName = downloadpath + fileName;
                        //info.Arguments = software.formasileciosa;

                        //using (Process exeProcess = Process.Start(info))
                        //{
                        //    exeProcess.WaitForExit();
                        //}

                        await RunProcessAsync(downloadpath + fileName, software.formasileciosa);
                        lblStatus.Text = software.nome + " instalado com sucesso!";
                    }
                }
                lblStatus.Text = "Todos os softwares selecionados foram instalados com sucesso!";
                progressInstallation.Value += 1;
            }
        }

        private List<Software> SerializeApps()
        {
            string filepath = "./AppList.json";
            string text = File.ReadAllText(filepath);

            var deserializedProduct = JsonConvert.DeserializeObject<List<Software>>(text);

            return deserializedProduct;
        }

        public static async Task RunProcessAsync(string fileName, string arguments)
        {
            var tcs = new TaskCompletionSource<int>();

            var process = new Process
            {
                StartInfo = { FileName = fileName, Arguments = arguments },
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
