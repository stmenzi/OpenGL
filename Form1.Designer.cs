namespace Graphics
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.codeTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExecuteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.επεξεργασίαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.examples2DMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplePointMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGLFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examples3DMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylindersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesAnimMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotatingCubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesLightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidSphereLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpotLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.examplesCustomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βοήθειαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appUseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularMsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolBarBtn = new System.Windows.Forms.ToolStripButton();
            this.importToolBarBtn = new System.Windows.Forms.ToolStripButton();
            this.exeToolBarBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolBarBtn = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.lineNumbers_For_RichTextBox1 = new LineNumbers.LineNumbers_For_RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.CheckFileExists = true;
            this.saveFileDlg.OverwritePrompt = false;
            this.saveFileDlg.Title = "Αποθήκευση ";
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeTxtBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.codeTxtBox.Location = new System.Drawing.Point(47, 51);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.Size = new System.Drawing.Size(1273, 514);
            this.codeTxtBox.TabIndex = 0;
            this.codeTxtBox.Text = "";
            this.codeTxtBox.TextChanged += new System.EventHandler(this.TextChangedEvent);
            this.codeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeTxtBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.επεξεργασίαToolStripMenuItem,
            this.examplesMenu,
            this.βοήθειαToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1320, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSaveMenuItem,
            this.fileExecuteMenuItem,
            this.toolStripSeparator3,
            this.fileExitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(55, 19);
            this.fileMenu.Text = "Αρχείο";
            // 
            // fileSaveMenuItem
            // 
            this.fileSaveMenuItem.Name = "fileSaveMenuItem";
            this.fileSaveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileSaveMenuItem.Text = "Αποθήκευση";
            this.fileSaveMenuItem.Click += new System.EventHandler(this.fileSaveMenuItem_Click);
            // 
            // fileExecuteMenuItem
            // 
            this.fileExecuteMenuItem.Name = "fileExecuteMenuItem";
            this.fileExecuteMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileExecuteMenuItem.Text = "Εκτέλεση";
            this.fileExecuteMenuItem.Click += new System.EventHandler(this.exeToolBarBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // fileExitMenuItem
            // 
            this.fileExitMenuItem.Name = "fileExitMenuItem";
            this.fileExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileExitMenuItem.Text = "Έξοδος";
            this.fileExitMenuItem.Click += new System.EventHandler(this.fileExitMenuItem_Click);
            // 
            // επεξεργασίαToolStripMenuItem
            // 
            this.επεξεργασίαToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.toolStripSeparator4,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem});
            this.επεξεργασίαToolStripMenuItem.Name = "επεξεργασίαToolStripMenuItem";
            this.επεξεργασίαToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.επεξεργασίαToolStripMenuItem.Text = "Επεξεργασία";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(178, 22);
            this.undoMenuItem.Text = "Αναίρεση";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cutMenuItem.Text = "Αποκοπή";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copyMenuItem.Text = "Αντιγραφή";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pasteMenuItem.Text = "Επικόλληση";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // examplesMenu
            // 
            this.examplesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examples2DMenuItem,
            this.examples3DMenuItem,
            this.examplesAnimMenuItem,
            this.examplesLightMenuItem,
            this.toolStripSeparator5,
            this.examplesCustomMenuItem});
            this.examplesMenu.Name = "examplesMenu";
            this.examplesMenu.Size = new System.Drawing.Size(97, 19);
            this.examplesMenu.Text = "Παραδείγματα";
            // 
            // examples2DMenuItem
            // 
            this.examples2DMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplePointMenuItem,
            this.simpleLineToolStripMenuItem,
            this.lineStripToolStripMenuItem,
            this.lineLoopToolStripMenuItem,
            this.singleTriangleToolStripMenuItem,
            this.openGLFontToolStripMenuItem,
            this.colorChangeToolStripMenuItem});
            this.examples2DMenuItem.Name = "examples2DMenuItem";
            this.examples2DMenuItem.Size = new System.Drawing.Size(152, 22);
            this.examples2DMenuItem.Text = "2D";
            // 
            // simplePointMenuItem
            // 
            this.simplePointMenuItem.Name = "simplePointMenuItem";
            this.simplePointMenuItem.Size = new System.Drawing.Size(152, 22);
            this.simplePointMenuItem.Text = "Simple Point";
            this.simplePointMenuItem.Click += new System.EventHandler(this.simplePointMenuItem_Click);
            // 
            // simpleLineToolStripMenuItem
            // 
            this.simpleLineToolStripMenuItem.Name = "simpleLineToolStripMenuItem";
            this.simpleLineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.simpleLineToolStripMenuItem.Text = "Simple Line";
            this.simpleLineToolStripMenuItem.Click += new System.EventHandler(this.simpleLineToolStripMenuItem_Click);
            // 
            // lineStripToolStripMenuItem
            // 
            this.lineStripToolStripMenuItem.Name = "lineStripToolStripMenuItem";
            this.lineStripToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lineStripToolStripMenuItem.Text = "Line Strip";
            this.lineStripToolStripMenuItem.Click += new System.EventHandler(this.lineStripToolStripMenuItem_Click);
            // 
            // lineLoopToolStripMenuItem
            // 
            this.lineLoopToolStripMenuItem.Name = "lineLoopToolStripMenuItem";
            this.lineLoopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lineLoopToolStripMenuItem.Text = "Line Loop";
            this.lineLoopToolStripMenuItem.Click += new System.EventHandler(this.lineLoopToolStripMenuItem_Click);
            // 
            // singleTriangleToolStripMenuItem
            // 
            this.singleTriangleToolStripMenuItem.Name = "singleTriangleToolStripMenuItem";
            this.singleTriangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.singleTriangleToolStripMenuItem.Text = "Single Triangle";
            this.singleTriangleToolStripMenuItem.Click += new System.EventHandler(this.singleTriangleToolStripMenuItem_Click);
            // 
            // openGLFontToolStripMenuItem
            // 
            this.openGLFontToolStripMenuItem.Name = "openGLFontToolStripMenuItem";
            this.openGLFontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openGLFontToolStripMenuItem.Text = "OpenGLFont";
            this.openGLFontToolStripMenuItem.Click += new System.EventHandler(this.openGLFontToolStripMenuItem_Click);
            // 
            // colorChangeToolStripMenuItem
            // 
            this.colorChangeToolStripMenuItem.Name = "colorChangeToolStripMenuItem";
            this.colorChangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorChangeToolStripMenuItem.Text = "ColorChange";
            this.colorChangeToolStripMenuItem.Click += new System.EventHandler(this.colorChangeToolStripMenuItem_Click);
            // 
            // examples3DMenuItem
            // 
            this.examples3DMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cubeToolStripMenuItem,
            this.cylindersToolStripMenuItem,
            this.coneToolStripMenuItem,
            this.octahedronToolStripMenuItem});
            this.examples3DMenuItem.Name = "examples3DMenuItem";
            this.examples3DMenuItem.Size = new System.Drawing.Size(152, 22);
            this.examples3DMenuItem.Text = "3D";
            // 
            // cubeToolStripMenuItem
            // 
            this.cubeToolStripMenuItem.Name = "cubeToolStripMenuItem";
            this.cubeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cubeToolStripMenuItem.Text = "Cube";
            this.cubeToolStripMenuItem.Click += new System.EventHandler(this.cubeToolStripMenuItem_Click);
            // 
            // cylindersToolStripMenuItem
            // 
            this.cylindersToolStripMenuItem.Name = "cylindersToolStripMenuItem";
            this.cylindersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cylindersToolStripMenuItem.Text = "Cylinders";
            this.cylindersToolStripMenuItem.Click += new System.EventHandler(this.cylindersToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.coneToolStripMenuItem_Click);
            // 
            // octahedronToolStripMenuItem
            // 
            this.octahedronToolStripMenuItem.Name = "octahedronToolStripMenuItem";
            this.octahedronToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.octahedronToolStripMenuItem.Text = "Octahedron";
            this.octahedronToolStripMenuItem.Click += new System.EventHandler(this.octahedronToolStripMenuItem_Click);
            // 
            // examplesAnimMenuItem
            // 
            this.examplesAnimMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotatingCubeToolStripMenuItem});
            this.examplesAnimMenuItem.Name = "examplesAnimMenuItem";
            this.examplesAnimMenuItem.Size = new System.Drawing.Size(152, 22);
            this.examplesAnimMenuItem.Text = "Animation";
            // 
            // rotatingCubeToolStripMenuItem
            // 
            this.rotatingCubeToolStripMenuItem.Name = "rotatingCubeToolStripMenuItem";
            this.rotatingCubeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rotatingCubeToolStripMenuItem.Text = "RotatingCube";
            this.rotatingCubeToolStripMenuItem.Click += new System.EventHandler(this.rotatingCubeToolStripMenuItem_Click);
            // 
            // examplesLightMenuItem
            // 
            this.examplesLightMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidSphereLightToolStripMenuItem,
            this.addSpotLightToolStripMenuItem});
            this.examplesLightMenuItem.Name = "examplesLightMenuItem";
            this.examplesLightMenuItem.Size = new System.Drawing.Size(152, 22);
            this.examplesLightMenuItem.Text = "Light";
            // 
            // solidSphereLightToolStripMenuItem
            // 
            this.solidSphereLightToolStripMenuItem.Name = "solidSphereLightToolStripMenuItem";
            this.solidSphereLightToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.solidSphereLightToolStripMenuItem.Text = "SolidSphereLight";
            this.solidSphereLightToolStripMenuItem.Click += new System.EventHandler(this.solidSphereLightToolStripMenuItem_Click);
            // 
            // addSpotLightToolStripMenuItem
            // 
            this.addSpotLightToolStripMenuItem.Name = "addSpotLightToolStripMenuItem";
            this.addSpotLightToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addSpotLightToolStripMenuItem.Text = "AddSpotLight";
            this.addSpotLightToolStripMenuItem.Click += new System.EventHandler(this.addSpotLightToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // examplesCustomMenuItem
            // 
            this.examplesCustomMenuItem.Name = "examplesCustomMenuItem";
            this.examplesCustomMenuItem.Size = new System.Drawing.Size(152, 22);
            this.examplesCustomMenuItem.Text = "Custom";
            // 
            // βοήθειαToolStripMenuItem
            // 
            this.βοήθειαToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appUseMenuItem});
            this.βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            this.βοήθειαToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.βοήθειαToolStripMenuItem.Text = "Βοήθεια";
            // 
            // appUseMenuItem
            // 
            this.appUseMenuItem.Name = "appUseMenuItem";
            this.appUseMenuItem.Size = new System.Drawing.Size(174, 22);
            this.appUseMenuItem.Text = "Χρήση Εφαρμογής";
            // 
            // regularMsg
            // 
            this.regularMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.regularMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regularMsg.Location = new System.Drawing.Point(0, 601);
            this.regularMsg.Margin = new System.Windows.Forms.Padding(4);
            this.regularMsg.Name = "regularMsg";
            this.regularMsg.Size = new System.Drawing.Size(1320, 138);
            this.regularMsg.TabIndex = 11;
            this.regularMsg.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(-3, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Building Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolBarBtn,
            this.importToolBarBtn,
            this.exeToolBarBtn,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.exitToolBarBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1320, 23);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolBarBtn
            // 
            this.saveToolBarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolBarBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToolBarBtn.Image")));
            this.saveToolBarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolBarBtn.Name = "saveToolBarBtn";
            this.saveToolBarBtn.Size = new System.Drawing.Size(23, 20);
            this.saveToolBarBtn.Text = "Αποθήκευση";
            this.saveToolBarBtn.Click += new System.EventHandler(this.fileSaveMenuItem_Click);
            // 
            // importToolBarBtn
            // 
            this.importToolBarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importToolBarBtn.Image = ((System.Drawing.Image)(resources.GetObject("importToolBarBtn.Image")));
            this.importToolBarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolBarBtn.Name = "importToolBarBtn";
            this.importToolBarBtn.Size = new System.Drawing.Size(23, 20);
            this.importToolBarBtn.Text = "Εισαγωγή παραδείγματος";
            this.importToolBarBtn.Click += new System.EventHandler(this.importToolBarBtn_Click);
            // 
            // exeToolBarBtn
            // 
            this.exeToolBarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exeToolBarBtn.Image = ((System.Drawing.Image)(resources.GetObject("exeToolBarBtn.Image")));
            this.exeToolBarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exeToolBarBtn.Name = "exeToolBarBtn";
            this.exeToolBarBtn.Size = new System.Drawing.Size(23, 20);
            this.exeToolBarBtn.Text = "Εκτέλεση";
            this.exeToolBarBtn.Click += new System.EventHandler(this.exeToolBarBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "Αποκοπή";
            this.toolStripButton1.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "Αντιγραφή";
            this.toolStripButton2.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "Επικόλληση";
            this.toolStripButton3.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // exitToolBarBtn
            // 
            this.exitToolBarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolBarBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitToolBarBtn.Image")));
            this.exitToolBarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolBarBtn.Name = "exitToolBarBtn";
            this.exitToolBarBtn.Size = new System.Drawing.Size(23, 20);
            this.exitToolBarBtn.Text = "Έξοδος";
            this.exitToolBarBtn.Click += new System.EventHandler(this.fileExitMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(1129, 741);
            this.progressBar.Maximum = 5000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 20);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 15;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(3, 742);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            this.statusLbl.TabIndex = 16;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Location = new System.Drawing.Point(1070, 567);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(249, 32);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "ΕΠΕΞΕΡΓΑΣΙΑ ΠΑΡΑΔΕΙΓΜΑΤΟΣ";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // lineNumbers_For_RichTextBox1
            // 
            this.lineNumbers_For_RichTextBox1._SeeThroughMode_ = false;
            this.lineNumbers_For_RichTextBox1.AutoSizing = true;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox1.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.BorderLines_Thickness = 2F;
            this.lineNumbers_For_RichTextBox1.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lineNumbers_For_RichTextBox1.GridLines_Color = System.Drawing.Color.Lavender;
            this.lineNumbers_For_RichTextBox1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineNumbers_For_RichTextBox1.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox1.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_LeadingZeroes = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox1.Location = new System.Drawing.Point(18, 51);
            this.lineNumbers_For_RichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox1.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox1.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Name = "lineNumbers_For_RichTextBox1";
            this.lineNumbers_For_RichTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lineNumbers_For_RichTextBox1.ParentRichTextBox = this.codeTxtBox;
            this.lineNumbers_For_RichTextBox1.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox1.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox1.Show_GridLines = false;
            this.lineNumbers_For_RichTextBox1.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox1.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox1.Size = new System.Drawing.Size(28, 514);
            this.lineNumbers_For_RichTextBox1.TabIndex = 14;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1320, 763);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lineNumbers_For_RichTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regularMsg);
            this.Controls.Add(this.codeTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εφαρμογή Εκμάθησης OpenGL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExecuteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesMenu;
        private System.Windows.Forms.ToolStripMenuItem examples2DMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examples3DMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesAnimMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesLightMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplePointMenuItem;
        public System.Windows.Forms.RichTextBox regularMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem simpleLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineStripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylindersToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolBarBtn;
        private System.Windows.Forms.ToolStripButton importToolBarBtn;
        private System.Windows.Forms.ToolStripButton exeToolBarBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exitToolBarBtn;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLbl;
        public System.Windows.Forms.ToolStripMenuItem examplesCustomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGLFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotatingCubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidSphereLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpotLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem επεξεργασίαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem βοήθειαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appUseMenuItem;
        private System.Windows.Forms.Button editBtn;
        public System.Windows.Forms.RichTextBox codeTxtBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

