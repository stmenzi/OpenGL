using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics
{
    public partial class newExampleForm : Form
    {

        public string exampleName;

        public newExampleForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            exampleName = nameTxtBox.Text;
            Close();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTxtBox.Text != "")
            {
                createBtn.Enabled = true;
            }
            else
            {
                createBtn.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
