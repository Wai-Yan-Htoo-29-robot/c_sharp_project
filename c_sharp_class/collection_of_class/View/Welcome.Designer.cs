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
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_reserve_table = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(289, 7);
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
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(-4, 596);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(180, 49);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.Controls.Add(this.btn_reserve_table);
            this.panel4.Controls.Add(this.btn_logout);
            this.panel4.Controls.Add(this.btn_account);
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 644);
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
            this.panel5.Location = new System.Drawing.Point(184, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(716, 645);
            this.panel5.TabIndex = 5;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 699);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_reserve_table;
        private System.Windows.Forms.Panel panel5;
    }
}