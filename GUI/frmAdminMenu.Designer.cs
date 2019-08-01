namespace GUI
{
    partial class frmAdminMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btnRestock = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogRecord = new System.Windows.Forms.Button();
            this.btnSaleRecord = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRestock);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.btnLogRecord);
            this.panel1.Controls.Add(this.btnSaleRecord);
            this.panel1.Controls.Add(this.btnProductManagement);
            this.panel1.Controls.Add(this.btnStaffManagement);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GUI.Properties.Resources.Logo2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lbl7);
            this.panel2.Location = new System.Drawing.Point(29, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 46);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.SkyBlue;
            this.lbl7.Location = new System.Drawing.Point(46, 30);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(100, 5);
            this.lbl7.TabIndex = 19;
            // 
            // btnRestock
            // 
            this.btnRestock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.Location = new System.Drawing.Point(700, 5);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(100, 34);
            this.btnRestock.TabIndex = 7;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.BtnRestock_Click);
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(700, 38);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(100, 5);
            this.lbl6.TabIndex = 17;
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(600, 38);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 5);
            this.lbl5.TabIndex = 16;
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(500, 38);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 5);
            this.lbl4.TabIndex = 15;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(400, 38);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 5);
            this.lbl3.TabIndex = 14;
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(300, 38);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 5);
            this.lbl2.TabIndex = 13;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(200, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 5);
            this.lbl1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::GUI.Properties.Resources.cancel;
            this.btnExit.Location = new System.Drawing.Point(908, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(806, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(90, 20);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // btnLogRecord
            // 
            this.btnLogRecord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogRecord.FlatAppearance.BorderSize = 0;
            this.btnLogRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogRecord.Location = new System.Drawing.Point(600, 5);
            this.btnLogRecord.Name = "btnLogRecord";
            this.btnLogRecord.Size = new System.Drawing.Size(100, 34);
            this.btnLogRecord.TabIndex = 6;
            this.btnLogRecord.Text = "Log";
            this.btnLogRecord.UseVisualStyleBackColor = true;
            this.btnLogRecord.Click += new System.EventHandler(this.BtnLogRecord_Click);
            // 
            // btnSaleRecord
            // 
            this.btnSaleRecord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaleRecord.FlatAppearance.BorderSize = 0;
            this.btnSaleRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleRecord.Location = new System.Drawing.Point(500, 5);
            this.btnSaleRecord.Name = "btnSaleRecord";
            this.btnSaleRecord.Size = new System.Drawing.Size(100, 34);
            this.btnSaleRecord.TabIndex = 5;
            this.btnSaleRecord.Text = "Sale Record";
            this.btnSaleRecord.UseVisualStyleBackColor = true;
            this.btnSaleRecord.Click += new System.EventHandler(this.BtnSaleRecord_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductManagement.FlatAppearance.BorderSize = 0;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.Location = new System.Drawing.Point(400, 5);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(100, 34);
            this.btnProductManagement.TabIndex = 4;
            this.btnProductManagement.Text = "Product";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.BtnProductManagement_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStaffManagement.FlatAppearance.BorderSize = 0;
            this.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffManagement.Location = new System.Drawing.Point(300, 5);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(100, 34);
            this.btnStaffManagement.TabIndex = 3;
            this.btnStaffManagement.Text = "Staff Manage";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.BtnStaffManagement_Click);
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(200, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 34);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMenu";
            this.Load += new System.EventHandler(this.FrmAdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnLogRecord;
        private System.Windows.Forms.Button btnSaleRecord;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl7;
    }
}