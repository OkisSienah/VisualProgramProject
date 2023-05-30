using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Index : Form
    {
        static Config config = new Config();

        // Variable
        public string userID;
        private bool dragging = false;
        private Point start_point = new Point(0, 0);

        public Index()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Login Page
        private void btLogin_Click(object sender, EventArgs e)
        {
            config.LoginUser(tbUser.Texts, tbPass.Texts, this);
        }

        private void createAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegister.BringToFront();
            tbUser.Texts = "";
            tbPass.Texts = "";
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            var window = MessageBox.Show(
            "                   Are you sure?", "",
            MessageBoxButtons.YesNo);
            if (window == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Register Page
        private void btRegister_Click(object sender, EventArgs e)
        {
            var userLog = new User(tbName.Texts, bDate.Value, tbAddress.Texts, tbUsername.Texts, tbPassword.Texts);
            if (tbName.Texts == string.Empty || tbAddress.Texts == string.Empty || tbUsername.Texts == string.Empty || tbPassword.Texts == string.Empty)
            {
                MessageBox.Show("Please fill in all available fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                config.ReadUser();
                config.AddValidateUser(userLog);

                tbName.Texts = "";
                tbAddress.Texts = "";
                tbUsername.Texts = "";
                tbPassword.Texts = "";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
            tbName.Texts = "";
            tbAddress.Texts = "";
            tbUsername.Texts = "";
            tbPassword.Texts = "";
        }

        // Draggable Page
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void creditsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelCredits.BringToFront();
        }
    }
}
