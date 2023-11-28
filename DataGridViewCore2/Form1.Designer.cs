namespace DataGridViewCore2;

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
        DumpToJsonButton = new Button();
        upButton1 = new WindowFormsControlsCore.UpButton();
        downButton1 = new WindowFormsControlsCore.DownButton();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(627, 188);
        dataGridView1.TabIndex = 0;
        // 
        // DumpToJsonButton
        // 
        DumpToJsonButton.Location = new Point(12, 206);
        DumpToJsonButton.Name = "DumpToJsonButton";
        DumpToJsonButton.Size = new Size(94, 29);
        DumpToJsonButton.TabIndex = 2;
        DumpToJsonButton.Text = "To Json";
        DumpToJsonButton.UseVisualStyleBackColor = true;
        DumpToJsonButton.Click += DumpToJsonButton_Click;
        // 
        // upButton1
        // 
        upButton1.Image = (Image)resources.GetObject("upButton1.Image");
        upButton1.Location = new Point(672, 12);
        upButton1.Name = "upButton1";
        upButton1.Size = new Size(55, 50);
        upButton1.TabIndex = 3;
        upButton1.UseVisualStyleBackColor = true;
        upButton1.Click += upButton1_Click;
        // 
        // downButton1
        // 
        downButton1.Image = (Image)resources.GetObject("downButton1.Image");
        downButton1.Location = new Point(672, 68);
        downButton1.Name = "downButton1";
        downButton1.Size = new Size(55, 50);
        downButton1.TabIndex = 4;
        downButton1.UseVisualStyleBackColor = true;
        downButton1.Click += downButton1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(749, 244);
        Controls.Add(downButton1);
        Controls.Add(upButton1);
        Controls.Add(DumpToJsonButton);
        Controls.Add(dataGridView1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button DumpToJsonButton;
    private WindowFormsControlsCore.UpButton upButton1;
    private WindowFormsControlsCore.DownButton downButton1;
}
