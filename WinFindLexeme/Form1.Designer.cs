﻿namespace WinFindLexeme
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.butDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.butTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(-2, 35);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(897, 207);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(-2, 374);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(897, 235);
            this.txtOutput.TabIndex = 1;
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(128, 268);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(249, 71);
            this.butDo.TabIndex = 2;
            this.butDo.Text = "Do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(128, 2);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(502, 26);
            this.txtTableName.TabIndex = 4;
            // 
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(468, 268);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(249, 71);
            this.butTest.TabIndex = 5;
            this.butTest.Text = "DoTest";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 608);
            this.Controls.Add(this.butTest);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button butTest;
    }
}
