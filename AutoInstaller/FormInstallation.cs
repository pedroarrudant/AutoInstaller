﻿using AI.Application;
using AI.Infrastructure.IoC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace AutoInstaller
{
    public partial class FormInstallation : Form
    {
        private IDownload _appDownload;
        private IInstall _appInstall;

        public FormInstallation()
        {
            InitializeComponent();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IInfrastructureFactory, InfrastructureFactory>();

            _appDownload = container.Resolve<Download>();
            _appInstall = container.Resolve<Install>();

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
                CellTemplate = cell,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            dgvSoftwares.Columns.Add(chk);
            dgvSoftwares.Columns.Add(columnName);

            var softwares = _appDownload.ListAvailableSoftwares();

            foreach (string software in softwares)
            {
                object[] row = new object[] { false, software };
                dgvSoftwares.Rows.Add(row);
            }

            ButtonInstall.Enabled = false;
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

            ValidateCheckedDgv(dgvSoftwares);
        }

        private async void btnInstalar_Click(object sender, EventArgs e)
        {
            ProgressInstallation.Maximum = dgvSoftwares.RowCount;
            foreach (DataGridViewRow row in dgvSoftwares.Rows)
            {
                if (row.Cells[0].Value.ToString() == "True")
                {
                    //await _appDownload.DownloadFileAsync(row.Cells[1].Value.ToString());

                    LblStatus.Text = "Instalando " + row.Cells[1].Value.ToString() + "...";

                    IUnityContainer container = new UnityContainer();
                    container.RegisterType<IInfrastructureFactory, InfrastructureFactory>();

                    var logic = container.Resolve<Download>();

                    await logic.DownloadFileAsync(row.Cells[1].Value.ToString());

                    await _appInstall.InstallSoftwareAsync(row.Cells[1].Value.ToString());

                    LblStatus.Text = row.Cells[1].Value.ToString() + " instalado com sucesso!";
                }
                ProgressInstallation.Value += 1;
            }
            LblStatus.Text = "Todos os softwares selecionados foram instalados com sucesso!";
        }

        private void ValidateCheckedDgv(DataGridView dataGridView)
        {
            bool IsAnythingActive = false;
            foreach (DataGridViewRow row in dgvSoftwares.Rows)
            {
                if (row.Cells[0].Value.ToString() == "True")
                {
                    IsAnythingActive = true;
                    break;
                }
            }

            if (IsAnythingActive)
            {
                ButtonInstall.Enabled = true;
            }
            else
            {
                ButtonInstall.Enabled = false;
            }
        }

    }
}
