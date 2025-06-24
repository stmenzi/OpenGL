using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Graphics
{
    class customExamples
    {
        public ToolStripMenuItem newProject;
        public string projectName;

        public void addCustomExamples() {
            var mForm = Form.ActiveForm as mainForm;
        	
 newProject = new ToolStripMenuItem();
 mForm.examplesCustomMenuItem.DropDownItems.Add(newProject);
 newProject.Text = projectName;
 newProject.Name = projectName + "MenuItem";
 newProject.Click += new EventHandler(mForm.newProject_Click);
}
    }
}
