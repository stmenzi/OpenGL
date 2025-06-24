using System;
using System.Collections.Generic;   //  Required to content the central directory
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;    // Required to use ZipStorer class
using System.Resources;
using System.Reflection;
using System.Text.RegularExpressions;


namespace Graphics
{
    public partial class mainForm : Form
    {
        public String code;
        public string exampleName;
        public string examplePath;
        public string projPath;
        public string exePath;
        public ToolStripMenuItem newProject;
        public bool textChangedEventFlag;
       
        // Define static variables shared by class methods. 
        public static StringBuilder prOutput = null;
        private static int numOutputLines = 0;
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            addCustomExamples();
        }

        /*
         * Η συνάρτηση  addCustomExamples διαβάζει τα ονόματα των παραδειγμάτων που έχουν δημιουργηθεί στο φάκελο Custom
         * και δημιουργεί το αντίστοιχο μενού στα "Παραδείγματα"
        */
        private void addCustomExamples(){
            if (Directory.Exists(@"C:\examples\Custom"))
            {
                string[] subdirectoryEntries = Directory.GetDirectories(@"C:\examples\Custom");
                string projectName;

                if (subdirectoryEntries != null)
                {
                    foreach (string subdirectory in subdirectoryEntries)
                    {

                        projectName = subdirectory.Substring(subdirectory.LastIndexOf("\\") + 1);

                        newProject = new ToolStripMenuItem();
                        examplesCustomMenuItem.DropDownItems.Add(newProject);

                        newProject.Text = projectName;
                        newProject.Name = projectName + "MenuItem";
                        newProject.Click += new EventHandler(newProject_Click);
                    }
                }
            }
        }

        private static void prOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                numOutputLines++;

