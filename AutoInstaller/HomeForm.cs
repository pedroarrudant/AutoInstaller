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
        readonly Download appDownload = new Download();
        readonly Install appInstall = new Install();

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

            dgvSoftwares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckSoftware_Event);

            var columnName = new DataGridViewColumn
            {
                HeaderText = "Software Name",
                Name = "columnName",
                CellTemplate = cell
            };

            dgvSoftwares.Columns.Add(chk);
            dgvSoftwares.Columns.Add(columnName);

            var softwares = appDownload.ListAvailableSoftwares();

            foreach (string software in softwares)
            {
                object[] row = new object[] { false, software };
                dgvSoftwares.Rows.Add(row);
            }
        }

        private void CheckSoftware_Event(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                if (dgvSoftwares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "False")
                {
                    dgvSoftwares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else
                {
                    dgvSoftwares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
            }
        }

        private async void btnInstalar_Click(object sender, EventArgs e)
        {
            progressInstallation.Maximum = dgvSoftwares.RowCount;
            foreach (DataGridViewRow row in dgvSoftwares.Rows)
            {
                if (row.Cells[0].Value.ToString() == "True")
                {
                    await appDownload.DownloadFileAsync(row.Cells[1].Value.ToString());

                    lblStatus.Text = "Instalando " + row.Cells[1].Value.ToString() + "...";

                    await appInstall.InstallSoftwareAsync(row.Cells[1].Value.ToString());

                    lblStatus.Text = row.Cells[1].Value.ToString() + " instalado com sucesso!";
                }
                progressInstallation.Value += 1;
            }
            lblStatus.Text = "Todos os softwares selecionados foram instalados com sucesso!";
        }
    }
}
