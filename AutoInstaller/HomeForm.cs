using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI.Application;

namespace AutoInstaller
{
    public partial class HomeForm : Form
    {
        Download appDownload = new Download();
        Install appInstall = new Install();

        public HomeForm()
        {
            InitializeComponent();
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

            var softwares = appDownload.ListAvailableSoftwares();

            foreach (string software in softwares)
            {
                object[] row = new object[] { false, software, "0" + " MB" };
                dgvSoftwares.Rows.Add(row);
            }
        }

        private async void btnInstalar_Click(object sender, EventArgs e)
        {
            progressInstallation.Maximum = dgvSoftwares.RowCount;
            foreach (DataGridViewRow row in dgvSoftwares.Rows)
            {
                bool result = await appDownload.DownloadFileAsync(row.Cells[1].Value.ToString());

                    if (row.Cells[0].Value.ToString() == "True" && result == true)
                    {

                        lblStatus.Text = "Instalando " + row.Cells[1].Value.ToString() + "...";

                        await appInstall.InstallSoftwareAsync(row.Cells[1].Value.ToString());

                        lblStatus.Text = row.Cells[1].Value.ToString() + " instalado com sucesso!";
                    }

                lblStatus.Text = "Todos os softwares selecionados foram instalados com sucesso!";
                progressInstallation.Value += 1;
            }
        }
    }
}
