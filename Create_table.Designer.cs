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
            this.path = new System.Windows.Forms.Button();
            this.tbl_create = new System.Windows.Forms.Button();
            this.tbl_id = new System.Windows.Forms.TextBox();
            this.tbl_num = new System.Windows.Forms.TextBox();
            this.tbl_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.AccessibleDescription = "Path to lxd file with current table number";
            this.path.Location = new System.Drawing.Point(202, 44);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(56, 18);
            this.path.TabIndex = 13;
            this.path.Text = "---";
            this.path.UseVisualStyleBackColor = true;
            // 
            // tbl_create
            // 
            this.tbl_create.Location = new System.Drawing.Point(96, 93);
            this.tbl_create.Name = "tbl_create";
            this.tbl_create.Size = new System.Drawing.Size(75, 23);
            this.tbl_create.TabIndex = 12;
            this.tbl_create.Text = "Create";
            this.tbl_create.UseVisualStyleBackColor = true;
            this.tbl_create.Click += new System.EventHandler(this.tbl_create_Click);
            // 
            // tbl_id
            // 
            this.tbl_id.Location = new System.Drawing.Point(96, 67);
            this.tbl_id.Name = "tbl_id";
            this.tbl_id.Size = new System.Drawing.Size(162, 20);
            this.tbl_id.TabIndex = 11;
            // 
            // tbl_num
            // 
            this.tbl_num.Location = new System.Drawing.Point(96, 42);
            this.tbl_num.Name = "tbl_num";
            this.tbl_num.Size = new System.Drawing.Size(100, 20);
            this.tbl_num.TabIndex = 9;
            // 
            // tbl_name
            // 
            this.tbl_name.Location = new System.Drawing.Point(96, 19);
            this.tbl_name.Name = "tbl_name";
            this.tbl_name.Size = new System.Drawing.Size(162, 20);
            this.tbl_name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Table num:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table name:";
            // 
            // Create_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 135);
            this.Controls.Add(this.path);
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

        private System.Windows.Forms.Button path;
        private System.Windows.Forms.Button tbl_create;
        private System.Windows.Forms.TextBox tbl_id;
        private System.Windows.Forms.TextBox tbl_num;
        private System.Windows.Forms.TextBox tbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}