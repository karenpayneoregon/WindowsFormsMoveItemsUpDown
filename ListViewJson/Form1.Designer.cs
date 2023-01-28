namespace ListViewJson;

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
            this.listView1 = new System.Windows.Forms.ListView();
            this.upButton1 = new WindowFormsControlsCore.UpButton();
            this.downButton1 = new WindowFormsControlsCore.DownButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // upButton1
            // 
            this.upButton1.Image = ((System.Drawing.Image)(resources.GetObject("upButton1.Image")));
            this.upButton1.Location = new System.Drawing.Point(564, 112);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(55, 50);
            this.upButton1.TabIndex = 1;
            this.upButton1.UseVisualStyleBackColor = true;
            this.upButton1.Click += new System.EventHandler(this.upButton1_Click);
            // 
            // downButton1
            // 
            this.downButton1.Image = ((System.Drawing.Image)(resources.GetObject("downButton1.Image")));
            this.downButton1.Location = new System.Drawing.Point(564, 182);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(55, 50);
            this.downButton1.TabIndex = 2;
            this.downButton1.UseVisualStyleBackColor = true;
            this.downButton1.Click += new System.EventHandler(this.downButton1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::ListViewJson.Properties.Resources.Save;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(563, 358);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 41);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.downButton1);
            this.Controls.Add(this.upButton1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView json move up/down";
            this.ResumeLayout(false);

    }

    #endregion

    private ListView listView1;
    private WindowFormsControlsCore.UpButton upButton1;
    private WindowFormsControlsCore.DownButton downButton1;
    private Button SaveButton;
}
