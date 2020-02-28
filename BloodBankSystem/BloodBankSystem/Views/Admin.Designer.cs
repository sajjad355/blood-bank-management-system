namespace BloodBankSystem.Views
{
    partial class Admin
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonBloodStock = new System.Windows.Forms.Button();
            this.buttonMember = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(147, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 64);
            this.label6.TabIndex = 14;
            this.label6.Text = "Life Saver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-12, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 146);
            this.panel1.TabIndex = 26;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::BloodBankSystem.Properties.Resources.Go_back_icon2;
            this.buttonBack.Location = new System.Drawing.Point(1130, 17);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 62);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BloodBankSystem.Properties.Resources.l1;
            this.pictureBox6.Location = new System.Drawing.Point(30, 17);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(108, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::BloodBankSystem.Properties.Resources.home_icon12;
            this.buttonHome.Location = new System.Drawing.Point(1060, 17);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(60, 62);
            this.buttonHome.TabIndex = 19;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.HomeButtonClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(-12, 749);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 108);
            this.panel2.TabIndex = 27;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.Maroon;
            this.buttonHistory.Location = new System.Drawing.Point(598, 568);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(272, 105);
            this.buttonHistory.TabIndex = 10;
            this.buttonHistory.Text = "All History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.HistoryButtonClick);
            // 
            // buttonBloodStock
            // 
            this.buttonBloodStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBloodStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodStock.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBloodStock.Location = new System.Drawing.Point(598, 255);
            this.buttonBloodStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBloodStock.Name = "buttonBloodStock";
            this.buttonBloodStock.Size = new System.Drawing.Size(272, 103);
            this.buttonBloodStock.TabIndex = 9;
            this.buttonBloodStock.Text = "Blood Stock";
            this.buttonBloodStock.UseVisualStyleBackColor = false;
            this.buttonBloodStock.Click += new System.EventHandler(this.StockButtonClick);
            // 
            // buttonMember
            // 
            this.buttonMember.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMember.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMember.Location = new System.Drawing.Point(598, 412);
            this.buttonMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMember.Name = "buttonMember";
            this.buttonMember.Size = new System.Drawing.Size(272, 105);
            this.buttonMember.TabIndex = 29;
            this.buttonMember.Text = "Member Information";
            this.buttonMember.UseVisualStyleBackColor = false;
            this.buttonMember.Click += new System.EventHandler(this.MemberInformationButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBankSystem.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(146, 278);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(592, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Administration";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1216, 856);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMember);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBloodStock);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonBloodStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMember;
        private System.Windows.Forms.Label label1;
    }
}