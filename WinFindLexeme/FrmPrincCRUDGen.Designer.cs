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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExittlsStr = new System.Windows.Forms.ToolStripButton();
            this.DoTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.LoadTempTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.TestTlsStrp = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscFld = new System.Windows.Forms.TextBox();
            this.TemplatesTab = new System.Windows.Forms.TabControl();
            this.SpecOutTbPg = new System.Windows.Forms.TabPage();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.BodyOutTbPg = new System.Windows.Forms.TabPage();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.SpecTempTbPg = new System.Windows.Forms.TabPage();
            this.txtTempSpec = new System.Windows.Forms.TextBox();
            this.BodyTempTbPg = new System.Windows.Forms.TabPage();
            this.txtTempBod = new System.Windows.Forms.TextBox();
            this.TestTbPg = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLexeme = new System.Windows.Forms.TextBox();
            this.butDo = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.TemplatesTab.SuspendLayout();
            this.SpecOutTbPg.SuspendLayout();
            this.BodyOutTbPg.SuspendLayout();
            this.SpecTempTbPg.SuspendLayout();
            this.BodyTempTbPg.SuspendLayout();
            this.TestTbPg.SuspendLayout();
            this.pnlParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(208, 61);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(502, 39);
            this.txtTableName.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExittlsStr,
            this.DoTlsStrp,
            this.LoadTempTlsStrp,
            this.TestTlsStrp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1144, 38);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ExittlsStr
            // 
            this.ExittlsStr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExittlsStr.Image = ((System.Drawing.Image)(resources.GetObject("ExittlsStr.Image")));
            this.ExittlsStr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExittlsStr.Name = "ExittlsStr";
            this.ExittlsStr.Size = new System.Drawing.Size(40, 32);
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
            this.DoTlsStrp.Size = new System.Drawing.Size(40, 32);
            this.DoTlsStrp.Text = "toolStripButton1";
            this.DoTlsStrp.ToolTipText = "Do Process";
            this.DoTlsStrp.Click += new System.EventHandler(this.DoTlsStrp_Click);
            // 
            // LoadTempTlsStrp
            // 
            this.LoadTempTlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadTempTlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("LoadTempTlsStrp.Image")));
            this.LoadTempTlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadTempTlsStrp.Name = "LoadTempTlsStrp";
            this.LoadTempTlsStrp.Size = new System.Drawing.Size(40, 32);
            this.LoadTempTlsStrp.Text = "toolStripButton1";
            this.LoadTempTlsStrp.ToolTipText = "Load Template";
            this.LoadTempTlsStrp.Click += new System.EventHandler(this.LoadTempTlsStrp_Click);
            // 
            // TestTlsStrp
            // 
            this.TestTlsStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TestTlsStrp.Image = ((System.Drawing.Image)(resources.GetObject("TestTlsStrp.Image")));
            this.TestTlsStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TestTlsStrp.Name = "TestTlsStrp";
            this.TestTlsStrp.Size = new System.Drawing.Size(40, 32);
            this.TestTlsStrp.Text = "toolStripButton2";
            this.TestTlsStrp.ToolTipText = "Test";
            this.TestTlsStrp.Click += new System.EventHandler(this.TestTlsStrp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discriminador:";
            // 
            // txtDiscFld
            // 
            this.txtDiscFld.Location = new System.Drawing.Point(208, 106);
            this.txtDiscFld.Name = "txtDiscFld";
            this.txtDiscFld.Size = new System.Drawing.Size(502, 39);
            this.txtDiscFld.TabIndex = 3;
            // 
            // TemplatesTab
            // 
            this.TemplatesTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplatesTab.Controls.Add(this.SpecOutTbPg);
            this.TemplatesTab.Controls.Add(this.BodyOutTbPg);
            this.TemplatesTab.Controls.Add(this.SpecTempTbPg);
            this.TemplatesTab.Controls.Add(this.BodyTempTbPg);
            this.TemplatesTab.Controls.Add(this.TestTbPg);
            this.TemplatesTab.Location = new System.Drawing.Point(9, 202);
            this.TemplatesTab.Name = "TemplatesTab";
            this.TemplatesTab.SelectedIndex = 0;
            this.TemplatesTab.Size = new System.Drawing.Size(1135, 509);
            this.TemplatesTab.TabIndex = 5;
            // 
            // SpecOutTbPg
            // 
            this.SpecOutTbPg.Controls.Add(this.txtSpec);
            this.SpecOutTbPg.Location = new System.Drawing.Point(4, 41);
            this.SpecOutTbPg.Name = "SpecOutTbPg";
            this.SpecOutTbPg.Size = new System.Drawing.Size(1127, 464);
            this.SpecOutTbPg.TabIndex = 4;
            this.SpecOutTbPg.Text = "Spec";
            this.SpecOutTbPg.UseVisualStyleBackColor = true;
            // 
            // txtSpec
            // 
            this.txtSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpec.Location = new System.Drawing.Point(0, 0);
            this.txtSpec.Multiline = true;
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSpec.Size = new System.Drawing.Size(1127, 464);
            this.txtSpec.TabIndex = 3;
            // 
            // BodyOutTbPg
            // 
            this.BodyOutTbPg.Controls.Add(this.txtBody);
            this.BodyOutTbPg.Location = new System.Drawing.Point(4, 41);
            this.BodyOutTbPg.Name = "BodyOutTbPg";
            this.BodyOutTbPg.Size = new System.Drawing.Size(1069, 431);
            this.BodyOutTbPg.TabIndex = 3;
            this.BodyOutTbPg.Text = "Body";
            this.BodyOutTbPg.UseVisualStyleBackColor = true;
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Location = new System.Drawing.Point(0, 0);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(1069, 431);
            this.txtBody.TabIndex = 2;
            // 
            // SpecTempTbPg
            // 
            this.SpecTempTbPg.Controls.Add(this.txtTempSpec);
            this.SpecTempTbPg.Location = new System.Drawing.Point(4, 41);
            this.SpecTempTbPg.Name = "SpecTempTbPg";
            this.SpecTempTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.SpecTempTbPg.Size = new System.Drawing.Size(1069, 431);
            this.SpecTempTbPg.TabIndex = 0;
            this.SpecTempTbPg.Text = "Spec Template";
            this.SpecTempTbPg.UseVisualStyleBackColor = true;
            // 
            // txtTempSpec
            // 
            this.txtTempSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempSpec.Location = new System.Drawing.Point(3, 3);
            this.txtTempSpec.Multiline = true;
            this.txtTempSpec.Name = "txtTempSpec";
            this.txtTempSpec.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTempSpec.Size = new System.Drawing.Size(1063, 425);
            this.txtTempSpec.TabIndex = 4;
            // 
            // BodyTempTbPg
            // 
            this.BodyTempTbPg.Controls.Add(this.txtTempBod);
            this.BodyTempTbPg.Location = new System.Drawing.Point(4, 41);
            this.BodyTempTbPg.Name = "BodyTempTbPg";
            this.BodyTempTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.BodyTempTbPg.Size = new System.Drawing.Size(1069, 431);
            this.BodyTempTbPg.TabIndex = 1;
            this.BodyTempTbPg.Text = "Body Template";
            this.BodyTempTbPg.UseVisualStyleBackColor = true;
            // 
            // txtTempBod
            // 
            this.txtTempBod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempBod.Location = new System.Drawing.Point(3, 3);
            this.txtTempBod.Multiline = true;
            this.txtTempBod.Name = "txtTempBod";
            this.txtTempBod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTempBod.Size = new System.Drawing.Size(1063, 425);
            this.txtTempBod.TabIndex = 3;
            // 
            // TestTbPg
            // 
            this.TestTbPg.Controls.Add(this.label3);
            this.TestTbPg.Controls.Add(this.txtLexeme);
            this.TestTbPg.Controls.Add(this.butDo);
            this.TestTbPg.Controls.Add(this.txtOutput);
            this.TestTbPg.Location = new System.Drawing.Point(4, 41);
            this.TestTbPg.Name = "TestTbPg";
            this.TestTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.TestTbPg.Size = new System.Drawing.Size(1069, 431);
            this.TestTbPg.TabIndex = 2;
            this.TestTbPg.Text = "Test Lexemes";
            this.TestTbPg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lexeme";
            // 
            // txtLexeme
            // 
            this.txtLexeme.Location = new System.Drawing.Point(120, 28);
            this.txtLexeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLexeme.Name = "txtLexeme";
            this.txtLexeme.Size = new System.Drawing.Size(527, 39);
            this.txtLexeme.TabIndex = 25;
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(29, 68);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(76, 30);
            this.butDo.TabIndex = 23;
            this.butDo.Text = "do";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.ButDo_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(7, 106);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(1062, 329);
            this.txtOutput.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Owner:";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(208, 12);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(502, 39);
            this.txtOwner.TabIndex = 1;
            // 
            // pnlParameters
            // 
            this.pnlParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParameters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParameters.Controls.Add(this.txtOwner);
            this.pnlParameters.Controls.Add(this.label5);
            this.pnlParameters.Controls.Add(this.label2);
            this.pnlParameters.Controls.Add(this.txtTableName);
            this.pnlParameters.Controls.Add(this.txtDiscFld);
            this.pnlParameters.Controls.Add(this.label1);
            this.pnlParameters.Location = new System.Drawing.Point(12, 41);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(1131, 155);
            this.pnlParameters.TabIndex = 9;
            // 
            // FrmPrincCRUDGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 714);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlParameters);
            this.Controls.Add(this.TemplatesTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincCRUDGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Oracle Packages";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TemplatesTab.ResumeLayout(false);
            this.SpecOutTbPg.ResumeLayout(false);
            this.SpecOutTbPg.PerformLayout();
            this.BodyOutTbPg.ResumeLayout(false);
            this.BodyOutTbPg.PerformLayout();
            this.SpecTempTbPg.ResumeLayout(false);
            this.SpecTempTbPg.PerformLayout();
            this.BodyTempTbPg.ResumeLayout(false);
            this.BodyTempTbPg.PerformLayout();
            this.TestTbPg.ResumeLayout(false);
            this.TestTbPg.PerformLayout();
            this.pnlParameters.ResumeLayout(false);
            this.pnlParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DoTlsStrp;
        private System.Windows.Forms.ToolStripButton TestTlsStrp;
        private System.Windows.Forms.ToolStripButton ExittlsStr;
        private System.Windows.Forms.TabControl TemplatesTab;
        private System.Windows.Forms.TabPage SpecTempTbPg;
        private System.Windows.Forms.TabPage BodyTempTbPg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscFld;
        private System.Windows.Forms.ToolStripButton LoadTempTlsStrp;
        private System.Windows.Forms.TabPage TestTbPg;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLexeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Panel pnlParameters;
        private System.Windows.Forms.TabPage SpecOutTbPg;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TabPage BodyOutTbPg;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtTempSpec;
        private System.Windows.Forms.TextBox txtTempBod;
    }
}

