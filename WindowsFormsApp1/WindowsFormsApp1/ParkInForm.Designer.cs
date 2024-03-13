namespace WindowsFormsApp1
{
    partial class ParkInForm
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
            this.DashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.ParkInButton2 = new System.Windows.Forms.Button();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.Brandlabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.Typelabel = new System.Windows.Forms.Label();
            this.PNtextBox = new System.Windows.Forms.TextBox();
            this.PNlabel = new System.Windows.Forms.Label();
            this.VIlabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 530);
            this.panel1.TabIndex = 0;
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
            this.DashboardButton.TabIndex = 3;
            this.DashboardButton.Text = "< Back";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.detailsLabel2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.detailsLabel);
            this.panel2.Controls.Add(this.ParkInButton2);
            this.panel2.Controls.Add(this.BrandComboBox);
            this.panel2.Controls.Add(this.Brandlabel);
            this.panel2.Controls.Add(this.TypeComboBox);
            this.panel2.Controls.Add(this.Typelabel);
            this.panel2.Controls.Add(this.PNtextBox);
            this.panel2.Controls.Add(this.PNlabel);
            this.panel2.Controls.Add(this.VIlabel);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 530);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cost";
            // 
            // detailsLabel2
            // 
            this.detailsLabel2.AutoSize = true;
            this.detailsLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.detailsLabel2.Location = new System.Drawing.Point(9, 296);
            this.detailsLabel2.Name = "detailsLabel2";
            this.detailsLabel2.Size = new System.Drawing.Size(17, 24);
            this.detailsLabel2.TabIndex = 15;
            this.detailsLabel2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vehicle Summary";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.ForeColor = System.Drawing.Color.DimGray;
            this.detailsLabel.Location = new System.Drawing.Point(9, 176);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(17, 24);
            this.detailsLabel.TabIndex = 13;
            this.detailsLabel.Text = "-";
            this.detailsLabel.Click += new System.EventHandler(this.detailsLabel_Click);
            // 
            // ParkInButton2
            // 
            this.ParkInButton2.BackColor = System.Drawing.Color.DimGray;
            this.ParkInButton2.FlatAppearance.BorderSize = 0;
            this.ParkInButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkInButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkInButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.ParkInButton2.Location = new System.Drawing.Point(386, 459);
            this.ParkInButton2.Name = "ParkInButton2";
            this.ParkInButton2.Size = new System.Drawing.Size(152, 59);
            this.ParkInButton2.TabIndex = 12;
            this.ParkInButton2.Text = "Park In";
            this.ParkInButton2.UseVisualStyleBackColor = false;
            this.ParkInButton2.Click += new System.EventHandler(this.ParkInButton2_Click);
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(307, 98);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(152, 32);
            this.BrandComboBox.TabIndex = 11;
            this.BrandComboBox.Text = "Select";
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // Brandlabel
            // 
            this.Brandlabel.AutoSize = true;
            this.Brandlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brandlabel.ForeColor = System.Drawing.Color.DimGray;
            this.Brandlabel.Location = new System.Drawing.Point(232, 101);
            this.Brandlabel.Name = "Brandlabel";
            this.Brandlabel.Size = new System.Drawing.Size(69, 24);
            this.Brandlabel.TabIndex = 10;
            this.Brandlabel.Text = "Brand";
            this.Brandlabel.Click += new System.EventHandler(this.Brandlabel_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(71, 98);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(152, 32);
            this.TypeComboBox.TabIndex = 9;
            this.TypeComboBox.Text = "Select";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typelabel.ForeColor = System.Drawing.Color.DimGray;
            this.Typelabel.Location = new System.Drawing.Point(8, 101);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(57, 24);
            this.Typelabel.TabIndex = 8;
            this.Typelabel.Text = "Type";
            this.Typelabel.Click += new System.EventHandler(this.Typelabel_Click);
            // 
            // PNtextBox
            // 
            this.PNtextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNtextBox.Location = new System.Drawing.Point(166, 59);
            this.PNtextBox.Name = "PNtextBox";
            this.PNtextBox.Size = new System.Drawing.Size(152, 33);
            this.PNtextBox.TabIndex = 7;
            this.PNtextBox.TextChanged += new System.EventHandler(this.PNtextBox_TextChanged);
            // 
            // PNlabel
            // 
            this.PNlabel.AutoSize = true;
            this.PNlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNlabel.ForeColor = System.Drawing.Color.DimGray;
            this.PNlabel.Location = new System.Drawing.Point(8, 62);
            this.PNlabel.Name = "PNlabel";
            this.PNlabel.Size = new System.Drawing.Size(152, 24);
            this.PNlabel.TabIndex = 5;
            this.PNlabel.Text = "Plate Number";
            // 
            // VIlabel
            // 
            this.VIlabel.AutoSize = true;
            this.VIlabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIlabel.ForeColor = System.Drawing.Color.DimGray;
            this.VIlabel.Location = new System.Drawing.Point(6, 9);
            this.VIlabel.Name = "VIlabel";
            this.VIlabel.Size = new System.Drawing.Size(309, 33);
            this.VIlabel.TabIndex = 4;
            this.VIlabel.Text = "VEHICLE INFORMATION";
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
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ParkInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParkInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkInForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label VIlabel;
        private System.Windows.Forms.Label PNlabel;
        private System.Windows.Forms.TextBox PNtextBox;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.Label Brandlabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.Button ParkInButton2;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label detailsLabel2;
        private System.Windows.Forms.Label label3;
    }
}