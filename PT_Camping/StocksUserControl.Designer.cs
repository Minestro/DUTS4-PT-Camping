﻿namespace PT_Camping
{
    partial class StocksUserControl
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
            this.components = new System.ComponentModel.Container();
            this.productListView = new System.Windows.Forms.ListView();
            this.addStockButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.informationsLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.amountProductLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.commandButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            // 
            // productListView
            // 
            this.productListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.Location = new System.Drawing.Point(43, 47);
            this.productListView.Name = "productListView";
            this.productListView.Scrollable = false;
            this.productListView.Size = new System.Drawing.Size(314, 390);
            this.productListView.TabIndex = 11;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.List;
            this.productListView.SelectedIndexChanged += new System.EventHandler(this.ProductListView_SelectedIndexChanged);
            this.productListView.Resize += new System.EventHandler(this.productListView_Resize);
            // 
            // addStockButton
            // 
            this.addStockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStockButton.Location = new System.Drawing.Point(140, 463);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(120, 35);
            this.addStockButton.TabIndex = 12;
            this.addStockButton.Text = "Nouveau Stock";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddStockButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.Location = new System.Drawing.Point(160, 143);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(120, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Location = new System.Drawing.Point(161, 221);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(119, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // informationsLabel
            // 
            this.informationsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.informationsLabel.AutoSize = true;
            this.informationsLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.informationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationsLabel.ForeColor = System.Drawing.Color.White;
            this.informationsLabel.Location = new System.Drawing.Point(100, 10);
            this.informationsLabel.Name = "informationsLabel";
            this.informationsLabel.Size = new System.Drawing.Size(103, 20);
            this.informationsLabel.TabIndex = 16;
            this.informationsLabel.Text = "Détail produit";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(28, 146);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(57, 13);
            this.productCodeLabel.TabIndex = 17;
            this.productCodeLabel.Text = "Référence";
            // 
            // amountProductLabel
            // 
            this.amountProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountProductLabel.AutoSize = true;
            this.amountProductLabel.Location = new System.Drawing.Point(28, 198);
            this.amountProductLabel.Name = "amountProductLabel";
            this.amountProductLabel.Size = new System.Drawing.Size(47, 13);
            this.amountProductLabel.TabIndex = 18;
            this.amountProductLabel.Text = "Quantité";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(28, 224);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(24, 13);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Prix";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(28, 172);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(29, 13);
            this.ProductNameLabel.TabIndex = 20;
            this.ProductNameLabel.Text = "Nom";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameTextBox.Location = new System.Drawing.Point(161, 169);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.productNameTextBox.TabIndex = 21;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_delete;
            this.deleteProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteProductButton.Location = new System.Drawing.Point(243, 46);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(30, 30);
            this.deleteProductButton.TabIndex = 22;
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductButton.BackgroundImage = global::PT_Camping.Properties.Resources.ic_edit;
            this.editProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editProductButton.Location = new System.Drawing.Point(279, 46);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(30, 30);
            this.editProductButton.TabIndex = 23;
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(198, 46);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(41, 30);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Annuler";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // commandButton
            // 
            this.commandButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commandButton.Location = new System.Drawing.Point(168, 340);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(120, 30);
            this.commandButton.TabIndex = 26;
            this.commandButton.Text = "Commander";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.amountTextBox.Location = new System.Drawing.Point(161, 195);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(119, 20);
            this.amountTextBox.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // providerComboBox
            // 
            this.providerComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.providerComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.providerComboBox.Enabled = false;
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(161, 247);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(120, 21);
            this.providerComboBox.TabIndex = 28;
            // 
            // sellButton
            // 
            this.sellButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellButton.Location = new System.Drawing.Point(24, 340);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(120, 30);
            this.sellButton.TabIndex = 29;
            this.sellButton.Text = "Vendre";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.productListView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addStockButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.detailsPanel, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 550);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.White;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.panel1);
            this.detailsPanel.Controls.Add(this.sellButton);
            this.detailsPanel.Controls.Add(this.productCodeLabel);
            this.detailsPanel.Controls.Add(this.ProductNameLabel);
            this.detailsPanel.Controls.Add(this.amountTextBox);
            this.detailsPanel.Controls.Add(this.amountProductLabel);
            this.detailsPanel.Controls.Add(this.priceLabel);
            this.detailsPanel.Controls.Add(this.providerComboBox);
            this.detailsPanel.Controls.Add(this.productNameTextBox);
            this.detailsPanel.Controls.Add(this.resetButton);
            this.detailsPanel.Controls.Add(this.priceTextBox);
            this.detailsPanel.Controls.Add(this.commandButton);
            this.detailsPanel.Controls.Add(this.deleteProductButton);
            this.detailsPanel.Controls.Add(this.editProductButton);
            this.detailsPanel.Controls.Add(this.idTextBox);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(443, 47);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(314, 390);
            this.detailsPanel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Responsable";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.informationsLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 40);
            this.panel1.TabIndex = 30;
            // 
            // StocksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StocksUserControl";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.appBarTitle, 0);
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label informationsLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label amountProductLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
