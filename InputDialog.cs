using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagMappingEdit
{
    public partial class InputDialog : Form
    {
        public InputDialog(string title, ref string value)
        {
            InitializeComponent();
            this.Text = title;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            this.textBoxValue.Text = value;    
            textBoxValue.Focus();
            textBoxValue.SelectionStart = textBoxValue.Text.Length;
        }

        public string ClassName
        {
            get
            {
                return textBoxValue.Text;
            }
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            radButtonOk.Enabled = string.IsNullOrEmpty(textBoxValue.Text) ? false : true;
        }

        private void radButtonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
