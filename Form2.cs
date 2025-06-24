using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;    // Required to use ZipStorer class
using System.Resources;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Graphics
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void fileExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileBackMenuItem_Click(object sender, EventArgs e)
        {
            editExampleNameForm eForm = new editExampleNameForm();
            mainForm mForm = new mainForm();
            //saveFileDlg.FileName = eForm.editableExampleName;
/*
            string projectName = eForm.editableExampleName;

            if (projectName != "")
            {

                try
                {
                    Assembly assembly;
                    Stream zipStream;

                    assembly = Assembly.GetExecutingAssembly();
                    zipStream = assembly.GetManifestResourceStream("Graphics.Resources.newOpenGL.zip");
                    string newPath = @"C:\examples\Custom\" + projectName;
                    mForm.extract(zipStream, newPath);
                    statusLbl.Text = "Δημιουργία νέου παραδείγματος...";
                }
                catch
                {
                    statusLbl.Text = "";
                    MessageBox.Show("Σφάλμα: Το αρχείο δεν μπόρεσε να δημιουργηθεί.", "Δημιουργία νέου παραδείγματος", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Προσθήκη στο μενού
                mForm.newProject = new ToolStripMenuItem();

                mForm.examplesCustomMenuItem.DropDownItems.Add(mForm.newProject);
                mForm.newProject.Text = projectName;
                mForm.newProject.Name = projectName + "MenuItem";
                mForm.newProject.Click += new EventHandler(mForm.newProject_Click);


                //Άνοιγμα παραδείγματος
                mForm.exampleName = "newOpenGl";

                mForm.examplePath = "C:\\examples\\Custom\\" + projectName + "\\" + mForm.exampleName + "\\" + mForm.exampleName + ".cpp";
                //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
                FileManager fm = new FileManager(mForm.examplePath);

                mForm.code = fm.readFile();
                //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
                mForm.textChangedEventFlag = false;
                mForm.codeTxtBox.Clear();
                mForm.Parse();
                mForm.textChangedEventFlag = true;
            }


            FileManager flm = new FileManager(saveFileDlg.FileName);
            flm.writeFile(editCodeTxtBox.Text);
            mForm.codeTxtBox.Lines = editCodeTxtBox.Lines;
            Close();*/
        }


        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            if (editCodeTxtBox.SelectionLength > 0)

                editCodeTxtBox.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (editCodeTxtBox.SelectionLength > 0)

                editCodeTxtBox.Copy();

        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                editCodeTxtBox.Paste();
            }

        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            if (editCodeTxtBox.CanUndo)
            {
                editCodeTxtBox.Undo();
                editCodeTxtBox.ClearUndo();
            }
        }
    }
}
