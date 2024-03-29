namespace PT_Camping.Views.UserControls
{
    partial class IssuesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuesUserControl));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.criticalityComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.emplacementLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.resolutionDateTextBox = new System.Windows.Forms.TextBox();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.issueTypeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.detailsTitleBarPanel = new System.Windows.Forms.Panel();
            this.detailsTitle = new System.Windows.Forms.Label();
            this.resolveButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.criticalityLabel = new System.Windows.Forms.Label();
            this.resolutionDateLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.issueTypeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.issuesListView = new System.Windows.Forms.ListView();
            this.addIssueButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.detailsTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appBarTitle
            // 
            this.appBarTitle.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Controls.Add(this.detailsPanel, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.issuesListView, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.addIssueButton, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(900, 538);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.criticalityComboBox);
            this.detailsPanel.Controls.Add(this.resetButton);
            this.detailsPanel.Controls.Add(this.locationTextBox);
            this.detailsPanel.Controls.Add(this.emplacementLabel);
            this.detailsPanel.Controls.Add(this.descriptionTextBox);
            this.detailsPanel.Controls.Add(this.statusTextBox);
            this.detailsPanel.Controls.Add(this.resolutionDateTextBox);
            this.detailsPanel.Controls.Add(this.creationDateTextBox);
            this.detailsPanel.Controls.Add(this.issueTypeTextBox);
            this.detailsPanel.Controls.Add(this.idTextBox);
            this.detailsPanel.Controls.Add(this.deleteButton);
            this.detailsPanel.Controls.Add(this.editButton);
            this.detailsPanel.Controls.Add(this.detailsTitleBarPanel);
            this.detailsPanel.Controls.Add(this.resolveButton);
            this.detailsPanel.Controls.Add(this.descriptionLabel);
            this.detailsPanel.Controls.Add(this.statusLabel);
            this.detailsPanel.Controls.Add(this.criticalityLabel);
            this.detailsPanel.Controls.Add(this.resolutionDateLabel);
            this.detailsPanel.Controls.Add(this.creationDateLabel);
            this.detailsPanel.Controls.Add(this.issueTypeLabel);
            this.detailsPanel.Controls.Add(this.idLabel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(499, 47);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(352, 379);
            this.detailsPanel.TabIndex = 11;
            // 
            // criticalityComboBox
            // 
            this.criticalityComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criticalityComboBox.Enabled = false;
            this.criticalityComboBox.FormattingEnabled = true;
            this.criticalityComboBox.Items.AddRange(new object[] {
            "1/5",
            "2/5",
            "3/5",
            "4/5",
            "5/5"});
            this.criticalityComboBox.Location = new System.Drawing.Point(182, 230);
            this.criticalityComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.criticalityComboBox.Name = "criticalityComboBox";
            this.criticalityComboBox.Size = new System.Drawing.Size(159, 24);
            this.criticalityComboBox.TabIndex = 17;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_undo;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(210, 57);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(40, 37);
            this.resetButton.TabIndex = 25;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationTextBox.Location = new System.Drawing.Point(182, 102);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(159, 22);
            this.locationTextBox.TabIndex = 13;
            // 
            // emplacementLabel
            // 
            this.emplacementLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emplacementLabel.AutoSize = true;
            this.emplacementLabel.Location = new System.Drawing.Point(6, 105);
            this.emplacementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emplacementLabel.Name = "emplacementLabel";
            this.emplacementLabel.Size = new System.Drawing.Size(93, 17);
            this.emplacementLabel.TabIndex = 19;
            this.emplacementLabel.Text = "Emplacement";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(182, 295);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.MaxLength = 300;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ShortcutsEnabled = false;
            this.descriptionTextBox.Size = new System.Drawing.Size(159, 48);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusTextBox.Location = new System.Drawing.Point(182, 263);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusTextBox.MaxLength = 50;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.ShortcutsEnabled = false;
            this.statusTextBox.Size = new System.Drawing.Size(159, 22);
            this.statusTextBox.TabIndex = 18;
            // 
            // resolutionDateTextBox
            // 
            this.resolutionDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolutionDateTextBox.Location = new System.Drawing.Point(182, 198);
            this.resolutionDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resolutionDateTextBox.Name = "resolutionDateTextBox";
            this.resolutionDateTextBox.ReadOnly = true;
            this.resolutionDateTextBox.ShortcutsEnabled = false;
            this.resolutionDateTextBox.Size = new System.Drawing.Size(159, 22);
            this.resolutionDateTextBox.TabIndex = 16;
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creationDateTextBox.Location = new System.Drawing.Point(182, 166);
            this.creationDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.ReadOnly = true;
            this.creationDateTextBox.Size = new System.Drawing.Size(159, 22);
            this.creationDateTextBox.TabIndex = 15;
            // 
            // issueTypeTextBox
            // 
            this.issueTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueTypeTextBox.Location = new System.Drawing.Point(182, 134);
            this.issueTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.issueTypeTextBox.Name = "issueTypeTextBox";
            this.issueTypeTextBox.ReadOnly = true;
            this.issueTypeTextBox.Size = new System.Drawing.Size(159, 22);
            this.issueTypeTextBox.TabIndex = 14;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Location = new System.Drawing.Point(182, 70);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(159, 22);
            this.idTextBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Location = new System.Drawing.Point(258, 57);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 37);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteIssueButtonClick);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Location = new System.Drawing.Point(306, 57);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 37);
            this.editButton.TabIndex = 11;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditButtonClick);
            // 
            // detailsTitleBarPanel
            // 
            this.detailsTitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.detailsTitleBarPanel.Controls.Add(this.detailsTitle);
            this.detailsTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsTitleBarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsTitleBarPanel.Name = "detailsTitleBarPanel";
            this.detailsTitleBarPanel.Size = new System.Drawing.Size(350, 49);
            this.detailsTitleBarPanel.TabIndex = 9;
            // 
            // detailsTitle
            // 
            this.detailsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailsTitle.AutoSize = true;
            this.detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTitle.ForeColor = System.Drawing.Color.White;
            this.detailsTitle.Location = new System.Drawing.Point(106, 12);
            this.detailsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsTitle.Name = "detailsTitle";
            this.detailsTitle.Size = new System.Drawing.Size(133, 25);
            this.detailsTitle.TabIndex = 0;
            this.detailsTitle.Text = "Détail incident";
            // 
            // resolveButton
            // 
            this.resolveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolveButton.AutoSize = true;
            this.resolveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resolveButton.Location = new System.Drawing.Point(94, 370);
            this.resolveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resolveButton.Name = "resolveButton";
            this.resolveButton.Size = new System.Drawing.Size(211, 37);
            this.resolveButton.TabIndex = 20;
            this.resolveButton.Text = "Marqué comme résolu";
            this.resolveButton.UseVisualStyleBackColor = true;
            this.resolveButton.Click += new System.EventHandler(this.OnResolveIssueButtonClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 299);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 267);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(86, 17);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Avancement";
            // 
            // criticalityLabel
            // 
            this.criticalityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criticalityLabel.AutoSize = true;
            this.criticalityLabel.Location = new System.Drawing.Point(6, 233);
            this.criticalityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.criticalityLabel.Name = "criticalityLabel";
            this.criticalityLabel.Size = new System.Drawing.Size(54, 17);
            this.criticalityLabel.TabIndex = 5;
            this.criticalityLabel.Text = "Criticité";
            // 
            // resolutionDateLabel
            // 
            this.resolutionDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resolutionDateLabel.AutoSize = true;
            this.resolutionDateLabel.Location = new System.Drawing.Point(6, 201);
            this.resolutionDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resolutionDateLabel.Name = "resolutionDateLabel";
            this.resolutionDateLabel.Size = new System.Drawing.Size(124, 17);
            this.resolutionDateLabel.TabIndex = 4;
            this.resolutionDateLabel.Text = "Date de résolution";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(6, 169);
            this.creationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(113, 17);
            this.creationDateLabel.TabIndex = 3;
            this.creationDateLabel.Text = "Date de création";
            // 
            // issueTypeLabel
            // 
            this.issueTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issueTypeLabel.AutoSize = true;
            this.issueTypeLabel.Location = new System.Drawing.Point(6, 137);
            this.issueTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.issueTypeLabel.Name = "issueTypeLabel";
            this.issueTypeLabel.Size = new System.Drawing.Size(40, 17);
            this.issueTypeLabel.TabIndex = 2;
            this.issueTypeLabel.Text = "Type";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 73);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(74, 17);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Référence";
            // 
            // issuesListView
            // 
            this.issuesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuesListView.FullRowSelect = true;
            this.issuesListView.GridLines = true;
            this.issuesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.issuesListView.HideSelection = false;
            this.issuesListView.Location = new System.Drawing.Point(49, 47);
            this.issuesListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.issuesListView.MultiSelect = false;
            this.issuesListView.Name = "issuesListView";
            this.issuesListView.Scrollable = false;
            this.issuesListView.Size = new System.Drawing.Size(352, 379);
            this.issuesListView.TabIndex = 10;
            this.issuesListView.UseCompatibleStateImageBehavior = false;
            this.issuesListView.View = System.Windows.Forms.View.List;
            this.issuesListView.SelectedIndexChanged += new System.EventHandler(this.IssuesListView_SelectedIndexChanged);
            this.issuesListView.Resize += new System.EventHandler(this.IssuesListView_Resize);
            // 
            // addIssueButton
            // 
            this.addIssueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIssueButton.AutoSize = true;
            this.addIssueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIssueButton.Location = new System.Drawing.Point(145, 448);
            this.addIssueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addIssueButton.Name = "addIssueButton";
            this.addIssueButton.Size = new System.Drawing.Size(160, 43);
            this.addIssueButton.TabIndex = 11;
            this.addIssueButton.Text = "Nouvel incident";
            this.addIssueButton.UseVisualStyleBackColor = true;
            this.addIssueButton.Click += new System.EventHandler(this.OnAddIssueButtonClick);
            // 
            // IssuesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "IssuesUserControl";
            this.Controls.SetChildIndex(this.tableLayoutPanel, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.detailsTitleBarPanel.ResumeLayout(false);
            this.detailsTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListView issuesListView;
        private System.Windows.Forms.Button addIssueButton;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button resolveButton;
        private System.Windows.Forms.Panel detailsTitleBarPanel;
        private System.Windows.Forms.Label detailsTitle;
        private System.Windows.Forms.Label emplacementLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label criticalityLabel;
        private System.Windows.Forms.Label resolutionDateLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label issueTypeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox resolutionDateTextBox;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.TextBox issueTypeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ComboBox criticalityComboBox;
        private System.Windows.Forms.Button resetButton;
    }
}
