﻿namespace InvoiceManagement
{
    partial class formCreateInvoice
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
            this.newInvLabel = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.timeInput = new System.Windows.Forms.DateTimePicker();
            this.prodListView = new System.Windows.Forms.ListView();
            this.prodID = new System.Windows.Forms.ColumnHeader();
            this.prodName = new System.Windows.Forms.ColumnHeader();
            this.unit = new System.Windows.Forms.ColumnHeader();
            this.unitPrice = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.discount = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.prodComboBox = new System.Windows.Forms.ComboBox();
            this.addProdButton = new System.Windows.Forms.Button();
            this.createInvButton = new System.Windows.Forms.Button();
            this.quantityInputBox = new System.Windows.Forms.TextBox();
            this.unitPriceInputBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.discountInputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newInvLabel
            // 
            this.newInvLabel.AutoSize = true;
            this.newInvLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newInvLabel.Location = new System.Drawing.Point(23, 32);
            this.newInvLabel.Name = "newInvLabel";
            this.newInvLabel.Size = new System.Drawing.Size(115, 25);
            this.newInvLabel.TabIndex = 1;
            this.newInvLabel.Text = "New Invoice";
            // 
            // dateInput
            // 
            this.dateInput.CustomFormat = "MM/dd/yyyy";
            this.dateInput.Location = new System.Drawing.Point(441, 33);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(200, 23);
            this.dateInput.TabIndex = 2;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimeLabel.Location = new System.Drawing.Point(318, 35);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(107, 21);
            this.DateTimeLabel.TabIndex = 3;
            this.DateTimeLabel.Text = "Date and time";
            // 
            // timeInput
            // 
            this.timeInput.CustomFormat = "hh:mm:ss";
            this.timeInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeInput.Location = new System.Drawing.Point(647, 33);
            this.timeInput.Name = "timeInput";
            this.timeInput.ShowUpDown = true;
            this.timeInput.Size = new System.Drawing.Size(98, 23);
            this.timeInput.TabIndex = 5;
            // 
            // prodListView
            // 
            this.prodListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodID,
            this.prodName,
            this.unit,
            this.unitPrice,
            this.quantity,
            this.discount,
            this.amount});
            this.prodListView.FullRowSelect = true;
            this.prodListView.Location = new System.Drawing.Point(23, 92);
            this.prodListView.MultiSelect = false;
            this.prodListView.Name = "prodListView";
            this.prodListView.Size = new System.Drawing.Size(515, 259);
            this.prodListView.TabIndex = 6;
            this.prodListView.UseCompatibleStateImageBehavior = false;
            this.prodListView.View = System.Windows.Forms.View.Details;
            this.prodListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prodListView_MouseClick);
            // 
            // prodID
            // 
            this.prodID.Text = "Product ID";
            this.prodID.Width = 75;
            // 
            // prodName
            // 
            this.prodName.Text = "Product Name";
            this.prodName.Width = 100;
            // 
            // unit
            // 
            this.unit.Text = "Unit";
            this.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Unit Price";
            this.unitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitPrice.Width = 75;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discount
            // 
            this.discount.Text = "Discount";
            this.discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 80;
            // 
            // prodComboBox
            // 
            this.prodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.prodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.prodComboBox.FormattingEnabled = true;
            this.prodComboBox.Location = new System.Drawing.Point(18, 35);
            this.prodComboBox.Name = "prodComboBox";
            this.prodComboBox.Size = new System.Drawing.Size(153, 23);
            this.prodComboBox.TabIndex = 7;
            this.prodComboBox.SelectedValueChanged += new System.EventHandler(this.prodComboBox_SelectedValueChanged);
            // 
            // addProdButton
            // 
            this.addProdButton.Location = new System.Drawing.Point(64, 188);
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.Size = new System.Drawing.Size(89, 23);
            this.addProdButton.TabIndex = 8;
            this.addProdButton.Text = "Add";
            this.addProdButton.UseVisualStyleBackColor = true;
            this.addProdButton.Click += new System.EventHandler(this.addProdButton_Click);
            // 
            // createInvButton
            // 
            this.createInvButton.Location = new System.Drawing.Point(605, 339);
            this.createInvButton.Name = "createInvButton";
            this.createInvButton.Size = new System.Drawing.Size(116, 33);
            this.createInvButton.TabIndex = 9;
            this.createInvButton.Text = "Create invoice";
            this.createInvButton.UseVisualStyleBackColor = true;
            this.createInvButton.Click += new System.EventHandler(this.createInvButton_Click);
            // 
            // quantityInputBox
            // 
            this.quantityInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityInputBox.ForeColor = System.Drawing.Color.Silver;
            this.quantityInputBox.Location = new System.Drawing.Point(18, 73);
            this.quantityInputBox.Name = "quantityInputBox";
            this.quantityInputBox.Size = new System.Drawing.Size(95, 23);
            this.quantityInputBox.TabIndex = 10;
            this.quantityInputBox.Text = "Enter quantity ...";
            // 
            // unitPriceInputBox
            // 
            this.unitPriceInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitPriceInputBox.ForeColor = System.Drawing.Color.Silver;
            this.unitPriceInputBox.Location = new System.Drawing.Point(18, 111);
            this.unitPriceInputBox.Name = "unitPriceInputBox";
            this.unitPriceInputBox.Size = new System.Drawing.Size(135, 23);
            this.unitPriceInputBox.TabIndex = 11;
            this.unitPriceInputBox.Text = "Enter unit price ...";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(23, 349);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(436, 23);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalAmount
            // 
            this.totalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAmount.Location = new System.Drawing.Point(456, 349);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalAmount.Size = new System.Drawing.Size(82, 23);
            this.totalAmount.TabIndex = 13;
            this.totalAmount.Text = "0";
            this.totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountInputBox
            // 
            this.discountInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountInputBox.ForeColor = System.Drawing.Color.Silver;
            this.discountInputBox.Location = new System.Drawing.Point(18, 149);
            this.discountInputBox.Name = "discountInputBox";
            this.discountInputBox.Size = new System.Drawing.Size(135, 23);
            this.discountInputBox.TabIndex = 14;
            this.discountInputBox.Text = "Enter discount (%) ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockLabel);
            this.groupBox1.Controls.Add(this.prodComboBox);
            this.groupBox1.Controls.Add(this.discountInputBox);
            this.groupBox1.Controls.Add(this.addProdButton);
            this.groupBox1.Controls.Add(this.quantityInputBox);
            this.groupBox1.Controls.Add(this.unitPriceInputBox);
            this.groupBox1.Location = new System.Drawing.Point(558, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 230);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add product";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(119, 76);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(39, 15);
            this.stockLabel.TabIndex = 15;
            this.stockLabel.Text = "Stock:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // formCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.createInvButton);
            this.Controls.Add(this.prodListView);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.newInvLabel);
            this.Name = "formCreateInvoice";
            this.Text = "Create Invoice";
            this.Load += new System.EventHandler(this.formCreateInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label newInvLabel;
        private DateTimePicker dateInput;
        private Label DateTimeLabel;
        private DateTimePicker timeInput;
        private ListView prodListView;
        private ComboBox prodComboBox;
        private Button addProdButton;
        private Button createInvButton;
        private ColumnHeader prodID;
        private ColumnHeader prodName;
        private ColumnHeader unit;
        private ColumnHeader unitPrice;
        private ColumnHeader quantity;
        private TextBox quantityInputBox;
        private TextBox unitPriceInputBox;
        private Label totalLabel;
        private Label totalAmount;
        private TextBox discountInputBox;
        private ColumnHeader discount;
        private ColumnHeader amount;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label stockLabel;
    }
}