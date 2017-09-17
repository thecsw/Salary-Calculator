namespace WindowsFormsApp1
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.nameTT = new System.Windows.Forms.TextBox();
            this.MR = new System.Windows.Forms.CheckBox();
            this.MRS = new System.Windows.Forms.CheckBox();
            this.MS = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ADMIN = new System.Windows.Forms.CheckBox();
            this.SUPER = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ACC = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTT
            // 
            this.nameTT.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTT.Location = new System.Drawing.Point(162, 79);
            this.nameTT.Name = "nameTT";
            this.nameTT.Size = new System.Drawing.Size(117, 34);
            this.nameTT.TabIndex = 0;
            // 
            // MR
            // 
            this.MR.AutoSize = true;
            this.MR.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MR.Location = new System.Drawing.Point(77, 119);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(54, 29);
            this.MR.TabIndex = 1;
            this.MR.Text = "Mr.";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // MRS
            // 
            this.MRS.AutoSize = true;
            this.MRS.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRS.Location = new System.Drawing.Point(200, 119);
            this.MRS.Name = "MRS";
            this.MRS.Size = new System.Drawing.Size(63, 29);
            this.MRS.TabIndex = 2;
            this.MRS.Text = "Mrs.";
            this.MRS.UseVisualStyleBackColor = true;
            this.MRS.Click += new System.EventHandler(this.MRS_Click);
            // 
            // MS
            // 
            this.MS.AutoSize = true;
            this.MS.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS.Location = new System.Drawing.Point(137, 119);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(57, 29);
            this.MS.TabIndex = 3;
            this.MS.Text = "Ms.";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADMIN
            // 
            this.ADMIN.AutoSize = true;
            this.ADMIN.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.Location = new System.Drawing.Point(20, 28);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(67, 23);
            this.ADMIN.TabIndex = 7;
            this.ADMIN.Text = "Admin";
            this.ADMIN.UseVisualStyleBackColor = true;
            this.ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // SUPER
            // 
            this.SUPER.AutoSize = true;
            this.SUPER.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPER.Location = new System.Drawing.Point(192, 28);
            this.SUPER.Name = "SUPER";
            this.SUPER.Size = new System.Drawing.Size(90, 23);
            this.SUPER.TabIndex = 8;
            this.SUPER.Text = "Supervisor";
            this.SUPER.UseVisualStyleBackColor = true;
            this.SUPER.Click += new System.EventHandler(this.USER_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ACC);
            this.groupBox1.Controls.Add(this.SUPER);
            this.groupBox1.Controls.Add(this.ADMIN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login as";
            // 
            // ACC
            // 
            this.ACC.AutoSize = true;
            this.ACC.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACC.Location = new System.Drawing.Point(93, 28);
            this.ACC.Name = "ACC";
            this.ACC.Size = new System.Drawing.Size(93, 23);
            this.ACC.TabIndex = 9;
            this.ACC.Text = "Accountant";
            this.ACC.UseVisualStyleBackColor = true;
            this.ACC.Click += new System.EventHandler(this.ACC_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(338, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MRS);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.nameTT);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(338, 271);
            this.MinimumSize = new System.Drawing.Size(338, 271);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginWindow_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTT;
        private System.Windows.Forms.CheckBox MR;
        private System.Windows.Forms.CheckBox MRS;
        private System.Windows.Forms.CheckBox MS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ADMIN;
        private System.Windows.Forms.CheckBox SUPER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ACC;
    }
}