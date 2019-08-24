using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TagMappingEdit
{
    public partial class MappedClassUserControl : UserControl
    {
        private Mapping m_currentmap = null;
        private MappedClassListUserControl m_mappedClassListUserCtrl = null;
        private bool m_inSetMapping = false;

        public MappedClassUserControl(MappedClassListUserControl mappedClassListUserCtrl)
        {
            InitializeComponent();
            SetMapping(null);
            m_mappedClassListUserCtrl = mappedClassListUserCtrl;
            this.checkBoxAllowBrowse.CheckedChanged += new System.EventHandler(this.checkBoxAllowBrowse_CheckedChanged);
            this.checkBoxIsPolymorphic.CheckedChanged += new System.EventHandler(this.checkBoxIsPolymorphic_CheckedChanged);
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
        }


        public void SetMapping(Mapping map)
        {
            m_currentmap = map;
            m_inSetMapping = true;
            if (m_currentmap == null)
            {
                ResetMappingControlValues();
                m_inSetMapping = false;
                return;
            }
            radButtonAddMappedTarget.Enabled = true;
            textBoxClass.Text = map.Source; 
            textBoxDisplay.Text = map.Display;
            textBoxCategory.Text = map.Category;
            if (map.IsPolymorphic != null)
                checkBoxIsPolymorphic.Checked = (bool)map.IsPolymorphic;

            checkBoxAllowBrowse.Checked = map.AllowBrowse;
            listBoxMappedTargets.Items.Clear();
            if (map.MappedTargets != null)
                listBoxMappedTargets.Items.AddRange(map.MappedTargets.ToArray());

            m_inSetMapping = false;
        }
        public void ResetMappingControlValues()
        {
            listBoxMappedTargets.Items.Clear();
            radButtonRemoveMappedTarget.Enabled = false;
            radButtonAddMappedTarget.Enabled = false;
            textBoxDisplay.Text = string.Empty;
            checkBoxIsPolymorphic.Checked = false;
            checkBoxAllowBrowse.Checked = true;
            textBoxCategory.Text = string.Empty;
        }

        private bool AlreadyExists(string value)
        {
            foreach (string lv in listBoxMappedTargets.Items)
            {
                if (lv.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        private void SetMappedTargets()
        {
            if (m_currentmap == null)
                return;
            if (m_currentmap.MappedTargets == null)
                m_currentmap.MappedTargets = new List<string>();
            m_currentmap.MappedTargets = listBoxMappedTargets.Items.Cast<string>().ToList();
            m_mappedClassListUserCtrl.SaveButtonEnabledState = true;
        }


        private void radButtonAddMappedTarget_Click(object sender, EventArgs e)
        {
            string value = "op:"; // string.Empty;

            if (m_mappedClassListUserCtrl.TagClassMappingManager.TagClassMappingHelper.InputBox
                ("New Class Target name", ref value) == DialogResult.OK) //localize
            {
                if (AlreadyExists(value))
                    return;

                listBoxMappedTargets.Items.Add(value);
                SetMappedTargets();
            }
        }

        private void radButtonRemoveMappedTarget_Click(object sender, EventArgs e)
        {
            if (listBoxMappedTargets.SelectedItem != null)
                listBoxMappedTargets.Items.Remove(listBoxMappedTargets.SelectedItem);
            radButtonRemoveMappedTarget.Enabled = false;
            SetMappedTargets();
        }

        private void listBoxMappedTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            radButtonRemoveMappedTarget.Enabled = true;
        }

        private void checkBoxIsPolymorphic_CheckedChanged(object sender, EventArgs e)
        {
            if (m_currentmap == null || m_inSetMapping)
                return;

            m_currentmap.IsPolymorphic = checkBoxIsPolymorphic.Checked;
            m_mappedClassListUserCtrl.SaveButtonEnabledState = true;
        }

        private void checkBoxAllowBrowse_CheckedChanged(object sender, EventArgs e)
        {
            if (m_currentmap == null || m_inSetMapping)
                return;

            m_currentmap.AllowBrowse = checkBoxAllowBrowse.Checked;
            m_mappedClassListUserCtrl.SaveButtonEnabledState = true;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            if (m_currentmap == null || m_inSetMapping)
                return;
            m_currentmap.Category = textBoxCategory.Text;
            m_mappedClassListUserCtrl.SaveButtonEnabledState = true;

        }
    }
}
