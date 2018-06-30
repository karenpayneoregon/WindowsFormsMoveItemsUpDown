namespace MainApplication
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboSortColumns = new System.Windows.Forms.ComboBox();
            this.cmdSort = new System.Windows.Forms.Button();
            this.cboDirection = new System.Windows.Forms.ComboBox();
            this.upButton1 = new WindowFormsControls.UpButton();
            this.downButton1 = new WindowFormsControls.DownButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboDirection);
            this.panel1.Controls.Add(this.cmdSort);
            this.panel1.Controls.Add(this.cboSortColumns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 61);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 291);
            this.dataGridView1.TabIndex = 1;
            // 
            // cboSortColumns
            // 
            this.cboSortColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortColumns.FormattingEnabled = true;
            this.cboSortColumns.Location = new System.Drawing.Point(12, 18);
            this.cboSortColumns.Name = "cboSortColumns";
            this.cboSortColumns.Size = new System.Drawing.Size(121, 21);
            this.cboSortColumns.TabIndex = 0;
            this.cboSortColumns.Visible = false;
            // 
            // cmdSort
            // 
            this.cmdSort.Location = new System.Drawing.Point(279, 18);
            this.cmdSort.Name = "cmdSort";
            this.cmdSort.Size = new System.Drawing.Size(75, 23);
            this.cmdSort.TabIndex = 1;
            this.cmdSort.Text = "Sort";
            this.cmdSort.UseVisualStyleBackColor = true;
            this.cmdSort.Visible = false;
            this.cmdSort.Click += new System.EventHandler(this.cmdSort_Click);
            // 
            // cboDirection
            // 
            this.cboDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirection.FormattingEnabled = true;
            this.cboDirection.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cboDirection.Location = new System.Drawing.Point(139, 18);
            this.cboDirection.Name = "cboDirection";
            this.cboDirection.Size = new System.Drawing.Size(121, 21);
            this.cboDirection.TabIndex = 2;
            this.cboDirection.Visible = false;
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(672, 35);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(44, 40);
            this.upButton1.TabIndex = 2;
            this.upButton1.UseVisualStyleBackColor = true;
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(672, 81);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(44, 40);
            this.downButton1.TabIndex = 3;
            this.downButton1.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 360);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboSortColumns;
        private System.Windows.Forms.Button cmdSort;
        private System.Windows.Forms.ComboBox cboDirection;
        private WindowFormsControls.UpButton upButton1;
        private WindowFormsControls.DownButton downButton1;
    }
}