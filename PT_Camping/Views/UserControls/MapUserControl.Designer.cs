﻿namespace PT_Camping.Views.UserControls
{
    partial class MapUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.importMapPanel = new System.Windows.Forms.Panel();
            this.importLabel = new System.Windows.Forms.Label();
            this.importMapButton = new System.Windows.Forms.Button();
            this.mapTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.modeCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validateChangesButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.categoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addLocationPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.editLocationPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.carCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.caractEditLabel = new System.Windows.Forms.Label();
            this.typeLocationComboBox = new System.Windows.Forms.ComboBox();
            this.typeEditLabel = new System.Windows.Forms.Label();
            this.locationNameTextBox = new System.Windows.Forms.TextBox();
            this.nameEditLabel = new System.Windows.Forms.Label();
            this.nullSelectionPanel = new System.Windows.Forms.Panel();
            this.importMapRightPanel = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.detailsLocationPanel = new System.Windows.Forms.Panel();
            this.locationIssuesListBox = new System.Windows.Forms.ListView();
            this.pendingIssuesLabel = new System.Windows.Forms.Label();
            this.catLocationListView = new System.Windows.Forms.ListView();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.catLocationLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.locationNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.resStateLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.importMapPanel.SuspendLayout();
            this.mapTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.editLocationPanel.SuspendLayout();
            this.nullSelectionPanel.SuspendLayout();
            this.detailsLocationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // importMapPanel
            // 
            this.importMapPanel.Controls.Add(this.importLabel);
            this.importMapPanel.Controls.Add(this.importMapButton);
            this.importMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importMapPanel.Location = new System.Drawing.Point(0, 0);
            this.importMapPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importMapPanel.Name = "importMapPanel";
            this.importMapPanel.Size = new System.Drawing.Size(890, 570);
            this.importMapPanel.TabIndex = 0;
            this.importMapPanel.Visible = false;
            // 
            // importLabel
            // 
            this.importLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importLabel.AutoSize = true;
            this.importLabel.Location = new System.Drawing.Point(203, 202);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(457, 17);
            this.importLabel.TabIndex = 1;
            this.importLabel.Text = "Aucune carte n\'a été trouvé pour ce camping. Veuillez en importer une.";
            // 
            // importMapButton
            // 
            this.importMapButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importMapButton.Location = new System.Drawing.Point(335, 312);
            this.importMapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importMapButton.Name = "importMapButton";
            this.importMapButton.Size = new System.Drawing.Size(189, 53);
            this.importMapButton.TabIndex = 0;
            this.importMapButton.Text = "Importer une carte";
            this.importMapButton.UseVisualStyleBackColor = true;
            this.importMapButton.Click += new System.EventHandler(this.ImportMapButton_Click);
            // 
            // mapTablePanel
            // 
            this.mapTablePanel.AllowDrop = true;
            this.mapTablePanel.ColumnCount = 3;
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mapTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapTablePanel.Controls.Add(this.pictureBox, 1, 1);
            this.mapTablePanel.Controls.Add(this.modeCheckBox, 0, 0);
            this.mapTablePanel.Controls.Add(this.dateTimePicker, 1, 0);
            this.mapTablePanel.Controls.Add(this.validateChangesButton, 2, 0);
            this.mapTablePanel.Controls.Add(this.leftPanel, 0, 1);
            this.mapTablePanel.Controls.Add(this.rightPanel, 2, 1);
            this.mapTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mapTablePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapTablePanel.Name = "mapTablePanel";
            this.mapTablePanel.RowCount = 2;
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.mapTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mapTablePanel.Size = new System.Drawing.Size(890, 570);
            this.mapTablePanel.TabIndex = 1;
            this.mapTablePanel.Visible = false;
            this.mapTablePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MapTablePanel_DragDrop);
            this.mapTablePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MapTablePanel_DragEnter);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(135, 41);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(530, 527);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // modeCheckBox
            // 
            this.modeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeCheckBox.AutoSize = true;
            this.modeCheckBox.Location = new System.Drawing.Point(10, 9);
            this.modeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(112, 21);
            this.modeCheckBox.TabIndex = 0;
            this.modeCheckBox.Text = "Mode Edition";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            this.modeCheckBox.CheckedChanged += new System.EventHandler(this.ModeCheckBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(319, 8);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // validateChangesButton
            // 
            this.validateChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validateChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validateChangesButton.Location = new System.Drawing.Point(722, 8);
            this.validateChangesButton.Margin = new System.Windows.Forms.Padding(2);
            this.validateChangesButton.Name = "validateChangesButton";
            this.validateChangesButton.Size = new System.Drawing.Size(113, 23);
            this.validateChangesButton.TabIndex = 3;
            this.validateChangesButton.Text = "Sauvegarder";
            this.validateChangesButton.UseVisualStyleBackColor = true;
            this.validateChangesButton.Click += new System.EventHandler(this.ValidateChangesButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoriesCheckedListBox);
            this.leftPanel.Controls.Add(this.addLocationPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(2, 41);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(129, 527);
            this.leftPanel.TabIndex = 6;
            // 
            // categoriesCheckedListBox
            // 
            this.categoriesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesCheckedListBox.FormattingEnabled = true;
            this.categoriesCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.categoriesCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriesCheckedListBox.Name = "categoriesCheckedListBox";
            this.categoriesCheckedListBox.Size = new System.Drawing.Size(129, 527);
            this.categoriesCheckedListBox.TabIndex = 1;
            this.categoriesCheckedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CategoriesCheckedListBox_MouseUp);
            // 
            // addLocationPanel
            // 
            this.addLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.addLocationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLocationPanel.Name = "addLocationPanel";
            this.addLocationPanel.Size = new System.Drawing.Size(129, 527);
            this.addLocationPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsLocationPanel);
            this.rightPanel.Controls.Add(this.nullSelectionPanel);
            this.rightPanel.Controls.Add(this.editLocationPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(669, 41);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(219, 527);
            this.rightPanel.TabIndex = 7;
            // 
            // editLocationPanel
            // 
            this.editLocationPanel.Controls.Add(this.deleteButton);
            this.editLocationPanel.Controls.Add(this.carCheckedListBox);
            this.editLocationPanel.Controls.Add(this.caractEditLabel);
            this.editLocationPanel.Controls.Add(this.typeLocationComboBox);
            this.editLocationPanel.Controls.Add(this.typeEditLabel);
            this.editLocationPanel.Controls.Add(this.locationNameTextBox);
            this.editLocationPanel.Controls.Add(this.nameEditLabel);
            this.editLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.editLocationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.editLocationPanel.Name = "editLocationPanel";
            this.editLocationPanel.Size = new System.Drawing.Size(219, 527);
            this.editLocationPanel.TabIndex = 3;
            this.editLocationPanel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(79, 340);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 31);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // carCheckedListBox
            // 
            this.carCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carCheckedListBox.FormattingEnabled = true;
            this.carCheckedListBox.Location = new System.Drawing.Point(20, 148);
            this.carCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carCheckedListBox.Name = "carCheckedListBox";
            this.carCheckedListBox.Size = new System.Drawing.Size(196, 123);
            this.carCheckedListBox.TabIndex = 5;
            this.carCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CarCheckedListBox_Check);
            // 
            // caractEditLabel
            // 
            this.caractEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.caractEditLabel.AutoSize = true;
            this.caractEditLabel.Location = new System.Drawing.Point(16, 127);
            this.caractEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caractEditLabel.Name = "caractEditLabel";
            this.caractEditLabel.Size = new System.Drawing.Size(118, 17);
            this.caractEditLabel.TabIndex = 4;
            this.caractEditLabel.Text = "Caractéristiques :";
            // 
            // typeLocationComboBox
            // 
            this.typeLocationComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.typeLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeLocationComboBox.FormattingEnabled = true;
            this.typeLocationComboBox.Location = new System.Drawing.Point(60, 64);
            this.typeLocationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeLocationComboBox.Name = "typeLocationComboBox";
            this.typeLocationComboBox.Size = new System.Drawing.Size(156, 24);
            this.typeLocationComboBox.TabIndex = 3;
            // 
            // typeEditLabel
            // 
            this.typeEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.typeEditLabel.AutoSize = true;
            this.typeEditLabel.Location = new System.Drawing.Point(13, 68);
            this.typeEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeEditLabel.Name = "typeEditLabel";
            this.typeEditLabel.Size = new System.Drawing.Size(40, 17);
            this.typeEditLabel.TabIndex = 2;
            this.typeEditLabel.Text = "Type";
            // 
            // locationNameTextBox
            // 
            this.locationNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationNameTextBox.Location = new System.Drawing.Point(60, 23);
            this.locationNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationNameTextBox.MaxLength = 50;
            this.locationNameTextBox.Name = "locationNameTextBox";
            this.locationNameTextBox.ShortcutsEnabled = false;
            this.locationNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.locationNameTextBox.TabIndex = 1;
            // 
            // nameEditLabel
            // 
            this.nameEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameEditLabel.AutoSize = true;
            this.nameEditLabel.Location = new System.Drawing.Point(16, 26);
            this.nameEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameEditLabel.Name = "nameEditLabel";
            this.nameEditLabel.Size = new System.Drawing.Size(37, 17);
            this.nameEditLabel.TabIndex = 0;
            this.nameEditLabel.Text = "Nom";
            // 
            // nullSelectionPanel
            // 
            this.nullSelectionPanel.Controls.Add(this.importMapRightPanel);
            this.nullSelectionPanel.Controls.Add(this.infoLabel);
            this.nullSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nullSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.nullSelectionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.nullSelectionPanel.Name = "nullSelectionPanel";
            this.nullSelectionPanel.Size = new System.Drawing.Size(219, 527);
            this.nullSelectionPanel.TabIndex = 8;
            this.nullSelectionPanel.Visible = false;
            // 
            // importMapRightPanel
            // 
            this.importMapRightPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.importMapRightPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importMapRightPanel.Location = new System.Drawing.Point(29, 289);
            this.importMapRightPanel.Name = "importMapRightPanel";
            this.importMapRightPanel.Size = new System.Drawing.Size(134, 30);
            this.importMapRightPanel.TabIndex = 19;
            this.importMapRightPanel.Text = "Importer une carte";
            this.importMapRightPanel.UseVisualStyleBackColor = true;
            this.importMapRightPanel.Click += new System.EventHandler(this.ImportMapButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(1, 26);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(212, 17);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Aucun emplacement sélectionné";
            // 
            // detailsLocationPanel
            // 
            this.detailsLocationPanel.Controls.Add(this.locationIssuesListBox);
            this.detailsLocationPanel.Controls.Add(this.pendingIssuesLabel);
            this.detailsLocationPanel.Controls.Add(this.catLocationListView);
            this.detailsLocationPanel.Controls.Add(this.detailsLabel);
            this.detailsLocationPanel.Controls.Add(this.catLocationLabel);
            this.detailsLocationPanel.Controls.Add(this.categoryLabel);
            this.detailsLocationPanel.Controls.Add(this.locationNameLabel);
            this.detailsLocationPanel.Controls.Add(this.nameLabel);
            this.detailsLocationPanel.Controls.Add(this.reserveButton);
            this.detailsLocationPanel.Controls.Add(this.resStateLabel);
            this.detailsLocationPanel.Controls.Add(this.stateLabel);
            this.detailsLocationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsLocationPanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.detailsLocationPanel.Name = "detailsLocationPanel";
            this.detailsLocationPanel.Size = new System.Drawing.Size(219, 527);
            this.detailsLocationPanel.TabIndex = 5;
            this.detailsLocationPanel.Visible = false;
            // 
            // locationIssuesListBox
            // 
            this.locationIssuesListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationIssuesListBox.FullRowSelect = true;
            this.locationIssuesListBox.GridLines = true;
            this.locationIssuesListBox.HideSelection = false;
            this.locationIssuesListBox.Location = new System.Drawing.Point(17, 250);
            this.locationIssuesListBox.MultiSelect = false;
            this.locationIssuesListBox.Name = "locationIssuesListBox";
            this.locationIssuesListBox.Size = new System.Drawing.Size(200, 84);
            this.locationIssuesListBox.TabIndex = 11;
            this.locationIssuesListBox.UseCompatibleStateImageBehavior = false;
            this.locationIssuesListBox.View = System.Windows.Forms.View.List;
            this.locationIssuesListBox.DoubleClick += new System.EventHandler(this.LocationIssuesListBox_DoubleClick);
            // 
            // pendingIssuesLabel
            // 
            this.pendingIssuesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pendingIssuesLabel.AutoSize = true;
            this.pendingIssuesLabel.Location = new System.Drawing.Point(14, 235);
            this.pendingIssuesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pendingIssuesLabel.Name = "pendingIssuesLabel";
            this.pendingIssuesLabel.Size = new System.Drawing.Size(131, 17);
            this.pendingIssuesLabel.TabIndex = 10;
            this.pendingIssuesLabel.Text = "Incidents en cours :";
            // 
            // catLocationListView
            // 
            this.catLocationListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catLocationListView.Location = new System.Drawing.Point(17, 155);
            this.catLocationListView.Margin = new System.Windows.Forms.Padding(2);
            this.catLocationListView.Name = "catLocationListView";
            this.catLocationListView.Size = new System.Drawing.Size(200, 73);
            this.catLocationListView.TabIndex = 9;
            this.catLocationListView.UseCompatibleStateImageBehavior = false;
            this.catLocationListView.View = System.Windows.Forms.View.List;
            // 
            // detailsLabel
            // 
            this.detailsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(15, 140);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(118, 17);
            this.detailsLabel.TabIndex = 8;
            this.detailsLabel.Text = "Caractéristiques :";
            // 
            // catLocationLabel
            // 
            this.catLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catLocationLabel.AutoSize = true;
            this.catLocationLabel.Location = new System.Drawing.Point(106, 35);
            this.catLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.catLocationLabel.Name = "catLocationLabel";
            this.catLocationLabel.Size = new System.Drawing.Size(85, 17);
            this.catLocationLabel.TabIndex = 7;
            this.catLocationLabel.Text = "CATEGORY";
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(32, 35);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 17);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Catégorie :";
            // 
            // locationNameLabel
            // 
            this.locationNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationNameLabel.AutoSize = true;
            this.locationNameLabel.Location = new System.Drawing.Point(71, 10);
            this.locationNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationNameLabel.Name = "locationNameLabel";
            this.locationNameLabel.Size = new System.Drawing.Size(125, 17);
            this.locationNameLabel.TabIndex = 5;
            this.locationNameLabel.Text = "LOCATION_NAME";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 10);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nom :";
            // 
            // reserveButton
            // 
            this.reserveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reserveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reserveButton.Location = new System.Drawing.Point(76, 85);
            this.reserveButton.Margin = new System.Windows.Forms.Padding(2);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(65, 22);
            this.reserveButton.TabIndex = 2;
            this.reserveButton.Text = "Réserver";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // resStateLabel
            // 
            this.resStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resStateLabel.AutoSize = true;
            this.resStateLabel.Location = new System.Drawing.Point(71, 60);
            this.resStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resStateLabel.Name = "resStateLabel";
            this.resStateLabel.Size = new System.Drawing.Size(120, 17);
            this.resStateLabel.TabIndex = 1;
            this.resStateLabel.Text = "BOOKED_STATE";
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(32, 60);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 17);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "Etat :";
            // 
            // MapUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.mapTablePanel);
            this.Controls.Add(this.importMapPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapUserControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 30);
            this.Size = new System.Drawing.Size(900, 600);
            this.importMapPanel.ResumeLayout(false);
            this.importMapPanel.PerformLayout();
            this.mapTablePanel.ResumeLayout(false);
            this.mapTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.editLocationPanel.ResumeLayout(false);
            this.editLocationPanel.PerformLayout();
            this.nullSelectionPanel.ResumeLayout(false);
            this.nullSelectionPanel.PerformLayout();
            this.detailsLocationPanel.ResumeLayout(false);
            this.detailsLocationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel importMapPanel;
        private System.Windows.Forms.Button importMapButton;
        private System.Windows.Forms.Label importLabel;
        private System.Windows.Forms.TableLayoutPanel mapTablePanel;
        private System.Windows.Forms.CheckBox modeCheckBox;
        private System.Windows.Forms.CheckedListBox categoriesCheckedListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button validateChangesButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel detailsLocationPanel;
        private System.Windows.Forms.Label resStateLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel editLocationPanel;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.Label nameEditLabel;
        private System.Windows.Forms.Label typeEditLabel;
        private System.Windows.Forms.ComboBox typeLocationComboBox;
        private System.Windows.Forms.Label caractEditLabel;
        private System.Windows.Forms.CheckedListBox carCheckedListBox;
        private System.Windows.Forms.Label locationNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label catLocationLabel;
        private System.Windows.Forms.ListView catLocationListView;
        private System.Windows.Forms.Label pendingIssuesLabel;
        private System.Windows.Forms.ListView locationIssuesListBox;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel addLocationPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel nullSelectionPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button importMapRightPanel;
    }
}
