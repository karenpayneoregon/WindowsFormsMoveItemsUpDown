﻿namespace MainApplication
{
    partial class WizardForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdMoveToPurchase = new System.Windows.Forms.Button();
            this.cmdMoveFromPurchase = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 199);
            this.listBox1.TabIndex = 0;
            // 
            // cmdMoveToPurchase
            // 
            this.cmdMoveToPurchase.Location = new System.Drawing.Point(295, 41);
            this.cmdMoveToPurchase.Name = "cmdMoveToPurchase";
            this.cmdMoveToPurchase.Size = new System.Drawing.Size(75, 23);
            this.cmdMoveToPurchase.TabIndex = 1;
            this.cmdMoveToPurchase.Text = ">";
            this.cmdMoveToPurchase.UseVisualStyleBackColor = true;
            this.cmdMoveToPurchase.Click += new System.EventHandler(this.cmdMoveToPurchase_Click);
            // 
            // cmdMoveFromPurchase
            // 
            this.cmdMoveFromPurchase.Location = new System.Drawing.Point(295, 70);
            this.cmdMoveFromPurchase.Name = "cmdMoveFromPurchase";
            this.cmdMoveFromPurchase.Size = new System.Drawing.Size(75, 23);
            this.cmdMoveFromPurchase.TabIndex = 2;
            this.cmdMoveFromPurchase.Text = "<";
            this.cmdMoveFromPurchase.UseVisualStyleBackColor = true;
            this.cmdMoveFromPurchase.Click += new System.EventHandler(this.cmdMoveFromPurchase_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(376, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 199);
            this.listBox2.TabIndex = 3;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 227);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.cmdMoveFromPurchase);
            this.Controls.Add(this.cmdMoveToPurchase);
            this.Controls.Add(this.listBox1);
            this.Name = "WizardForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdMoveToPurchase;
        private System.Windows.Forms.Button cmdMoveFromPurchase;
        private System.Windows.Forms.ListBox listBox2;
    }
}