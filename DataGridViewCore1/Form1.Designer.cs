using WindowFormsControlsCore;

namespace DataGridViewCore1;

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
        dataGridView1 = new DataGridView();
        upButton = new UpButton();
        downButton = new DownButton();
        currentButton = new Button();
        dumpButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Left;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(318, 511);
        dataGridView1.TabIndex = 0;
        // 
        // upButton
        // 
        upButton.Image = (Image)resources.GetObject("upButton.Image");
        upButton.Location = new Point(348, 12);
        upButton.Name = "upButton";
        upButton.Size = new Size(75, 49);
        upButton.TabIndex = 1;
        upButton.UseVisualStyleBackColor = true;
        upButton.Click += upButton_Click;
        // 
        // downButton
        // 
        downButton.Image = (Image)resources.GetObject("downButton.Image");
        downButton.Location = new Point(348, 67);
        downButton.Name = "downButton";
        downButton.Size = new Size(75, 49);
        downButton.TabIndex = 2;
        downButton.UseVisualStyleBackColor = true;
        downButton.Click += downButton_Click;
        // 
        // currentButton
        // 
        currentButton.Location = new Point(348, 139);
        currentButton.Name = "currentButton";
        currentButton.Size = new Size(75, 49);
        currentButton.TabIndex = 3;
        currentButton.Text = "Current";
        currentButton.UseVisualStyleBackColor = true;
        currentButton.Click += currentButton_Click;
        // 
        // dumpButton
        // 
        dumpButton.Location = new Point(348, 194);
        dumpButton.Name = "dumpButton";
        dumpButton.Size = new Size(75, 49);
        dumpButton.TabIndex = 4;
        dumpButton.Text = "To Json";
        dumpButton.UseVisualStyleBackColor = true;
        dumpButton.Click += dumpButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(454, 511);
        Controls.Add(dumpButton);
        Controls.Add(currentButton);
        Controls.Add(downButton);
        Controls.Add(upButton);
        Controls.Add(dataGridView1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private UpButton upButton;
    private DownButton downButton;
    private Button currentButton;
    private Button dumpButton;
}
