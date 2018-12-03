namespace TNurislamova_301025614_A4
{
    partial class FormSwimTracker
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSwimmers = new System.Windows.Forms.Label();
            this.ClubsListView = new System.Windows.Forms.ListView();
            this.columnHeaderClubNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClubName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddClub = new System.Windows.Forms.Button();
            this.labelClubs = new System.Windows.Forms.Label();
            this.buttonAllCoaches = new System.Windows.Forms.Button();
            this.buttonAllSwimmers = new System.Windows.Forms.Button();
            this.buttonAddSwimmer = new System.Windows.Forms.Button();
            this.labelCoaches = new System.Windows.Forms.Label();
            this.buttonAddCoach = new System.Windows.Forms.Button();
            this.coachListView = new System.Windows.Forms.ListView();
            this.columnHeaderCoachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCoachNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCoachClubNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.swimmerListView = new System.Windows.Forms.ListView();
            this.columnHeaderSwimmerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSwimmerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSwimmerClubNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSwimmersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSwimmersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.72243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.83767F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel1.Controls.Add(this.labelSwimmers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClubsListView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddClub, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelClubs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAllCoaches, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAllSwimmers, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddSwimmer, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCoaches, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddCoach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.coachListView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.swimmerListView, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelSwimmers
            // 
            this.labelSwimmers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSwimmers.AutoSize = true;
            this.labelSwimmers.Location = new System.Drawing.Point(637, 13);
            this.labelSwimmers.Name = "labelSwimmers";
            this.labelSwimmers.Size = new System.Drawing.Size(54, 13);
            this.labelSwimmers.TabIndex = 8;
            this.labelSwimmers.Text = "Swimmers";
            this.labelSwimmers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSwimmers.Click += new System.EventHandler(this.labelSwimmers_Click);
            // 
            // ClubsListView
            // 
            this.ClubsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClubNumber,
            this.columnHeaderClubName});
            this.ClubsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClubsListView.GridLines = true;
            this.ClubsListView.Location = new System.Drawing.Point(3, 83);
            this.ClubsListView.Name = "ClubsListView";
            this.ClubsListView.ShowItemToolTips = true;
            this.ClubsListView.Size = new System.Drawing.Size(250, 331);
            this.ClubsListView.TabIndex = 0;
            this.ClubsListView.UseCompatibleStateImageBehavior = false;
            this.ClubsListView.View = System.Windows.Forms.View.Details;
            this.ClubsListView.SelectedIndexChanged += new System.EventHandler(this.ClubsListView_SelectedIndexChanged);
            this.ClubsListView.Click += new System.EventHandler(this.ClubsListView_Click);
            this.ClubsListView.DoubleClick += new System.EventHandler(this.ClubsListView_DoubleClick);
            // 
            // columnHeaderClubNumber
            // 
            this.columnHeaderClubNumber.Text = "Club #";
            this.columnHeaderClubNumber.Width = 104;
            // 
            // columnHeaderClubName
            // 
            this.columnHeaderClubName.Text = "Club Name";
            this.columnHeaderClubName.Width = 111;
            // 
            // buttonAddClub
            // 
            this.buttonAddClub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddClub.Location = new System.Drawing.Point(84, 48);
            this.buttonAddClub.Name = "buttonAddClub";
            this.buttonAddClub.Size = new System.Drawing.Size(88, 23);
            this.buttonAddClub.TabIndex = 1;
            this.buttonAddClub.Text = "Add Club";
            this.buttonAddClub.UseVisualStyleBackColor = true;
            this.buttonAddClub.Click += new System.EventHandler(this.buttonAddClub_Click);
            // 
            // labelClubs
            // 
            this.labelClubs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClubs.AutoSize = true;
            this.labelClubs.Location = new System.Drawing.Point(111, 13);
            this.labelClubs.Name = "labelClubs";
            this.labelClubs.Size = new System.Drawing.Size(33, 13);
            this.labelClubs.TabIndex = 2;
            this.labelClubs.Text = "Clubs";
            this.labelClubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClubs.Click += new System.EventHandler(this.labelClubs_Click);
            // 
            // buttonAllCoaches
            // 
            this.buttonAllCoaches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAllCoaches.Location = new System.Drawing.Point(321, 420);
            this.buttonAllCoaches.Name = "buttonAllCoaches";
            this.buttonAllCoaches.Size = new System.Drawing.Size(135, 34);
            this.buttonAllCoaches.TabIndex = 3;
            this.buttonAllCoaches.Text = "Show All Coaches";
            this.buttonAllCoaches.UseVisualStyleBackColor = true;
            this.buttonAllCoaches.Click += new System.EventHandler(this.buttonAllCoaches_Click);
            // 
            // buttonAllSwimmers
            // 
            this.buttonAllSwimmers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAllSwimmers.Location = new System.Drawing.Point(596, 420);
            this.buttonAllSwimmers.Name = "buttonAllSwimmers";
            this.buttonAllSwimmers.Size = new System.Drawing.Size(135, 34);
            this.buttonAllSwimmers.TabIndex = 4;
            this.buttonAllSwimmers.Text = "Show All Swimmers";
            this.buttonAllSwimmers.UseVisualStyleBackColor = true;
            this.buttonAllSwimmers.Click += new System.EventHandler(this.buttonAllSwimmers_Click);
            // 
            // buttonAddSwimmer
            // 
            this.buttonAddSwimmer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddSwimmer.Location = new System.Drawing.Point(620, 48);
            this.buttonAddSwimmer.Name = "buttonAddSwimmer";
            this.buttonAddSwimmer.Size = new System.Drawing.Size(88, 23);
            this.buttonAddSwimmer.TabIndex = 6;
            this.buttonAddSwimmer.Text = "Add Swimmer";
            this.buttonAddSwimmer.UseVisualStyleBackColor = true;
            // 
            // labelCoaches
            // 
            this.labelCoaches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCoaches.AutoSize = true;
            this.labelCoaches.Location = new System.Drawing.Point(364, 13);
            this.labelCoaches.Name = "labelCoaches";
            this.labelCoaches.Size = new System.Drawing.Size(49, 13);
            this.labelCoaches.TabIndex = 9;
            this.labelCoaches.Text = "Coaches";
            this.labelCoaches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddCoach
            // 
            this.buttonAddCoach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCoach.Location = new System.Drawing.Point(344, 48);
            this.buttonAddCoach.Name = "buttonAddCoach";
            this.buttonAddCoach.Size = new System.Drawing.Size(88, 23);
            this.buttonAddCoach.TabIndex = 5;
            this.buttonAddCoach.Text = "Add Coach";
            this.buttonAddCoach.UseVisualStyleBackColor = true;
            // 
            // coachListView
            // 
            this.coachListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCoachName,
            this.columnHeaderCoachNumber,
            this.columnHeaderCoachClubNumber});
            this.coachListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coachListView.GridLines = true;
            this.coachListView.Location = new System.Drawing.Point(259, 83);
            this.coachListView.Name = "coachListView";
            this.coachListView.Size = new System.Drawing.Size(259, 331);
            this.coachListView.TabIndex = 10;
            this.coachListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderCoachName
            // 
            this.columnHeaderCoachName.Text = "Coach Name";
            // 
            // columnHeaderCoachNumber
            // 
            this.columnHeaderCoachNumber.Text = "Coach #";
            // 
            // columnHeaderCoachClubNumber
            // 
            this.columnHeaderCoachClubNumber.Text = "Club Number";
            // 
            // swimmerListView
            // 
            this.swimmerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSwimmerNumber,
            this.columnHeaderSwimmerName,
            this.columnHeaderSwimmerClubNumber});
            this.swimmerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swimmerListView.GridLines = true;
            this.swimmerListView.Location = new System.Drawing.Point(524, 83);
            this.swimmerListView.Name = "swimmerListView";
            this.swimmerListView.ShowItemToolTips = true;
            this.swimmerListView.Size = new System.Drawing.Size(280, 331);
            this.swimmerListView.TabIndex = 11;
            this.swimmerListView.UseCompatibleStateImageBehavior = false;
            this.swimmerListView.View = System.Windows.Forms.View.Details;
            this.swimmerListView.SelectedIndexChanged += new System.EventHandler(this.swimmerListView_SelectedIndexChanged);
            // 
            // columnHeaderSwimmerNumber
            // 
            this.columnHeaderSwimmerNumber.Text = "Swimmer #";
            this.columnHeaderSwimmerNumber.Width = 68;
            // 
            // columnHeaderSwimmerName
            // 
            this.columnHeaderSwimmerName.Text = "Swimmer Name";
            this.columnHeaderSwimmerName.Width = 103;
            // 
            // columnHeaderSwimmerClubNumber
            // 
            this.columnHeaderSwimmerClubNumber.Text = "Club Number";
            this.columnHeaderSwimmerClubNumber.Width = 91;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadSwimmersToolStripMenuItem,
            this.saveSwimmersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loadToolStripMenuItem.Text = "Load Clubs ...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveToolStripMenuItem.Text = "Save Clubs ...";
            // 
            // loadSwimmersToolStripMenuItem
            // 
            this.loadSwimmersToolStripMenuItem.Name = "loadSwimmersToolStripMenuItem";
            this.loadSwimmersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loadSwimmersToolStripMenuItem.Text = "Load Swimmers ...";
            this.loadSwimmersToolStripMenuItem.Click += new System.EventHandler(this.loadSwimmersToolStripMenuItem_Click);
            // 
            // saveSwimmersToolStripMenuItem
            // 
            this.saveSwimmersToolStripMenuItem.Name = "saveSwimmersToolStripMenuItem";
            this.saveSwimmersToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveSwimmersToolStripMenuItem.Text = "Save Swimmers ...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            // 
            // FormSwimTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSwimTracker";
            this.Text = "Swim Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView ClubsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderClubNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderClubName;
        private System.Windows.Forms.Button buttonAddClub;
        private System.Windows.Forms.Label labelSwimmers;
        private System.Windows.Forms.Label labelClubs;
        private System.Windows.Forms.Button buttonAllCoaches;
        private System.Windows.Forms.Button buttonAllSwimmers;
        private System.Windows.Forms.Button buttonAddCoach;
        private System.Windows.Forms.Button buttonAddSwimmer;
        private System.Windows.Forms.Label labelCoaches;
        private System.Windows.Forms.ListView coachListView;
        private System.Windows.Forms.ListView swimmerListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSwimmersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSwimmersToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColumnHeader columnHeaderSwimmerNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderSwimmerName;
        private System.Windows.Forms.ColumnHeader columnHeaderSwimmerClubNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderCoachNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderCoachName;
        private System.Windows.Forms.ColumnHeader columnHeaderCoachClubNumber;
    }
}

