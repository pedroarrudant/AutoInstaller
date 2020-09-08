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
        private readonly List<Software> softwares;
        public Form1()
        {
            InitializeComponent();

            this.softwares = SerializeApps();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Install";
            chk.Name = "chkinstall";

            var columnName = new DataGridViewColumn();
            columnName.HeaderText = "Software Name";
            columnName.Name = "columnName";
            columnName.CellTemplate = cell;

            var columnSize = new DataGridViewColumn();
            columnSize.HeaderText = "Software Size";
            columnSize.Name = "columnSize";
            columnSize.CellTemplate = cell;

            dgvSoftwares.Columns.Add(chk);
            dgvSoftwares.Columns.Add(columnName);
            dgvSoftwares.Columns.Add(columnSize);

            foreach (var software in softwares)
            {
                object[] row = new object[] { false, software.nome, "0" + " MB" };
                dgvSoftwares.Rows.Add(row);
            }
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSoftwares.Rows)
            {
                foreach (var software in softwares)
                {
                    if (software.nome == row.Cells[1].Value.ToString() && row.Cells[0].Value.ToString() == "True")
                    {
                        string remoteUri = software.caminhoweb;
                        string fileName = software.nomearquivo;

                        // Create a new WebClient instance.
                        using (WebClient myWebClient = new WebClient())
                        {
                            // Download the Web resource and save it into the current filesystem folder.
                            myWebClient.DownloadFile(remoteUri, downloadpath + fileName);
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
