namespace Yet_another_tool
{
    partial class Main
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
            this.open_crt_tbl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.search_result = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table list:";
            // 
            // open_crt_tbl
            // 
            this.open_crt_tbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_crt_tbl.Location = new System.Drawing.Point(288, 156);
            this.open_crt_tbl.Name = "open_crt_tbl";
            this.open_crt_tbl.Size = new System.Drawing.Size(75, 23);
            this.open_crt_tbl.TabIndex = 1;
            this.open_crt_tbl.Text = "Create table";
            this.open_crt_tbl.UseVisualStyleBackColor = true;
            this.open_crt_tbl.Click += new System.EventHandler(this.open_crt_tbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by table number";
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(17, 42);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(87, 20);
            this.search_bar.TabIndex = 3;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // search_result
            // 
            this.search_result.AutoScroll = true;
            this.search_result.Location = new System.Drawing.Point(17, 68);
            this.search_result.Name = "search_result";
            this.search_result.Size = new System.Drawing.Size(345, 75);
            this.search_result.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(375, 542);
            this.Controls.Add(this.search_result);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.open_crt_tbl);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(391, 1200);
            this.MinimumSize = new System.Drawing.Size(391, 580);
            this.Name = "Main";
            this.Text = "Yet another tool";
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Main_ControlAdded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open_crt_tbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Panel search_result;
    }
}

