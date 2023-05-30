using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace Project
{
    internal class Config
    {
        private static string connectionString = "Server=localhost;database=tabenori;uid=root;Pwd=;";
        private static MySqlConnection con = new MySqlConnection(connectionString);

        /*SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True;Pooling=False");*/
        DataTable dt = new DataTable();

        public MySqlConnection GetConnection() {
            return con;
        }

        // ==== Reading User Table ====
        public ArrayList ReadUser()
        {
            con.Open();
            string query = "SELECT * FROM user;";
            var cmd = new MySqlCommand(query, con);
            var reader = cmd.ExecuteReader();

            ArrayList data = new ArrayList();
            if (!reader.HasRows)
            {
                reader.Close();
                string query2 = "set foreign_key_checks = 0; truncate user; set foreign_key_checks = 1";
                var cmd2 = new MySqlCommand(query2, con);
                var reader2 = cmd2.ExecuteReader();
                reader2.Close();
            }
            con.Close();
            return data;
        }

        // Add User and Validating
        public void AddValidateUser(User user)
        {
            con.Open();
            string query1 = "SELECT * FROM user where username = '" + user.username + "'";
            var cmd = new MySqlCommand(query1, con);
            var reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                reader.Close();
                MessageBox.Show("Username is already exists!");
            }
            else
            {
                MessageBox.Show("Username is available!");
                reader.Close();
                MySqlCommand query = new MySqlCommand("insert into user(fullname, bdate, address, username, password) values(@fullname, @bdate, @address, @username, @password);", con);

                query.Parameters.AddWithValue("@fullname", user.fullname);
                query.Parameters.AddWithValue("@bdate", user.bdate);
                query.Parameters.AddWithValue("@address", user.address);
                query.Parameters.AddWithValue("@username", user.username);
                query.Parameters.AddWithValue("@password", user.password);
                query.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            con.Close();
        }

        // User Login
        public void LoginUser(string username, string password, Index index)
        {
            con.Open();
            MySqlCommand query = new MySqlCommand("SELECT * FROM user where username = '" + username + "' and password = '" + password + "' ", con);
            MySqlDataReader dr = query.ExecuteReader();
            if (username != string.Empty || password != string.Empty)
            {
                if (dr.Read())
                {
                    string userID = dr["userid"].ToString();
                    MessageBox.Show("Hello, " + dr["fullname"] + "!");
                    
                    MenuUtama menu = new MenuUtama(userID);
                    menu.Show();
                    index.Hide();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No accounts detected in the application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all available fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        // ==== Main Menu Page ====

        public void History(DataGridView historyOrder, string selectedUserID)
        {
            con.Open();
            MySqlCommand query = new MySqlCommand("select * from history where user_id = '" + selectedUserID + "'", con);
            dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dt);
            con.Close();
            historyOrder.DataSource = dt;
        }

        public void HistoryFilter(DataGridView historyOrder, RTbox findTbox)
        {
            if (dt != null)
            {
                DataView filter = new DataView(dt);
                int filterNomor = 0;
                try
                {
                    filterNomor = Int32.Parse(findTbox.Texts);
                }
                catch (Exception)
                {

                }
                filter.RowFilter = "nama_makanan like '%" + findTbox.Texts + "%' OR no_makanan = " + filterNomor;
                historyOrder.DataSource = filter;
            }
        }

        public void AddingMenu(DataGridView viewOrder, string selectedMenu, RPictureBox onigiri1, RPictureBox onigiri2, RPictureBox onigiri3, RPictureBox onigiri4, int quantity, int priceTotal, Label totalPrice)
        {
            con.Open();
            if (selectedMenu == onigiri1.Texts)
            {
                MySqlCommand query1 = new MySqlCommand("SELECT * FROM daftarmenu WHERE nama_makanan = '" + selectedMenu + "'", con);
                DbDataReader dr = query1.ExecuteReader();
                if (dr.Read())
                {
                    viewOrder.Rows.Add(dr["no_makanan"].ToString(), selectedMenu, quantity, dr["harga"].ToString(), ((int)quantity) * ((int)dr["harga"]));
                }
                dr.Close();

                priceTotal = 0;
                for (int i = 0; i < viewOrder.Rows.Count; i++)
                {
                    priceTotal += Convert.ToInt32(viewOrder.Rows[i].Cells[4].Value);
                }

                totalPrice.Text = "Total Price: " + priceTotal.ToString();
            }
            else if (selectedMenu == onigiri2.Texts)
            {
                MySqlCommand query1 = new MySqlCommand("SELECT * FROM daftarmenu WHERE nama_makanan = '" + selectedMenu + "'", con);
                DbDataReader dr = query1.ExecuteReader();
                if (dr.Read())
                {
                    viewOrder.Rows.Add(dr["no_makanan"].ToString(), selectedMenu, quantity, dr["harga"].ToString(), ((int)quantity) * ((int)dr["harga"]));
                }
                dr.Close();

                priceTotal = 0;
                for (int i = 0; i < viewOrder.Rows.Count; i++)
                {
                    priceTotal += Convert.ToInt32(viewOrder.Rows[i].Cells[4].Value);
                }

                totalPrice.Text = "Total Price: " + priceTotal.ToString();
            }
            else if (selectedMenu == onigiri3.Texts)
            {
                MySqlCommand query1 = new MySqlCommand("SELECT * FROM daftarmenu WHERE nama_makanan = '" + selectedMenu + "'", con);
                DbDataReader dr = query1.ExecuteReader();
                if (dr.Read())
                {
                    viewOrder.Rows.Add(dr["no_makanan"].ToString(), selectedMenu, quantity, dr["harga"].ToString(), ((int)quantity) * ((int)dr["harga"]));
                }
                dr.Close();

                priceTotal = 0;
                for (int i = 0; i < viewOrder.Rows.Count; i++)
                {
                    priceTotal += Convert.ToInt32(viewOrder.Rows[i].Cells[4].Value);
                }

                totalPrice.Text = "Total Price: " + priceTotal.ToString();
            }
            else if (selectedMenu == onigiri4.Texts)
            {
                MySqlCommand query1 = new MySqlCommand("SELECT * FROM daftarmenu WHERE nama_makanan = '" + selectedMenu + "'", con);
                DbDataReader dr = query1.ExecuteReader();
                if (dr.Read())
                {
                    viewOrder.Rows.Add(dr["no_makanan"].ToString(), selectedMenu, quantity, dr["harga"].ToString(), ((int)quantity) * ((int)dr["harga"]));
                }
                dr.Close();
            }
            con.Close();

            priceTotal = 0;
            for (int i = 0; i < viewOrder.Rows.Count; i++)
            {
                priceTotal += Convert.ToInt32(viewOrder.Rows[i].Cells[4].Value);
            }

            totalPrice.Text = "Total Price: " + priceTotal.ToString();
        }

        public void OrderMenu(DataGridView viewOrder, string selectedUserID)
        {
            con.Open();

            DateTime ts = DateTime.Now;

            for (int i = 0; i < viewOrder.Rows.Count; i++)
            {
                MySqlCommand query = new MySqlCommand("INSERT INTO history(no_makanan, user_id, nama_makanan, jumlah, harga, total, waktu) VALUES (@no_makanan, @user_id, @nama_makanan, @jumlah, @harga, @total, @waktu)", con);

                query.Parameters.Add("@no_makanan", MySqlDbType.Int32).Value = viewOrder.Rows[i].Cells[0].Value;
                query.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Int32.Parse(selectedUserID);
                query.Parameters.Add("@nama_makanan", MySqlDbType.VarChar).Value = viewOrder.Rows[i].Cells[1].Value;
                query.Parameters.Add("@jumlah", MySqlDbType.Int32).Value = viewOrder.Rows[i].Cells[2].Value;
                query.Parameters.Add("@harga", MySqlDbType.Int32).Value = viewOrder.Rows[i].Cells[3].Value;
                query.Parameters.Add("@total", MySqlDbType.Int32).Value = viewOrder.Rows[i].Cells[4].Value;
                query.Parameters.Add("waktu", MySqlDbType.Timestamp).Value = ts;

                query.ExecuteNonQuery();

            }
            if(viewOrder.Rows.Count == 0)
            {
                MessageBox.Show("Please Add The Order!");
            }
            else
            {
                MessageBox.Show("Check Out Successfully!");
            }

            con.Close();
        }
    }
}
