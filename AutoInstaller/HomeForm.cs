using System;
using System.Windows.Forms;
using AI.Application;
using AI.Infrastructure;

namespace AutoInstaller
{
    public partial class HomeForm : Form
    {
        private readonly IFileDownload _fileDownload;
        private readonly IFileOperations _fileOperations;
        private Download _appDownload;
        private Install _appInstall;

        public HomeForm(IFileDownload FileDownload, IFileOperations FileOperations)
        {
            InitializeComponent();
            _fileOperations = FileOperations;
            _fileDownload = FileDownload;
            _appDownload = new Download(_fileDownload, _fileOperations);
            _appInstall = new Install(_fileOperations);

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
                HeaderText = "Software",
                Name = "columnName",
                CellTemplate = cell
            };

            dgvSoftwares.Columns.Add(chk);
            dgvSoftwares.Columns.Add(columnName);

            var softwares = _appDownload.ListAvailableSoftwares();

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
                    await _appDownload.DownloadFileAsync(row.Cells[1].Value.ToString());

                    lblStatus.Text = "Instalando " + row.Cells[1].Value.ToString() + "...";

                    await _appInstall.InstallSoftwareAsync(row.Cells[1].Value.ToString());

                    lblStatus.Text = row.Cells[1].Value.ToString() + " instalado com sucesso!";
                }
                progressInstallation.Value += 1;
            }
            lblStatus.Text = "Todos os softwares selecionados foram instalados com sucesso!";
        }
    }
}
