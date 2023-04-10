namespace ListBxOnlyCore;

partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.downButton1 = new WindowFormsControlsCore.DownButton();
            this.upButton1 = new WindowFormsControlsCore.UpButton();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 304);
            this.listBox1.TabIndex = 0;
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(194, 127);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(55, 50);
            this.downButton1.TabIndex = 4;
            this.downButton1.UseVisualStyleBackColor = true;
            this.downButton1.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(194, 59);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(55, 50);
            this.upButton1.TabIndex = 3;
            this.upButton1.UseVisualStyleBackColor = true;
            this.upButton1.Click += new System.EventHandler(this.upButton_Click);
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(194, 197);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(94, 29);
            this.CurrentButton.TabIndex = 5;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

    }

    #endregion

    private ListBox listBox1;
    private WindowFormsControlsCore.DownButton downButton1;
    private WindowFormsControlsCore.UpButton upButton1;
    private Button CurrentButton;
}