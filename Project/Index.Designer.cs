namespace Project
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.tbUser = new Project.RTbox();
            this.tbPass = new Project.RTbox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btLogin = new Project.RButton();
            this.btQuit = new Project.RButton();
            this.createAccLink = new System.Windows.Forms.LinkLabel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.creditsLink = new System.Windows.Forms.LinkLabel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new Project.RTbox();
            this.bDate = new Project.RDatePicker();
            this.tbAddress = new Project.RTbox();
            this.tbUsername = new Project.RTbox();
            this.tbPassword = new Project.RTbox();
            this.btRegister = new Project.RButton();
            this.btCancel = new Project.RButton();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelCredits = new System.Windows.Forms.Panel();
            this.btBack = new Project.RButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.BorderColor = System.Drawing.Color.Blue;
            this.tbUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbUser.BorderRadius = 2;
            this.tbUser.BorderSize = 1;
            this.tbUser.Location = new System.Drawing.Point(277, 18);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.Multiline = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(7);
            this.tbUser.PasswordChar = false;
            this.tbUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUser.PlaceHolderText = "Enter Username";
            this.tbUser.Size = new System.Drawing.Size(250, 30);
            this.tbUser.TabIndex = 0;
            this.tbUser.Texts = "";
            this.tbUser.UnderlinedStyle = true;
            // 
            // tbPass
            // 
            this.tbPass.BorderColor = System.Drawing.Color.Blue;
            this.tbPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPass.BorderRadius = 2;
            this.tbPass.BorderSize = 1;
            this.tbPass.Location = new System.Drawing.Point(277, 52);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbPass.PasswordChar = true;
            this.tbPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPass.PlaceHolderText = "Enter Password";
            this.tbPass.Size = new System.Drawing.Size(250, 30);
            this.tbPass.TabIndex = 1;
            this.tbPass.Texts = "";
            this.tbPass.UnderlinedStyle = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHeader.BackgroundImage = global::Project.Properties.Resources.logo_2;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 225);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Lime;
            this.btLogin.BorderColor = System.Drawing.Color.Black;
            this.btLogin.BorderRadius = 15;
            this.btLogin.BorderSize = 1;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Location = new System.Drawing.Point(277, 98);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(250, 32);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.Red;
            this.btQuit.BorderColor = System.Drawing.Color.Black;
            this.btQuit.BorderRadius = 15;
            this.btQuit.BorderSize = 1;
            this.btQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuit.FlatAppearance.BorderSize = 0;
            this.btQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btQuit.Location = new System.Drawing.Point(277, 136);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(250, 32);
            this.btQuit.TabIndex = 4;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // createAccLink
            // 
            this.createAccLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.createAccLink.AutoSize = true;
            this.createAccLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccLink.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createAccLink.Location = new System.Drawing.Point(359, 202);
            this.createAccLink.Name = "createAccLink";
            this.createAccLink.Size = new System.Drawing.Size(89, 15);
            this.createAccLink.TabIndex = 9;
            this.createAccLink.TabStop = true;
            this.createAccLink.Text = "Create Account";
            this.createAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccLink_LinkClicked);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.creditsLink);
            this.panelForm.Controls.Add(this.tbPass);
            this.panelForm.Controls.Add(this.createAccLink);
            this.panelForm.Controls.Add(this.tbUser);
            this.panelForm.Controls.Add(this.btQuit);
            this.panelForm.Controls.Add(this.btLogin);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelForm.Location = new System.Drawing.Point(0, 224);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(800, 226);
            this.panelForm.TabIndex = 10;
            this.panelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // creditsLink
            // 
            this.creditsLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.creditsLink.AutoSize = true;
            this.creditsLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsLink.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.creditsLink.Location = new System.Drawing.Point(380, 180);
            this.creditsLink.Name = "creditsLink";
            this.creditsLink.Size = new System.Drawing.Size(44, 15);
            this.creditsLink.TabIndex = 10;
            this.creditsLink.TabStop = true;
            this.creditsLink.Text = "Credits";
            this.creditsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLink_LinkClicked);
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.panel2);
            this.panelRegister.Controls.Add(this.panel1);
            this.panelRegister.Controls.Add(this.tbName);
            this.panelRegister.Controls.Add(this.bDate);
            this.panelRegister.Controls.Add(this.tbAddress);
            this.panelRegister.Controls.Add(this.tbUsername);
            this.panelRegister.Controls.Add(this.tbPassword);
            this.panelRegister.Controls.Add(this.btRegister);
            this.panelRegister.Controls.Add(this.btCancel);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(800, 450);
            this.panelRegister.TabIndex = 0;
            this.panelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panelRegister.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(553, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 174);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 174);
            this.panel1.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderColor = System.Drawing.Color.Blue;
            this.tbName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbName.BorderRadius = 2;
            this.tbName.BorderSize = 1;
            this.tbName.Location = new System.Drawing.Point(279, 83);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(7);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceHolderText = "Enter Fullname";
            this.tbName.Size = new System.Drawing.Size(243, 30);
            this.tbName.TabIndex = 15;
            this.tbName.Texts = "";
            this.tbName.UnderlinedStyle = false;
            // 
            // bDate
            // 
            this.bDate.BorderColor = System.Drawing.Color.Blue;
            this.bDate.BorderRadius = 0;
            this.bDate.BorderSize = 1;
            this.bDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDate.Location = new System.Drawing.Point(279, 119);
            this.bDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(243, 35);
            this.bDate.SkinColor = System.Drawing.Color.White;
            this.bDate.TabIndex = 19;
            this.bDate.TextColor = System.Drawing.Color.Black;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.BorderColor = System.Drawing.Color.Blue;
            this.tbAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbAddress.BorderRadius = 2;
            this.tbAddress.BorderSize = 1;
            this.tbAddress.Location = new System.Drawing.Point(279, 159);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.Multiline = false;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Padding = new System.Windows.Forms.Padding(7);
            this.tbAddress.PasswordChar = false;
            this.tbAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbAddress.PlaceHolderText = "Enter Address";
            this.tbAddress.Size = new System.Drawing.Size(243, 30);
            this.tbAddress.TabIndex = 16;
            this.tbAddress.Texts = "";
            this.tbAddress.UnderlinedStyle = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderColor = System.Drawing.Color.Blue;
            this.tbUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbUsername.BorderRadius = 2;
            this.tbUsername.BorderSize = 1;
            this.tbUsername.Location = new System.Drawing.Point(279, 193);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(7);
            this.tbUsername.PasswordChar = false;
            this.tbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUsername.PlaceHolderText = "Enter Username";
            this.tbUsername.Size = new System.Drawing.Size(243, 30);
            this.tbUsername.TabIndex = 17;
            this.tbUsername.Texts = "";
            this.tbUsername.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.Blue;
            this.tbPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPassword.BorderRadius = 2;
            this.tbPassword.BorderSize = 1;
            this.tbPassword.Location = new System.Drawing.Point(279, 227);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(7);
            this.tbPassword.PasswordChar = true;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPassword.PlaceHolderText = "Enter Password";
            this.tbPassword.Size = new System.Drawing.Size(243, 30);
            this.tbPassword.TabIndex = 18;
            this.tbPassword.Texts = "";
            this.tbPassword.UnderlinedStyle = false;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Lime;
            this.btRegister.BorderColor = System.Drawing.Color.Black;
            this.btRegister.BorderRadius = 15;
            this.btRegister.BorderSize = 1;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Location = new System.Drawing.Point(279, 296);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(243, 40);
            this.btRegister.TabIndex = 20;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.BorderColor = System.Drawing.Color.Black;
            this.btCancel.BorderRadius = 15;
            this.btCancel.BorderSize = 1;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancel.Location = new System.Drawing.Point(279, 342);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(243, 40);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelForm);
            this.panelLogin.Controls.Add(this.panelHeader);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(800, 450);
            this.panelLogin.TabIndex = 0;
            // 
            // panelCredits
            // 
            this.panelCredits.Controls.Add(this.btBack);
            this.panelCredits.Controls.Add(this.label8);
            this.panelCredits.Controls.Add(this.label7);
            this.panelCredits.Controls.Add(this.label6);
            this.panelCredits.Controls.Add(this.label5);
            this.panelCredits.Controls.Add(this.label4);
            this.panelCredits.Controls.Add(this.label3);
            this.panelCredits.Controls.Add(this.label2);
            this.panelCredits.Controls.Add(this.label1);
            this.panelCredits.Location = new System.Drawing.Point(0, 0);
            this.panelCredits.Name = "panelCredits";
            this.panelCredits.Size = new System.Drawing.Size(800, 450);
            this.panelCredits.TabIndex = 0;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Salmon;
            this.btBack.BorderColor = System.Drawing.Color.Black;
            this.btBack.BorderRadius = 10;
            this.btBack.BorderSize = 1;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(329, 342);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(150, 40);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(553, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nabila Daniasti Darno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(553, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nicolas Anelka Winata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(553, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Backend";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mohammad Anand Ridho Sulthoni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anastasia Alice Angelica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daniel Ebeneizer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "UI/UX Designer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created By:";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelCredits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.Text = "Login";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelCredits.ResumeLayout(false);
            this.panelCredits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RTbox tbUser;
        private RTbox tbPass;
        private Panel panelHeader;
        private RButton btLogin;
        private RButton btQuit;
        private LinkLabel createAccLink;
        private Panel panelForm;
        private Panel panelRegister;
        private RTbox tbName;
        private RDatePicker bDate;
        private RTbox tbAddress;
        private RTbox tbUsername;
        private RTbox tbPassword;
        private Panel panelLogin;
        private RButton btRegister;
        private RButton btCancel;
        private Panel panel2;
        private Panel panel1;
        private LinkLabel creditsLink;
        private Panel panelCredits;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RButton btBack;
    }
}