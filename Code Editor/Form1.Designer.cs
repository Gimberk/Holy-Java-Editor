
namespace Code_Editor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editorTxt = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderInFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoLbl = new System.Windows.Forms.Label();
            this.saveLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectLbl = new System.Windows.Forms.Label();
            this.openProjectBtn = new System.Windows.Forms.PictureBox();
            this.newProjectLbl = new System.Windows.Forms.Label();
            this.newProjectBtn = new System.Windows.Forms.PictureBox();
            this.fileView = new System.Windows.Forms.TreeView();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStartupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTitleTxt = new System.Windows.Forms.ToolStripTextBox();
            this.saveCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openProjectBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProjectBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // editorTxt
            // 
            this.editorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.editorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorTxt.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.editorTxt.Location = new System.Drawing.Point(328, 24);
            this.editorTxt.Name = "editorTxt";
            this.editorTxt.Size = new System.Drawing.Size(1203, 659);
            this.editorTxt.TabIndex = 0;
            this.editorTxt.Text = "";
            this.editorTxt.TextChanged += new System.EventHandler(this.editorTxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.removeFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.openFolderInFileExplorerToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 142);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.removeFileToolStripMenuItem.Text = "Delete";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.removeFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // openFolderInFileExplorerToolStripMenuItem
            // 
            this.openFolderInFileExplorerToolStripMenuItem.Name = "openFolderInFileExplorerToolStripMenuItem";
            this.openFolderInFileExplorerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openFolderInFileExplorerToolStripMenuItem.Text = "Open Project in File Explorer";
            this.openFolderInFileExplorerToolStripMenuItem.Click += new System.EventHandler(this.openFolderInFileExplorerToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.infoLbl.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.ForeColor = System.Drawing.Color.Gray;
            this.infoLbl.Location = new System.Drawing.Point(435, 242);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(986, 45);
            this.infoLbl.TabIndex = 2;
            this.infoLbl.Text = "Create a New Project or Open an Existing One to Get Started";
            // 
            // saveLbl
            // 
            this.saveLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveLbl.AutoSize = true;
            this.saveLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLbl.ForeColor = System.Drawing.Color.Gray;
            this.saveLbl.Location = new System.Drawing.Point(333, 650);
            this.saveLbl.Name = "saveLbl";
            this.saveLbl.Size = new System.Drawing.Size(0, 24);
            this.saveLbl.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1531, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.removeStartupProjectToolStripMenuItem,
            this.saveCurrentFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.runToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // openProjectLbl
            // 
            this.openProjectLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openProjectLbl.AutoSize = true;
            this.openProjectLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.openProjectLbl.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProjectLbl.ForeColor = System.Drawing.Color.White;
            this.openProjectLbl.Location = new System.Drawing.Point(907, 598);
            this.openProjectLbl.Name = "openProjectLbl";
            this.openProjectLbl.Size = new System.Drawing.Size(172, 36);
            this.openProjectLbl.TabIndex = 6;
            this.openProjectLbl.Text = "Open Project";
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.openProjectBtn.Image = ((System.Drawing.Image)(resources.GetObject("openProjectBtn.Image")));
            this.openProjectBtn.Location = new System.Drawing.Point(693, 540);
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(265, 134);
            this.openProjectBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openProjectBtn.TabIndex = 5;
            this.openProjectBtn.TabStop = false;
            this.openProjectBtn.Click += new System.EventHandler(this.openProjectBtn_Click);
            // 
            // newProjectLbl
            // 
            this.newProjectLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectLbl.AutoSize = true;
            this.newProjectLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.newProjectLbl.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProjectLbl.ForeColor = System.Drawing.Color.White;
            this.newProjectLbl.Location = new System.Drawing.Point(907, 458);
            this.newProjectLbl.Name = "newProjectLbl";
            this.newProjectLbl.Size = new System.Drawing.Size(247, 36);
            this.newProjectLbl.TabIndex = 6;
            this.newProjectLbl.Text = "Create New Project";
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.newProjectBtn.Image = ((System.Drawing.Image)(resources.GetObject("newProjectBtn.Image")));
            this.newProjectBtn.Location = new System.Drawing.Point(693, 400);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(265, 134);
            this.newProjectBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newProjectBtn.TabIndex = 5;
            this.newProjectBtn.TabStop = false;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // fileView
            // 
            this.fileView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.fileView.ContextMenuStrip = this.contextMenuStrip1;
            this.fileView.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileView.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fileView.LineColor = System.Drawing.Color.WhiteSmoke;
            this.fileView.Location = new System.Drawing.Point(0, 24);
            this.fileView.Name = "fileView";
            this.fileView.Size = new System.Drawing.Size(327, 659);
            this.fileView.TabIndex = 8;
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.closeFileToolStripMenuItem.Text = "Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // removeStartupProjectToolStripMenuItem
            // 
            this.removeStartupProjectToolStripMenuItem.Name = "removeStartupProjectToolStripMenuItem";
            this.removeStartupProjectToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.removeStartupProjectToolStripMenuItem.Text = "Remove Startup Project";
            this.removeStartupProjectToolStripMenuItem.Click += new System.EventHandler(this.removeStartupProjectToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // generalSettingsToolStripMenuItem
            // 
            this.generalSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleTitleTxt});
            this.generalSettingsToolStripMenuItem.Name = "generalSettingsToolStripMenuItem";
            this.generalSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generalSettingsToolStripMenuItem.Text = "General Settings";
            // 
            // consoleTitleTxt
            // 
            this.consoleTitleTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.consoleTitleTxt.Name = "consoleTitleTxt";
            this.consoleTitleTxt.Size = new System.Drawing.Size(100, 23);
            this.consoleTitleTxt.Text = "Console Title";
            // 
            // saveCurrentFileToolStripMenuItem
            // 
            this.saveCurrentFileToolStripMenuItem.Name = "saveCurrentFileToolStripMenuItem";
            this.saveCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveCurrentFileToolStripMenuItem.Text = "Save Current File";
            this.saveCurrentFileToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentFileToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(339, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openProjectLbl);
            this.Controls.Add(this.newProjectLbl);
            this.Controls.Add(this.openProjectBtn);
            this.Controls.Add(this.newProjectBtn);
            this.Controls.Add(this.saveLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.editorTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Holy Java Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openProjectBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProjectBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox editorTxt;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label saveLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.Label openProjectLbl;
        private System.Windows.Forms.PictureBox openProjectBtn;
        private System.Windows.Forms.Label newProjectLbl;
        private System.Windows.Forms.PictureBox newProjectBtn;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TreeView fileView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openFolderInFileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStartupProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox consoleTitleTxt;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentFileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

