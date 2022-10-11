namespace collection_of_class.View
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_account = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbo_service = new System.Windows.Forms.ComboBox();
            this.cbo_time = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_reserve_table = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 51);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome From WY";
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Image = ((System.Drawing.Image)(resources.GetObject("btn_account.Image")));
            this.btn_account.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_account.Location = new System.Drawing.Point(3, 8);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(171, 49);
            this.btn_account.TabIndex = 1;
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-3, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 68);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cbo_service);
            this.panel3.Controls.Add(this.cbo_time);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(64, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 30);
            this.panel3.TabIndex = 2;
            // 
            // cbo_service
            // 
            this.cbo_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_service.FormattingEnabled = true;
            this.cbo_service.Items.AddRange(new object[] {
            "couple (2 people)",
            "family (3-6 people)",
            "group (6-20)"});
            this.cbo_service.Location = new System.Drawing.Point(472, 0);
            this.cbo_service.Name = "cbo_service";
            this.cbo_service.Size = new System.Drawing.Size(183, 28);
            this.cbo_service.TabIndex = 3;
            // 
            // cbo_time
            // 
            this.cbo_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_time.FormattingEnabled = true;
            this.cbo_time.Items.AddRange(new object[] {
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm",
            "8:00 pm",
            "8:30 pm",
            "9:00 pm"});
            this.cbo_time.Location = new System.Drawing.Point(308, 0);
            this.cbo_time.Name = "cbo_time";
            this.cbo_time.Size = new System.Drawing.Size(151, 28);
            this.cbo_time.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.Controls.Add(this.btn_reserve_table);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_account);
            this.panel4.Location = new System.Drawing.Point(0, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 580);
            this.panel4.TabIndex = 4;
            // 
            // btn_reserve_table
            // 
            this.btn_reserve_table.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_reserve_table.FlatAppearance.BorderSize = 0;
            this.btn_reserve_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserve_table.Location = new System.Drawing.Point(0, 87);
            this.btn_reserve_table.Name = "btn_reserve_table";
            this.btn_reserve_table.Size = new System.Drawing.Size(180, 49);
            this.btn_reserve_table.TabIndex = 5;
            this.btn_reserve_table.Text = "Reserve Table";
            this.btn_reserve_table.UseVisualStyleBackColor = false;
            this.btn_reserve_table.Click += new System.EventHandler(this.btn_reserve_table_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(184, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 572);
            this.panel5.TabIndex = 5;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 708);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbo_service;
        private System.Windows.Forms.ComboBox cbo_time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_reserve_table;
        private System.Windows.Forms.Panel panel5;
    }
}