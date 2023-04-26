namespace Postgraduates
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            hTMLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            loadZNUNewsToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            loggerToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            mainStatusBar = new StatusStrip();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            searchGroupBox = new GroupBox();
            clearSearchButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            queryGroupBox = new GroupBox();
            flowLayoutPanel = new FlowLayoutPanel();
            runQuerryButton = new Button();
            dataGridView = new DataGridView();
            clearQueryButton = new Button();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            searchGroupBox.SuspendLayout();
            queryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1124, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator2, openToolStripMenuItem, toolStripSeparator4, saveToolStripMenuItem, saveAsToolStripMenuItem, exportToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(112, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(109, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(109, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(112, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save &as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hTMLToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(112, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // hTMLToolStripMenuItem
            // 
            hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            hTMLToolStripMenuItem.Size = new Size(106, 22);
            hTMLToolStripMenuItem.Text = "HTML";
            hTMLToolStripMenuItem.Click += hTMLToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadZNUNewsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // loadZNUNewsToolStripMenuItem
            // 
            loadZNUNewsToolStripMenuItem.Name = "loadZNUNewsToolStripMenuItem";
            loadZNUNewsToolStripMenuItem.Size = new Size(67, 22);
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(12, 20);
            // 
            // loggerToolStripMenuItem
            // 
            loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            loggerToolStripMenuItem.Size = new Size(32, 19);
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(32, 19);
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(32, 19);
            // 
            // mainStatusBar
            // 
            mainStatusBar.ImageScalingSize = new Size(20, 20);
            mainStatusBar.Location = new Point(0, 680);
            mainStatusBar.Name = "mainStatusBar";
            mainStatusBar.Size = new Size(1124, 22);
            mainStatusBar.TabIndex = 3;
            mainStatusBar.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView);
            splitContainer1.Size = new Size(1124, 656);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(searchGroupBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(queryGroupBox);
            splitContainer2.Size = new Size(292, 656);
            splitContainer2.SplitterDistance = 97;
            splitContainer2.TabIndex = 0;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(clearSearchButton);
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Controls.Add(searchTextBox);
            searchGroupBox.Dock = DockStyle.Top;
            searchGroupBox.Location = new Point(0, 0);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(292, 99);
            searchGroupBox.TabIndex = 3;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search";
            // 
            // clearSearchButton
            // 
            clearSearchButton.Location = new Point(3, 53);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(93, 23);
            clearSearchButton.TabIndex = 2;
            clearSearchButton.Text = "Clear";
            clearSearchButton.UseVisualStyleBackColor = true;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(102, 53);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(187, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "Find";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Location = new Point(3, 19);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(286, 23);
            searchTextBox.TabIndex = 0;
            // 
            // queryGroupBox
            // 
            queryGroupBox.Controls.Add(clearQueryButton);
            queryGroupBox.Controls.Add(flowLayoutPanel);
            queryGroupBox.Controls.Add(runQuerryButton);
            queryGroupBox.Dock = DockStyle.Fill;
            queryGroupBox.Location = new Point(0, 0);
            queryGroupBox.Name = "queryGroupBox";
            queryGroupBox.Size = new Size(292, 555);
            queryGroupBox.TabIndex = 0;
            queryGroupBox.TabStop = false;
            queryGroupBox.Text = "Query";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(3, 19);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(286, 501);
            flowLayoutPanel.TabIndex = 1;
            // 
            // runQuerryButton
            // 
            runQuerryButton.Location = new Point(211, 526);
            runQuerryButton.Name = "runQuerryButton";
            runQuerryButton.Size = new Size(75, 23);
            runQuerryButton.TabIndex = 0;
            runQuerryButton.Text = "Get";
            runQuerryButton.UseVisualStyleBackColor = true;
            runQuerryButton.Click += runQuerryButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(828, 656);
            dataGridView.TabIndex = 0;
            // 
            // clearQueryButton
            // 
            clearQueryButton.Location = new Point(3, 526);
            clearQueryButton.Name = "clearQueryButton";
            clearQueryButton.Size = new Size(75, 23);
            clearQueryButton.TabIndex = 2;
            clearQueryButton.Text = "Clear";
            clearQueryButton.UseVisualStyleBackColor = true;
            clearQueryButton.Click += clearQueryButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 702);
            Controls.Add(splitContainer1);
            Controls.Add(mainStatusBar);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            Text = "Postgraduates";
            FormClosing += MainForm_FormClosing;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            queryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip mainStatusBar;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem loadZNUNewsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem loggerToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem hTMLToolStripMenuItem;
        private SplitContainer splitContainer2;
        private GroupBox searchGroupBox;
        private Button clearSearchButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private GroupBox queryGroupBox;
        private Button runQuerryButton;
        private FlowLayoutPanel flowLayoutPanel;
        private Button clearQueryButton;
    }
}