namespace Skills_International
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Title = new Label();
            GroupBoxMain = new GroupBox();
            butClear = new Button();
            butLogin = new Button();
            txtPassword = new TextBox();
            txtUName = new TextBox();
            Password = new Label();
            Username = new Label();
            butExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            GroupBoxMain.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleDescription = "Logo Image";
            pictureBox1.AccessibleName = "Logo";
            pictureBox1.ImageLocation = "D:\\esoft\\Skills International\\Assets\\logo.jpeg";
            pictureBox1.Location = new Point(163, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Title
            // 
            Title.AccessibleName = "Title";
            Title.AutoSize = true;
            Title.Font = new Font("STZhongsong", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(108, 255);
            Title.Name = "Title";
            Title.Size = new Size(366, 40);
            Title.TabIndex = 1;
            Title.Text = "Skills International";
            Title.Click += label1_Click;
            // 
            // GroupBoxMain
            // 
            GroupBoxMain.AccessibleName = "GroupBoxMain";
            GroupBoxMain.BackColor = SystemColors.ControlLight;
            GroupBoxMain.BackgroundImageLayout = ImageLayout.Center;
            GroupBoxMain.Controls.Add(butClear);
            GroupBoxMain.Controls.Add(butLogin);
            GroupBoxMain.Controls.Add(txtPassword);
            GroupBoxMain.Controls.Add(txtUName);
            GroupBoxMain.Controls.Add(Password);
            GroupBoxMain.Controls.Add(Username);
            GroupBoxMain.Cursor = Cursors.IBeam;
            GroupBoxMain.FlatStyle = FlatStyle.Popup;
            GroupBoxMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxMain.ForeColor = SystemColors.ActiveCaptionText;
            GroupBoxMain.Location = new Point(65, 316);
            GroupBoxMain.Name = "GroupBoxMain";
            GroupBoxMain.Size = new Size(449, 338);
            GroupBoxMain.TabIndex = 2;
            GroupBoxMain.TabStop = false;
            GroupBoxMain.Text = "Login";
            // 
            // butClear
            // 
            butClear.AccessibleName = "butClear";
            butClear.BackColor = SystemColors.ButtonFace;
            butClear.Location = new Point(43, 243);
            butClear.Name = "butClear";
            butClear.Size = new Size(110, 35);
            butClear.TabIndex = 5;
            butClear.Text = "Clear";
            butClear.UseVisualStyleBackColor = false;
            butClear.Click += butClear_Click;
            // 
            // butLogin
            // 
            butLogin.AccessibleName = "butLogin";
            butLogin.BackColor = SystemColors.ButtonFace;
            butLogin.Location = new Point(325, 243);
            butLogin.Name = "butLogin";
            butLogin.Size = new Size(110, 35);
            butLogin.TabIndex = 4;
            butLogin.Text = "Login";
            butLogin.UseVisualStyleBackColor = false;
            butLogin.Click += butLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleName = "txtPassword ";
            txtPassword.Location = new Point(169, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 29);
            txtPassword.TabIndex = 3;
            // 
            // txtUName
            // 
            txtUName.AccessibleName = "txtUName";
            txtUName.Location = new Point(169, 72);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(245, 29);
            txtUName.TabIndex = 2;
            // 
            // Password
            // 
            Password.AccessibleName = "Password";
            Password.AutoSize = true;
            Password.Location = new Point(43, 133);
            Password.Name = "Password";
            Password.Size = new Size(76, 21);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // Username
            // 
            Username.AccessibleName = "Username";
            Username.AutoSize = true;
            Username.Location = new Point(43, 75);
            Username.Name = "Username";
            Username.Size = new Size(81, 21);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // butExit
            // 
            butExit.AccessibleName = "butExit";
            butExit.BackColor = SystemColors.ButtonFace;
            butExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butExit.Location = new Point(12, 691);
            butExit.Name = "butExit";
            butExit.Size = new Size(72, 34);
            butExit.TabIndex = 3;
            butExit.Text = "Exit";
            butExit.UseVisualStyleBackColor = false;
            butExit.Click += butExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(604, 737);
            Controls.Add(butExit);
            Controls.Add(GroupBoxMain);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login - Skills International";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            GroupBoxMain.ResumeLayout(false);
            GroupBoxMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Title;
        private GroupBox GroupBoxMain;
        private Button butLogin;
        private TextBox txtPassword;
        private TextBox txtUName;
        private Label Password;
        private Label Username;
        private Button butClear;
        private Button butExit;
    }
}
