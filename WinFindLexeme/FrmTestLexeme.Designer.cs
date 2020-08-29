namespace WinFindLexeme
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
            this.txtBoxLexeme = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lexeme:";
            // 
            // txtBoxLexeme
            // 
            this.txtBoxLexeme.Location = new System.Drawing.Point(101, 51);
            this.txtBoxLexeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxLexeme.Name = "txtBoxLexeme";
            this.txtBoxLexeme.Size = new System.Drawing.Size(527, 26);
            this.txtBoxLexeme.TabIndex = 7;
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(-1, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(674, 239);
            this.textBox1.TabIndex = 9;
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
            this.butDo.Location = new System.Drawing.Point(12, 7);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(63, 35);
            this.butDo.TabIndex = 11;
            this.butDo.Text = "do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // FrmTestLexeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 438);
            this.Controls.Add(this.butDo);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLexeme);
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
        private System.Windows.Forms.TextBox txtBoxLexeme;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butDo;
    }
}