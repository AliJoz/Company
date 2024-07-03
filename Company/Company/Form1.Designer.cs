
namespace Company
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rbnMain = new System.Windows.Forms.Ribbon();
            this.Backup_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Restore_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Help_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.About_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Exit_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.person_Tab = new System.Windows.Forms.RibbonTab();
            this.rbnpAddPerson = new System.Windows.Forms.RibbonPanel();
            this.btnAddPerson = new System.Windows.Forms.RibbonButton();
            this.rbnpDeletePerson = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.rbnpEditPerson = new System.Windows.Forms.RibbonPanel();
            this.btnEditPerson = new System.Windows.Forms.RibbonButton();
            this.rbnpSearchPerson = new System.Windows.Forms.RibbonPanel();
            this.ribbonTextBox1 = new System.Windows.Forms.RibbonTextBox();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtSearchPerson = new System.Windows.Forms.RibbonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnMain
            // 
            this.rbnMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.Minimized = false;
            this.rbnMain.Name = "rbnMain";
            // 
            // 
            // 
            this.rbnMain.OrbDropDown.BorderRoundness = 8;
            this.rbnMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Backup_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Restore_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Help_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.About_Menu_Item);
            this.rbnMain.OrbDropDown.MenuItems.Add(this.Exit_Menu_Item);
            this.rbnMain.OrbDropDown.Name = "";
            this.rbnMain.OrbDropDown.Size = new System.Drawing.Size(527, 292);
            this.rbnMain.OrbDropDown.TabIndex = 0;
            this.rbnMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbnMain.Size = new System.Drawing.Size(800, 126);
            this.rbnMain.TabIndex = 0;
            this.rbnMain.Tabs.Add(this.person_Tab);
            // 
            // Backup_Menu_Item
            // 
            this.Backup_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Backup_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Backup_Menu_Item.Image")));
            this.Backup_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("Backup_Menu_Item.LargeImage")));
            this.Backup_Menu_Item.Name = "Backup_Menu_Item";
            this.Backup_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Backup_Menu_Item.SmallImage")));
            this.Backup_Menu_Item.Text = "Backup";
            // 
            // Restore_Menu_Item
            // 
            this.Restore_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Restore_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Restore_Menu_Item.Image")));
            this.Restore_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("Restore_Menu_Item.LargeImage")));
            this.Restore_Menu_Item.Name = "Restore_Menu_Item";
            this.Restore_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Restore_Menu_Item.SmallImage")));
            this.Restore_Menu_Item.Text = "Restore";
            // 
            // Help_Menu_Item
            // 
            this.Help_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Help_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Help_Menu_Item.Image")));
            this.Help_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("Help_Menu_Item.LargeImage")));
            this.Help_Menu_Item.Name = "Help_Menu_Item";
            this.Help_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Help_Menu_Item.SmallImage")));
            this.Help_Menu_Item.Text = "Help";
            // 
            // About_Menu_Item
            // 
            this.About_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.About_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.Image")));
            this.About_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.LargeImage")));
            this.About_Menu_Item.Name = "About_Menu_Item";
            this.About_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.SmallImage")));
            this.About_Menu_Item.Text = "About";
            // 
            // Exit_Menu_Item
            // 
            this.Exit_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Exit_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Menu_Item.Image")));
            this.Exit_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("Exit_Menu_Item.LargeImage")));
            this.Exit_Menu_Item.Name = "Exit_Menu_Item";
            this.Exit_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Exit_Menu_Item.SmallImage")));
            this.Exit_Menu_Item.Text = "Exit";
            this.Exit_Menu_Item.Click += new System.EventHandler(this.Exit_Menu_Item_Click);
            // 
            // person_Tab
            // 
            this.person_Tab.Name = "person_Tab";
            this.person_Tab.Panels.Add(this.rbnpAddPerson);
            this.person_Tab.Panels.Add(this.rbnpDeletePerson);
            this.person_Tab.Panels.Add(this.rbnpEditPerson);
            this.person_Tab.Panels.Add(this.rbnpSearchPerson);
            this.person_Tab.Text = "Persons";
            // 
            // rbnpAddPerson
            // 
            this.rbnpAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("rbnpAddPerson.Image")));
            this.rbnpAddPerson.Items.Add(this.btnAddPerson);
            this.rbnpAddPerson.Name = "rbnpAddPerson";
            this.rbnpAddPerson.Text = "Add Person";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.LargeImage")));
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.SmallImage")));
            this.btnAddPerson.Text = "";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // rbnpDeletePerson
            // 
            this.rbnpDeletePerson.Items.Add(this.ribbonButton1);
            this.rbnpDeletePerson.Name = "rbnpDeletePerson";
            this.rbnpDeletePerson.Text = "Delete Person";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // rbnpEditPerson
            // 
            this.rbnpEditPerson.Items.Add(this.btnEditPerson);
            this.rbnpEditPerson.Name = "rbnpEditPerson";
            this.rbnpEditPerson.Text = "Edit Person";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPerson.Image")));
            this.btnEditPerson.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditPerson.LargeImage")));
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEditPerson.SmallImage")));
            this.btnEditPerson.Text = "";
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // rbnpSearchPerson
            // 
            this.rbnpSearchPerson.Items.Add(this.txtSearchPerson);
            this.rbnpSearchPerson.Name = "rbnpSearchPerson";
            this.rbnpSearchPerson.Text = "Search Personn";
            // 
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.Name = "ribbonTextBox1";
            this.ribbonTextBox1.TextBoxText = "";
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgView.Location = new System.Drawing.Point(0, 126);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(800, 324);
            this.dtgView.TabIndex = 1;
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Text = "";
            this.txtSearchPerson.TextBoxText = "";
            this.txtSearchPerson.TextBoxTextChanged += new System.EventHandler(this.txtSearchPerson_TextBoxTextChanged_1);
           // this.txtSearchPerson.TextBoxKeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPerson_TextBoxKeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.rbnMain);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rbnMain;
        private System.Windows.Forms.RibbonOrbMenuItem Backup_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Restore_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Help_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem About_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Exit_Menu_Item;
        private System.Windows.Forms.RibbonTab person_Tab;
        private System.Windows.Forms.RibbonPanel rbnpAddPerson;
        private System.Windows.Forms.RibbonButton btnAddPerson;
        private System.Windows.Forms.RibbonPanel rbnpDeletePerson;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel rbnpEditPerson;
        private System.Windows.Forms.RibbonButton btnEditPerson;
       
        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonTextBox ribbonTextBox1;

        private System.Windows.Forms.RibbonPanel rbnpSearchPerson;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RibbonTextBox txtSearchPerson;
    }
}

