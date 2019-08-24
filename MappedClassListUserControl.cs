using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace TagMappingEdit
{
    public partial class MappedClassListUserControl : UserControl
    {
        public MappingReader TagClassMappingManager = null;
        private Control m_radPanelHost = null;
        
        public MappedClassUserControl MappedClassUserCtrl { get; set; }

        public MappedClassListUserControl(MappingReader mappingManager,Control panelHost)
        {
            InitializeComponent();
            TagClassMappingManager = mappingManager;
            m_radPanelHost = panelHost;
            Populate();
            this.radListViewMappedClasses2D.SelectedItemChanged += new System.EventHandler(this.radListViewMappedClasses2D_SelectedItemChanged);
            this.radListViewMappedClasses3D.SelectedItemChanged += RadListViewMappedClasses3D_SelectedItemChanged;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            this.textBoxFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyUp);
            this.radButtonNew.Click += new System.EventHandler(this.radButtonNew_Click);
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            this.radButtonRemove.Click += new System.EventHandler(this.radButtonRemove_Click);
            this.radButtonCopy.Click += new System.EventHandler(this.radButtonCopy_Click);

        }
        private void Populate()
        {
            TagClassMappingManager.TagClassMappingHelper.Populate(radListViewMappedClasses2D, radListViewMappedClasses3D);
            radListViewMappedClasses2D.SelectedItem = null;
            radListViewMappedClasses3D.SelectedItem = null;
        }

        public bool SaveButtonEnabledState
        {
            get
            {
                return radButtonSave.Enabled;
            }
            set
            {
                radButtonSave.Enabled = value;
            }
        }

        private void ResetButtons()
        {
            radButtonCopy.Enabled = false;
            radButtonRemove.Enabled = false;
            m_radPanelHost.Enabled = false;
            MappedClassUserCtrl.SetMapping(null);
        }

        private void EnableButtons()
        {
            radButtonCopy.Enabled = true;
            radButtonRemove.Enabled = true;
            m_radPanelHost.Enabled = true;
        }

        private void Filter()
        {
            ResetButtons();
            CurrentListView.SelectedItem = null;
            if (string.IsNullOrEmpty(textBoxFilter.Text))
            {
                CurrentListView.FilterDescriptors.Clear();
            }
            else
            {
                FilterDescriptor valueFilter = new FilterDescriptor("Value", FilterOperator.Contains, textBoxFilter.Text);
                CurrentListView.FilterDescriptors.Add(valueFilter);
            }
        }

        private bool AlreadyExists(string value)
        {
            return TagClassMappingManager.TagClassMappingHelper.AlreadyDefined(value);
        }

        public RadListView CurrentListView
        {
            get
            {
                RadPageViewPage vp = radPageView.SelectedPage;
                switch (vp.Name)
                {
                    case "radPageViewPage2D":
                        return radListViewMappedClasses2D;
                    case "radPageViewPage3D":
                        return radListViewMappedClasses3D;
                }
                return radListViewMappedClasses2D;
            }
        }

        public string CurrentPrefix
        {
            get
            {
                RadPageViewPage vp = radPageView.SelectedPage;
                switch (vp.Name)
                {
                    case "radPageViewPage2D":
                        return TagClassMappingHelper.Mapping2DPrefix;
                    case "radPageViewPage3D":
                        return TagClassMappingHelper.Mapping3DPrefix;
                }
                return string.Empty;
            }
        }

        private void CreateNewMapping(string title, Mapping map)
        {
            string value = map.Source;
            if (string.IsNullOrEmpty(value))
                value = CurrentPrefix + ":";

            if (TagClassMappingManager.TagClassMappingHelper.InputBox(title, ref value) == DialogResult.OK)
            {
                if (AlreadyExists(value))
                {
                    MessageBox.Show("Class exists in mapping", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                map.Source = value;
                map.Display = value; //should use ec class display
                ListViewDataItem lv = new ListViewDataItem(map.Source);
                lv.Tag = map;
                CurrentListView.Items.Add(lv);
                CurrentListView.SelectedItem = lv;
                MappedClassUserCtrl.SetMapping(map);
                if (!TagClassMappingManager.TagClassMappingHelper.TagClassMappingConfig.ContainsKey(value))
                    TagClassMappingManager.TagClassMappingHelper.TagClassMappingConfig.Add(value, map); //should I read to save or just mod the source???
                radButtonSave.Enabled = true;
            }
        }

        private void RadListViewMappedClasses3D_SelectedItemChanged(object sender, EventArgs e)
        {
            ListViewItemEventArgs viewItemEventArgs = e as ListViewItemEventArgs;
            if (viewItemEventArgs.Item == null) return;
            SelectedItemChanged(viewItemEventArgs.Item);
            EnableButtons();
        }

        private void radListViewMappedClasses2D_SelectedItemChanged(object sender, EventArgs e)
        {
            ListViewItemEventArgs viewItemEventArgs = e as ListViewItemEventArgs;
            if (viewItemEventArgs.Item == null) return;
            SelectedItemChanged(viewItemEventArgs.Item);
            EnableButtons();
        }

        private void SelectedItemChanged(ListViewDataItem lv)
        {                       
            Mapping map = null;
            if (lv != null)
                map = lv.Tag as Mapping;
            MappedClassUserCtrl.SetMapping(map);
        }
        
        private void textBoxFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Filter();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = string.Empty;
            Filter();
        }

        private void radButtonNew_Click(object sender, EventArgs e)
        {
            Mapping map = new Mapping();
            map.Source = string.Empty;
            map.Category = string.Empty;
            CreateNewMapping("New Class Mapping", map);//localize
        }

        private void radButtonCopy_Click(object sender, EventArgs e)
        {
            ListViewDataItem lv = CurrentListView.SelectedItem;
            if (lv == null)
                return;

            Mapping map = lv.Tag as Mapping;
            Mapping clone = TagClassMappingManager.TagClassMappingHelper.Clone(map);
            CreateNewMapping("Copy Class Mapping", clone); //localize
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            TagClassMappingManager.TagClassMappingHelper.Save();
            radButtonSave.Enabled = false;
        }

        private void RemoveItem(ListViewDataItem lv, bool manualRemove)
        {
            if (lv == null)
                return;

            Mapping map = lv.Tag as Mapping;
            if (map == null)
                return;

            string key = map.Source.ToLower(); //needs to lower because that is how keys are stored
            if (TagClassMappingManager.TagClassMappingHelper.TagClassMappingConfig.ContainsKey(key))
                TagClassMappingManager.TagClassMappingHelper.TagClassMappingConfig.Remove(key); //should I read to save or just mod the source???

            //needed for remove button
            if (manualRemove)
                CurrentListView.Items.Remove(lv);

            ResetButtons();
            radButtonSave.Enabled = true;
        }

        private void radButtonRemove_Click(object sender, EventArgs e)
        {
            RemoveItem(CurrentListView.SelectedItem, true);
        }

        private void radListViewMappedClasses_ItemRemoved(object sender, ListViewItemEventArgs e)
        {            
            RemoveItem(e.Item, false);
        }

        private void radPageView_SelectedPageChanged(object sender, EventArgs e)
        {
            ListViewDataItem lv = CurrentListView.SelectedItem;
            radButtonCopy.Enabled = lv == null ? false : true;
            radButtonRemove.Enabled = lv == null ? false : true;
            SelectedItemChanged(lv);

        }
    }
}
