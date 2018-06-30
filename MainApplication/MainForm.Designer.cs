namespace MainApplication
{
    partial class MainForm
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
            this.cmdUnboundDataGridViewFullRowSelect = new System.Windows.Forms.Button();
            this.cmdBoundListBoxRememberPosition = new System.Windows.Forms.Button();
            this.cmdBoundDataGridView = new System.Windows.Forms.Button();
            this.cmdCheckedListBoxExample = new System.Windows.Forms.Button();
            this.chkBoundDataGridViewRemember = new System.Windows.Forms.CheckBox();
            this.cmdBuildCustomerSelectStatement = new System.Windows.Forms.Button();
            this.cmdListViewUnboundExample = new System.Windows.Forms.Button();
            this.cmdNextCategoryRowPosition = new System.Windows.Forms.Button();
            this.cmdJsonRemember = new System.Windows.Forms.Button();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdUnboundDataGridViewFullRowSelect
            // 
            this.cmdUnboundDataGridViewFullRowSelect.Location = new System.Drawing.Point(18, 16);
            this.cmdUnboundDataGridViewFullRowSelect.Name = "cmdUnboundDataGridViewFullRowSelect";
            this.cmdUnboundDataGridViewFullRowSelect.Size = new System.Drawing.Size(271, 23);
            this.cmdUnboundDataGridViewFullRowSelect.TabIndex = 0;
            this.cmdUnboundDataGridViewFullRowSelect.Text = "Unbound DataGridView full row select";
            this.cmdUnboundDataGridViewFullRowSelect.UseVisualStyleBackColor = true;
            this.cmdUnboundDataGridViewFullRowSelect.Click += new System.EventHandler(this.cmdUnboundDataGridViewFullRowSelect_Click);
            // 
            // cmdBoundListBoxRememberPosition
            // 
            this.cmdBoundListBoxRememberPosition.Location = new System.Drawing.Point(18, 74);
            this.cmdBoundListBoxRememberPosition.Name = "cmdBoundListBoxRememberPosition";
            this.cmdBoundListBoxRememberPosition.Size = new System.Drawing.Size(271, 23);
            this.cmdBoundListBoxRememberPosition.TabIndex = 1;
            this.cmdBoundListBoxRememberPosition.Text = "Bound ListBox remember";
            this.cmdBoundListBoxRememberPosition.UseVisualStyleBackColor = true;
            this.cmdBoundListBoxRememberPosition.Click += new System.EventHandler(this.cmdBoundListBoxRememberPosition_Click);
            // 
            // cmdBoundDataGridView
            // 
            this.cmdBoundDataGridView.Location = new System.Drawing.Point(18, 45);
            this.cmdBoundDataGridView.Name = "cmdBoundDataGridView";
            this.cmdBoundDataGridView.Size = new System.Drawing.Size(271, 23);
            this.cmdBoundDataGridView.TabIndex = 2;
            this.cmdBoundDataGridView.Text = "Bound DataGridView full row select";
            this.cmdBoundDataGridView.UseVisualStyleBackColor = true;
            this.cmdBoundDataGridView.Click += new System.EventHandler(this.cmdBoundDataGridView_Click);
            // 
            // cmdCheckedListBoxExample
            // 
            this.cmdCheckedListBoxExample.Location = new System.Drawing.Point(18, 103);
            this.cmdCheckedListBoxExample.Name = "cmdCheckedListBoxExample";
            this.cmdCheckedListBoxExample.Size = new System.Drawing.Size(271, 23);
            this.cmdCheckedListBoxExample.TabIndex = 3;
            this.cmdCheckedListBoxExample.Text = "CheckedListBox bound from class";
            this.cmdCheckedListBoxExample.UseVisualStyleBackColor = true;
            this.cmdCheckedListBoxExample.Click += new System.EventHandler(this.cmdCheckedListBoxExample_Click);
            // 
            // chkBoundDataGridViewRemember
            // 
            this.chkBoundDataGridViewRemember.AutoSize = true;
            this.chkBoundDataGridViewRemember.Checked = true;
            this.chkBoundDataGridViewRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoundDataGridViewRemember.Location = new System.Drawing.Point(295, 49);
            this.chkBoundDataGridViewRemember.Name = "chkBoundDataGridViewRemember";
            this.chkBoundDataGridViewRemember.Size = new System.Drawing.Size(136, 17);
            this.chkBoundDataGridViewRemember.TabIndex = 4;
            this.chkBoundDataGridViewRemember.Text = "Present results on save";
            this.chkBoundDataGridViewRemember.UseVisualStyleBackColor = true;
            // 
            // cmdBuildCustomerSelectStatement
            // 
            this.cmdBuildCustomerSelectStatement.Location = new System.Drawing.Point(18, 190);
            this.cmdBuildCustomerSelectStatement.Name = "cmdBuildCustomerSelectStatement";
            this.cmdBuildCustomerSelectStatement.Size = new System.Drawing.Size(271, 23);
            this.cmdBuildCustomerSelectStatement.TabIndex = 5;
            this.cmdBuildCustomerSelectStatement.Text = "Build Customer SELECT";
            this.cmdBuildCustomerSelectStatement.UseVisualStyleBackColor = true;
            this.cmdBuildCustomerSelectStatement.Click += new System.EventHandler(this.cmdBuildCustomerSelectStatement_Click);
            // 
            // cmdListViewUnboundExample
            // 
            this.cmdListViewUnboundExample.Location = new System.Drawing.Point(18, 132);
            this.cmdListViewUnboundExample.Name = "cmdListViewUnboundExample";
            this.cmdListViewUnboundExample.Size = new System.Drawing.Size(271, 23);
            this.cmdListViewUnboundExample.TabIndex = 7;
            this.cmdListViewUnboundExample.Text = "ListView unbound no remember";
            this.cmdListViewUnboundExample.UseVisualStyleBackColor = true;
            this.cmdListViewUnboundExample.Click += new System.EventHandler(this.cmdListViewUnboundExample_Click);
            // 
            // cmdNextCategoryRowPosition
            // 
            this.cmdNextCategoryRowPosition.Location = new System.Drawing.Point(18, 219);
            this.cmdNextCategoryRowPosition.Name = "cmdNextCategoryRowPosition";
            this.cmdNextCategoryRowPosition.Size = new System.Drawing.Size(271, 23);
            this.cmdNextCategoryRowPosition.TabIndex = 8;
            this.cmdNextCategoryRowPosition.Text = "Next Category RowPosition";
            this.cmdNextCategoryRowPosition.UseVisualStyleBackColor = true;
            this.cmdNextCategoryRowPosition.Click += new System.EventHandler(this.cmdNextCategoryRowPosition_Click);
            // 
            // cmdJsonRemember
            // 
            this.cmdJsonRemember.Location = new System.Drawing.Point(18, 161);
            this.cmdJsonRemember.Name = "cmdJsonRemember";
            this.cmdJsonRemember.Size = new System.Drawing.Size(271, 23);
            this.cmdJsonRemember.TabIndex = 9;
            this.cmdJsonRemember.Text = "ListView json remember";
            this.cmdJsonRemember.UseVisualStyleBackColor = true;
            this.cmdJsonRemember.Click += new System.EventHandler(this.cmdJsonRemember_Click);
            // 
            // cboCategories
            // 
            this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(295, 219);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(121, 21);
            this.cboCategories.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 269);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.cmdJsonRemember);
            this.Controls.Add(this.cmdNextCategoryRowPosition);
            this.Controls.Add(this.cmdListViewUnboundExample);
            this.Controls.Add(this.cmdBuildCustomerSelectStatement);
            this.Controls.Add(this.chkBoundDataGridViewRemember);
            this.Controls.Add(this.cmdCheckedListBoxExample);
            this.Controls.Add(this.cmdBoundDataGridView);
            this.Controls.Add(this.cmdBoundListBoxRememberPosition);
            this.Controls.Add(this.cmdUnboundDataGridViewFullRowSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUnboundDataGridViewFullRowSelect;
        private System.Windows.Forms.Button cmdBoundListBoxRememberPosition;
        private System.Windows.Forms.Button cmdBoundDataGridView;
        private System.Windows.Forms.Button cmdCheckedListBoxExample;
        private System.Windows.Forms.CheckBox chkBoundDataGridViewRemember;
        private System.Windows.Forms.Button cmdBuildCustomerSelectStatement;
        private System.Windows.Forms.Button cmdListViewUnboundExample;
        private System.Windows.Forms.Button cmdNextCategoryRowPosition;
        private System.Windows.Forms.Button cmdJsonRemember;
        private System.Windows.Forms.ComboBox cboCategories;
    }
}