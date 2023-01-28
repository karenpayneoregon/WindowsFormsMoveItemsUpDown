namespace ListBoxOnly
{
    partial class LoadProductListBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadProductListBoxForm));
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.downButton1 = new WindowFormsControls.DownButton();
            this.upButton1 = new WindowFormsControls.UpButton();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(12, 12);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(231, 173);
            this.lstProducts.TabIndex = 2;
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(249, 87);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(26, 25);
            this.downButton1.TabIndex = 4;
            this.downButton1.UseVisualStyleBackColor = true;
            this.downButton1.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(249, 50);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(26, 25);
            this.upButton1.TabIndex = 3;
            this.upButton1.UseVisualStyleBackColor = true;
            this.upButton1.Click += new System.EventHandler(this.upButton_Click);
            // 
            // LoadProductListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 206);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.lstProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadProductListBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move up/down";
            this.Load += new System.EventHandler(this.LoadProductListBoxForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstProducts;
        private WindowFormsControls.UpButton upButton1;
        private WindowFormsControls.DownButton downButton1;
    }
}
