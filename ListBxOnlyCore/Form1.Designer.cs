namespace ListBxOnlyCore;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.upButton1 = new WindowFormsControlsCore.UpButton();
            this.downButton1 = new WindowFormsControlsCore.DownButton();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(22, 12);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(254, 284);
            this.lstProducts.TabIndex = 0;
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(295, 58);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(55, 50);
            this.upButton1.TabIndex = 1;
            this.upButton1.UseVisualStyleBackColor = true;
            this.upButton1.Click += new System.EventHandler(this.upButton1_Click);
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(295, 126);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(55, 50);
            this.downButton1.TabIndex = 2;
            this.downButton1.UseVisualStyleBackColor = true;
            this.downButton1.Click += new System.EventHandler(this.downButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 356);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.lstProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox move items up/down";
            this.ResumeLayout(false);

    }

    #endregion

    private ListBox lstProducts;
    private WindowFormsControlsCore.UpButton upButton1;
    private WindowFormsControlsCore.DownButton downButton1;
}
