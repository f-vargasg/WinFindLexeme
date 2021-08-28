namespace WinOraclePackage
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
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExittlsStr = new System.Windows.Forms.ToolStripButton();
            this.DoTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.TestTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.LoadTempTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscFld = new System.Windows.Forms.TextBox();
            this.TemplatesTab = new System.Windows.Forms.TabControl();
            this.SpecTempTbPg = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtTempSpec = new System.Windows.Forms.TextBox();
            this.BodyTempTbPg = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtTempBod = new System.Windows.Forms.TextBox();
            this.TestTbPg = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLexeme = new System.Windows.Forms.TextBox();
            this.butDo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.TemplatesTab.SuspendLayout();
            this.SpecTempTbPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.BodyTempTbPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.TestTbPg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Location = new System.Drawing.Point(0, 0);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(1063, 248);
            this.txtBody.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(156, 28);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(502, 26);
            this.txtTableName.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExittlsStr,
            this.DoTlsStrp,
            this.LoadTempTlsStrp,
            this.TestTlsStrp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1086, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
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
            // LoadTempTlsStrp
            // 
            this.LoadTempTlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadTempTlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("LoadTempTlsStrp.Image")));
            this.LoadTempTlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadTempTlsStrp.Name = "LoadTempTlsStrp";
            this.LoadTempTlsStrp.Size = new System.Drawing.Size(23, 22);
            this.LoadTempTlsStrp.Text = "toolStripButton1";
            this.LoadTempTlsStrp.ToolTipText = "Load Template";
            this.LoadTempTlsStrp.Click += new System.EventHandler(this.LoadTempTlsStrp_Click);
            // 
            // txtSpec
            // 
            this.txtSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpec.Location = new System.Drawing.Point(0, 0);
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSpec.Size = new System.Drawing.Size(1063, 237);
            this.txtSpec.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discriminador:";
            // 
            // txtDiscFld
            // 
            this.txtDiscFld.Location = new System.Drawing.Point(156, 72);
            this.txtDiscFld.Name = "txtDiscFld";
            this.txtDiscFld.Size = new System.Drawing.Size(502, 26);
            this.txtDiscFld.TabIndex = 7;
            // 
            // TemplatesTab
            // 
            this.TemplatesTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplatesTab.Controls.Add(this.SpecTempTbPg);
            this.TemplatesTab.Controls.Add(this.BodyTempTbPg);
            this.TemplatesTab.Controls.Add(this.TestTbPg);
            this.TemplatesTab.Location = new System.Drawing.Point(9, 108);
            this.TemplatesTab.Name = "TemplatesTab";
            this.TemplatesTab.SelectedIndex = 0;
            this.TemplatesTab.Size = new System.Drawing.Size(1077, 521);
            this.TemplatesTab.TabIndex = 5;
            // 
            // SpecTempTbPg
            // 
            this.SpecTempTbPg.Controls.Add(this.splitContainer3);
            this.SpecTempTbPg.Location = new System.Drawing.Point(4, 29);
            this.SpecTempTbPg.Name = "SpecTempTbPg";
            this.SpecTempTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.SpecTempTbPg.Size = new System.Drawing.Size(1069, 488);
            this.SpecTempTbPg.TabIndex = 0;
            this.SpecTempTbPg.Text = "Spec Template";
            this.SpecTempTbPg.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtTempSpec);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtSpec);
            this.splitContainer3.Size = new System.Drawing.Size(1063, 482);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 3;
            // 
            // txtTempSpec
            // 
            this.txtTempSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempSpec.Location = new System.Drawing.Point(0, 0);
            this.txtTempSpec.Multiline = true;
            this.txtTempSpec.Name = "txtTempSpec";
            this.txtTempSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTempSpec.Size = new System.Drawing.Size(1063, 241);
            this.txtTempSpec.TabIndex = 1;
            // 
            // BodyTempTbPg
            // 
            this.BodyTempTbPg.Controls.Add(this.splitContainer2);
            this.BodyTempTbPg.Location = new System.Drawing.Point(4, 29);
            this.BodyTempTbPg.Name = "BodyTempTbPg";
            this.BodyTempTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.BodyTempTbPg.Size = new System.Drawing.Size(1069, 488);
            this.BodyTempTbPg.TabIndex = 1;
            this.BodyTempTbPg.Text = "Body Template";
            this.BodyTempTbPg.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtTempBod);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtBody);
            this.splitContainer2.Size = new System.Drawing.Size(1063, 482);
            this.splitContainer2.SplitterDistance = 230;
            this.splitContainer2.TabIndex = 2;
            // 
            // txtTempBod
            // 
            this.txtTempBod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempBod.Location = new System.Drawing.Point(0, 0);
            this.txtTempBod.Multiline = true;
            this.txtTempBod.Name = "txtTempBod";
            this.txtTempBod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTempBod.Size = new System.Drawing.Size(1063, 230);
            this.txtTempBod.TabIndex = 0;
            // 
            // TestTbPg
            // 
            this.TestTbPg.Controls.Add(this.label3);
            this.TestTbPg.Controls.Add(this.txtLexeme);
            this.TestTbPg.Controls.Add(this.butDo);
            this.TestTbPg.Controls.Add(this.label4);
            this.TestTbPg.Controls.Add(this.txtOwner);
            this.TestTbPg.Controls.Add(this.txtOutput);
            this.TestTbPg.Location = new System.Drawing.Point(4, 29);
            this.TestTbPg.Name = "TestTbPg";
            this.TestTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.TestTbPg.Size = new System.Drawing.Size(1069, 488);
            this.TestTbPg.TabIndex = 2;
            this.TestTbPg.Text = "Test Lexemes";
            this.TestTbPg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lexeme";
            // 
            // txtLexeme
            // 
            this.txtLexeme.Location = new System.Drawing.Point(118, 61);
            this.txtLexeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLexeme.Name = "txtLexeme";
            this.txtLexeme.Size = new System.Drawing.Size(527, 26);
            this.txtLexeme.TabIndex = 25;
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(29, 96);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(76, 30);
            this.butDo.TabIndex = 23;
            this.butDo.Text = "do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.ButDo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Owner";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(118, 25);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(527, 26);
            this.txtOwner.TabIndex = 20;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(7, 134);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1062, 346);
            this.txtOutput.TabIndex = 18;
            // 
            // FrmPrincCRUDGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 632);
            this.Controls.Add(this.TemplatesTab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiscFld);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincCRUDGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Oracle Packages";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TemplatesTab.ResumeLayout(false);
            this.SpecTempTbPg.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.BodyTempTbPg.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TestTbPg.ResumeLayout(false);
            this.TestTbPg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DoTlsStrp;
        private System.Windows.Forms.ToolStripButton TestTlsStrp;
        private System.Windows.Forms.ToolStripButton ExittlsStr;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TabControl TemplatesTab;
        private System.Windows.Forms.TabPage SpecTempTbPg;
        private System.Windows.Forms.TextBox txtTempSpec;
        private System.Windows.Forms.TabPage BodyTempTbPg;
        private System.Windows.Forms.TextBox txtTempBod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscFld;
        private System.Windows.Forms.ToolStripButton LoadTempTlsStrp;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabPage TestTbPg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLexeme;
    }
}

