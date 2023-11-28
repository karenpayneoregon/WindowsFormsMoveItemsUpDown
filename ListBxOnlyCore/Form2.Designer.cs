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
        listBox1 = new ListBox();
        downButton1 = new WindowFormsControlsCore.DownButton();
        upButton1 = new WindowFormsControlsCore.UpButton();
        CurrentButton = new Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(12, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(150, 304);
        listBox1.TabIndex = 0;
        // 
        // downButton1
        // 
        downButton1.Image = (Image)resources.GetObject("downButton1.Image");
        downButton1.Location = new Point(194, 127);
        downButton1.Name = "downButton1";
        downButton1.Size = new Size(55, 50);
        downButton1.TabIndex = 4;
        downButton1.UseVisualStyleBackColor = true;
        downButton1.Click += downButton_Click;
        // 
        // upButton1
        // 
        upButton1.Image = (Image)resources.GetObject("upButton1.Image");
        upButton1.Location = new Point(194, 59);
        upButton1.Name = "upButton1";
        upButton1.Size = new Size(55, 50);
        upButton1.TabIndex = 3;
        upButton1.UseVisualStyleBackColor = true;
        upButton1.Click += upButton_Click;
        // 
        // CurrentButton
        // 
        CurrentButton.Location = new Point(194, 197);
        CurrentButton.Name = "CurrentButton";
        CurrentButton.Size = new Size(94, 29);
        CurrentButton.TabIndex = 5;
        CurrentButton.Text = "Current";
        CurrentButton.UseVisualStyleBackColor = true;
        CurrentButton.Click += CurrentButton_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(345, 344);
        Controls.Add(CurrentButton);
        Controls.Add(downButton1);
        Controls.Add(upButton1);
        Controls.Add(listBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form2";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
    private WindowFormsControlsCore.DownButton downButton1;
    private WindowFormsControlsCore.UpButton upButton1;
    private Button CurrentButton;
}