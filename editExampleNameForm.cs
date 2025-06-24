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
    public partial class editExampleNameForm : Form
    {
        public string editableExampleName;

        public editExampleNameForm()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            editForm eForm = new editForm();
            mainForm mForm = new mainForm();

            eForm.editCodeTxtBox.Lines = mForm.codeTxtBox.Lines;
            eForm.ShowDialog();
            
            editableExampleName = nameTxtBox.Text;
            Close();

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTxtBox.Text != "")
            {
                NextBtn.Enabled = true;
            }
            else
            {
                NextBtn.Enabled = false;
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
