namespace StoreManagementSystem
{
    partial class Form1
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
            this.textBoxShopId = new System.Windows.Forms.TextBox();
            this.textBoxShopName = new System.Windows.Forms.TextBox();
            this.textBoxShopAddress = new System.Windows.Forms.TextBox();
            this.ButtonAddShop = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelShopID_newProduct = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.comboBoxShopId = new System.Windows.Forms.ComboBox();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.labelShopIdShow = new System.Windows.Forms.Label();
            this.comboBoxShopIdShow = new System.Windows.Forms.ComboBox();
            this.ButtonShowProducts = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
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
            // textBoxShopId
            // 
            this.textBoxShopId.Location = new System.Drawing.Point(87, 6);
            this.textBoxShopId.Name = "textBoxShopId";
            this.textBoxShopId.Size = new System.Drawing.Size(100, 20);
            this.textBoxShopId.TabIndex = 3;
            // 
            // textBoxShopName
            // 
            this.textBoxShopName.Location = new System.Drawing.Point(87, 30);
            this.textBoxShopName.Name = "textBoxShopName";
            this.textBoxShopName.Size = new System.Drawing.Size(100, 20);
            this.textBoxShopName.TabIndex = 4;
            // 
            // textBoxShopAddress
            // 
            this.textBoxShopAddress.Location = new System.Drawing.Point(87, 55);
            this.textBoxShopAddress.Name = "textBoxShopAddress";
            this.textBoxShopAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxShopAddress.TabIndex = 5;
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
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(87, 286);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(87, 262);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 10;
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
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(87, 236);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 18;
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(87, 211);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductId.TabIndex = 17;
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
            // comboBoxShopId
            // 
            this.comboBoxShopId.Location = new System.Drawing.Point(87, 311);
            this.comboBoxShopId.Name = "comboBoxShopId";
            this.comboBoxShopId.Size = new System.Drawing.Size(100, 21);
            this.comboBoxShopId.TabIndex = 0;
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
            // comboBoxShopIdShow
            // 
            this.comboBoxShopIdShow.Location = new System.Drawing.Point(441, 11);
            this.comboBoxShopIdShow.Name = "comboBoxShopIdShow";
            this.comboBoxShopIdShow.Size = new System.Drawing.Size(100, 21);
            this.comboBoxShopIdShow.TabIndex = 21;
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
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(389, 67);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(362, 303);
            this.listBoxProducts.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.ButtonShowProducts);
            this.Controls.Add(this.comboBoxShopIdShow);
            this.Controls.Add(this.labelShopIdShow);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.comboBoxShopId);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelShopID_newProduct);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.ButtonAddShop);
            this.Controls.Add(this.textBoxShopAddress);
            this.Controls.Add(this.textBoxShopName);
            this.Controls.Add(this.textBoxShopId);
            this.Controls.Add(this.labelShopAddress);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.labelShopID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShopID;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Label labelShopAddress;
        private System.Windows.Forms.TextBox textBoxShopId;
        private System.Windows.Forms.TextBox textBoxShopName;
        private System.Windows.Forms.TextBox textBoxShopAddress;
        private System.Windows.Forms.Button ButtonAddShop;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelShopID_newProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.ComboBox comboBoxShopId;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Label labelShopIdShow;
        private System.Windows.Forms.ComboBox comboBoxShopIdShow;
        private System.Windows.Forms.Button ButtonShowProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}

