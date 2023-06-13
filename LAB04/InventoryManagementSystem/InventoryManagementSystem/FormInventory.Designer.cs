namespace InventoryManagementSystem
{
    partial class FormInventory
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
            this.labelShopID = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.labelShopAddress = new System.Windows.Forms.Label();
            this.TextBoxShopId = new System.Windows.Forms.TextBox();
            this.TextBoxShopName = new System.Windows.Forms.TextBox();
            this.TextBoxShopAddress = new System.Windows.Forms.TextBox();
            this.ButtonAddShop = new System.Windows.Forms.Button();
            this.TextBoxQuantity = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.labelShopID_newProduct = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.TextBoxProductName = new System.Windows.Forms.TextBox();
            this.TextBoxProductId = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.ComboBoxShopIdAdd = new System.Windows.Forms.ComboBox();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.labelShopIdShow = new System.Windows.Forms.Label();
            this.ComboBoxShopIdView = new System.Windows.Forms.ComboBox();
            this.ButtonShowProducts = new System.Windows.Forms.Button();
            this.ListBoxInventory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelShopID
            // 
            this.labelShopID.AutoSize = true;
            this.labelShopID.Location = new System.Drawing.Point(29, 9);
            this.labelShopID.Name = "labelShopID";
            this.labelShopID.Size = new System.Drawing.Size(49, 13);
            this.labelShopID.TabIndex = 0;
            this.labelShopID.Text = "Shop ID:";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Location = new System.Drawing.Point(12, 33);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(66, 13);
            this.labelShopName.TabIndex = 1;
            this.labelShopName.Text = "Shop Name:";
            // 
            // labelShopAddress
            // 
            this.labelShopAddress.AutoSize = true;
            this.labelShopAddress.Location = new System.Drawing.Point(8, 58);
            this.labelShopAddress.Name = "labelShopAddress";
            this.labelShopAddress.Size = new System.Drawing.Size(70, 13);
            this.labelShopAddress.TabIndex = 2;
            this.labelShopAddress.Text = "Shop Adress:";
            // 
            // TextBoxShopId
            // 
            this.TextBoxShopId.Location = new System.Drawing.Point(87, 6);
            this.TextBoxShopId.Name = "TextBoxShopId";
            this.TextBoxShopId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxShopId.TabIndex = 3;
            // 
            // TextBoxShopName
            // 
            this.TextBoxShopName.Location = new System.Drawing.Point(87, 30);
            this.TextBoxShopName.Name = "TextBoxShopName";
            this.TextBoxShopName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxShopName.TabIndex = 4;
            // 
            // TextBoxShopAddress
            // 
            this.TextBoxShopAddress.Location = new System.Drawing.Point(87, 55);
            this.TextBoxShopAddress.Name = "TextBoxShopAddress";
            this.TextBoxShopAddress.Size = new System.Drawing.Size(100, 20);
            this.TextBoxShopAddress.TabIndex = 5;
            // 
            // ButtonAddShop
            // 
            this.ButtonAddShop.Location = new System.Drawing.Point(87, 91);
            this.ButtonAddShop.Name = "ButtonAddShop";
            this.ButtonAddShop.Size = new System.Drawing.Size(100, 23);
            this.ButtonAddShop.TabIndex = 6;
            this.ButtonAddShop.Text = "Add Shop";
            this.ButtonAddShop.UseVisualStyleBackColor = true;
            this.ButtonAddShop.Click += new System.EventHandler(this.ButtonAddShop_Click);
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.Location = new System.Drawing.Point(87, 286);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.TextBoxQuantity.TabIndex = 11;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(87, 262);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPrice.TabIndex = 10;
            // 
            // labelShopID_newProduct
            // 
            this.labelShopID_newProduct.AutoSize = true;
            this.labelShopID_newProduct.Location = new System.Drawing.Point(29, 314);
            this.labelShopID_newProduct.Name = "labelShopID_newProduct";
            this.labelShopID_newProduct.Size = new System.Drawing.Size(49, 13);
            this.labelShopID_newProduct.TabIndex = 9;
            this.labelShopID_newProduct.Text = "Shop ID:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(29, 289);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(44, 265);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            // 
            // TextBoxProductName
            // 
            this.TextBoxProductName.Location = new System.Drawing.Point(87, 236);
            this.TextBoxProductName.Name = "TextBoxProductName";
            this.TextBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxProductName.TabIndex = 18;
            // 
            // TextBoxProductId
            // 
            this.TextBoxProductId.Location = new System.Drawing.Point(87, 211);
            this.TextBoxProductId.Name = "TextBoxProductId";
            this.TextBoxProductId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxProductId.TabIndex = 17;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(0, 239);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 13);
            this.labelProductName.TabIndex = 15;
            this.labelProductName.Text = "Product Name:";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(17, 214);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(61, 13);
            this.labelProductId.TabIndex = 14;
            this.labelProductId.Text = "Product ID:";
            // 
            // ComboBoxShopIdAdd
            // 
            this.ComboBoxShopIdAdd.Location = new System.Drawing.Point(87, 311);
            this.ComboBoxShopIdAdd.Name = "ComboBoxShopIdAdd";
            this.ComboBoxShopIdAdd.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxShopIdAdd.TabIndex = 0;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(87, 347);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(100, 23);
            this.ButtonAddProduct.TabIndex = 19;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // labelShopIdShow
            // 
            this.labelShopIdShow.AutoSize = true;
            this.labelShopIdShow.Location = new System.Drawing.Point(386, 14);
            this.labelShopIdShow.Name = "labelShopIdShow";
            this.labelShopIdShow.Size = new System.Drawing.Size(49, 13);
            this.labelShopIdShow.TabIndex = 20;
            this.labelShopIdShow.Text = "Shop ID:";
            // 
            // ComboBoxShopIdView
            // 
            this.ComboBoxShopIdView.Location = new System.Drawing.Point(441, 11);
            this.ComboBoxShopIdView.Name = "ComboBoxShopIdView";
            this.ComboBoxShopIdView.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxShopIdView.TabIndex = 21;
            // 
            // ButtonShowProducts
            // 
            this.ButtonShowProducts.Location = new System.Drawing.Point(561, 9);
            this.ButtonShowProducts.Name = "ButtonShowProducts";
            this.ButtonShowProducts.Size = new System.Drawing.Size(99, 23);
            this.ButtonShowProducts.TabIndex = 22;
            this.ButtonShowProducts.Text = "Show Product";
            this.ButtonShowProducts.UseVisualStyleBackColor = true;
            this.ButtonShowProducts.Click += new System.EventHandler(this.ButtonShowProducts_Click);
            // 
            // ListBoxInventory
            // 
            this.ListBoxInventory.FormattingEnabled = true;
            this.ListBoxInventory.Location = new System.Drawing.Point(389, 67);
            this.ListBoxInventory.Name = "ListBoxInventory";
            this.ListBoxInventory.Size = new System.Drawing.Size(362, 303);
            this.ListBoxInventory.TabIndex = 23;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxInventory);
            this.Controls.Add(this.ButtonShowProducts);
            this.Controls.Add(this.ComboBoxShopIdView);
            this.Controls.Add(this.labelShopIdShow);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.ComboBoxShopIdAdd);
            this.Controls.Add(this.TextBoxProductName);
            this.Controls.Add(this.TextBoxProductId);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.TextBoxQuantity);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.labelShopID_newProduct);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.ButtonAddShop);
            this.Controls.Add(this.TextBoxShopAddress);
            this.Controls.Add(this.TextBoxShopName);
            this.Controls.Add(this.TextBoxShopId);
            this.Controls.Add(this.labelShopAddress);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.labelShopID);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShopID;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Label labelShopAddress;
        private System.Windows.Forms.TextBox TextBoxShopId;
        private System.Windows.Forms.TextBox TextBoxShopName;
        private System.Windows.Forms.TextBox TextBoxShopAddress;
        private System.Windows.Forms.Button ButtonAddShop;
        private System.Windows.Forms.TextBox TextBoxQuantity;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label labelShopID_newProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox TextBoxProductName;
        private System.Windows.Forms.TextBox TextBoxProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.ComboBox ComboBoxShopIdAdd;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Label labelShopIdShow;
        private System.Windows.Forms.ComboBox ComboBoxShopIdView;
        private System.Windows.Forms.Button ButtonShowProducts;
        private System.Windows.Forms.ListBox ListBoxInventory;
    }
}

