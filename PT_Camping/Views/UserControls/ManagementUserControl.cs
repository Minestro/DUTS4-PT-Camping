﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The ManagementUserControl is a UserControl handling the application's management process.
    /// It is designed to be derived by each management process.
    /// It provides a common AppBar for each management process with a back button to return to home,
    /// a title and a logout button.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class ManagementUserControl : UserControl
    {
        protected DataBase Db;
        protected List<Droit> UserRights;

        public ManagementUserControl()
        {
            InitializeComponent();
            logoutButton.FlatAppearance.BorderSize = 0;
        }

        public ManagementUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            HomeUserControl = homeUserControl;
            Db = new DataBase();
            UserRights = Db.Personne.First(
                    a => a.Code_Personne == LoginTools.Employee.Personne.Code_Personne).Droit.ToList();
            if (LoginTools.Employee != null)
            {
                userNameButton.Text = Resources.hello_user 
                    + LoginTools.Employee.Personne.Prenom_Personne 
                    + Resources.one_space + LoginTools.Employee.Personne.Nom_Personne;
            }
        }

        private void BackArrow_Click(object sender, EventArgs e)
        {
            HomeUserControl.InitPermissions();
            HomeUserControl.Window.WindowPanel.Controls.Add(HomeUserControl);
            HomeUserControl.Window.WindowPanel.Controls.Remove(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            HomeUserControl.Window.Logout();
            HomeUserControl.Window.WindowPanel.Controls.Remove(this);
        }

        private void UserNameButton_Click(object sender, EventArgs e)
        {
            HomeUserControl.StartEmployeesFromTitleBar(this);
        }

        internal void HandleResize()
        {
            Size = HomeUserControl.Size;
            appBar.Size = new Size(HomeUserControl.Size.Width, appBar.Size.Height);
        }


        public HomeUserControl HomeUserControl { get; set; }
    }
}
