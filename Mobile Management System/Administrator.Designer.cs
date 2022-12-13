namespace Mobile_Management_System
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnverify = new Guna.UI2.WinForms.Guna2Button();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndeletephone = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomerrecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnstock = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddnewphone = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Customer_Records1 = new Mobile_Management_System.Administrator_UC.UC_Customer_Records();
            this.uC_Stock1 = new Mobile_Management_System.Administrator_UC.UC_Stock();
            this.uC_Customer1 = new Mobile_Management_System.Administrator_UC.UC_Customer();
            this.uC_AddNewPhone1 = new Mobile_Management_System.Administrator_UC.UC_AddNewPhone();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Delete_Phone_Record1 = new Mobile_Management_System.Administrator_UC.UC_Delete_Phone_Record();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnverify);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.btndeletephone);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btncustomerrecords);
            this.panel1.Controls.Add(this.btnstock);
            this.panel1.Controls.Add(this.btncustomer);
            this.panel1.Controls.Add(this.btnaddnewphone);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 768);
            this.panel1.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.Animated = true;
            this.btncancel.AutoRoundedCorners = true;
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BorderRadius = 14;
            this.btncancel.CheckedState.Parent = this.btncancel;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.CustomImages.Parent = this.btncancel;
            this.btncancel.FillColor = System.Drawing.Color.White;
            this.btncancel.Font = new System.Drawing.Font("Satoshi Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btncancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncancel.HoverState.Parent = this.btncancel;
            this.btncancel.Location = new System.Drawing.Point(135, 591);
            this.btncancel.Name = "btncancel";
            this.btncancel.PressedColor = System.Drawing.Color.White;
            this.btncancel.ShadowDecoration.Parent = this.btncancel;
            this.btncancel.Size = new System.Drawing.Size(82, 31);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnverify
            // 
            this.btnverify.Animated = true;
            this.btnverify.AutoRoundedCorners = true;
            this.btnverify.BackColor = System.Drawing.Color.Transparent;
            this.btnverify.BorderRadius = 14;
            this.btnverify.CheckedState.Parent = this.btnverify;
            this.btnverify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverify.CustomImages.Parent = this.btnverify;
            this.btnverify.FillColor = System.Drawing.Color.White;
            this.btnverify.Font = new System.Drawing.Font("Satoshi Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.ForeColor = System.Drawing.Color.Black;
            this.btnverify.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnverify.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnverify.HoverState.Parent = this.btnverify;
            this.btnverify.Location = new System.Drawing.Point(17, 591);
            this.btnverify.Name = "btnverify";
            this.btnverify.PressedColor = System.Drawing.Color.White;
            this.btnverify.ShadowDecoration.Parent = this.btnverify;
            this.btnverify.Size = new System.Drawing.Size(82, 31);
            this.btnverify.TabIndex = 6;
            this.btnverify.Text = "Verify";
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Animated = true;
            this.txtpassword.AutoRoundedCorners = true;
            this.txtpassword.BorderRadius = 17;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(17, 537);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '▪';
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(200, 36);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndeletephone
            // 
            this.btndeletephone.Animated = true;
            this.btndeletephone.AutoRoundedCorners = true;
            this.btndeletephone.BorderRadius = 21;
            this.btndeletephone.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndeletephone.CheckedState.Parent = this.btndeletephone;
            this.btndeletephone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletephone.CustomImages.Parent = this.btndeletephone;
            this.btndeletephone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.btndeletephone.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletephone.ForeColor = System.Drawing.Color.White;
            this.btndeletephone.HoverState.FillColor = System.Drawing.Color.Red;
            this.btndeletephone.HoverState.ForeColor = System.Drawing.Color.White;
            this.btndeletephone.HoverState.Parent = this.btndeletephone;
            this.btndeletephone.Location = new System.Drawing.Point(17, 470);
            this.btndeletephone.Name = "btndeletephone";
            this.btndeletephone.PressedColor = System.Drawing.Color.White;
            this.btndeletephone.ShadowDecoration.Parent = this.btndeletephone;
            this.btndeletephone.Size = new System.Drawing.Size(200, 45);
            this.btndeletephone.TabIndex = 0;
            this.btndeletephone.Text = "Delete Records";
            this.btndeletephone.Click += new System.EventHandler(this.btndeletephone_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Animated = true;
            this.btnlogout.AutoRoundedCorners = true;
            this.btnlogout.BorderRadius = 21;
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.btnlogout.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnlogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Location = new System.Drawing.Point(53, 686);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.PressedColor = System.Drawing.Color.White;
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(129, 45);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btncustomerrecords
            // 
            this.btncustomerrecords.Animated = true;
            this.btncustomerrecords.AutoRoundedCorners = true;
            this.btncustomerrecords.BorderRadius = 21;
            this.btncustomerrecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncustomerrecords.CheckedState.Parent = this.btncustomerrecords;
            this.btncustomerrecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomerrecords.CustomImages.Parent = this.btncustomerrecords;
            this.btncustomerrecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.btncustomerrecords.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerrecords.ForeColor = System.Drawing.Color.White;
            this.btncustomerrecords.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btncustomerrecords.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncustomerrecords.HoverState.Parent = this.btncustomerrecords;
            this.btncustomerrecords.Location = new System.Drawing.Point(17, 388);
            this.btncustomerrecords.Name = "btncustomerrecords";
            this.btncustomerrecords.PressedColor = System.Drawing.Color.White;
            this.btncustomerrecords.ShadowDecoration.Parent = this.btncustomerrecords;
            this.btncustomerrecords.Size = new System.Drawing.Size(200, 45);
            this.btncustomerrecords.TabIndex = 0;
            this.btncustomerrecords.Text = "Customer Records";
            this.btncustomerrecords.Click += new System.EventHandler(this.btncustomerrecords_Click);
            // 
            // btnstock
            // 
            this.btnstock.Animated = true;
            this.btnstock.AutoRoundedCorners = true;
            this.btnstock.BorderRadius = 21;
            this.btnstock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnstock.CheckedState.Parent = this.btnstock;
            this.btnstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstock.CustomImages.Parent = this.btnstock;
            this.btnstock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.btnstock.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.White;
            this.btnstock.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnstock.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnstock.HoverState.Parent = this.btnstock;
            this.btnstock.Location = new System.Drawing.Point(17, 305);
            this.btnstock.Name = "btnstock";
            this.btnstock.PressedColor = System.Drawing.Color.White;
            this.btnstock.ShadowDecoration.Parent = this.btnstock;
            this.btnstock.Size = new System.Drawing.Size(200, 45);
            this.btnstock.TabIndex = 0;
            this.btnstock.Text = "Stock";
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Animated = true;
            this.btncustomer.AutoRoundedCorners = true;
            this.btncustomer.BorderRadius = 21;
            this.btncustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncustomer.CheckedState.Parent = this.btncustomer;
            this.btncustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomer.CustomImages.Parent = this.btncustomer;
            this.btncustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.btncustomer.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.ForeColor = System.Drawing.Color.White;
            this.btncustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btncustomer.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncustomer.HoverState.Parent = this.btncustomer;
            this.btncustomer.Location = new System.Drawing.Point(17, 221);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.PressedColor = System.Drawing.Color.White;
            this.btncustomer.ShadowDecoration.Parent = this.btncustomer;
            this.btncustomer.Size = new System.Drawing.Size(200, 45);
            this.btncustomer.TabIndex = 0;
            this.btncustomer.Text = "Customers";
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnaddnewphone
            // 
            this.btnaddnewphone.Animated = true;
            this.btnaddnewphone.AutoRoundedCorners = true;
            this.btnaddnewphone.BorderRadius = 21;
            this.btnaddnewphone.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnaddnewphone.CheckedState.Parent = this.btnaddnewphone;
            this.btnaddnewphone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddnewphone.CustomImages.Parent = this.btnaddnewphone;
            this.btnaddnewphone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.btnaddnewphone.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnewphone.ForeColor = System.Drawing.Color.White;
            this.btnaddnewphone.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnaddnewphone.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnaddnewphone.HoverState.Parent = this.btnaddnewphone;
            this.btnaddnewphone.Location = new System.Drawing.Point(17, 140);
            this.btnaddnewphone.Name = "btnaddnewphone";
            this.btnaddnewphone.PressedColor = System.Drawing.Color.White;
            this.btnaddnewphone.ShadowDecoration.Parent = this.btnaddnewphone;
            this.btnaddnewphone.Size = new System.Drawing.Size(200, 45);
            this.btnaddnewphone.TabIndex = 0;
            this.btnaddnewphone.Text = "Add New Phone";
            this.btnaddnewphone.Click += new System.EventHandler(this.btnaddnewphone_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_Delete_Phone_Record1);
            this.panel2.Controls.Add(this.uC_Customer_Records1);
            this.panel2.Controls.Add(this.uC_Stock1);
            this.panel2.Controls.Add(this.uC_Customer1);
            this.panel2.Controls.Add(this.uC_AddNewPhone1);
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 768);
            this.panel2.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 0;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 0;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 0;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_Customer_Records1
            // 
            this.uC_Customer_Records1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Customer_Records1.BackgroundImage")));
            this.uC_Customer_Records1.Location = new System.Drawing.Point(3, 0);
            this.uC_Customer_Records1.Name = "uC_Customer_Records1";
            this.uC_Customer_Records1.Size = new System.Drawing.Size(1130, 768);
            this.uC_Customer_Records1.TabIndex = 3;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Stock1.BackgroundImage")));
            this.uC_Stock1.Location = new System.Drawing.Point(3, 0);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(1130, 768);
            this.uC_Stock1.TabIndex = 2;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Customer1.BackgroundImage")));
            this.uC_Customer1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1130, 768);
            this.uC_Customer1.TabIndex = 1;
            // 
            // uC_AddNewPhone1
            // 
            this.uC_AddNewPhone1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_AddNewPhone1.BackgroundImage")));
            this.uC_AddNewPhone1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewPhone1.Name = "uC_AddNewPhone1";
            this.uC_AddNewPhone1.Size = new System.Drawing.Size(1130, 768);
            this.uC_AddNewPhone1.TabIndex = 0;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 0;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // uC_Delete_Phone_Record1
            // 
            this.uC_Delete_Phone_Record1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Delete_Phone_Record1.BackgroundImage")));
            this.uC_Delete_Phone_Record1.Location = new System.Drawing.Point(0, 0);
            this.uC_Delete_Phone_Record1.Name = "uC_Delete_Phone_Record1";
            this.uC_Delete_Phone_Record1.Size = new System.Drawing.Size(1130, 768);
            this.uC_Delete_Phone_Record1.TabIndex = 4;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private Guna.UI2.WinForms.Guna2Button btnverify;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2Button btndeletephone;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btncustomerrecords;
        private Guna.UI2.WinForms.Guna2Button btnstock;
        private Guna.UI2.WinForms.Guna2Button btncustomer;
        private Guna.UI2.WinForms.Guna2Button btnaddnewphone;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Administrator_UC.UC_AddNewPhone uC_AddNewPhone1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Administrator_UC.UC_Customer uC_Customer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Administrator_UC.UC_Stock uC_Stock1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Administrator_UC.UC_Customer_Records uC_Customer_Records1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Administrator_UC.UC_Delete_Phone_Record uC_Delete_Phone_Record1;
    }
}