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
        listView1 = new ListView();
        upButton1 = new WindowFormsControlsCore.UpButton();
        downButton1 = new WindowFormsControlsCore.DownButton();
        SaveButton = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Location = new Point(12, 12);
        listView1.Name = "listView1";
        listView1.Size = new Size(596, 387);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // upButton1
        // 
        upButton1.Image = (Image)resources.GetObject("upButton1.Image");
        upButton1.Location = new Point(624, 112);
        upButton1.Name = "upButton1";
        upButton1.Size = new Size(93, 50);
        upButton1.TabIndex = 1;
        upButton1.UseVisualStyleBackColor = true;
        upButton1.Click += upButton1_Click;
        // 
        // downButton1
        // 
        downButton1.Image = (Image)resources.GetObject("downButton1.Image");
        downButton1.Location = new Point(624, 182);
        downButton1.Name = "downButton1";
        downButton1.Size = new Size(93, 50);
        downButton1.TabIndex = 2;
        downButton1.UseVisualStyleBackColor = true;
        downButton1.Click += downButton1_Click;
        // 
        // SaveButton
        // 
        SaveButton.Image = Properties.Resources.Save;
        SaveButton.ImageAlign = ContentAlignment.MiddleLeft;
        SaveButton.Location = new Point(623, 358);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(94, 41);
        SaveButton.TabIndex = 3;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 417);
        label1.Name = "label1";
        label1.Size = new Size(536, 20);
        label1.TabIndex = 4;
        label1.Text = "CTRL+Up and CTRL+Down have the same functionality as the Up/Down buttons";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(745, 450);
        Controls.Add(label1);
        Controls.Add(SaveButton);
        Controls.Add(downButton1);
        Controls.Add(upButton1);
        Controls.Add(listView1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ListView json move up/down";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListView listView1;
    private WindowFormsControlsCore.UpButton upButton1;
    private WindowFormsControlsCore.DownButton downButton1;
    private Button SaveButton;
    private Label label1;
}