                // Add the text to the collected output.
                prOutput.Append(Environment.NewLine + "[" + numOutputLines.ToString() + "] - " + outLine.Data);
            }
        }

        
        private void fileSaveMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDlg.FileName = examplePath;

            FileManager fm = new FileManager(saveFileDlg.FileName);
            fm.writeFile(codeTxtBox.Text);
            statusLbl.Text = "Το αρχείο αποθηκεύτηκε.";
            Thread.Sleep(3000);
            statusLbl.Text = "";
        }

        private void simplePointMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "simplePoint";
            examplePath = "C:\\examples\\"+exampleName+"\\"+exampleName+"\\"+exampleName+".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox μέσω τησ συνάρτησης Parse
            statusLbl.Text = "Το παράδειγμα \"Simple Point\" δημιουργεί ένα σημείο";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
        }

        private void fileExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "simpleLine";
            examplePath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            statusLbl.Text = "Το παράδειγμα \"Simple Line\" δημιουργεί μια γραμμή, η οποία δημιουργείται από δύο σημεία";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
  
        }

        private void lineStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "lineStrip";
            examplePath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + exampleName + "\\Debug\\" + exampleName + ".exe";
            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            statusLbl.Text = "Το παράδειγμα \"Line Strip\" δημιουργεί μια τεθλασμένη ανοιχτή γραμμή, η οποία δημιουργείται από την ακολουθία πολλών σημείων";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
        }

        private void lineLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "lineLoop";
            examplePath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            statusLbl.Text = "Το παράδειγμα \"Line Loop\" δημιουργεί μια τεθλασμένη κλειστή γραμμή, η οποία δημιουργείται από την ακολουθία πολλών σημείων";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
        }

        private void singleTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "simpleTriangle";
            examplePath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            statusLbl.Text = "Το παράδειγμα \"Simple Triangle\" δημιουργεί ένα τρίγωνο";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
        }

        private void cubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "cube";
            examplePath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            statusLbl.Text = "Το παράδειγμα \"Cube\" δημιουργεί έναν πολύχρωμο κύβο";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
        }

        private void cylindersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            exampleName = "cylinders";
            examplePath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + exampleName + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            statusLbl.Text = "Το παράδειγμα \"Cylinders\" δημιουργεί δύο διαφορετικούς κυλίνδρους. Πατώντας το πλήκτρο \"w\" εναλλάσσονται από πλέγμα σε συμπαγείς";
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
        }

        private void exeToolBarBtn_Click(object sender, EventArgs e)
        {
            regularMsg.Clear();
            try
            {
                OutputRedirect.InputText(projPath, exePath);
                statusLbl.Text = "Εκτέλεση εφαρμογής";
                Thread.Sleep(3000);
                statusLbl.Text = "";
            }
            catch (InvalidOperationException er)
            {
                regularMsg.Text += "Exception:";
                regularMsg.Text += er.ToString();
                statusLbl.Text = "";
            }
        }

        public void newProject_Click(object sender, EventArgs e)
        {
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";
                   
            examplePath = "C:\\examples\\Custom\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\Custom\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\Custom\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
        }
     
        private void importToolBarBtn_Click(object sender, EventArgs e)
        {
            newExampleForm newForm = new newExampleForm();
            newForm.ShowDialog();

            string projectName = newForm.exampleName;
            
            showProgress(5000);

            if (projectName != "")
            {

                try
                {
                    Assembly assembly;
                    Stream zipStream;

                    assembly = Assembly.GetExecutingAssembly();
                    zipStream = assembly.GetManifestResourceStream("Graphics.Resources.newOpenGL.zip");
                    string newPath = @"C:\examples\Custom\" + projectName;
                    extract(zipStream, newPath);
                    statusLbl.Text = "Δημιουργία νέου παραδείγματος...";
                }
                catch
                {
                    statusLbl.Text = "";
                    MessageBox.Show("Σφάλμα: Το αρχείο δεν μπόρεσε να δημιουργηθεί.", "Δημιουργία νέου παραδείγματος", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Προσθήκη στο μενού
                newProject = new ToolStripMenuItem();

                examplesCustomMenuItem.DropDownItems.Add(newProject);
                newProject.Text = projectName;
                newProject.Name = projectName + "MenuItem";
                newProject.Click += new EventHandler(newProject_Click);


                //Άνοιγμα παραδείγματος
                exampleName = "newOpenGl";

                examplePath = "C:\\examples\\Custom\\" + projectName + "\\" + exampleName + "\\" + exampleName + ".cpp";
                //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
                FileManager fm = new FileManager(examplePath);

                code = fm.readFile();
                //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
                textChangedEventFlag = false;
                codeTxtBox.Clear();
                Parse();
                textChangedEventFlag = true;
            }
           
        }

        public void Parse()
        {
            codeTxtBox.Clear();
            // Foreach line in input,
            // identify key words and format them when adding to the rich text box.
            Regex r = new Regex("\\n");
            String[] lines = r.Split(code);
            foreach (string l in lines)
            {
                ParseLine(l);
            }
        }

        public void ParseLine(string line)
        {
            Regex r = new Regex("([ \\t{}();])");
            String[] tokens = r.Split(line);

            foreach (string token in tokens)
            {
                // Set the token's default color and font.
                codeTxtBox.SelectionColor = Color.Black;
                codeTxtBox.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);

                // Check for a comment.
                if (token == "//" || token.StartsWith("//"))
                {
                    // Find the start of the comment and then extract the whole comment.
                    int index = line.IndexOf("//");
                    string comment;
                    
                    comment = line.Substring(index, line.Length - index);    
                    codeTxtBox.SelectionColor = Color.Green;
                    codeTxtBox.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                    codeTxtBox.SelectedText = comment;
                    break;
                }
                // Check whether the token is a keyword. 
                String[] keywords = { 

                   "abstract","as","base","bool","break","byte","case","catch","char","checked","class","const","continue","decimal",
                   "default","delegate","do","double","else","enum","event","explicit","extern","false","finally","fixed","float",
                   "for","foreach","goto","if","implicit","in","int","namespace","new","null","object","operator","out","private",
                   "protected","public","return","short","sizeof","stackalloc","static","string","struct","switch","this","throw",
                   "true","try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void","volatile","while" 
                }; 
                
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (keywords[i] == token)
                    {
                        // Apply alternative color and font to highlight keyword.
                        codeTxtBox.SelectionColor = Color.Blue;
                        codeTxtBox.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                        break;
                    }
                }
                codeTxtBox.SelectedText = token;
            }
            codeTxtBox.SelectedText = "\n";
        }

        private void TextChangedEvent(object sender, EventArgs e)
        {
            if (textChangedEventFlag)
            {
                // Calculate the starting position of the current line.
                int start = 0, end = 0;
                for (start = codeTxtBox.SelectionStart - 1; start > 0; start--)
                {
                    if (codeTxtBox.Text[start] == '\n') { start++; break; }
                }

                // Calculate the end position of the current line.
                for (end = codeTxtBox.SelectionStart; end < codeTxtBox.Text.Length; end++)
                {
                    if (codeTxtBox.Text[end] == '\n') break;
                }

                // Extract the current line that is being edited.
                String line;
                if ((start != end) && (start != -1))
                {
                    line = codeTxtBox.Text.Substring(start, end - start);
                }
                else
                {
                    line = "";
                }

                // Backup the users current selection point.
                int selectionStart = codeTxtBox.SelectionStart;
                int selectionLength = codeTxtBox.SelectionLength;

                // Split the line into tokens.
                Regex r = new Regex("([ \\t{}();])");
                string[] tokens = r.Split(line);
                int index = start;
                foreach (string token in tokens)
                {

                    // Set the token's default color and font.
                    codeTxtBox.SelectionStart = index;
                    codeTxtBox.SelectionLength = token.Length;
                    codeTxtBox.SelectionColor = Color.Black;
                    codeTxtBox.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);

                    // Check for a comment.
                    if (token == "//" || token.StartsWith("//"))
                    {
                        // Find the start of the comment and then extract the whole comment.
                        int length = line.Length - (index - start);
                        string commentText = codeTxtBox.Text.Substring(index, length);
                        codeTxtBox.SelectionStart = index;
                        codeTxtBox.SelectionLength = length;
                        codeTxtBox.SelectionColor = Color.LightGreen;
                        codeTxtBox.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                        break;
                    }

                    // Check whether the token is a keyword. 
                    String[] keywords = { 

                   "abstract","as","base","bool","break","byte","case","catch","char","checked","class","const","continue","decimal",
                   "default","delegate","do","double","else","enum","event","explicit","extern","false","finally","fixed","float",
                   "for","foreach","goto","if","implicit","in","int","namespace","new","null","object","operator","out","private",
                   "protected","public","return","short","sizeof","stackalloc","static","string","struct","switch","this","throw",
                   "true","try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual","void","volatile","while" 
                    };


                    for (int i = 0; i < keywords.Length; i++)
                    {
                        if (keywords[i] == token)
                        {
                            // Apply alternative color and font to highlight keyword.        
                            codeTxtBox.SelectionColor = Color.Blue;
                            codeTxtBox.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                            break;
                        }
                    }
                    index += token.Length;
                }
                // Restore the users current selection point.    
                codeTxtBox.SelectionStart = selectionStart;
                codeTxtBox.SelectionLength = selectionLength;
            }
        } 

        private void showProgress(int ms) {
            
            progressBar.Visible = true;
            progressBar.Maximum = ms;

            for (int i = 0; i < ms; i++)
            {
                progressBar.PerformStep();
            }
            
            progressBar.Visible = false;

        }

        public void extract(Stream zipStream, string dest)
        {
            // Opens existing zip file
                ZipStorer zip = ZipStorer.Open(zipStream, FileAccess.Read);

                // Read all directory contents
                List<ZipStorer.ZipFileEntry> dir = zip.ReadCentralDir();
                
                // Extract all files in target directory
                string path;
                bool result;
                result = false;

                foreach (ZipStorer.ZipFileEntry entry in dir)
                {
                    path = Path.Combine(dest, entry.FilenameInZip);
                    result = zip.ExtractFile(entry, path);
                    if (entry.IsDirectory())
                    {
                        Directory.CreateDirectory(path.ToString());
                    }
                    else
                    {
                        result = zip.ExtractFile(entry, path);
                    }

                } 
                zip.Close();

                statusLbl.Text = "";
            
        }

        private void extractExamplesToolBarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Assembly assembly;
                Stream zipStream;

                assembly = Assembly.GetExecutingAssembly();
                zipStream = assembly.GetManifestResourceStream("Graphics.Resources.examples.zip");
                extract(zipStream, @"C:\examples");
                statusLbl.Text = "Περιμένετε όσο διαρκεί η αποσυμπίεση των αρχείων...";
                showProgress(5000);
                MessageBox.Show("Η εξαγωγή των παραδειγμάτων ολοκληρώθηκε επιτυχώς.", "Εκμάθηση OpenGL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (InvalidDataException)
            {
                statusLbl.Text = "";
                MessageBox.Show("Σφάλμα: Το αρχείο zip δεν υποστηρίζεται ή περιέχει σφάλματα.", "Εκμάθηση OpenGL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                statusLbl.Text = "";
                //MessageBox.Show("Δημιουργήθηκε άγνωστο σφάλμα κατά τη διάρκεια προσπέλασης του αρχείου.", "Εκμάθηση OpenGL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "Εκμάθηση OpenGL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
             
        }

        private void codeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = "Το αρχείο δεν έχει αποθηκευτεί";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomExamples();
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;

            codeTxtBox.ReadOnly = true;
        }

        private void octahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
            
        }

        private void openGLFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
            
        }

        private void rotatingCubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
            
        }

        private void colorChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
            
        }

        private void solidSphereLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            statusLbl.Text = "ΣτοIn this example we rotate 3D sphere with light in a circle shape like solar system.";

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
            
        }

        private void addSpotLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeTxtBox.ReadOnly = false;
            textChangedEventFlag = false;
            //Άνοιγμα παραδείγματος
            exampleName = "newOpenGl";

            examplePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".cpp";
            projPath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\" + exampleName + ".vcxproj";
            exePath = "C:\\examples\\" + sender.ToString() + "\\" + exampleName + "\\Debug\\" + exampleName + ".exe";

            //καλώ την κλάση FileManager για να διαβάσω το αρχείο που επέλεξα
            FileManager fm = new FileManager(examplePath);

            statusLbl.Text = "Πατώντας το πλήκτρο \"L\" ή \"D\" ενεργοποιείται και απενεργοποείται το φως.";

            code = fm.readFile();
            //φορτώνω τα περιεχόμενα του αρχείου στο codeTxtBox
            Parse();
            textChangedEventFlag = true;
            codeTxtBox.ReadOnly = true;
            
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            if (codeTxtBox.SelectionLength > 0)

                codeTxtBox.Cut();  
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (codeTxtBox.SelectionLength > 0)

                codeTxtBox.Copy();  

        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                codeTxtBox.Paste();
            }

        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            if (codeTxtBox.CanUndo)
            {
                codeTxtBox.Undo();
                codeTxtBox.ClearUndo();
            }            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editForm eForm = new editForm();
            eForm.editCodeTxtBox.Lines = codeTxtBox.Lines;
            eForm.ShowDialog();
        }

    }
}
