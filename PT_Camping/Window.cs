﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The windows form Window is the application's window.
    /// It handles UserControls which display the different screens of the app.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 06/08/17
    /// </summary>
    public partial class Window : Form
    {
        private ConnectionUserControl mConnectionUserControl;
        private HomeUserControl mHomeUserControl;

        public Window()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mConnectionUserControl = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUserControl);
        }


        internal void login()
        {
            mHomeUserControl = new HomeUserControl(this);
            windowPanel.Controls.Add(mHomeUserControl);
            windowPanel.Controls.Remove(mConnectionUserControl);
        }


        internal void logout()
        {
            mConnectionUserControl = new ConnectionUserControl(this);
            windowPanel.Controls.Add(mConnectionUserControl);
        }


        /// <summary>
        /// Properties (Getters & Setters)
        /// </summary>
        
        public Panel WindowPanel { get { return windowPanel; } set { windowPanel = value; } }
    }
}
