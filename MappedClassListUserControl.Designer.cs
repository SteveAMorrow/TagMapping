namespace TagMappingEdit
{
    partial class MappedClassListUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MappedClassListUserControl));
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
            this.radGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.radPageView = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage2D = new Telerik.WinControls.UI.RadPageViewPage();
            this.radListViewMappedClasses2D = new Telerik.WinControls.UI.RadListView();
            this.radPageViewPage3D = new Telerik.WinControls.UI.RadPageViewPage();
            this.radListViewMappedClasses3D = new Telerik.WinControls.UI.RadListView();
            this.radButtonCopy = new Telerik.WinControls.UI.RadButton();
            this.radButtonRemove = new Telerik.WinControls.UI.RadButton();
            this.buttonClearFilter = new Telerik.WinControls.UI.RadButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonFilter = new Telerik.WinControls.UI.RadButton();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.radButtonNew = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox)).BeginInit();
            this.radGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).BeginInit();
            this.radPageView.SuspendLayout();
            this.radPageViewPage2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewMappedClasses2D)).BeginInit();
            this.radPageViewPage3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewMappedClasses3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox
            // 
            this.radGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox.Controls.Add(this.radPageView);
            this.radGroupBox.Controls.Add(this.radButtonCopy);
            this.radGroupBox.Controls.Add(this.radButtonRemove);
            this.radGroupBox.Controls.Add(this.buttonClearFilter);
            this.radGroupBox.Controls.Add(this.buttonFilter);
            this.radGroupBox.Controls.Add(this.labelFilter);
            this.radGroupBox.Controls.Add(this.textBoxFilter);
            this.radGroupBox.Controls.Add(this.radButtonNew);
            this.radGroupBox.Controls.Add(this.radButtonSave);
            resources.ApplyResources(this.radGroupBox, "radGroupBox");
            this.radGroupBox.Name = "radGroupBox";
            // 
            // radPageView
            // 
            resources.ApplyResources(this.radPageView, "radPageView");
            this.radPageView.Controls.Add(this.radPageViewPage2D);
            this.radPageView.Controls.Add(this.radPageViewPage3D);
            this.radPageView.Name = "radPageView";
            this.radPageView.SelectedPage = this.radPageViewPage2D;
            this.radPageView.ThemeName = "VisualStudio2012Light";
            this.radPageView.SelectedPageChanged += new System.EventHandler(this.radPageView_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView.GetChildAt(0))).ShowItemPinButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView.GetChildAt(0))).ShowItemCloseButton = false;
            // 
            // radPageViewPage2D
            // 
            this.radPageViewPage2D.Controls.Add(this.radListViewMappedClasses2D);
            this.radPageViewPage2D.ItemSize = new System.Drawing.SizeF(26F, 24F);
            resources.ApplyResources(this.radPageViewPage2D, "radPageViewPage2D");
            this.radPageViewPage2D.Name = "radPageViewPage2D";
            // 
            // radListViewMappedClasses2D
            // 
            this.radListViewMappedClasses2D.AllowColumnReorder = false;
            this.radListViewMappedClasses2D.AllowColumnResize = false;
            this.radListViewMappedClasses2D.AllowEdit = false;
            listViewDetailColumn1.HeaderText = "Column 0";
            this.radListViewMappedClasses2D.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1});
            resources.ApplyResources(this.radListViewMappedClasses2D, "radListViewMappedClasses2D");
            this.radListViewMappedClasses2D.EnableFiltering = true;
            this.radListViewMappedClasses2D.Name = "radListViewMappedClasses2D";
            this.radListViewMappedClasses2D.ThemeName = "VisualStudio2012Light";
            this.radListViewMappedClasses2D.ItemRemoved += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radListViewMappedClasses_ItemRemoved);
            // 
            // radPageViewPage3D
            // 
            this.radPageViewPage3D.Controls.Add(this.radListViewMappedClasses3D);
            this.radPageViewPage3D.ItemSize = new System.Drawing.SizeF(26F, 24F);
            resources.ApplyResources(this.radPageViewPage3D, "radPageViewPage3D");
            this.radPageViewPage3D.Name = "radPageViewPage3D";
            // 
            // radListViewMappedClasses3D
            // 
            this.radListViewMappedClasses3D.AllowColumnReorder = false;
            this.radListViewMappedClasses3D.AllowColumnResize = false;
            this.radListViewMappedClasses3D.AllowEdit = false;
            listViewDetailColumn2.HeaderText = "Column 0";
            this.radListViewMappedClasses3D.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn2});
            resources.ApplyResources(this.radListViewMappedClasses3D, "radListViewMappedClasses3D");
            this.radListViewMappedClasses3D.EnableFiltering = true;
            this.radListViewMappedClasses3D.Name = "radListViewMappedClasses3D";
            this.radListViewMappedClasses3D.ThemeName = "VisualStudio2012Light";
            // 
            // radButtonCopy
            // 
            resources.ApplyResources(this.radButtonCopy, "radButtonCopy");
            this.radButtonCopy.Name = "radButtonCopy";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonCopy.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonCopy.GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText");
            // 
            // radButtonRemove
            // 
            resources.ApplyResources(this.radButtonRemove, "radButtonRemove");
            this.radButtonRemove.Name = "radButtonRemove";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonRemove.GetChildAt(0))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonRemove.GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText1");
            // 
            // buttonClearFilter
            // 
            resources.ApplyResources(this.buttonClearFilter, "buttonClearFilter");
            this.buttonClearFilter.ImageList = this.imageList;
            this.buttonClearFilter.Name = "buttonClearFilter";
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonClearFilter.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonClearFilter.GetChildAt(0))).ImageKey = resources.GetString("resource.ImageKey");
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonClearFilter.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonClearFilter.GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText2");
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Filter.ico");
            this.imageList.Images.SetKeyName(1, "Clear_2.ico");
            // 
            // buttonFilter
            // 
            resources.ApplyResources(this.buttonFilter, "buttonFilter");
            this.buttonFilter.ImageList = this.imageList;
            this.buttonFilter.Name = "buttonFilter";
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonFilter.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonFilter.GetChildAt(0))).ImageKey = resources.GetString("resource.ImageKey1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonFilter.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.buttonFilter.GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText3");
            // 
            // labelFilter
            // 
            resources.ApplyResources(this.labelFilter, "labelFilter");
            this.labelFilter.Name = "labelFilter";
            // 
            // textBoxFilter
            // 
            resources.ApplyResources(this.textBoxFilter, "textBoxFilter");
            this.textBoxFilter.Name = "textBoxFilter";
            // 
            // radButtonNew
            // 
            resources.ApplyResources(this.radButtonNew, "radButtonNew");
            this.radButtonNew.Name = "radButtonNew";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonNew.GetChildAt(0))).Text = resources.GetString("resource.Text2");
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButtonNew.GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText4");
            // 
            // radButtonSave
            // 
            resources.ApplyResources(this.radButtonSave, "radButtonSave");
            this.radButtonSave.Name = "radButtonSave";
            // 
            // MappedClassListUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox);
            this.Name = "MappedClassListUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox)).EndInit();
            this.radGroupBox.ResumeLayout(false);
            this.radGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView)).EndInit();
            this.radPageView.ResumeLayout(false);
            this.radPageViewPage2D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListViewMappedClasses2D)).EndInit();
            this.radPageViewPage3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListViewMappedClasses3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox;
        private Telerik.WinControls.UI.RadButton radButtonCopy;
        private Telerik.WinControls.UI.RadButton radButtonRemove;
        private Telerik.WinControls.UI.RadButton buttonClearFilter;
        private Telerik.WinControls.UI.RadButton buttonFilter;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private Telerik.WinControls.UI.RadListView radListViewMappedClasses2D;
        private Telerik.WinControls.UI.RadButton radButtonNew;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.UI.RadPageView radPageView;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2D;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3D;
        private Telerik.WinControls.UI.RadListView radListViewMappedClasses3D;
    }
}
