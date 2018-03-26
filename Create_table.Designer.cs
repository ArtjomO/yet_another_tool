namespace Yet_another_tool
{
    partial class Create_table
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
            this.path_lxd = new System.Windows.Forms.Button();
            this.tbl_create = new System.Windows.Forms.Button();
            this.tbl_id = new System.Windows.Forms.TextBox();
            this.tbl_num = new System.Windows.Forms.TextBox();
            this.tbl_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // path_lxd
            // 
            this.path_lxd.AccessibleDescription = "Path to lxd file with current table number";
            this.path_lxd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_lxd.Location = new System.Drawing.Point(202, 41);
            this.path_lxd.Name = "path_lxd";
            this.path_lxd.Size = new System.Drawing.Size(68, 20);
            this.path_lxd.TabIndex = 3;
            this.path_lxd.Text = "Path to .lxd";
            this.path_lxd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.path_lxd.UseVisualStyleBackColor = true;
            this.path_lxd.Click += new System.EventHandler(this.path_lxd_Click);
            // 
            // tbl_create
            // 
            this.tbl_create.Location = new System.Drawing.Point(96, 112);
            this.tbl_create.Name = "tbl_create";
            this.tbl_create.Size = new System.Drawing.Size(75, 23);
            this.tbl_create.TabIndex = 6;
            this.tbl_create.Text = "Create";
            this.tbl_create.UseVisualStyleBackColor = true;
            this.tbl_create.Click += new System.EventHandler(this.tbl_create_Click);
            // 
            // tbl_id
            // 
            this.tbl_id.Location = new System.Drawing.Point(96, 64);
            this.tbl_id.Name = "tbl_id";
            this.tbl_id.Size = new System.Drawing.Size(162, 20);
            this.tbl_id.TabIndex = 4;
            // 
            // tbl_num
            // 
            this.tbl_num.Location = new System.Drawing.Point(96, 42);
            this.tbl_num.Name = "tbl_num";
            this.tbl_num.Size = new System.Drawing.Size(100, 20);
            this.tbl_num.TabIndex = 2;
            // 
            // tbl_name
            // 
            this.tbl_name.Location = new System.Drawing.Point(96, 19);
            this.tbl_name.Name = "tbl_name";
            this.tbl_name.Size = new System.Drawing.Size(162, 20);
            this.tbl_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table num:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Table IP:";
            // 
            // tbl_ip
            // 
            this.tbl_ip.Location = new System.Drawing.Point(96, 86);
            this.tbl_ip.Name = "tbl_ip";
            this.tbl_ip.Size = new System.Drawing.Size(117, 20);
            this.tbl_ip.TabIndex = 5;
            // 
            // Create_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 148);
            this.Controls.Add(this.tbl_ip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.path_lxd);
            this.Controls.Add(this.tbl_create);
            this.Controls.Add(this.tbl_id);
            this.Controls.Add(this.tbl_num);
            this.Controls.Add(this.tbl_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_table";
            this.Text = "Create table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button path_lxd;
        private System.Windows.Forms.Button tbl_create;
        private System.Windows.Forms.TextBox tbl_id;
        private System.Windows.Forms.TextBox tbl_num;
        private System.Windows.Forms.TextBox tbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbl_ip;
    }
}