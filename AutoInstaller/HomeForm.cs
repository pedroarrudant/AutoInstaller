﻿using System;
using System.Drawing;
using System.Windows.Forms;
using AI.Application;
using FontAwesome.Sharp;
using AI.Infrastructure.IoC;

namespace AutoInstaller
{
    public partial class HomeForm : Form
    {
        private IconButton currentButton;
        private Panel leftOrderButton;
        private Form CurrentChildForm;
        private IInfrastructureFactory _InfraFactory;



        public HomeForm()
        {
            InitializeComponent();

            leftOrderButton = new Panel();
            leftOrderButton.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftOrderButton);

            _InfraFactory = new InfrastructureFactory();

            Reset();
        }

        public struct RGBColors 
        {
            public static Color ButtonSelected = Color.FromArgb(57, 40, 57);
            public static Color Button = Color.FromArgb(37, 20, 37);

        }

        private void ActivateButton(object SenderButton, Color Color)
        {
            if (SenderButton != null)
            {
                DisabelButton();

                currentButton = (IconButton)SenderButton;
                currentButton.BackColor = RGBColors.ButtonSelected;
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
                currentButton.BackColor = RGBColors.Button;
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void BtnInstallation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenChildForm(new FormInstallation());
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

            ActivateButton(BtnInstallation, Color.White);
            OpenChildForm(new FormInstallation());
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
