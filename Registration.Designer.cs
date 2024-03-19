namespace Skills_International
{
    partial class Registration
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
            Logout = new LinkLabel();
            Title = new Label();
            StudentRegistration = new GroupBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            Parent = new GroupBox();
            txtNICbox = new TextBox();
            txtcontactNo = new TextBox();
            txtParent = new TextBox();
            txtconta = new Label();
            txtNIC = new Label();
            txtParentName = new Label();
            Contact = new GroupBox();
            txthome = new TextBox();
            txtmobile = new TextBox();
            txteail = new TextBox();
            txtAddress = new TextBox();
            HomePhone = new Label();
            MobilePhone = new Label();
            Email = new Label();
            Address = new Label();
            basic = new GroupBox();
            GFMale = new RadioButton();
            Gmale = new RadioButton();
            dateOB = new DateTimePicker();
            txtSName = new TextBox();
            txtFName = new TextBox();
            Gender = new Label();
            DOB = new Label();
            SecondName = new Label();
            Firstname = new Label();
            Comboreg = new ComboBox();
            RegNo = new Label();
            Exit = new LinkLabel();
            StudentRegistration.SuspendLayout();
            Parent.SuspendLayout();
            Contact.SuspendLayout();
            basic.SuspendLayout();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Location = new Point(12, 9);
            Logout.Name = "Logout";
            Logout.Size = new Size(45, 15);
            Logout.TabIndex = 0;
            Logout.TabStop = true;
            Logout.Text = "Logout";
            Logout.LinkClicked += Logout_LinkClicked;
            // 
            // Title
            // 
            Title.AccessibleName = "Title";
            Title.AutoSize = true;
            Title.Font = new Font("STZhongsong", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(131, 50);
            Title.Name = "Title";
            Title.Size = new Size(366, 40);
            Title.TabIndex = 2;
            Title.Text = "Skills International";
            // 
            // StudentRegistration
            // 
            StudentRegistration.AccessibleName = "StudentRegistration";
            StudentRegistration.Controls.Add(btnDelete);
            StudentRegistration.Controls.Add(btnClear);
            StudentRegistration.Controls.Add(btnUpdate);
            StudentRegistration.Controls.Add(btnRegister);
            StudentRegistration.Controls.Add(Parent);
            StudentRegistration.Controls.Add(Contact);
            StudentRegistration.Controls.Add(basic);
            StudentRegistration.Controls.Add(Comboreg);
            StudentRegistration.Controls.Add(RegNo);
            StudentRegistration.Location = new Point(27, 106);
            StudentRegistration.Name = "StudentRegistration";
            StudentRegistration.Size = new Size(576, 696);
            StudentRegistration.TabIndex = 3;
            StudentRegistration.TabStop = false;
            StudentRegistration.Text = "Student Registration";
            // 
            // btnDelete
            // 
            btnDelete.AccessibleName = "Delete";
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(471, 667);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.AccessibleName = "Clear";
            btnClear.BackColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(390, 667);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AccessibleName = "Update";
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(124, 667);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.AccessibleName = "Register";
            btnRegister.BackColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(43, 667);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Parent
            // 
            Parent.Controls.Add(txtNICbox);
            Parent.Controls.Add(txtcontactNo);
            Parent.Controls.Add(txtParent);
            Parent.Controls.Add(txtconta);
            Parent.Controls.Add(txtNIC);
            Parent.Controls.Add(txtParentName);
            Parent.FlatStyle = FlatStyle.Popup;
            Parent.Location = new Point(43, 500);
            Parent.Name = "Parent";
            Parent.Size = new Size(503, 137);
            Parent.TabIndex = 4;
            Parent.TabStop = false;
            Parent.Text = "Parent Details";
            // 
            // txtNICbox
            // 
            txtNICbox.Location = new Point(126, 59);
            txtNICbox.Name = "txtNICbox";
            txtNICbox.Size = new Size(350, 23);
            txtNICbox.TabIndex = 5;
            // 
            // txtcontactNo
            // 
            txtcontactNo.Location = new Point(126, 96);
            txtcontactNo.Name = "txtcontactNo";
            txtcontactNo.Size = new Size(350, 23);
            txtcontactNo.TabIndex = 4;
            // 
            // txtParent
            // 
            txtParent.Location = new Point(126, 25);
            txtParent.Name = "txtParent";
            txtParent.Size = new Size(350, 23);
            txtParent.TabIndex = 3;
            // 
            // txtconta
            // 
            txtconta.AccessibleName = "Contact Number";
            txtconta.AutoSize = true;
            txtconta.Location = new Point(27, 96);
            txtconta.Name = "txtconta";
            txtconta.Size = new Size(96, 15);
            txtconta.TabIndex = 2;
            txtconta.Text = "Contact Number";
            // 
            // txtNIC
            // 
            txtNIC.AccessibleName = "NIC";
            txtNIC.AutoSize = true;
            txtNIC.Location = new Point(27, 62);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(27, 15);
            txtNIC.TabIndex = 1;
            txtNIC.Text = "NIC";
            txtNIC.Click += label2_Click;
            // 
            // txtParentName
            // 
            txtParentName.AccessibleName = "ParentName";
            txtParentName.AutoSize = true;
            txtParentName.Location = new Point(27, 28);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(76, 15);
            txtParentName.TabIndex = 0;
            txtParentName.Text = "Parent Name";
            // 
            // Contact
            // 
            Contact.Controls.Add(txthome);
            Contact.Controls.Add(txtmobile);
            Contact.Controls.Add(txteail);
            Contact.Controls.Add(txtAddress);
            Contact.Controls.Add(HomePhone);
            Contact.Controls.Add(MobilePhone);
            Contact.Controls.Add(Email);
            Contact.Controls.Add(Address);
            Contact.Location = new Point(43, 272);
            Contact.Name = "Contact";
            Contact.Size = new Size(503, 205);
            Contact.TabIndex = 3;
            Contact.TabStop = false;
            Contact.Text = "Contact Details";
            // 
            // txthome
            // 
            txthome.Location = new Point(350, 159);
            txthome.Name = "txthome";
            txthome.Size = new Size(126, 23);
            txthome.TabIndex = 7;
            // 
            // txtmobile
            // 
            txtmobile.Location = new Point(126, 159);
            txtmobile.Name = "txtmobile";
            txtmobile.Size = new Size(126, 23);
            txtmobile.TabIndex = 6;
            // 
            // txteail
            // 
            txteail.Location = new Point(126, 117);
            txteail.Name = "txteail";
            txteail.Size = new Size(350, 23);
            txteail.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(126, 47);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 53);
            txtAddress.TabIndex = 4;
            // 
            // HomePhone
            // 
            HomePhone.AccessibleName = "HomePhone";
            HomePhone.AutoSize = true;
            HomePhone.Location = new Point(267, 159);
            HomePhone.Name = "HomePhone";
            HomePhone.Size = new Size(77, 15);
            HomePhone.TabIndex = 3;
            HomePhone.Text = "Home Phone";
            // 
            // MobilePhone
            // 
            MobilePhone.AccessibleName = "Mobile Phone";
            MobilePhone.AutoSize = true;
            MobilePhone.Location = new Point(27, 159);
            MobilePhone.Name = "MobilePhone";
            MobilePhone.Size = new Size(81, 15);
            MobilePhone.TabIndex = 2;
            MobilePhone.Text = "Mobile Phone";
            // 
            // Email
            // 
            Email.AccessibleName = "Email";
            Email.AutoSize = true;
            Email.Location = new Point(27, 117);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // Address
            // 
            Address.AccessibleName = "Address";
            Address.AutoSize = true;
            Address.Location = new Point(27, 47);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 0;
            Address.Text = "Address";
            // 
            // basic
            // 
            basic.Controls.Add(GFMale);
            basic.Controls.Add(Gmale);
            basic.Controls.Add(dateOB);
            basic.Controls.Add(txtSName);
            basic.Controls.Add(txtFName);
            basic.Controls.Add(Gender);
            basic.Controls.Add(DOB);
            basic.Controls.Add(SecondName);
            basic.Controls.Add(Firstname);
            basic.Location = new Point(43, 68);
            basic.Name = "basic";
            basic.Size = new Size(503, 186);
            basic.TabIndex = 2;
            basic.TabStop = false;
            basic.Text = "Basic  Details";
            // 
            // GFMale
            // 
            GFMale.AutoSize = true;
            GFMale.Location = new Point(249, 148);
            GFMale.Name = "GFMale";
            GFMale.Size = new Size(63, 19);
            GFMale.TabIndex = 8;
            GFMale.TabStop = true;
            GFMale.Text = "Female";
            GFMale.UseVisualStyleBackColor = true;
            // 
            // Gmale
            // 
            Gmale.AutoSize = true;
            Gmale.Location = new Point(130, 148);
            Gmale.Name = "Gmale";
            Gmale.Size = new Size(51, 19);
            Gmale.TabIndex = 7;
            Gmale.TabStop = true;
            Gmale.Text = "Male";
            Gmale.UseVisualStyleBackColor = true;
            // 
            // dateOB
            // 
            dateOB.Location = new Point(126, 103);
            dateOB.Name = "dateOB";
            dateOB.Size = new Size(196, 23);
            dateOB.TabIndex = 6;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(126, 65);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(361, 23);
            txtSName.TabIndex = 5;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(126, 31);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(361, 23);
            txtFName.TabIndex = 4;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(27, 148);
            Gender.Name = "Gender";
            Gender.Size = new Size(45, 15);
            Gender.TabIndex = 3;
            Gender.Text = "Gender";
            // 
            // DOB
            // 
            DOB.AutoSize = true;
            DOB.Location = new Point(27, 111);
            DOB.Name = "DOB";
            DOB.Size = new Size(75, 15);
            DOB.TabIndex = 2;
            DOB.Text = "Date Of Birth";
            // 
            // SecondName
            // 
            SecondName.AutoSize = true;
            SecondName.Location = new Point(27, 73);
            SecondName.Name = "SecondName";
            SecondName.Size = new Size(81, 15);
            SecondName.TabIndex = 1;
            SecondName.Text = "Second Name";
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Location = new Point(27, 39);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(64, 15);
            Firstname.TabIndex = 0;
            Firstname.Text = "First Name";
            // 
            // Comboreg
            // 
            Comboreg.FormattingEnabled = true;
            Comboreg.Location = new Point(104, 28);
            Comboreg.Name = "Comboreg";
            Comboreg.Size = new Size(121, 23);
            Comboreg.TabIndex = 1;
            Comboreg.SelectedIndexChanged += Comboreg_SelectedIndexChanged;
            // 
            // RegNo
            // 
            RegNo.AutoSize = true;
            RegNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegNo.Location = new Point(27, 28);
            RegNo.Name = "RegNo";
            RegNo.Size = new Size(53, 17);
            RegNo.TabIndex = 0;
            RegNo.Text = "Reg No";
            // 
            // Exit
            // 
            Exit.AccessibleName = "Exit";
            Exit.AutoSize = true;
            Exit.Location = new Point(543, 815);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 15);
            Exit.TabIndex = 4;
            Exit.TabStop = true;
            Exit.Text = "Exit";
            Exit.LinkClicked += Exit_LinkClicked;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(638, 839);
            Controls.Add(Exit);
            Controls.Add(StudentRegistration);
            Controls.Add(Title);
            Controls.Add(Logout);
            Name = "Registration";
            Text = "Student Registration - Skills International";
            StudentRegistration.ResumeLayout(false);
            StudentRegistration.PerformLayout();
            Parent.ResumeLayout(false);
            Parent.PerformLayout();
            Contact.ResumeLayout(false);
            Contact.PerformLayout();
            basic.ResumeLayout(false);
            basic.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel Logout;
        private Label Title;
        private GroupBox StudentRegistration;
        private Label RegNo;
        private GroupBox Parent;
        private GroupBox Contact;
        private GroupBox basic;
        private TextBox txtSName;
        private TextBox txtFName;
        private Label Gender;
        private Label DOB;
        private Label SecondName;
        private Label Firstname;
        private ComboBox Comboreg;
        private RadioButton GFMale;
        private RadioButton Gmale;
        private DateTimePicker dateOB;
        private TextBox txtAddress;
        private Label HomePhone;
        private Label MobilePhone;
        private Label Email;
        private Label Address;
        private TextBox txthome;
        private TextBox txtmobile;
        private TextBox txteail;
        private TextBox txtNICbox;
        private TextBox txtcontactNo;
        private TextBox txtParent;
        private Label txtconta;
        private Label txtNIC;
        private Label txtParentName;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRegister;
        private LinkLabel Exit;
    }
}