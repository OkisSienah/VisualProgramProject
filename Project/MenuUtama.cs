using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    public partial class MenuUtama : Form
    {
        Config config = new Config();

        // Private Variable
        private string selectedUserID;
        private int priceTotal = 0;
        private bool dragging = false;
        private Point start_point = new Point(0, 0);
        private List<RPictureBox> menuMakanan = new List<RPictureBox>();

        public MenuUtama(string userID)
        {
            InitializeComponent();
            menuMakanan.Add(Onigiri1);
            menuMakanan.Add(Onigiri2);
            menuMakanan.Add(Onigiri3);
            menuMakanan.Add(Onigiri4);
            this.StartPosition = FormStartPosition.CenterScreen;
            selectedUserID = userID;
        }

        // Style Data Table
        void StyleDataTable()
        {
            historyOrder.BorderStyle = BorderStyle.Fixed3D;
            historyOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(102, 148, 204);
            historyOrder.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            historyOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            historyOrder.BackgroundColor = Color.FromArgb(108, 120, 119);

            historyOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            historyOrder.EnableHeadersVisualStyles = false;
            historyOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            historyOrder.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            historyOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            historyOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void StyleDataTable1()
        {
            viewOrder.BorderStyle = BorderStyle.Fixed3D;
            viewOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(102, 148, 204);
            viewOrder.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            viewOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            viewOrder.BackgroundColor = Color.FromArgb(108, 120, 119);

            viewOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            viewOrder.EnableHeadersVisualStyles = false;
            viewOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            viewOrder.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            viewOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            viewOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        // Taskbar
        private void btHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menuMakanan.Count; i++)
            {
                menuMakanan[i].BorderSize = 0;
            }
            selectedMenu.Text = "";
            quantityPicker.Value = 0;
            panelOrder.BringToFront();
            StyleDataTable1();
        }
        private void btHistory_Click(object sender, EventArgs e)
        {
            panelHistory.BringToFront();
            StyleDataTable();
            config.History(historyOrder, selectedUserID);
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Index login = new Index();
            this.Close();
            login.Show();
        }

        // History Page
        private void findTbox__TextChanged(object sender, EventArgs e)
        {
            config.HistoryFilter(historyOrder, findTbox);
        }

        // Order Page
        private void Onigiri1_Click(object sender, EventArgs e)
        {
            menuMakanan[0].BorderSize = 4;
            for(int i = 0; i < menuMakanan.Count; i++)
            {
                if (i != 0)
                {
                    menuMakanan[i].BorderSize = 0;
                }
            }
            selectedMenu.Text = Onigiri1.Texts;
        }

        private void Onigiri2_Click(object sender, EventArgs e)
        {
            menuMakanan[1].BorderSize = 4;
            for (int i = 0; i < menuMakanan.Count; i++)
            {
                if (i != 1)
                {
                    menuMakanan[i].BorderSize = 0;
                }
            }
            selectedMenu.Text = Onigiri2.Texts;
        }

        private void Onigiri3_Click(object sender, EventArgs e)
        {
            menuMakanan[2].BorderSize = 4;
            for (int i = 0; i < menuMakanan.Count; i++)
            {
                if (i != 2)
                {
                    menuMakanan[i].BorderSize = 0;
                }
            }
            selectedMenu.Text = Onigiri3.Texts;
        }

        private void Onigiri4_Click(object sender, EventArgs e)
        {
            menuMakanan[3].BorderSize = 4;
            for (int i = 0; i < menuMakanan.Count; i++)
            {
                if (i != 3)
                {
                    menuMakanan[i].BorderSize = 0;
                }
            }
            selectedMenu.Text = Onigiri4.Texts;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int quantity = ((int)quantityPicker.Value);
            config.AddingMenu(viewOrder, selectedMenu.Text, Onigiri1, Onigiri2, Onigiri3, Onigiri4, (int)quantityPicker.Value, priceTotal, totalPrice);
        }

        private void btPlaceOrder_Click(object sender, EventArgs e)
        {
            config.OrderMenu(viewOrder, selectedUserID);

            selectedMenu.Text = "";
            quantityPicker.Value = 0;
            totalPrice.Text = "Total Price: 0";
            viewOrder.Rows.Clear();
            viewOrder.Refresh();
        }

        private void viewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == viewOrder.Columns["delBtn"].Index && e.RowIndex >= 0)
            {
                priceTotal -= Convert.ToInt32(viewOrder.Rows[e.RowIndex].Cells[4].Value);
                viewOrder.Rows.RemoveAt(e.RowIndex);
            }

            totalPrice.Text = "Total Price: " + priceTotal.ToString();
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
    }
}
