namespace TagMappingEdit
{
    partial class MappedClassUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MappedClassUserControl));
            this.radGroupBoxClassProps = new Telerik.WinControls.UI.RadGroupBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.checkBoxAllowBrowse = new System.Windows.Forms.CheckBox();
            this.radGroupBoxTargets = new Telerik.WinControls.UI.RadGroupBox();
            this.listBoxMappedTargets = new System.Windows.Forms.ListBox();
            this.radButtonAddMappedTarget = new Telerik.WinControls.UI.RadButton();
            this.radButtonRemoveMappedTarget = new Telerik.WinControls.UI.RadButton();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.checkBoxIsPolymorphic = new System.Windows.Forms.CheckBox();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxClassProps)).BeginInit();
            this.radGroupBoxClassProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxTargets)).BeginInit();
            this.radGroupBoxTargets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddMappedTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveMappedTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBoxClassProps
            // 
            this.radGroupBoxClassProps.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxClassProps.Controls.Add(this.labelClass);
            this.radGroupBoxClassProps.Controls.Add(this.textBoxClass);
            this.radGroupBoxClassProps.Controls.Add(this.checkBoxAllowBrowse);
            this.radGroupBoxClassProps.Controls.Add(this.radGroupBoxTargets);
            this.radGroupBoxClassProps.Controls.Add(this.labelCategory);
            this.radGroupBoxClassProps.Controls.Add(this.labelDisplay);
            this.radGroupBoxClassProps.Controls.Add(this.textBoxCategory);
            this.radGroupBoxClassProps.Controls.Add(this.checkBoxIsPolymorphic);
            this.radGroupBoxClassProps.Controls.Add(this.textBoxDisplay);
            resources.ApplyResources(this.radGroupBoxClassProps, "radGroupBoxClassProps");
            this.radGroupBoxClassProps.Name = "radGroupBoxClassProps";
            // 
            // labelClass
            // 
            resources.ApplyResources(this.labelClass, "labelClass");
            this.labelClass.Name = "labelClass";
            // 
            // textBoxClass
            // 
            resources.ApplyResources(this.textBoxClass, "textBoxClass");
            this.textBoxClass.Name = "textBoxClass";
            // 
            // checkBoxAllowBrowse
            // 
            resources.ApplyResources(this.checkBoxAllowBrowse, "checkBoxAllowBrowse");
            this.checkBoxAllowBrowse.Name = "checkBoxAllowBrowse";
            this.checkBoxAllowBrowse.UseVisualStyleBackColor = true;
            // 
            // radGroupBoxTargets
            // 
            this.radGroupBoxTargets.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            resources.ApplyResources(this.radGroupBoxTargets, "radGroupBoxTargets");
            this.radGroupBoxTargets.Controls.Add(this.listBoxMappedTargets);
            this.radGroupBoxTargets.Controls.Add(this.radButtonAddMappedTarget);
            this.radGroupBoxTargets.Controls.Add(this.radButtonRemoveMappedTarget);
            this.radGroupBoxTargets.Name = "radGroupBoxTargets";
            // 
            // listBoxMappedTargets
            // 
            resources.ApplyResources(this.listBoxMappedTargets, "listBoxMappedTargets");
            this.listBoxMappedTargets.FormattingEnabled = true;
            this.listBoxMappedTargets.Name = "listBoxMappedTargets";
            this.listBoxMappedTargets.SelectedIndexChanged += new System.EventHandler(this.listBoxMappedTargets_SelectedIndexChanged);
            // 
            // radButtonAddMappedTarget
            // 
            resources.ApplyResources(this.radButtonAddMappedTarget, "radButtonAddMappedTarget");
            this.radButtonAddMappedTarget.Name = "radButtonAddMappedTarget";
            this.radButtonAddMappedTarget.Click += new System.EventHandler(this.radButtonAddMappedTarget_Click);
            // 
            // radButtonRemoveMappedTarget
            // 
            resources.ApplyResources(this.radButtonRemoveMappedTarget, "radButtonRemoveMappedTarget");
            this.radButtonRemoveMappedTarget.Name = "radButtonRemoveMappedTarget";
            this.radButtonRemoveMappedTarget.Click += new System.EventHandler(this.radButtonRemoveMappedTarget_Click);
            // 
            // labelCategory
            // 
            resources.ApplyResources(this.labelCategory, "labelCategory");
            this.labelCategory.Name = "labelCategory";
            // 
            // labelDisplay
            // 
            resources.ApplyResources(this.labelDisplay, "labelDisplay");
            this.labelDisplay.Name = "labelDisplay";
            // 
            // textBoxCategory
            // 
            resources.ApplyResources(this.textBoxCategory, "textBoxCategory");
            this.textBoxCategory.Name = "textBoxCategory";
            // 
            // checkBoxIsPolymorphic
            // 
            resources.ApplyResources(this.checkBoxIsPolymorphic, "checkBoxIsPolymorphic");
            this.checkBoxIsPolymorphic.Name = "checkBoxIsPolymorphic";
            this.checkBoxIsPolymorphic.UseVisualStyleBackColor = true;
            // 
            // textBoxDisplay
            // 
            resources.ApplyResources(this.textBoxDisplay, "textBoxDisplay");
            this.textBoxDisplay.Name = "textBoxDisplay";
            // 
            // MappedClassUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBoxClassProps);
            this.Name = "MappedClassUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxClassProps)).EndInit();
            this.radGroupBoxClassProps.ResumeLayout(false);
            this.radGroupBoxClassProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxTargets)).EndInit();
            this.radGroupBoxTargets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddMappedTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveMappedTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBoxClassProps;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxTargets;
        private System.Windows.Forms.ListBox listBoxMappedTargets;
        private Telerik.WinControls.UI.RadButton radButtonAddMappedTarget;
        private Telerik.WinControls.UI.RadButton radButtonRemoveMappedTarget;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxIsPolymorphic;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.CheckBox checkBoxAllowBrowse;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxClass;
    }
}
