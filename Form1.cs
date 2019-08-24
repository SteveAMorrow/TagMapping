using System.Windows.Forms;

namespace TagMappingEdit
{
    public partial class Form1 : Form
    {

        string cfg = @"C:\Coding\TagMappingEdit\mapping\MappingsTagClass.json";
        string usercfg = @"C:\Coding\TagMappingEdit\mapping\UserMappingsTagClass.json";
        MappedClassListUserControl mcl = null;
        public Form1()
        {
            InitializeComponent();
            LoadMapping(true);
        }
        private void radButtonReloadSystem_Click(object sender, System.EventArgs e)
        {
            LoadMapping(false);
        }
        private void radButtonReloadUser_Click(object sender, System.EventArgs e)
        {
            LoadMapping(true);
        }

        private void LoadMapping(bool useUserCfg)
        {
            radSplitContainer.SplitPanels[0].Controls.Clear();
            radSplitContainer.SplitPanels[1].Controls.Clear();
            mcl = null;
            MappingReader mappingManager = new MappingReader(cfg, usercfg, useUserCfg);
            mcl = new MappedClassListUserControl(mappingManager, radSplitContainer.SplitPanels[1]);
            radSplitContainer.SplitPanels[0].Controls.Add(mcl);
            mcl.Dock = DockStyle.Fill;

            MappedClassUserControl mappedClassUserCtrl = new MappedClassUserControl(mcl);
            mcl.MappedClassUserCtrl = mappedClassUserCtrl;
            radSplitContainer.SplitPanels[1].Controls.Add(mappedClassUserCtrl);
            mappedClassUserCtrl.Dock = DockStyle.Fill;

        }


    }
}
