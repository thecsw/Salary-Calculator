namespace WindowsFormsApp1
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.nameT = new System.Windows.Forms.TextBox();
            this.surnameT = new System.Windows.Forms.TextBox();
            this.eduC = new System.Windows.Forms.CheckedListBox();
            this.employeeL = new System.Windows.Forms.ListView();
            this.nameL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.premiumL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameLB = new System.Windows.Forms.Label();
            this.surnameLB = new System.Windows.Forms.Label();
            this.eduLB = new System.Windows.Forms.Label();
            this.skipLB = new System.Windows.Forms.Label();
            this.perfLB = new System.Windows.Forms.Label();
            this.skipT = new System.Windows.Forms.TextBox();
            this.finT = new System.Windows.Forms.TextBox();
            this.budgetLB = new System.Windows.Forms.Label();
            this.premLB = new System.Windows.Forms.Label();
            this.budgetT = new System.Windows.Forms.TextBox();
            this.premiumC = new System.Windows.Forms.CheckBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.amountGR = new System.Windows.Forms.GroupBox();
            this.emplGR = new System.Windows.Forms.GroupBox();
            this.imsize = new System.Windows.Forms.Label();
            this.uploadB = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.DEBIG = new System.Windows.Forms.Button();
            this.developerLB = new System.Windows.Forms.Label();
            this.loadTimer = new System.Windows.Forms.Timer(this.components);
            this.SEE = new System.Windows.Forms.Timer(this.components);
            this.preferGR = new System.Windows.Forms.GroupBox();
            this.loggedL = new System.Windows.Forms.Label();
            this.openGraphB = new System.Windows.Forms.Button();
            this.analyzedGR = new System.Windows.Forms.GroupBox();
            this.rep = new System.Windows.Forms.Button();
            this.IQR = new System.Windows.Forms.Label();
            this.deviationLB = new System.Windows.Forms.Label();
            this.upper = new System.Windows.Forms.Label();
            this.lower = new System.Windows.Forms.Label();
            this.medianLB = new System.Windows.Forms.Label();
            this.averageSalaryLB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DELALL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadProfile = new System.Windows.Forms.Timer(this.components);
            this.SAVEDT = new System.Windows.Forms.Label();
            this.savanim = new System.Windows.Forms.Timer(this.components);
            this.amountGR.SuspendLayout();
            this.emplGR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.preferGR.SuspendLayout();
            this.analyzedGR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 331);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.addB_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(74, 331);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 23);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.editB_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(130, 331);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(56, 23);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.removeB_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(202, 331);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(50, 23);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.sortB_Click);
            // 
            // nameT
            // 
            this.nameT.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameT.Location = new System.Drawing.Point(271, 31);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(120, 23);
            this.nameT.TabIndex = 10;
            // 
            // surnameT
            // 
            this.surnameT.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameT.Location = new System.Drawing.Point(271, 62);
            this.surnameT.Name = "surnameT";
            this.surnameT.Size = new System.Drawing.Size(120, 23);
            this.surnameT.TabIndex = 11;
            // 
            // eduC
            // 
            this.eduC.CheckOnClick = true;
            this.eduC.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eduC.FormattingEnabled = true;
            this.eduC.Items.AddRange(new object[] {
            "Secondary School",
            "High School",
            "College",
            "University",
            "Masters Degree"});
            this.eduC.Location = new System.Drawing.Point(271, 93);
            this.eduC.Name = "eduC";
            this.eduC.Size = new System.Drawing.Size(120, 89);
            this.eduC.TabIndex = 12;
            this.eduC.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.eduC_ItemCheck);
            // 
            // employeeL
            // 
            this.employeeL.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.employeeL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameL,
            this.salaryL,
            this.premiumL,
            this.IDnumber});
            this.employeeL.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeL.Location = new System.Drawing.Point(18, 17);
            this.employeeL.Name = "employeeL";
            this.employeeL.Size = new System.Drawing.Size(234, 308);
            this.employeeL.TabIndex = 13;
            this.employeeL.UseCompatibleStateImageBehavior = false;
            this.employeeL.View = System.Windows.Forms.View.Details;
            this.employeeL.Click += new System.EventHandler(this.employeeL_Click);
            this.employeeL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.employeeL_MouseUp);
            // 
            // nameL
            // 
            this.nameL.Text = "Full Name";
            this.nameL.Width = 106;
            // 
            // salaryL
            // 
            this.salaryL.Text = "Salary";
            this.salaryL.Width = 56;
            // 
            // premiumL
            // 
            this.premiumL.Text = "Premium";
            this.premiumL.Width = 67;
            // 
            // IDnumber
            // 
            this.IDnumber.Text = "ID";
            this.IDnumber.Width = 0;
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.Location = new System.Drawing.Point(149, 33);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(50, 21);
            this.nameLB.TabIndex = 14;
            this.nameLB.Text = "Name";
            // 
            // surnameLB
            // 
            this.surnameLB.AutoSize = true;
            this.surnameLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLB.Location = new System.Drawing.Point(149, 62);
            this.surnameLB.Name = "surnameLB";
            this.surnameLB.Size = new System.Drawing.Size(70, 21);
            this.surnameLB.TabIndex = 15;
            this.surnameLB.Text = "Surname";
            // 
            // eduLB
            // 
            this.eduLB.AutoSize = true;
            this.eduLB.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eduLB.Location = new System.Drawing.Point(149, 121);
            this.eduLB.Name = "eduLB";
            this.eduLB.Size = new System.Drawing.Size(121, 20);
            this.eduLB.TabIndex = 16;
            this.eduLB.Text = "Academic Degree";
            // 
            // skipLB
            // 
            this.skipLB.AutoSize = true;
            this.skipLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipLB.Location = new System.Drawing.Point(149, 193);
            this.skipLB.Name = "skipLB";
            this.skipLB.Size = new System.Drawing.Size(171, 21);
            this.skipLB.TabIndex = 18;
            this.skipLB.Text = "Number of skipped days";
            // 
            // perfLB
            // 
            this.perfLB.AutoSize = true;
            this.perfLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfLB.Location = new System.Drawing.Point(149, 221);
            this.perfLB.Name = "perfLB";
            this.perfLB.Size = new System.Drawing.Size(111, 21);
            this.perfLB.TabIndex = 19;
            this.perfLB.Text = "Professionalism";
            // 
            // skipT
            // 
            this.skipT.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipT.Location = new System.Drawing.Point(326, 191);
            this.skipT.Name = "skipT";
            this.skipT.Size = new System.Drawing.Size(65, 23);
            this.skipT.TabIndex = 20;
            this.skipT.Text = "0";
            this.skipT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skipT_KeyPress);
            // 
            // finT
            // 
            this.finT.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finT.Location = new System.Drawing.Point(348, 219);
            this.finT.Name = "finT";
            this.finT.Size = new System.Drawing.Size(42, 23);
            this.finT.TabIndex = 21;
            this.finT.Text = "0";
            this.finT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.finT_KeyPress);
            // 
            // budgetLB
            // 
            this.budgetLB.AutoSize = true;
            this.budgetLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLB.Location = new System.Drawing.Point(337, 341);
            this.budgetLB.Name = "budgetLB";
            this.budgetLB.Size = new System.Drawing.Size(59, 21);
            this.budgetLB.TabIndex = 22;
            this.budgetLB.Text = "Budget";
            // 
            // premLB
            // 
            this.premLB.AutoSize = true;
            this.premLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premLB.Location = new System.Drawing.Point(489, 341);
            this.premLB.Name = "premLB";
            this.premLB.Size = new System.Drawing.Size(105, 21);
            this.premLB.TabIndex = 23;
            this.premLB.Text = "With premium";
            // 
            // budgetT
            // 
            this.budgetT.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetT.Location = new System.Drawing.Point(402, 341);
            this.budgetT.Name = "budgetT";
            this.budgetT.Size = new System.Drawing.Size(81, 23);
            this.budgetT.TabIndex = 24;
            this.budgetT.Text = "0";
            this.budgetT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budgetT_KeyPress);
            // 
            // premiumC
            // 
            this.premiumC.AutoSize = true;
            this.premiumC.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumC.Location = new System.Drawing.Point(598, 347);
            this.premiumC.Name = "premiumC";
            this.premiumC.Size = new System.Drawing.Size(15, 14);
            this.premiumC.TabIndex = 25;
            this.premiumC.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI Semilight", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(300, 391);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(104, 34);
            this.Calculate.TabIndex = 26;
            this.Calculate.Text = "Calculate!";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(410, 396);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(203, 25);
            this.loading.TabIndex = 27;
            // 
            // amountGR
            // 
            this.amountGR.Controls.Add(this.employeeL);
            this.amountGR.Controls.Add(this.SortButton);
            this.amountGR.Controls.Add(this.AddButton);
            this.amountGR.Controls.Add(this.EditButton);
            this.amountGR.Controls.Add(this.RemoveButton);
            this.amountGR.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountGR.Location = new System.Drawing.Point(16, 63);
            this.amountGR.Name = "amountGR";
            this.amountGR.Size = new System.Drawing.Size(267, 362);
            this.amountGR.TabIndex = 28;
            this.amountGR.TabStop = false;
            this.amountGR.Text = "Amount of employees: 0";
            // 
            // emplGR
            // 
            this.emplGR.Controls.Add(this.imsize);
            this.emplGR.Controls.Add(this.uploadB);
            this.emplGR.Controls.Add(this.profilePicture);
            this.emplGR.Controls.Add(this.surnameT);
            this.emplGR.Controls.Add(this.nameT);
            this.emplGR.Controls.Add(this.eduC);
            this.emplGR.Controls.Add(this.nameLB);
            this.emplGR.Controls.Add(this.surnameLB);
            this.emplGR.Controls.Add(this.eduLB);
            this.emplGR.Controls.Add(this.skipLB);
            this.emplGR.Controls.Add(this.perfLB);
            this.emplGR.Controls.Add(this.finT);
            this.emplGR.Controls.Add(this.skipT);
            this.emplGR.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplGR.Location = new System.Drawing.Point(300, 48);
            this.emplGR.Name = "emplGR";
            this.emplGR.Size = new System.Drawing.Size(397, 248);
            this.emplGR.TabIndex = 29;
            this.emplGR.TabStop = false;
            this.emplGR.Text = "Employees Information";
            // 
            // imsize
            // 
            this.imsize.AutoSize = true;
            this.imsize.Font = new System.Drawing.Font("Segoe UI Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imsize.Location = new System.Drawing.Point(35, 221);
            this.imsize.Name = "imsize";
            this.imsize.Size = new System.Drawing.Size(92, 24);
            this.imsize.TabIndex = 24;
            this.imsize.Text = "Recommended Size \r\n          110x150";
            this.imsize.Click += new System.EventHandler(this.imsize_Click);
            // 
            // uploadB
            // 
            this.uploadB.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadB.Location = new System.Drawing.Point(41, 192);
            this.uploadB.Name = "uploadB";
            this.uploadB.Size = new System.Drawing.Size(76, 30);
            this.uploadB.TabIndex = 23;
            this.uploadB.Text = "Upload";
            this.uploadB.UseVisualStyleBackColor = true;
            this.uploadB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // profilePicture
            // 
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePicture.Location = new System.Drawing.Point(23, 36);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(110, 150);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 22;
            this.profilePicture.TabStop = false;
            // 
            // DEBIG
            // 
            this.DEBIG.Location = new System.Drawing.Point(314, 24);
            this.DEBIG.Name = "DEBIG";
            this.DEBIG.Size = new System.Drawing.Size(81, 47);
            this.DEBIG.TabIndex = 35;
            this.DEBIG.Text = "addMax";
            this.DEBIG.UseVisualStyleBackColor = true;
            this.DEBIG.Visible = false;
            this.DEBIG.Click += new System.EventHandler(this.showChart_Click);
            // 
            // developerLB
            // 
            this.developerLB.AutoSize = true;
            this.developerLB.Cursor = System.Windows.Forms.Cursors.Help;
            this.developerLB.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerLB.Location = new System.Drawing.Point(0, 425);
            this.developerLB.Name = "developerLB";
            this.developerLB.Size = new System.Drawing.Size(210, 13);
            this.developerLB.TabIndex = 30;
            this.developerLB.Text = "Developed and tested by Sagindyk Urazayev";
            this.developerLB.Click += new System.EventHandler(this.developer_Click);
            // 
            // loadTimer
            // 
            this.loadTimer.Interval = 1;
            this.loadTimer.Tick += new System.EventHandler(this.loadTimer_Tick);
            // 
            // SEE
            // 
            this.SEE.Enabled = true;
            this.SEE.Interval = 5000;
            this.SEE.Tick += new System.EventHandler(this.SEE_Tick);
            // 
            // preferGR
            // 
            this.preferGR.Controls.Add(this.DEBIG);
            this.preferGR.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferGR.Location = new System.Drawing.Point(302, 302);
            this.preferGR.Name = "preferGR";
            this.preferGR.Size = new System.Drawing.Size(395, 83);
            this.preferGR.TabIndex = 32;
            this.preferGR.TabStop = false;
            this.preferGR.Text = "Budget Preferences";
            // 
            // loggedL
            // 
            this.loggedL.AutoSize = true;
            this.loggedL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedL.ForeColor = System.Drawing.Color.OrangeRed;
            this.loggedL.Location = new System.Drawing.Point(405, 17);
            this.loggedL.Name = "loggedL";
            this.loggedL.Size = new System.Drawing.Size(222, 28);
            this.loggedL.TabIndex = 33;
            this.loggedL.Text = "Welcome, Mr. Urazayev";
            // 
            // openGraphB
            // 
            this.openGraphB.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGraphB.Location = new System.Drawing.Point(18, 330);
            this.openGraphB.Name = "openGraphB";
            this.openGraphB.Size = new System.Drawing.Size(86, 39);
            this.openGraphB.TabIndex = 36;
            this.openGraphB.Text = "Open Salary Graph";
            this.openGraphB.UseVisualStyleBackColor = true;
            this.openGraphB.Click += new System.EventHandler(this.openGraphB_Click);
            // 
            // analyzedGR
            // 
            this.analyzedGR.Controls.Add(this.rep);
            this.analyzedGR.Controls.Add(this.IQR);
            this.analyzedGR.Controls.Add(this.deviationLB);
            this.analyzedGR.Controls.Add(this.upper);
            this.analyzedGR.Controls.Add(this.lower);
            this.analyzedGR.Controls.Add(this.medianLB);
            this.analyzedGR.Controls.Add(this.openGraphB);
            this.analyzedGR.Controls.Add(this.averageSalaryLB);
            this.analyzedGR.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzedGR.Location = new System.Drawing.Point(710, 48);
            this.analyzedGR.Name = "analyzedGR";
            this.analyzedGR.Size = new System.Drawing.Size(197, 377);
            this.analyzedGR.TabIndex = 37;
            this.analyzedGR.TabStop = false;
            this.analyzedGR.Text = "Analyzed Data";
            // 
            // rep
            // 
            this.rep.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rep.Location = new System.Drawing.Point(110, 330);
            this.rep.Name = "rep";
            this.rep.Size = new System.Drawing.Size(70, 39);
            this.rep.TabIndex = 42;
            this.rep.Text = "Output Salary";
            this.rep.UseVisualStyleBackColor = true;
            this.rep.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // IQR
            // 
            this.IQR.AutoSize = true;
            this.IQR.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQR.Location = new System.Drawing.Point(15, 224);
            this.IQR.Name = "IQR";
            this.IQR.Size = new System.Drawing.Size(143, 21);
            this.IQR.TabIndex = 41;
            this.IQR.Text = "Interquartile Range:";
            // 
            // deviationLB
            // 
            this.deviationLB.AutoSize = true;
            this.deviationLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviationLB.Location = new System.Drawing.Point(15, 272);
            this.deviationLB.Name = "deviationLB";
            this.deviationLB.Size = new System.Drawing.Size(142, 21);
            this.deviationLB.TabIndex = 40;
            this.deviationLB.Text = "Standard Deviation:\r\n";
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper.Location = new System.Drawing.Point(15, 177);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(113, 21);
            this.upper.TabIndex = 39;
            this.upper.Text = "Upper Quartile:\r\n";
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower.Location = new System.Drawing.Point(14, 130);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(112, 21);
            this.lower.TabIndex = 38;
            this.lower.Text = "Lower Quartile:\r\n";
            // 
            // medianLB
            // 
            this.medianLB.AutoSize = true;
            this.medianLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianLB.Location = new System.Drawing.Point(15, 84);
            this.medianLB.Name = "medianLB";
            this.medianLB.Size = new System.Drawing.Size(64, 21);
            this.medianLB.TabIndex = 37;
            this.medianLB.Text = "Median:\r\n";
            // 
            // averageSalaryLB
            // 
            this.averageSalaryLB.AutoSize = true;
            this.averageSalaryLB.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageSalaryLB.Location = new System.Drawing.Point(15, 36);
            this.averageSalaryLB.Name = "averageSalaryLB";
            this.averageSalaryLB.Size = new System.Drawing.Size(112, 21);
            this.averageSalaryLB.TabIndex = 0;
            this.averageSalaryLB.Text = "Average Salary:\r\n";
            this.averageSalaryLB.Click += new System.EventHandler(this.averageSalaryLB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(710, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(775, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // DELALL
            // 
            this.DELALL.Location = new System.Drawing.Point(622, 396);
            this.DELALL.Name = "DELALL";
            this.DELALL.Size = new System.Drawing.Size(75, 23);
            this.DELALL.TabIndex = 14;
            this.DELALL.Text = "DELETE ALL";
            this.DELALL.UseVisualStyleBackColor = true;
            this.DELALL.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(907, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // LoadProfile
            // 
            this.LoadProfile.Interval = 50;
            this.LoadProfile.Tick += new System.EventHandler(this.LoadProfile_Tick);
            // 
            // SAVEDT
            // 
            this.SAVEDT.AutoSize = true;
            this.SAVEDT.Cursor = System.Windows.Forms.Cursors.Help;
            this.SAVEDT.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEDT.Location = new System.Drawing.Point(697, 425);
            this.SAVEDT.Name = "SAVEDT";
            this.SAVEDT.Size = new System.Drawing.Size(0, 13);
            this.SAVEDT.TabIndex = 43;
            // 
            // savanim
            // 
            this.savanim.Interval = 1000;
            this.savanim.Tick += new System.EventHandler(this.savanim_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 440);
            this.Controls.Add(this.SAVEDT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELALL);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loggedL);
            this.Controls.Add(this.developerLB);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.premiumC);
            this.Controls.Add(this.budgetT);
            this.Controls.Add(this.premLB);
            this.Controls.Add(this.budgetLB);
            this.Controls.Add(this.amountGR);
            this.Controls.Add(this.emplGR);
            this.Controls.Add(this.preferGR);
            this.Controls.Add(this.analyzedGR);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(930, 440);
            this.MinimumSize = new System.Drawing.Size(930, 440);
            this.Name = "mainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Salary Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.amountGR.ResumeLayout(false);
            this.emplGR.ResumeLayout(false);
            this.emplGR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.preferGR.ResumeLayout(false);
            this.analyzedGR.ResumeLayout(false);
            this.analyzedGR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox surnameT;
        private System.Windows.Forms.ListView employeeL;
        private System.Windows.Forms.ColumnHeader nameL;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label surnameLB;
        private System.Windows.Forms.Label eduLB;
        private System.Windows.Forms.Label skipLB;
        private System.Windows.Forms.Label perfLB;
        private System.Windows.Forms.TextBox skipT;
        private System.Windows.Forms.TextBox finT;
        private System.Windows.Forms.Label budgetLB;
        private System.Windows.Forms.Label premLB;
        private System.Windows.Forms.TextBox budgetT;
        private System.Windows.Forms.CheckBox premiumC;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ColumnHeader salaryL;
        private System.Windows.Forms.ColumnHeader premiumL;
        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.GroupBox amountGR;
        private System.Windows.Forms.GroupBox emplGR;
        private System.Windows.Forms.Label developerLB;
        private System.Windows.Forms.Timer loadTimer;
        private System.Windows.Forms.Timer SEE;
        private System.Windows.Forms.GroupBox preferGR;
        private System.Windows.Forms.Label loggedL;
        private System.Windows.Forms.Button uploadB;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label imsize;
        private System.Windows.Forms.Button DEBIG;
        public System.Windows.Forms.CheckedListBox eduC;
        private System.Windows.Forms.Button openGraphB;
        private System.Windows.Forms.GroupBox analyzedGR;
        private System.Windows.Forms.Label averageSalaryLB;
        private System.Windows.Forms.Label medianLB;
        private System.Windows.Forms.Label lower;
        private System.Windows.Forms.Label upper;
        private System.Windows.Forms.Label deviationLB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label IQR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button DELALL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader IDnumber;
        private System.Windows.Forms.Timer LoadProfile;
        private System.Windows.Forms.Label SAVEDT;
        private System.Windows.Forms.Timer savanim;
        private System.Windows.Forms.Button rep;
    }
}

