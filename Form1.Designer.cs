namespace TagMappingEdit
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
            this.radButtonReload = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer)).BeginInit();
            this.radSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonReload
            // 
            this.radButtonReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonReload.Location = new System.Drawing.Point(615, 588);
            this.radButtonReload.Name = "radButtonReload";
            this.radButtonReload.Size = new System.Drawing.Size(190, 24);
            this.radButtonReload.TabIndex = 11;
            this.radButtonReload.Text = "Load from system";
            this.radButtonReload.Click += new System.EventHandler(this.radButtonReloadSystem_Click);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(614, 618);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(190, 24);
            this.radButton1.TabIndex = 12;
            this.radButton1.Text = "Load from User";
            this.radButton1.Click += new System.EventHandler(this.radButtonReloadUser_Click);
            // 
            // radSplitContainer
            // 
            this.radSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSplitContainer.Controls.Add(this.splitPanel1);
            this.radSplitContainer.Controls.Add(this.splitPanel2);
            this.radSplitContainer.Location = new System.Drawing.Point(9, 9);
            this.radSplitContainer.Name = "radSplitContainer";
            // 
            // 
            // 
            this.radSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer.Size = new System.Drawing.Size(795, 561);
            this.radSplitContainer.SplitterWidth = 10;
            this.radSplitContainer.TabIndex = 13;
            this.radSplitContainer.TabStop = false;
            this.radSplitContainer.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(356, 561);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.04685777F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-43, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Location = new System.Drawing.Point(366, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(429, 561);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.04685777F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(43, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 651);
            this.Controls.Add(this.radSplitContainer);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radButtonReload);
            this.MinimumSize = new System.Drawing.Size(789, 476);
            this.Name = "Form1";
            this.Text = "Form Host";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer)).EndInit();
            this.radSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton radButtonReload;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
    }
}

