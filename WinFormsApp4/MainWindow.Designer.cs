namespace WinFormsApp4
{
    partial class MainWindow
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
            ShopsListBox = new ListBox();
            ProductsListBox = new ListBox();
            CreateShopButton = new Button();
            NameShopTextBox = new TextBox();
            NameProductTextBox = new TextBox();
            CreateProductButton = new Button();
            RemoveProductButton = new Button();
            RemoveShopButton = new Button();
            SuspendLayout();
            // 
            // ShopsListBox
            // 
            ShopsListBox.FormattingEnabled = true;
            ShopsListBox.ItemHeight = 20;
            ShopsListBox.Location = new Point(30, 16);
            ShopsListBox.Margin = new Padding(3, 4, 3, 4);
            ShopsListBox.Name = "ShopsListBox";
            ShopsListBox.Size = new Size(189, 484);
            ShopsListBox.TabIndex = 0;
            ShopsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 20;
            ProductsListBox.Location = new Point(334, 16);
            ProductsListBox.Margin = new Padding(3, 4, 3, 4);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(189, 484);
            ProductsListBox.TabIndex = 1;
            ProductsListBox.SelectedIndexChanged += Products_SelectedIndexChanged;
            // 
            // CreateShopButton
            // 
            CreateShopButton.Location = new Point(39, 536);
            CreateShopButton.Name = "CreateShopButton";
            CreateShopButton.Size = new Size(180, 52);
            CreateShopButton.TabIndex = 2;
            CreateShopButton.Text = "Add Shop";
            CreateShopButton.UseVisualStyleBackColor = true;
            CreateShopButton.Click += CreateShopButton_Click;
            // 
            // NameShopTextBox
            // 
            NameShopTextBox.Location = new Point(5, 503);
            NameShopTextBox.Name = "NameShopTextBox";
            NameShopTextBox.Size = new Size(245, 27);
            NameShopTextBox.TabIndex = 3;
            // 
            // NameProductTextBox
            // 
            NameProductTextBox.Location = new Point(309, 503);
            NameProductTextBox.Name = "NameProductTextBox";
            NameProductTextBox.Size = new Size(245, 27);
            NameProductTextBox.TabIndex = 5;
            // 
            // CreateProductButton
            // 
            CreateProductButton.Location = new Point(343, 536);
            CreateProductButton.Name = "CreateProductButton";
            CreateProductButton.Size = new Size(180, 52);
            CreateProductButton.TabIndex = 4;
            CreateProductButton.Text = "Add Product";
            CreateProductButton.UseVisualStyleBackColor = true;
            CreateProductButton.Click += CreateProductButton_Click;
            // 
            // RemoveProductButton
            // 
            RemoveProductButton.Location = new Point(529, 16);
            RemoveProductButton.Name = "RemoveProductButton";
            RemoveProductButton.Size = new Size(103, 43);
            RemoveProductButton.TabIndex = 6;
            RemoveProductButton.Text = "Remove";
            RemoveProductButton.UseVisualStyleBackColor = true;
            RemoveProductButton.Click += RemoveProductButton_Click;
            // 
            // RemoveShopButton
            // 
            RemoveShopButton.Location = new Point(225, 16);
            RemoveShopButton.Name = "RemoveShopButton";
            RemoveShopButton.Size = new Size(103, 43);
            RemoveShopButton.TabIndex = 7;
            RemoveShopButton.Text = "Remove";
            RemoveShopButton.UseVisualStyleBackColor = true;
            RemoveShopButton.Click += RemoveShopButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 605);
            Controls.Add(RemoveShopButton);
            Controls.Add(RemoveProductButton);
            Controls.Add(NameProductTextBox);
            Controls.Add(CreateProductButton);
            Controls.Add(NameShopTextBox);
            Controls.Add(CreateShopButton);
            Controls.Add(ProductsListBox);
            Controls.Add(ShopsListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ShopsListBox;
        private ListBox ProductsListBox;
        private Button CreateShopButton;
        private TextBox NameShopTextBox;
        private TextBox NameProductTextBox;
        private Button CreateProductButton;
        private Button RemoveProductButton;
        private Button RemoveShopButton;
    }
}