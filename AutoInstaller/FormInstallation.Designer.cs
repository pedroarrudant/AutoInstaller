namespace AutoInstaller
{
    partial class FormInstallation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProgressInstallation = new System.Windows.Forms.ProgressBar();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.dgvSoftwares = new System.Windows.Forms.DataGridView();
            this.LblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressInstallation
            // 
            this.ProgressInstallation.Location = new System.Drawing.Point(15, 392);
            this.ProgressInstallation.Name = "ProgressInstallation";
            this.ProgressInstallation.Size = new System.Drawing.Size(366, 23);
            this.ProgressInstallation.TabIndex = 3;
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.ButtonInstall.FlatAppearance.BorderSize = 0;
            this.ButtonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstall.ForeColor = System.Drawing.Color.White;
            this.ButtonInstall.Location = new System.Drawing.Point(195, 421);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(186, 56);
            this.ButtonInstall.TabIndex = 2;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.UseVisualStyleBackColor = false;
            // 
            // dgvSoftwares
            // 
            this.dgvSoftwares.AllowUserToAddRows = false;
            this.dgvSoftwares.AllowUserToDeleteRows = false;
            this.dgvSoftwares.AllowUserToResizeColumns = false;
            this.dgvSoftwares.AllowUserToResizeRows = false;
            this.dgvSoftwares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.dgvSoftwares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoftwares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSoftwares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoftwares.ColumnHeadersVisible = false;
            this.dgvSoftwares.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSoftwares.Location = new System.Drawing.Point(15, 12);
            this.dgvSoftwares.Name = "dgvSoftwares";
            this.dgvSoftwares.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.dgvSoftwares.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoftwares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSoftwares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoftwares.Size = new System.Drawing.Size(365, 358);
            this.dgvSoftwares.TabIndex = 4;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.ForeColor = System.Drawing.Color.Black;
            this.LblStatus.Location = new System.Drawing.Point(15, 373);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(74, 13);
            this.LblStatus.TabIndex = 5;
            this.LblStatus.Text = "Aguardando...";
            // 
            // FormInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(434, 489);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.dgvSoftwares);
            this.Controls.Add(this.ProgressInstallation);
            this.Controls.Add(this.ButtonInstall);
            this.Name = "FormInstallation";
            this.Text = "Installation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressInstallation;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.DataGridView dgvSoftwares;
        private System.Windows.Forms.Label LblStatus;
    }
}