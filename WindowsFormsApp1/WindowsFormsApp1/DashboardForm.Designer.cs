namespace WindowsFormsApp1
{
    partial class DashboardForm
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
            this.ParkInButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VIlabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PlateNumberComboBox = new System.Windows.Forms.ComboBox();
            this.ParkOutButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.ParkInButton);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 530);
            this.panel1.TabIndex = 0;
            // 
            // ParkInButton
            // 
            this.ParkInButton.FlatAppearance.BorderSize = 0;
            this.ParkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkInButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkInButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ParkInButton.Location = new System.Drawing.Point(0, 122);
            this.ParkInButton.Name = "ParkInButton";
            this.ParkInButton.Size = new System.Drawing.Size(200, 54);
            this.ParkInButton.TabIndex = 3;
            this.ParkInButton.Text = "Park In";
            this.ParkInButton.UseVisualStyleBackColor = true;
            this.ParkInButton.Click += new System.EventHandler(this.ParkInButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogoutButton.Location = new System.Drawing.Point(0, 182);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(200, 54);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DashboardButton.Location = new System.Drawing.Point(0, 62);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(200, 54);
            this.DashboardButton.TabIndex = 2;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.ParkOutButton);
            this.panel2.Controls.Add(this.PlateNumberComboBox);
            this.panel2.Controls.Add(this.VIlabel);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 530);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // VIlabel
            // 
            this.VIlabel.AutoSize = true;
            this.VIlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIlabel.ForeColor = System.Drawing.Color.DimGray;
            this.VIlabel.Location = new System.Drawing.Point(20, 69);
            this.VIlabel.Name = "VIlabel";
            this.VIlabel.Size = new System.Drawing.Size(392, 33);
            this.VIlabel.TabIndex = 5;
            this.VIlabel.Text = "CURRENTLY PARKED VEHICLES";
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(510, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PlateNumberComboBox
            // 
            this.PlateNumberComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateNumberComboBox.FormattingEnabled = true;
            this.PlateNumberComboBox.Location = new System.Drawing.Point(26, 314);
            this.PlateNumberComboBox.Name = "PlateNumberComboBox";
            this.PlateNumberComboBox.Size = new System.Drawing.Size(162, 30);
            this.PlateNumberComboBox.TabIndex = 7;
            this.PlateNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.PlateNumberComboBox_SelectedIndexChanged);
            // 
            // ParkOutButton
            // 
            this.ParkOutButton.BackColor = System.Drawing.Color.DimGray;
            this.ParkOutButton.FlatAppearance.BorderSize = 0;
            this.ParkOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkOutButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkOutButton.Location = new System.Drawing.Point(194, 315);
            this.ParkOutButton.Name = "ParkOutButton";
            this.ParkOutButton.Size = new System.Drawing.Size(63, 29);
            this.ParkOutButton.TabIndex = 8;
            this.ParkOutButton.UseVisualStyleBackColor = false;
            this.ParkOutButton.Click += new System.EventHandler(this.ParkOutButton_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 100);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(20, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Park Out Here";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button ParkInButton;
        private System.Windows.Forms.Label VIlabel;
        private System.Windows.Forms.ComboBox PlateNumberComboBox;
        private System.Windows.Forms.Button ParkOutButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}