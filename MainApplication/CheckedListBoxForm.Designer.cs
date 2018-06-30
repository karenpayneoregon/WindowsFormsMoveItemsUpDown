namespace MainApplication
{
    partial class CheckedListBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckedListBoxForm));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.upButton1 = new WindowFormsControls.UpButton();
            this.downButton1 = new WindowFormsControls.DownButton();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdPurchase = new System.Windows.Forms.Button();
            this.upButton2 = new WindowFormsControls.UpButton();
            this.downButton2 = new WindowFormsControls.DownButton();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(268, 214);
            this.checkedListBox1.TabIndex = 0;
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(286, 43);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(44, 40);
            this.upButton1.TabIndex = 1;
            this.upButton1.UseVisualStyleBackColor = true;
            this.upButton1.Click += new System.EventHandler(this.upButton1_Click);
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(286, 89);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(44, 40);
            this.downButton1.TabIndex = 2;
            this.downButton1.UseVisualStyleBackColor = true;
            this.downButton1.Click += new System.EventHandler(this.downButton1_Click);
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(12, 232);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(268, 23);
            this.cmdSelect.TabIndex = 3;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 212);
            this.listBox1.TabIndex = 4;
            // 
            // cmdPurchase
            // 
            this.cmdPurchase.Location = new System.Drawing.Point(340, 232);
            this.cmdPurchase.Name = "cmdPurchase";
            this.cmdPurchase.Size = new System.Drawing.Size(268, 23);
            this.cmdPurchase.TabIndex = 7;
            this.cmdPurchase.Text = "Purchase";
            this.cmdPurchase.UseVisualStyleBackColor = true;
            this.cmdPurchase.Click += new System.EventHandler(this.cmdPurchase_Click);
            // 
            // upButton2
            // 
            this.upButton2.Image = ((System.Drawing.Image)(resources.GetObject("upButton2.Image")));
            this.upButton2.Location = new System.Drawing.Point(624, 43);
            this.upButton2.Name = "upButton2";
            this.upButton2.Size = new System.Drawing.Size(44, 40);
            this.upButton2.TabIndex = 5;
            this.upButton2.UseVisualStyleBackColor = true;
            this.upButton2.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton2
            // 
            this.downButton2.Image = ((System.Drawing.Image)(resources.GetObject("downButton2.Image")));
            this.downButton2.Location = new System.Drawing.Point(624, 89);
            this.downButton2.Name = "downButton2";
            this.downButton2.Size = new System.Drawing.Size(44, 40);
            this.downButton2.TabIndex = 6;
            this.downButton2.UseVisualStyleBackColor = true;
            this.downButton2.Click += new System.EventHandler(this.downButton_Click);
            // 
            // CheckedListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 271);
            this.Controls.Add(this.downButton2);
            this.Controls.Add(this.upButton2);
            this.Controls.Add(this.cmdPurchase);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CheckedListBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckedListBox code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private WindowFormsControls.UpButton upButton1;
        private WindowFormsControls.DownButton downButton1;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdPurchase;
        private WindowFormsControls.UpButton upButton2;
        private WindowFormsControls.DownButton downButton2;
    }
}