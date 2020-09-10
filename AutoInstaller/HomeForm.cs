using System;
using System.Drawing;
using System.Windows.Forms;
using AI.Application;
using AI.Infrastructure;
using FontAwesome.Sharp;

namespace AutoInstaller
{
    public partial class HomeForm : Form
    {
        private readonly IFileDownload _fileDownload;
        private readonly IFileOperations _fileOperations;
        private Download _appDownload;
        private Install _appInstall;
        private IconButton currentButton;
        private Panel leftOrderButton;
        private Form CurrentChildForm;

        public HomeForm(IFileDownload FileDownload, IFileOperations FileOperations)
        {
            InitializeComponent();
            _fileOperations = FileOperations;
            _fileDownload = FileDownload;
            _appDownload = new Download(_fileDownload, _fileOperations);
            _appInstall = new Install(_fileOperations);

            leftOrderButton = new Panel();
            leftOrderButton.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftOrderButton);

            //PopulateDataGridView();
            Reset();
        }

        //Se precisar chamar alguma cor usando o espectro RGB
        public struct RGBColors 
        {
            public static Color White = Color.FromArgb(255,255,255);
        }

        private void ActivateButton(object SenderButton, Color Color)
        {
            if (SenderButton != null)
            {
                DisabelButton();

                currentButton = (IconButton)SenderButton;
                currentButton.BackColor = Color.FromArgb(37, 20, 37);
                currentButton.ForeColor = Color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftOrderButton.BackColor = Color;
                leftOrderButton.Location = new Point(0, currentButton.Location.Y);
                leftOrderButton.Visible = true;
                leftOrderButton.BringToFront();

                TitlePanelPictureBox.IconChar = currentButton.IconChar;
                TitlePanelPictureBox.IconColor = currentButton.IconColor;
                LblTitlePanel.Text = currentButton.Text;
            }
        }

        private void DisabelButton() 
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Indigo;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //private void PopulateDataGridView()
        //{
        //    DataGridViewCell cell = new DataGridViewTextBoxCell();

        //    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
        //    {
        //        HeaderText = "Install",
        //        Name = "chkinstall"
        //    };

        //    dgvSoftwares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckSoftware_Event);

        //    var columnName = new DataGridViewColumn
        //    {
        //        HeaderText = "Software",
        //        Name = "columnName",
        //        CellTemplate = cell
        //    };

        //    dgvSoftwares.Columns.Add(chk);
        //    dgvSoftwares.Columns.Add(columnName);

        //    var softwares = _appDownload.ListAvailableSoftwares();

        //    foreach (string software in softwares)
        //    {
        //        object[] row = new object[] { false, software };
        //        dgvSoftwares.Rows.Add(row);
        //    }
        //}

        //private void CheckSoftware_Event(object sender, DataGridViewCellEventArgs e) 
        //{
        //    if (e.RowIndex < 0 || e.ColumnIndex < 0)
        //    {
        //        return;
        //    }

        //    if (e.ColumnIndex == 0)
        //    {
        //        if (dgvSoftwares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "False")
        //        {
        //            dgvSoftwares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
        //        }
        //        else
        //        {
        //            dgvSoftwares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
        //        }
        //    }
        //}

        //private async void btnInstalar_Click(object sender, EventArgs e)
        //{
        //    progressInstallation.Maximum = dgvSoftwares.RowCount;
        //    foreach (DataGridViewRow row in dgvSoftwares.Rows)
        //    {
        //        if (row.Cells[0].Value.ToString() == "True")
        //        {
        //            await _appDownload.DownloadFileAsync(row.Cells[1].Value.ToString());

        //            lblStatus.Text = "Instalando " + row.Cells[1].Value.ToString() + "...";

        //            await _appInstall.InstallSoftwareAsync(row.Cells[1].Value.ToString());

        //            lblStatus.Text = row.Cells[1].Value.ToString() + " instalado com sucesso!";
        //        }
        //        progressInstallation.Value += 1;
        //    }
        //    lblStatus.Text = "Todos os softwares selecionados foram instalados com sucesso!";
        //}

        private void BtnInstallation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormInstallation(_fileDownload, _fileOperations));
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormConfiguration());
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormAbout());
        }

        private void Reset()
        {
            DisabelButton();
            leftOrderButton.Visible = false;
            TitlePanelPictureBox.IconChar = IconChar.Desktop;
            TitlePanelPictureBox.IconColor = Color.White;
            LblTitlePanel.Text = "Installation";
        }

        private void OpenChildForm(Form ChildForm) 
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ChildForm);
            PanelContainer.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            LblTitlePanel.Text = ChildForm.Text;

        }
    }
}
