namespace MainApplication
{
    partial class ListViewJsonExampleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewJsonExampleForm));
            this.downButton1 = new WindowFormsControls.DownButton();
            this.upButton1 = new WindowFormsControls.UpButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmdSavePositions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(540, 153);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(44, 40);
            this.downButton1.TabIndex = 5;
            this.downButton1.UseVisualStyleBackColor = true;
            this.downButton1.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(540, 107);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(44, 40);
            this.upButton1.TabIndex = 4;
            this.upButton1.UseVisualStyleBackColor = true;
            this.upButton1.Click += new System.EventHandler(this.upButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 23);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(513, 292);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cmdSavePositions
            // 
            this.cmdSavePositions.Location = new System.Drawing.Point(541, 318);
            this.cmdSavePositions.Name = "cmdSavePositions";
            this.cmdSavePositions.Size = new System.Drawing.Size(44, 40);
            this.cmdSavePositions.TabIndex = 6;
            this.cmdSavePositions.Text = "Save";
            this.cmdSavePositions.UseVisualStyleBackColor = true;
            this.cmdSavePositions.Click += new System.EventHandler(this.cmdSavePositions_Click);
            // 
            // ListViewJsonExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 370);
            this.Controls.Add(this.cmdSavePositions);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListViewJsonExampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListViewJsonExampleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowFormsControls.DownButton downButton1;
        private WindowFormsControls.UpButton upButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cmdSavePositions;
    }
}