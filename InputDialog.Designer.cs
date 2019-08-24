namespace TagMappingEdit
{
    partial class InputDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDialog));
            this.radButtonOk = new Telerik.WinControls.UI.RadButton();
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonOk
            // 
            resources.ApplyResources(this.radButtonOk, "radButtonOk");
            this.radButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.radButtonOk.Name = "radButtonOk";
            this.radButtonOk.Click += new System.EventHandler(this.radButtonOk_Click);
            // 
            // radButtonCancel
            // 
            resources.ApplyResources(this.radButtonCancel, "radButtonCancel");
            this.radButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.radButtonCancel.Name = "radButtonCancel";
            // 
            // labelDisplay
            // 
            resources.ApplyResources(this.labelDisplay, "labelDisplay");
            this.labelDisplay.Name = "labelDisplay";
            // 
            // textBoxValue
            // 
            resources.ApplyResources(this.textBoxValue, "textBoxValue");
            this.textBoxValue.Name = "textBoxValue";
            // 
            // InputDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.radButtonOk);
            this.Controls.Add(this.radButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputDialog";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonOk;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.TextBox textBoxValue;
    }
}