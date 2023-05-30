namespace Project
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.panelHome = new System.Windows.Forms.Panel();
            this.btLogOut = new Project.RButton();
            this.btHistory = new Project.RButton();
            this.btOrder = new Project.RButton();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btHome = new Project.RButton();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.labelRecord = new System.Windows.Forms.Label();
            this.findTbox = new Project.RTbox();
            this.historyOrder = new System.Windows.Forms.DataGridView();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.selectedMenu = new System.Windows.Forms.Label();
            this.quantityPicker = new System.Windows.Forms.NumericUpDown();
            this.labelMenu = new System.Windows.Forms.Label();
            this.btPlaceOrder = new Project.RButton();
            this.btAdd = new Project.RButton();
            this.totalPrice = new System.Windows.Forms.Label();
            this.quantityMenu = new System.Windows.Forms.Label();
            this.viewOrder = new System.Windows.Forms.DataGridView();
            this.foodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Onigiri4 = new Project.RPictureBox();
            this.Onigiri3 = new Project.RPictureBox();
            this.Onigiri2 = new Project.RPictureBox();
            this.Onigiri1 = new Project.RPictureBox();
            this.panelNavigation.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyOrder)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.BackgroundImage = global::Project.Properties.Resources.logo_2;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(800, 393);
            this.panelHome.TabIndex = 3;
            this.panelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // btLogOut
            // 
            this.btLogOut.BackColor = System.Drawing.Color.LightCoral;
            this.btLogOut.BorderColor = System.Drawing.Color.Black;
            this.btLogOut.BorderRadius = 15;
            this.btLogOut.BorderSize = 1;
            this.btLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogOut.FlatAppearance.BorderSize = 0;
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLogOut.Location = new System.Drawing.Point(638, 8);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(150, 40);
            this.btLogOut.TabIndex = 2;
            this.btLogOut.Text = "Log Out";
            this.btLogOut.UseVisualStyleBackColor = false;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // btHistory
            // 
            this.btHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btHistory.BorderColor = System.Drawing.Color.Black;
            this.btHistory.BorderRadius = 15;
            this.btHistory.BorderSize = 1;
            this.btHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHistory.FlatAppearance.BorderSize = 0;
            this.btHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHistory.Location = new System.Drawing.Point(389, 8);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(150, 40);
            this.btHistory.TabIndex = 1;
            this.btHistory.Text = "History";
            this.btHistory.UseVisualStyleBackColor = false;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.Coral;
            this.btOrder.BorderColor = System.Drawing.Color.Black;
            this.btOrder.BorderRadius = 15;
            this.btOrder.BorderSize = 1;
            this.btOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrder.FlatAppearance.BorderSize = 0;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btOrder.Location = new System.Drawing.Point(127, 8);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(150, 40);
            this.btOrder.TabIndex = 0;
            this.btOrder.Text = "Order Now";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.btHome);
            this.panelNavigation.Controls.Add(this.btHistory);
            this.panelNavigation.Controls.Add(this.btLogOut);
            this.panelNavigation.Controls.Add(this.btOrder);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(0, 390);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 60);
            this.panelNavigation.TabIndex = 4;
            this.panelNavigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelNavigation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelNavigation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // btHome
            // 
            this.btHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btHome.BackgroundImage")));
            this.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHome.BorderColor = System.Drawing.Color.Black;
            this.btHome.BorderRadius = 0;
            this.btHome.BorderSize = 0;
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Location = new System.Drawing.Point(12, 9);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(66, 40);
            this.btHome.TabIndex = 3;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.White;
            this.panelHistory.Controls.Add(this.labelRecord);
            this.panelHistory.Controls.Add(this.findTbox);
            this.panelHistory.Controls.Add(this.historyOrder);
            this.panelHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(800, 393);
            this.panelHistory.TabIndex = 0;
            this.panelHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelHistory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelHistory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecord.Location = new System.Drawing.Point(538, 65);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(0, 16);
            this.labelRecord.TabIndex = 3;
            // 
            // findTbox
            // 
            this.findTbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.findTbox.BorderColor = System.Drawing.Color.Black;
            this.findTbox.BorderFocusColor = System.Drawing.Color.Black;
            this.findTbox.BorderRadius = 8;
            this.findTbox.BorderSize = 1;
            this.findTbox.Location = new System.Drawing.Point(538, 20);
            this.findTbox.Margin = new System.Windows.Forms.Padding(0);
            this.findTbox.Multiline = false;
            this.findTbox.Name = "findTbox";
            this.findTbox.Padding = new System.Windows.Forms.Padding(7);
            this.findTbox.PasswordChar = false;
            this.findTbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.findTbox.PlaceHolderText = "Search Here...";
            this.findTbox.Size = new System.Drawing.Size(250, 30);
            this.findTbox.TabIndex = 2;
            this.findTbox.Texts = "";
            this.findTbox.UnderlinedStyle = false;
            this.findTbox._TextChanged += new System.EventHandler(this.findTbox__TextChanged);
            // 
            // historyOrder
            // 
            this.historyOrder.AllowUserToAddRows = false;
            this.historyOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyOrder.GridColor = System.Drawing.SystemColors.ControlText;
            this.historyOrder.Location = new System.Drawing.Point(1, 84);
            this.historyOrder.Name = "historyOrder";
            this.historyOrder.ReadOnly = true;
            this.historyOrder.RowTemplate.Height = 25;
            this.historyOrder.Size = new System.Drawing.Size(798, 306);
            this.historyOrder.TabIndex = 0;
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.White;
            this.panelOrder.Controls.Add(this.selectedMenu);
            this.panelOrder.Controls.Add(this.quantityPicker);
            this.panelOrder.Controls.Add(this.labelMenu);
            this.panelOrder.Controls.Add(this.btPlaceOrder);
            this.panelOrder.Controls.Add(this.btAdd);
            this.panelOrder.Controls.Add(this.totalPrice);
            this.panelOrder.Controls.Add(this.quantityMenu);
            this.panelOrder.Controls.Add(this.viewOrder);
            this.panelOrder.Controls.Add(this.Onigiri4);
            this.panelOrder.Controls.Add(this.Onigiri3);
            this.panelOrder.Controls.Add(this.Onigiri2);
            this.panelOrder.Controls.Add(this.Onigiri1);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(800, 390);
            this.panelOrder.TabIndex = 4;
            this.panelOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // selectedMenu
            // 
            this.selectedMenu.AutoSize = true;
            this.selectedMenu.Location = new System.Drawing.Point(687, 9);
            this.selectedMenu.Name = "selectedMenu";
            this.selectedMenu.Size = new System.Drawing.Size(0, 15);
            this.selectedMenu.TabIndex = 11;
            // 
            // quantityPicker
            // 
            this.quantityPicker.Location = new System.Drawing.Point(698, 35);
            this.quantityPicker.Name = "quantityPicker";
            this.quantityPicker.Size = new System.Drawing.Size(90, 23);
            this.quantityPicker.TabIndex = 10;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(629, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(54, 15);
            this.labelMenu.TabIndex = 9;
            this.labelMenu.Text = "Selected:";
            // 
            // btPlaceOrder
            // 
            this.btPlaceOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.btPlaceOrder.BorderColor = System.Drawing.Color.Black;
            this.btPlaceOrder.BorderRadius = 10;
            this.btPlaceOrder.BorderSize = 1;
            this.btPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlaceOrder.Location = new System.Drawing.Point(629, 127);
            this.btPlaceOrder.Name = "btPlaceOrder";
            this.btPlaceOrder.Size = new System.Drawing.Size(159, 29);
            this.btPlaceOrder.TabIndex = 8;
            this.btPlaceOrder.Text = "Place Order";
            this.btPlaceOrder.UseVisualStyleBackColor = false;
            this.btPlaceOrder.Click += new System.EventHandler(this.btPlaceOrder_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.btAdd.BorderColor = System.Drawing.Color.Black;
            this.btAdd.BorderRadius = 10;
            this.btAdd.BorderSize = 1;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(629, 92);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(159, 29);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(629, 66);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(73, 15);
            this.totalPrice.TabIndex = 6;
            this.totalPrice.Text = "Total Price: 0";
            // 
            // quantityMenu
            // 
            this.quantityMenu.AutoSize = true;
            this.quantityMenu.Location = new System.Drawing.Point(629, 37);
            this.quantityMenu.Name = "quantityMenu";
            this.quantityMenu.Size = new System.Drawing.Size(56, 15);
            this.quantityMenu.TabIndex = 5;
            this.quantityMenu.Text = "Quantity:";
            // 
            // viewOrder
            // 
            this.viewOrder.AllowUserToAddRows = false;
            this.viewOrder.AllowUserToOrderColumns = true;
            this.viewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodID,
            this.menuName,
            this.quantity,
            this.price,
            this.total,
            this.delBtn});
            this.viewOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewOrder.Location = new System.Drawing.Point(0, 162);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.RowTemplate.Height = 25;
            this.viewOrder.Size = new System.Drawing.Size(800, 228);
            this.viewOrder.TabIndex = 4;
            this.viewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewOrder_CellContentClick);
            // 
            // foodID
            // 
            this.foodID.HeaderText = "Food ID";
            this.foodID.Name = "foodID";
            // 
            // menuName
            // 
            this.menuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuName.HeaderText = "Menu Name";
            this.menuName.Name = "menuName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // delBtn
            // 
            this.delBtn.HeaderText = "Delete";
            this.delBtn.Name = "delBtn";
            this.delBtn.Text = "Delete";
            this.delBtn.UseColumnTextForButtonValue = true;
            // 
            // Onigiri4
            // 
            this.Onigiri4.BackgroundImage = global::Project.Properties.Resources.Rendang;
            this.Onigiri4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Onigiri4.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.Onigiri4.BorderColor = System.Drawing.Color.DarkViolet;
            this.Onigiri4.BorderColor2 = System.Drawing.Color.HotPink;
            this.Onigiri4.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Onigiri4.BorderSize = 0;
            this.Onigiri4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Onigiri4.GradientAngle = 30F;
            this.Onigiri4.Location = new System.Drawing.Point(464, 12);
            this.Onigiri4.Name = "Onigiri4";
            this.Onigiri4.Size = new System.Drawing.Size(132, 132);
            this.Onigiri4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Onigiri4.TabIndex = 3;
            this.Onigiri4.TabStop = false;
            this.Onigiri4.Texts = "Onigiri Rendang";
            this.Onigiri4.Click += new System.EventHandler(this.Onigiri4_Click);
            // 
            // Onigiri3
            // 
            this.Onigiri3.BackgroundImage = global::Project.Properties.Resources.TunaMayo;
            this.Onigiri3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Onigiri3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.Onigiri3.BorderColor = System.Drawing.Color.DarkViolet;
            this.Onigiri3.BorderColor2 = System.Drawing.Color.HotPink;
            this.Onigiri3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Onigiri3.BorderSize = 0;
            this.Onigiri3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Onigiri3.GradientAngle = 30F;
            this.Onigiri3.Location = new System.Drawing.Point(316, 12);
            this.Onigiri3.Name = "Onigiri3";
            this.Onigiri3.Size = new System.Drawing.Size(132, 132);
            this.Onigiri3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Onigiri3.TabIndex = 2;
            this.Onigiri3.TabStop = false;
            this.Onigiri3.Texts = "Onigiri Tuna Mayo";
            this.Onigiri3.Click += new System.EventHandler(this.Onigiri3_Click);
            // 
            // Onigiri2
            // 
            this.Onigiri2.BackgroundImage = global::Project.Properties.Resources.IkanTongkol;
            this.Onigiri2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Onigiri2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.Onigiri2.BorderColor = System.Drawing.Color.DarkViolet;
            this.Onigiri2.BorderColor2 = System.Drawing.Color.HotPink;
            this.Onigiri2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Onigiri2.BorderSize = 0;
            this.Onigiri2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Onigiri2.GradientAngle = 30F;
            this.Onigiri2.Location = new System.Drawing.Point(164, 12);
            this.Onigiri2.Name = "Onigiri2";
            this.Onigiri2.Size = new System.Drawing.Size(132, 132);
            this.Onigiri2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Onigiri2.TabIndex = 1;
            this.Onigiri2.TabStop = false;
            this.Onigiri2.Texts = "Onigiri Ikan Tongkol";
            this.Onigiri2.Click += new System.EventHandler(this.Onigiri2_Click);
            // 
            // Onigiri1
            // 
            this.Onigiri1.BackgroundImage = global::Project.Properties.Resources.AyamSuwir;
            this.Onigiri1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Onigiri1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.Onigiri1.BorderColor = System.Drawing.Color.DarkViolet;
            this.Onigiri1.BorderColor2 = System.Drawing.Color.HotPink;
            this.Onigiri1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Onigiri1.BorderSize = 0;
            this.Onigiri1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Onigiri1.GradientAngle = 30F;
            this.Onigiri1.Location = new System.Drawing.Point(12, 12);
            this.Onigiri1.Name = "Onigiri1";
            this.Onigiri1.Size = new System.Drawing.Size(132, 132);
            this.Onigiri1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Onigiri1.TabIndex = 0;
            this.Onigiri1.TabStop = false;
            this.Onigiri1.Texts = "Onigiri Ayam Suwir";
            this.Onigiri1.Click += new System.EventHandler(this.Onigiri1_Click);
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panelOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.panelNavigation.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyOrder)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Onigiri1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHome;
        private RButton btLogOut;
        private RButton btHistory;
        private RButton btOrder;
        private Panel panelNavigation;
        private Panel panelHistory;
        private DataGridView historyOrder;
        private RTbox findTbox;
        private Label labelRecord;
        private Panel panelOrder;
        private RPictureBox Onigiri4;
        private RPictureBox Onigiri3;
        private RPictureBox Onigiri2;
        private RPictureBox Onigiri1;
        private DataGridView viewOrder;
        private DataGridViewTextBoxColumn foodID;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn delBtn;
        private Label totalPrice;
        private Label quantityMenu;
        private RButton btPlaceOrder;
        private RButton btAdd;
        private Label labelMenu;
        private NumericUpDown quantityPicker;
        private Label selectedMenu;
        private RButton btHome;
    }
}