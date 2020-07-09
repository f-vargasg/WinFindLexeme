﻿namespace WinFindLexeme
{
    partial class FrmPrincCRUDGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincCRUDGen));
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DoTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.TestTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.ExittlsStr = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SpecPg = new System.Windows.Forms.TabPage();
            this.BodyPg = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SpecPg.SuspendLayout();
            this.BodyPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTemplate
            // 
            this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplate.Location = new System.Drawing.Point(3, 44);
            this.txtTemplate.Multiline = true;
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTemplate.Size = new System.Drawing.Size(1090, 307);
            this.txtTemplate.TabIndex = 0;
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Location = new System.Drawing.Point(3, 3);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(1079, 271);
            this.txtBody.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(107, 9);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(502, 26);
            this.txtTableName.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoTlsStrp,
            this.TestTlsStrp,
            this.ExittlsStr});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DoTlsStrp
            // 
            this.DoTlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DoTlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("DoTlsStrp.Image")));
            this.DoTlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DoTlsStrp.Name = "DoTlsStrp";
            this.DoTlsStrp.Size = new System.Drawing.Size(23, 22);
            this.DoTlsStrp.Text = "toolStripButton1";
            this.DoTlsStrp.ToolTipText = "Do Process";
            this.DoTlsStrp.Click += new System.EventHandler(this.DoTlsStrp_Click);
            // 
            // TestTlsStrp
            // 
            this.TestTlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TestTlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("TestTlsStrp.Image")));
            this.TestTlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TestTlsStrp.Name = "TestTlsStrp";
            this.TestTlsStrp.Size = new System.Drawing.Size(23, 22);
            this.TestTlsStrp.Text = "toolStripButton2";
            this.TestTlsStrp.ToolTipText = "Test";
            this.TestTlsStrp.Click += new System.EventHandler(this.TestTlsStrp_Click);
            // 
            // ExittlsStr
            // 
            this.ExittlsStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExittlsStr.Image = ((System.Drawing.Image)(resources.GetObject("ExittlsStr.Image")));
            this.ExittlsStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExittlsStr.Name = "ExittlsStr";
            this.ExittlsStr.Size = new System.Drawing.Size(23, 22);
            this.ExittlsStr.Text = "toolStripButton3";
            this.ExittlsStr.ToolTipText = "Exit";
            this.ExittlsStr.Click += new System.EventHandler(this.ExittlsStr_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SpecPg);
            this.tabControl1.Controls.Add(this.BodyPg);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 310);
            this.tabControl1.TabIndex = 7;
            // 
            // SpecPg
            // 
            this.SpecPg.Controls.Add(this.txtSpec);
            this.SpecPg.Location = new System.Drawing.Point(4, 29);
            this.SpecPg.Name = "SpecPg";
            this.SpecPg.Padding = new System.Windows.Forms.Padding(3);
            this.SpecPg.Size = new System.Drawing.Size(1085, 277);
            this.SpecPg.TabIndex = 0;
            this.SpecPg.Text = "Package Spec";
            this.SpecPg.UseVisualStyleBackColor = true;
            // 
            // BodyPg
            // 
            this.BodyPg.Controls.Add(this.txtBody);
            this.BodyPg.Location = new System.Drawing.Point(4, 29);
            this.BodyPg.Name = "BodyPg";
            this.BodyPg.Padding = new System.Windows.Forms.Padding(3);
            this.BodyPg.Size = new System.Drawing.Size(1085, 277);
            this.BodyPg.TabIndex = 1;
            this.BodyPg.Text = "Package Body";
            this.BodyPg.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTemplate);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTableName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1093, 668);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 8;
            // 
            // txtSpec
            // 
            this.txtSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpec.Location = new System.Drawing.Point(3, 3);
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSpec.Size = new System.Drawing.Size(1079, 271);
            this.txtSpec.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 693);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.SpecPg.ResumeLayout(false);
            this.SpecPg.PerformLayout();
            this.BodyPg.ResumeLayout(false);
            this.BodyPg.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DoTlsStrp;
        private System.Windows.Forms.ToolStripButton TestTlsStrp;
        private System.Windows.Forms.ToolStripButton ExittlsStr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SpecPg;
        private System.Windows.Forms.TabPage BodyPg;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSpec;
    }
}

