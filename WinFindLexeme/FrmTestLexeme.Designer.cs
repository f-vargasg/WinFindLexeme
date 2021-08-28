namespace WinOraclePackage
{
    partial class FrmTestLexeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butDo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscFld = new System.Windows.Forms.TextBox();
            this.butTestOptParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "TableName";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(101, 71);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(527, 26);
            this.txtTableName.TabIndex = 7;
            // 
            // butOk
            // 
            this.butOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOk.Location = new System.Drawing.Point(171, 367);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(116, 59);
            this.butOk.TabIndex = 8;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(-1, 163);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(674, 183);
            this.txtOutput.TabIndex = 9;
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butCancel.Location = new System.Drawing.Point(401, 367);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(116, 59);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(-1, 2);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(76, 30);
            this.butDo.TabIndex = 11;
            this.butDo.Text = "do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Owner";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(101, 35);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(527, 26);
            this.txtOwner.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Disc.Fld:";
            // 
            // txtDiscFld
            // 
            this.txtDiscFld.Location = new System.Drawing.Point(101, 107);
            this.txtDiscFld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscFld.Name = "txtDiscFld";
            this.txtDiscFld.Size = new System.Drawing.Size(527, 26);
            this.txtDiscFld.TabIndex = 15;
            // 
            // butTestOptParams
            // 
            this.butTestOptParams.Location = new System.Drawing.Point(128, 2);
            this.butTestOptParams.Name = "butTestOptParams";
            this.butTestOptParams.Size = new System.Drawing.Size(76, 30);
            this.butTestOptParams.TabIndex = 16;
            this.butTestOptParams.Text = "Opt.Params";
            this.butTestOptParams.UseVisualStyleBackColor = true;
            this.butTestOptParams.Click += new System.EventHandler(this.butTestOptParams_Click);
            // 
            // FrmTestLexeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 438);
            this.Controls.Add(this.butTestOptParams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscFld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.butDo);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTestLexeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTestLexeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscFld;
        private System.Windows.Forms.Button butTestOptParams;
    }
}