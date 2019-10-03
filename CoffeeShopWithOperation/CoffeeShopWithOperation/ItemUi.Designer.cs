namespace CoffeeShopWithOperation
{
    partial class ItemUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameItemTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.showItemDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.priceItemTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idItemTextBox = new System.Windows.Forms.TextBox();
            this.showItemButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.searchItemButton = new System.Windows.Forms.Button();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameItemTextBox
            // 
            this.nameItemTextBox.Location = new System.Drawing.Point(186, 53);
            this.nameItemTextBox.Name = "nameItemTextBox";
            this.nameItemTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameItemTextBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(21, 305);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(87, 33);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // showItemDataGridView
            // 
            this.showItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showItemDataGridView.Location = new System.Drawing.Point(21, 151);
            this.showItemDataGridView.Name = "showItemDataGridView";
            this.showItemDataGridView.Size = new System.Drawing.Size(482, 134);
            this.showItemDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // priceItemTextBox
            // 
            this.priceItemTextBox.Location = new System.Drawing.Point(186, 89);
            this.priceItemTextBox.Name = "priceItemTextBox";
            this.priceItemTextBox.Size = new System.Drawing.Size(140, 20);
            this.priceItemTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // idItemTextBox
            // 
            this.idItemTextBox.Location = new System.Drawing.Point(186, 20);
            this.idItemTextBox.Name = "idItemTextBox";
            this.idItemTextBox.Size = new System.Drawing.Size(140, 20);
            this.idItemTextBox.TabIndex = 1;
            // 
            // showItemButton
            // 
            this.showItemButton.Location = new System.Drawing.Point(117, 305);
            this.showItemButton.Name = "showItemButton";
            this.showItemButton.Size = new System.Drawing.Size(87, 33);
            this.showItemButton.TabIndex = 2;
            this.showItemButton.Text = "Show";
            this.showItemButton.UseVisualStyleBackColor = true;
            this.showItemButton.Click += new System.EventHandler(this.showItemButton_Click);
            // 
            // updateItemButton
            // 
            this.updateItemButton.Location = new System.Drawing.Point(210, 305);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.Size = new System.Drawing.Size(87, 33);
            this.updateItemButton.TabIndex = 2;
            this.updateItemButton.Text = "Update";
            this.updateItemButton.UseVisualStyleBackColor = true;
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(311, 305);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(87, 33);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // searchItemButton
            // 
            this.searchItemButton.Location = new System.Drawing.Point(416, 305);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(87, 33);
            this.searchItemButton.TabIndex = 2;
            this.searchItemButton.Text = "Search";
            this.searchItemButton.UseVisualStyleBackColor = true;
            this.searchItemButton.Click += new System.EventHandler(this.searchItemButton_Click);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(142, 124);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(184, 21);
            this.itemComboBox.TabIndex = 4;
            this.itemComboBox.ValueMember = "Id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(CoffeeShopWithOperation.Model.Item);
            // 
            // ItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 354);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.showItemDataGridView);
            this.Controls.Add(this.searchItemButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.updateItemButton);
            this.Controls.Add(this.showItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.idItemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceItemTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameItemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ItemUi";
            this.Text = "ItemUi";
            this.Load += new System.EventHandler(this.ItemUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameItemTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridView showItemDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceItemTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idItemTextBox;
        private System.Windows.Forms.Button showItemButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button searchItemButton;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}