

    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(428, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.connectionsToolStripMenuItem.Text = "Connections";
            this.connectionsToolStripMenuItem.ToolTipText = "Wybierz po³¹czenie z warstwami do eksportu";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.ToolTipText = "Eksport obiektów do wybranego katalogu...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.ToolTipText = "Zapisz raport eksportu";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Wybierz katalog eksportu obiektów";
            // 
            // mListView
            // 
            this.mListView.CheckBoxes = true;
            this.mListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mListView.ContextMenuStrip = this.contextMenu;
            this.mListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListView.FullRowSelect = true;
            this.mListView.Location = new System.Drawing.Point(0, 28);
            this.mListView.MultiSelect = false;
            this.mListView.Name = "mListView";
            this.mListView.ShowGroups = false;
            this.mListView.Size = new System.Drawing.Size(428, 156);
            this.mListView.TabIndex = 1;
            this.mListView.UseCompatibleStateImageBehavior = false;
            this.mListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FeatureName";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FeatureStatus";
            this.columnHeader2.Width = 200;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaznaczWszystkoToolStripMenuItem,
            this.odznaczWszystkoToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem});
            this.contextMenu.Name = "mContextMenuStrip";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenu.Size = new System.Drawing.Size(204, 82);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.ToolTipText = "Zaznacz wszystkie warstwy";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // odznaczWszystkoToolStripMenuItem
            // 
            this.odznaczWszystkoToolStripMenuItem.Name = "odznaczWszystkoToolStripMenuItem";
            this.odznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.odznaczWszystkoToolStripMenuItem.Text = "Odznacz wszystko";
            this.odznaczWszystkoToolStripMenuItem.ToolTipText = "Odznacz wszystkie warstwy";
            this.odznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.odznaczWszystkoToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.ToolTipText = "Zapisz raport eksportu";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "MapInfoExport.txt";
            this.saveFileDialog.Filter = "Raport eksportu (*.txt)|*.txt";
            this.saveFileDialog.Title = "Zapisz raport eksportu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 184);
            this.Controls.Add(this.mListView);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Location = new System.Drawing.Point(158, 422);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MapInfoBatch v1.0 (24 maja 2012)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListView mListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;


    }













































