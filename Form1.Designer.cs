namespace Yet_another_tool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_name = new System.Windows.Forms.TextBox();
            this.tbl_num = new System.Windows.Forms.TextBox();
            this.tbl_id = new System.Windows.Forms.TextBox();
            this.tbl_create = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table num:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table ID:";
            // 
            // tbl_name
            // 
            this.tbl_name.Location = new System.Drawing.Point(84, 6);
            this.tbl_name.Name = "tbl_name";
            this.tbl_name.Size = new System.Drawing.Size(162, 20);
            this.tbl_name.TabIndex = 1;
            // 
            // tbl_num
            // 
            this.tbl_num.Location = new System.Drawing.Point(84, 29);
            this.tbl_num.Name = "tbl_num";
            this.tbl_num.Size = new System.Drawing.Size(100, 20);
            this.tbl_num.TabIndex = 2;
            // 
            // tbl_id
            // 
            this.tbl_id.Location = new System.Drawing.Point(84, 54);
            this.tbl_id.Name = "tbl_id";
            this.tbl_id.Size = new System.Drawing.Size(162, 20);
            this.tbl_id.TabIndex = 3;
            // 
            // tbl_create
            // 
            this.tbl_create.Location = new System.Drawing.Point(84, 80);
            this.tbl_create.Name = "tbl_create";
            this.tbl_create.Size = new System.Drawing.Size(75, 23);
            this.tbl_create.TabIndex = 4;
            this.tbl_create.Text = "Create";
            this.tbl_create.UseVisualStyleBackColor = true;
            this.tbl_create.Click += new System.EventHandler(this.tbl_create_Click);
            // 
            // path
            // 
            this.path.AccessibleDescription = "Path to lxd file with current table number";
            this.path.Location = new System.Drawing.Point(190, 31);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(56, 18);
            this.path.TabIndex = 5;
            this.path.Text = "---";
            this.path.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 316);
            this.Controls.Add(this.path);
            this.Controls.Add(this.tbl_create);
            this.Controls.Add(this.tbl_id);
            this.Controls.Add(this.tbl_num);
            this.Controls.Add(this.tbl_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbl_name;
        private System.Windows.Forms.TextBox tbl_num;
        private System.Windows.Forms.TextBox tbl_id;
        private System.Windows.Forms.Button tbl_create;
        private System.Windows.Forms.Button path;
    }
}

