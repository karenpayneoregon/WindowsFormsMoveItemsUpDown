namespace DataGridViewCore;

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
        upButton1 = new WindowFormsControlsCore.UpButton();
        downButton1 = new WindowFormsControlsCore.DownButton();
        CurrentRowDataButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
        dataGridView1.Location = new Point(12, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(498, 399);
        dataGridView1.TabIndex = 0;
        // 
        // upButton1
        // 
        upButton1.Image = (Image)resources.GetObject("upButton1.Image");
        upButton1.Location = new Point(550, 96);
        upButton1.Name = "upButton1";
        upButton1.Size = new Size(55, 50);
        upButton1.TabIndex = 1;
        upButton1.UseVisualStyleBackColor = true;
        upButton1.Click += upButton_Click;
        // 
        // downButton1
        // 
        downButton1.Image = (Image)resources.GetObject("downButton1.Image");
        downButton1.Location = new Point(550, 152);
        downButton1.Name = "downButton1";
        downButton1.Size = new Size(55, 50);
        downButton1.TabIndex = 2;
        downButton1.UseVisualStyleBackColor = true;
        downButton1.Click += downButton_Click;
        // 
        // CurrentRowDataButton
        // 
        CurrentRowDataButton.Location = new Point(532, 219);
        CurrentRowDataButton.Name = "CurrentRowDataButton";
        CurrentRowDataButton.Size = new Size(94, 29);
        CurrentRowDataButton.TabIndex = 3;
        CurrentRowDataButton.Text = "Current";
        CurrentRowDataButton.UseVisualStyleBackColor = true;
        CurrentRowDataButton.Click += CurrentRowDataButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(638, 450);
        Controls.Add(CurrentRowDataButton);
        Controls.Add(downButton1);
        Controls.Add(upButton1);
        Controls.Add(dataGridView1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Remember position - Products/category Beverages";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private WindowFormsControlsCore.UpButton upButton1;
    private WindowFormsControlsCore.DownButton downButton1;
    private Button CurrentRowDataButton;
}
