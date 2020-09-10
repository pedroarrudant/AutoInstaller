namespace AutoInstaller
{
    partial class HomeForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnAbout = new FontAwesome.Sharp.IconButton();
            this.BtnConfiguration = new FontAwesome.Sharp.IconButton();
            this.BtnInstallation = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitlePanel = new System.Windows.Forms.Label();
            this.TitlePanelPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePanelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.PanelMenu.Controls.Add(this.BtnAbout);
            this.PanelMenu.Controls.Add(this.BtnConfiguration);
            this.PanelMenu.Controls.Add(this.BtnInstallation);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 596);
            this.PanelMenu.TabIndex = 7;
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.BtnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAbout.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.BtnAbout.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAbout.IconSize = 32;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Location = new System.Drawing.Point(0, 230);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAbout.Rotation = 0D;
            this.BtnAbout.Size = new System.Drawing.Size(200, 60);
            this.BtnAbout.TabIndex = 3;
            this.BtnAbout.Text = "About";
            this.BtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnConfiguration
            // 
            this.BtnConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.BtnConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguration.FlatAppearance.BorderSize = 0;
            this.BtnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguration.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguration.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguration.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.BtnConfiguration.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguration.IconSize = 32;
            this.BtnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguration.Location = new System.Drawing.Point(0, 170);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnConfiguration.Rotation = 0D;
            this.BtnConfiguration.Size = new System.Drawing.Size(200, 60);
            this.BtnConfiguration.TabIndex = 2;
            this.BtnConfiguration.Text = "Configuration";
            this.BtnConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguration.UseVisualStyleBackColor = false;
            this.BtnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            // 
            // BtnInstallation
            // 
            this.BtnInstallation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.BtnInstallation.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInstallation.FlatAppearance.BorderSize = 0;
            this.BtnInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstallation.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstallation.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnInstallation.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.BtnInstallation.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnInstallation.IconSize = 32;
            this.BtnInstallation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInstallation.Location = new System.Drawing.Point(0, 110);
            this.BtnInstallation.Name = "BtnInstallation";
            this.BtnInstallation.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInstallation.Rotation = 0D;
            this.BtnInstallation.Size = new System.Drawing.Size(200, 60);
            this.BtnInstallation.TabIndex = 1;
            this.BtnInstallation.Text = "Installation";
            this.BtnInstallation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInstallation.UseVisualStyleBackColor = false;
            this.BtnInstallation.Click += new System.EventHandler(this.BtnInstallation_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 110);
            this.PanelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.LblTitlePanel);
            this.panel1.Controls.Add(this.TitlePanelPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 110);
            this.panel1.TabIndex = 8;
            // 
            // LblTitlePanel
            // 
            this.LblTitlePanel.AutoSize = true;
            this.LblTitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlePanel.ForeColor = System.Drawing.Color.White;
            this.LblTitlePanel.Location = new System.Drawing.Point(118, 40);
            this.LblTitlePanel.Name = "LblTitlePanel";
            this.LblTitlePanel.Size = new System.Drawing.Size(145, 31);
            this.LblTitlePanel.TabIndex = 1;
            this.LblTitlePanel.Text = "Installation";
            // 
            // TitlePanelPictureBox
            // 
            this.TitlePanelPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.TitlePanelPictureBox.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.TitlePanelPictureBox.IconColor = System.Drawing.Color.White;
            this.TitlePanelPictureBox.IconSize = 82;
            this.TitlePanelPictureBox.Location = new System.Drawing.Point(6, 12);
            this.TitlePanelPictureBox.Name = "TitlePanelPictureBox";
            this.TitlePanelPictureBox.Size = new System.Drawing.Size(106, 82);
            this.TitlePanelPictureBox.TabIndex = 0;
            this.TitlePanelPictureBox.TabStop = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.Lavender;
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(200, 110);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(589, 486);
            this.PanelContainer.TabIndex = 9;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(789, 596);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Auto Installer";
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePanelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton BtnAbout;
        private FontAwesome.Sharp.IconButton BtnConfiguration;
        private FontAwesome.Sharp.IconButton BtnInstallation;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox TitlePanelPictureBox;
        private System.Windows.Forms.Label LblTitlePanel;
        private System.Windows.Forms.Panel PanelContainer;
    }
}

