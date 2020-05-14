namespace GymManagementSystem
{
    partial class ManagerEmp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clienttab = new System.Windows.Forms.TabPage();
            this.cid = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.heightinch = new System.Windows.Forms.ComboBox();
            this.heightft = new System.Windows.Forms.ComboBox();
            this.cInsert = new System.Windows.Forms.Button();
            this.cUpdate = new System.Windows.Forms.Button();
            this.cDelete = new System.Windows.Forms.Button();
            this.cClearAll = new System.Windows.Forms.Button();
            this.cshow = new System.Windows.Forms.Button();
            this.clientinfotable = new System.Windows.Forms.DataGridView();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.crbFemale = new System.Windows.Forms.RadioButton();
            this.crbMale = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trainertab = new System.Windows.Forms.TabPage();
            this.tid = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.thinch = new System.Windows.Forms.ComboBox();
            this.thft = new System.Windows.Forms.ComboBox();
            this.tInsert = new System.Windows.Forms.Button();
            this.tUpdate = new System.Windows.Forms.Button();
            this.tDelete = new System.Windows.Forms.Button();
            this.tClearAll = new System.Windows.Forms.Button();
            this.trainerinfotable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trbFemale = new System.Windows.Forms.RadioButton();
            this.trbMale = new System.Windows.Forms.RadioButton();
            this.tdob = new System.Windows.Forms.DateTimePicker();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tuname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tweight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.taddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tphone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.tShowAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.clienttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfotable)).BeginInit();
            this.Gender.SuspendLayout();
            this.trainertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerinfotable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clienttab);
            this.tabControl1.Controls.Add(this.trainertab);
            this.tabControl1.Location = new System.Drawing.Point(1, 113);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1683, 710);
            this.tabControl1.TabIndex = 7;
            // 
            // clienttab
            // 
            this.clienttab.Controls.Add(this.cid);
            this.clienttab.Controls.Add(this.label21);
            this.clienttab.Controls.Add(this.label20);
            this.clienttab.Controls.Add(this.heightinch);
            this.clienttab.Controls.Add(this.heightft);
            this.clienttab.Controls.Add(this.cInsert);
            this.clienttab.Controls.Add(this.cUpdate);
            this.clienttab.Controls.Add(this.cDelete);
            this.clienttab.Controls.Add(this.cClearAll);
            this.clienttab.Controls.Add(this.cshow);
            this.clienttab.Controls.Add(this.clientinfotable);
            this.clienttab.Controls.Add(this.Gender);
            this.clienttab.Controls.Add(this.dob);
            this.clienttab.Controls.Add(this.password);
            this.clienttab.Controls.Add(this.label10);
            this.clienttab.Controls.Add(this.username);
            this.clienttab.Controls.Add(this.label9);
            this.clienttab.Controls.Add(this.weight);
            this.clienttab.Controls.Add(this.label8);
            this.clienttab.Controls.Add(this.label7);
            this.clienttab.Controls.Add(this.label6);
            this.clienttab.Controls.Add(this.address);
            this.clienttab.Controls.Add(this.label5);
            this.clienttab.Controls.Add(this.phone);
            this.clienttab.Controls.Add(this.label4);
            this.clienttab.Controls.Add(this.email);
            this.clienttab.Controls.Add(this.label3);
            this.clienttab.Controls.Add(this.name);
            this.clienttab.Controls.Add(this.label2);
            this.clienttab.Location = new System.Drawing.Point(4, 25);
            this.clienttab.Margin = new System.Windows.Forms.Padding(4);
            this.clienttab.Name = "clienttab";
            this.clienttab.Padding = new System.Windows.Forms.Padding(4);
            this.clienttab.Size = new System.Drawing.Size(1675, 681);
            this.clienttab.TabIndex = 0;
            this.clienttab.Text = "Client";
            this.clienttab.UseVisualStyleBackColor = true;
            // 
            // cid
            // 
            this.cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.Location = new System.Drawing.Point(568, 612);
            this.cid.Margin = new System.Windows.Forms.Padding(4);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(157, 36);
            this.cid.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(479, 295);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "inch.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(291, 293);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 25);
            this.label20.TabIndex = 8;
            this.label20.Text = "ft.";
            // 
            // heightinch
            // 
            this.heightinch.FormattingEnabled = true;
            this.heightinch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.heightinch.Location = new System.Drawing.Point(359, 293);
            this.heightinch.Margin = new System.Windows.Forms.Padding(4);
            this.heightinch.Name = "heightinch";
            this.heightinch.Size = new System.Drawing.Size(97, 24);
            this.heightinch.TabIndex = 7;
            // 
            // heightft
            // 
            this.heightft.FormattingEnabled = true;
            this.heightft.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.heightft.Location = new System.Drawing.Point(184, 293);
            this.heightft.Margin = new System.Windows.Forms.Padding(4);
            this.heightft.Name = "heightft";
            this.heightft.Size = new System.Drawing.Size(97, 24);
            this.heightft.TabIndex = 6;
            // 
            // cInsert
            // 
            this.cInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cInsert.Location = new System.Drawing.Point(1218, 612);
            this.cInsert.Margin = new System.Windows.Forms.Padding(4);
            this.cInsert.Name = "cInsert";
            this.cInsert.Size = new System.Drawing.Size(204, 57);
            this.cInsert.TabIndex = 5;
            this.cInsert.Text = "Insert";
            this.cInsert.UseVisualStyleBackColor = true;
            this.cInsert.Click += new System.EventHandler(this.cInsert_Click);
            // 
            // cUpdate
            // 
            this.cUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUpdate.Location = new System.Drawing.Point(990, 612);
            this.cUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cUpdate.Name = "cUpdate";
            this.cUpdate.Size = new System.Drawing.Size(204, 57);
            this.cUpdate.TabIndex = 5;
            this.cUpdate.Text = "Update";
            this.cUpdate.UseVisualStyleBackColor = true;
            this.cUpdate.Click += new System.EventHandler(this.cUpdate_Click);
            // 
            // cDelete
            // 
            this.cDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDelete.Location = new System.Drawing.Point(765, 612);
            this.cDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cDelete.Name = "cDelete";
            this.cDelete.Size = new System.Drawing.Size(204, 57);
            this.cDelete.TabIndex = 5;
            this.cDelete.Text = "Delete";
            this.cDelete.UseVisualStyleBackColor = true;
            this.cDelete.Click += new System.EventHandler(this.cDelete_Click);
            // 
            // cClearAll
            // 
            this.cClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cClearAll.Location = new System.Drawing.Point(293, 603);
            this.cClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.cClearAll.Name = "cClearAll";
            this.cClearAll.Size = new System.Drawing.Size(204, 57);
            this.cClearAll.TabIndex = 5;
            this.cClearAll.Text = "Clear All";
            this.cClearAll.UseVisualStyleBackColor = true;
            this.cClearAll.Click += new System.EventHandler(this.cClearAll_Click);
            // 
            // cshow
            // 
            this.cshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cshow.Location = new System.Drawing.Point(55, 603);
            this.cshow.Margin = new System.Windows.Forms.Padding(4);
            this.cshow.Name = "cshow";
            this.cshow.Size = new System.Drawing.Size(204, 57);
            this.cshow.TabIndex = 5;
            this.cshow.Text = "Show All";
            this.cshow.UseVisualStyleBackColor = true;
            this.cshow.Click += new System.EventHandler(this.cshow_Click);
            // 
            // clientinfotable
            // 
            this.clientinfotable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientinfotable.Location = new System.Drawing.Point(568, 7);
            this.clientinfotable.Margin = new System.Windows.Forms.Padding(4);
            this.clientinfotable.Name = "clientinfotable";
            this.clientinfotable.RowHeadersWidth = 51;
            this.clientinfotable.Size = new System.Drawing.Size(907, 570);
            this.clientinfotable.TabIndex = 4;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.crbFemale);
            this.Gender.Controls.Add(this.crbMale);
            this.Gender.Location = new System.Drawing.Point(63, 469);
            this.Gender.Margin = new System.Windows.Forms.Padding(4);
            this.Gender.Name = "Gender";
            this.Gender.Padding = new System.Windows.Forms.Padding(4);
            this.Gender.Size = new System.Drawing.Size(481, 108);
            this.Gender.TabIndex = 3;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // crbFemale
            // 
            this.crbFemale.AutoSize = true;
            this.crbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbFemale.Location = new System.Drawing.Point(336, 46);
            this.crbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.crbFemale.Name = "crbFemale";
            this.crbFemale.Size = new System.Drawing.Size(98, 29);
            this.crbFemale.TabIndex = 0;
            this.crbFemale.TabStop = true;
            this.crbFemale.Text = "Female";
            this.crbFemale.UseVisualStyleBackColor = true;
            this.crbFemale.CheckedChanged += new System.EventHandler(this.crbFemale_CheckedChanged);
            // 
            // crbMale
            // 
            this.crbMale.AutoSize = true;
            this.crbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbMale.Location = new System.Drawing.Point(121, 46);
            this.crbMale.Margin = new System.Windows.Forms.Padding(4);
            this.crbMale.Name = "crbMale";
            this.crbMale.Size = new System.Drawing.Size(76, 29);
            this.crbMale.TabIndex = 0;
            this.crbMale.TabStop = true;
            this.crbMale.Text = "Male";
            this.crbMale.UseVisualStyleBackColor = true;
            this.crbMale.CheckedChanged += new System.EventHandler(this.crbMale_CheckedChanged);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(187, 249);
            this.dob.Margin = new System.Windows.Forms.Padding(4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(347, 22);
            this.dob.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(184, 416);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(351, 34);
            this.password.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(184, 373);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(351, 34);
            this.username.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "User Name:";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(184, 330);
            this.weight.Margin = new System.Windows.Forms.Padding(4);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(351, 34);
            this.weight.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date of Birth:";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(184, 201);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(351, 34);
            this.address.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(184, 158);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(351, 34);
            this.phone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone No:";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(184, 115);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(351, 34);
            this.email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(184, 72);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(351, 34);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // trainertab
            // 
            this.trainertab.Controls.Add(this.tShowAll);
            this.trainertab.Controls.Add(this.tid);
            this.trainertab.Controls.Add(this.label22);
            this.trainertab.Controls.Add(this.label23);
            this.trainertab.Controls.Add(this.thinch);
            this.trainertab.Controls.Add(this.thft);
            this.trainertab.Controls.Add(this.tInsert);
            this.trainertab.Controls.Add(this.tUpdate);
            this.trainertab.Controls.Add(this.tDelete);
            this.trainertab.Controls.Add(this.tClearAll);
            this.trainertab.Controls.Add(this.trainerinfotable);
            this.trainertab.Controls.Add(this.groupBox1);
            this.trainertab.Controls.Add(this.tdob);
            this.trainertab.Controls.Add(this.tpassword);
            this.trainertab.Controls.Add(this.label11);
            this.trainertab.Controls.Add(this.tuname);
            this.trainertab.Controls.Add(this.label12);
            this.trainertab.Controls.Add(this.tweight);
            this.trainertab.Controls.Add(this.label13);
            this.trainertab.Controls.Add(this.label14);
            this.trainertab.Controls.Add(this.label15);
            this.trainertab.Controls.Add(this.taddress);
            this.trainertab.Controls.Add(this.label16);
            this.trainertab.Controls.Add(this.tphone);
            this.trainertab.Controls.Add(this.label17);
            this.trainertab.Controls.Add(this.temail);
            this.trainertab.Controls.Add(this.label18);
            this.trainertab.Controls.Add(this.tname);
            this.trainertab.Controls.Add(this.label19);
            this.trainertab.Location = new System.Drawing.Point(4, 25);
            this.trainertab.Margin = new System.Windows.Forms.Padding(4);
            this.trainertab.Name = "trainertab";
            this.trainertab.Padding = new System.Windows.Forms.Padding(4);
            this.trainertab.Size = new System.Drawing.Size(1675, 681);
            this.trainertab.TabIndex = 1;
            this.trainertab.Text = "Trainer";
            this.trainertab.UseVisualStyleBackColor = true;
            // 
            // tid
            // 
            this.tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tid.Location = new System.Drawing.Point(583, 624);
            this.tid.Margin = new System.Windows.Forms.Padding(4);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(153, 34);
            this.tid.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(474, 306);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 25);
            this.label22.TabIndex = 33;
            this.label22.Text = "inch.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(286, 304);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 25);
            this.label23.TabIndex = 34;
            this.label23.Text = "ft.";
            // 
            // thinch
            // 
            this.thinch.FormattingEnabled = true;
            this.thinch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thinch.Location = new System.Drawing.Point(354, 304);
            this.thinch.Margin = new System.Windows.Forms.Padding(4);
            this.thinch.Name = "thinch";
            this.thinch.Size = new System.Drawing.Size(97, 24);
            this.thinch.TabIndex = 32;
            // 
            // thft
            // 
            this.thft.FormattingEnabled = true;
            this.thft.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.thft.Location = new System.Drawing.Point(179, 304);
            this.thft.Margin = new System.Windows.Forms.Padding(4);
            this.thft.Name = "thft";
            this.thft.Size = new System.Drawing.Size(97, 24);
            this.thft.TabIndex = 31;
            // 
            // tInsert
            // 
            this.tInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tInsert.Location = new System.Drawing.Point(1292, 613);
            this.tInsert.Margin = new System.Windows.Forms.Padding(4);
            this.tInsert.Name = "tInsert";
            this.tInsert.Size = new System.Drawing.Size(204, 57);
            this.tInsert.TabIndex = 30;
            this.tInsert.Text = "Insert";
            this.tInsert.UseVisualStyleBackColor = true;
            this.tInsert.Click += new System.EventHandler(this.tInsert_Click);
            // 
            // tUpdate
            // 
            this.tUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUpdate.Location = new System.Drawing.Point(1048, 613);
            this.tUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tUpdate.Name = "tUpdate";
            this.tUpdate.Size = new System.Drawing.Size(204, 57);
            this.tUpdate.TabIndex = 29;
            this.tUpdate.Text = "Update";
            this.tUpdate.UseVisualStyleBackColor = true;
            this.tUpdate.Click += new System.EventHandler(this.tUpdate_Click);
            // 
            // tDelete
            // 
            this.tDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDelete.Location = new System.Drawing.Point(793, 613);
            this.tDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tDelete.Name = "tDelete";
            this.tDelete.Size = new System.Drawing.Size(204, 57);
            this.tDelete.TabIndex = 28;
            this.tDelete.Text = "Delete";
            this.tDelete.UseVisualStyleBackColor = true;
            this.tDelete.Click += new System.EventHandler(this.tDelete_Click);
            // 
            // tClearAll
            // 
            this.tClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClearAll.Location = new System.Drawing.Point(44, 614);
            this.tClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.tClearAll.Name = "tClearAll";
            this.tClearAll.Size = new System.Drawing.Size(204, 57);
            this.tClearAll.TabIndex = 27;
            this.tClearAll.Text = "Clear All";
            this.tClearAll.UseVisualStyleBackColor = true;
            this.tClearAll.Click += new System.EventHandler(this.tClearAll_Click);
            // 
            // trainerinfotable
            // 
            this.trainerinfotable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainerinfotable.Location = new System.Drawing.Point(583, 18);
            this.trainerinfotable.Margin = new System.Windows.Forms.Padding(4);
            this.trainerinfotable.Name = "trainerinfotable";
            this.trainerinfotable.RowHeadersWidth = 51;
            this.trainerinfotable.Size = new System.Drawing.Size(913, 570);
            this.trainerinfotable.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trbFemale);
            this.groupBox1.Controls.Add(this.trbMale);
            this.groupBox1.Location = new System.Drawing.Point(44, 480);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 108);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // trbFemale
            // 
            this.trbFemale.AutoSize = true;
            this.trbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trbFemale.Location = new System.Drawing.Point(309, 46);
            this.trbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.trbFemale.Name = "trbFemale";
            this.trbFemale.Size = new System.Drawing.Size(98, 29);
            this.trbFemale.TabIndex = 0;
            this.trbFemale.TabStop = true;
            this.trbFemale.Text = "Female";
            this.trbFemale.UseVisualStyleBackColor = true;
            this.trbFemale.CheckedChanged += new System.EventHandler(this.trbFemale_CheckedChanged);
            // 
            // trbMale
            // 
            this.trbMale.AutoSize = true;
            this.trbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trbMale.Location = new System.Drawing.Point(121, 46);
            this.trbMale.Margin = new System.Windows.Forms.Padding(4);
            this.trbMale.Name = "trbMale";
            this.trbMale.Size = new System.Drawing.Size(76, 29);
            this.trbMale.TabIndex = 0;
            this.trbMale.TabStop = true;
            this.trbMale.Text = "Male";
            this.trbMale.UseVisualStyleBackColor = true;
            this.trbMale.CheckedChanged += new System.EventHandler(this.trbMale_CheckedChanged);
            // 
            // tdob
            // 
            this.tdob.Location = new System.Drawing.Point(179, 260);
            this.tdob.Margin = new System.Windows.Forms.Padding(4);
            this.tdob.Name = "tdob";
            this.tdob.Size = new System.Drawing.Size(347, 22);
            this.tdob.TabIndex = 23;
            // 
            // tpassword
            // 
            this.tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpassword.Location = new System.Drawing.Point(177, 428);
            this.tpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(351, 34);
            this.tpassword.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 437);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Password:";
            // 
            // tuname
            // 
            this.tuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuname.Location = new System.Drawing.Point(177, 384);
            this.tuname.Margin = new System.Windows.Forms.Padding(4);
            this.tuname.Name = "tuname";
            this.tuname.Size = new System.Drawing.Size(351, 34);
            this.tuname.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 394);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "User Name:";
            // 
            // tweight
            // 
            this.tweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweight.Location = new System.Drawing.Point(177, 341);
            this.tweight.Margin = new System.Windows.Forms.Padding(4);
            this.tweight.Name = "tweight";
            this.tweight.Size = new System.Drawing.Size(351, 34);
            this.tweight.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 351);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Weight:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 308);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 25);
            this.label14.TabIndex = 11;
            this.label14.Text = "Height:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 265);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 25);
            this.label15.TabIndex = 10;
            this.label15.Text = "Date of Birth:";
            // 
            // taddress
            // 
            this.taddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taddress.Location = new System.Drawing.Point(177, 212);
            this.taddress.Margin = new System.Windows.Forms.Padding(4);
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(351, 34);
            this.taddress.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 222);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "Address:";
            // 
            // tphone
            // 
            this.tphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tphone.Location = new System.Drawing.Point(177, 169);
            this.tphone.Margin = new System.Windows.Forms.Padding(4);
            this.tphone.Name = "tphone";
            this.tphone.Size = new System.Drawing.Size(351, 34);
            this.tphone.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(31, 178);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 25);
            this.label17.TabIndex = 8;
            this.label17.Text = "Phone No:";
            // 
            // temail
            // 
            this.temail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temail.Location = new System.Drawing.Point(177, 126);
            this.temail.Margin = new System.Windows.Forms.Padding(4);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(351, 34);
            this.temail.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 135);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 25);
            this.label18.TabIndex = 7;
            this.label18.Text = "Email:";
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.Location = new System.Drawing.Point(177, 83);
            this.tname.Margin = new System.Windows.Forms.Padding(4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(351, 34);
            this.tname.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(31, 92);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 25);
            this.label19.TabIndex = 6;
            this.label19.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymManagementSystem.Properties.Resources.running_man_;
            this.pictureBox1.Location = new System.Drawing.Point(475, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GymManagementSystem.Properties.Resources.backbutton;
            this.pictureBox2.Location = new System.Drawing.Point(17, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Minimize
            // 
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = global::GymManagementSystem.Properties.Resources.blue_circle__;
            this.Minimize.Location = new System.Drawing.Point(1382, 17);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(45, 31);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 17;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::GymManagementSystem.Properties.Resources.red_circle_x;
            this.Exit.Location = new System.Drawing.Point(1435, 17);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 31);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 18;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tShowAll
            // 
            this.tShowAll.Location = new System.Drawing.Point(300, 612);
            this.tShowAll.Name = "tShowAll";
            this.tShowAll.Size = new System.Drawing.Size(201, 58);
            this.tShowAll.TabIndex = 36;
            this.tShowAll.Text = "Show All";
            this.tShowAll.UseVisualStyleBackColor = true;
            this.tShowAll.Click += new System.EventHandler(this.tShowAll_Click);
            // 
            // ManagerEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 838);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerEmp";
            this.tabControl1.ResumeLayout(false);
            this.clienttab.ResumeLayout(false);
            this.clienttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfotable)).EndInit();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.trainertab.ResumeLayout(false);
            this.trainertab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerinfotable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clienttab;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox heightinch;
        private System.Windows.Forms.ComboBox heightft;
        private System.Windows.Forms.Button cInsert;
        private System.Windows.Forms.Button cUpdate;
        private System.Windows.Forms.Button cDelete;
        private System.Windows.Forms.Button cClearAll;
        private System.Windows.Forms.Button cshow;
        private System.Windows.Forms.DataGridView clientinfotable;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton crbFemale;
        private System.Windows.Forms.RadioButton crbMale;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage trainertab;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox thinch;
        private System.Windows.Forms.ComboBox thft;
        private System.Windows.Forms.Button tInsert;
        private System.Windows.Forms.Button tUpdate;
        private System.Windows.Forms.Button tDelete;
        private System.Windows.Forms.Button tClearAll;
        private System.Windows.Forms.DataGridView trainerinfotable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton trbFemale;
        private System.Windows.Forms.RadioButton trbMale;
        private System.Windows.Forms.DateTimePicker tdob;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tuname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tweight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tphone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tShowAll;
    }
}