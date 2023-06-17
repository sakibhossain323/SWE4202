
namespace LaundryManagementSystem
{
    partial class FormLaundrySystem
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
            this.LabelOwnerOrderId = new System.Windows.Forms.Label();
            this.LabelDetailOrderId = new System.Windows.Forms.Label();
            this.TextBoxOwnerOrderId = new System.Windows.Forms.TextBox();
            this.ComboBoxOwnerOrderStatus = new System.Windows.Forms.ComboBox();
            this.ButtonSetStatus = new System.Windows.Forms.Button();
            this.LabelOwnerBalance = new System.Windows.Forms.Label();
            this.LabelOwnerCurBalance = new System.Windows.Forms.Label();
            this.LabelCreateUserAddress = new System.Windows.Forms.Label();
            this.ButtonCreateUser = new System.Windows.Forms.Button();
            this.LabelCreateUserName = new System.Windows.Forms.Label();
            this.TextBoxCreateUserId = new System.Windows.Forms.TextBox();
            this.LabelCreateUserId = new System.Windows.Forms.Label();
            this.TextBoxCreateUserAddress = new System.Windows.Forms.TextBox();
            this.TextBoxCreateUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPlaceOrderShirtQt = new System.Windows.Forms.TextBox();
            this.TextBoxPlaceOrderPantQt = new System.Windows.Forms.TextBox();
            this.LabelPant = new System.Windows.Forms.Label();
            this.ButtonPlaceOrder = new System.Windows.Forms.Button();
            this.LabelShirt = new System.Windows.Forms.Label();
            this.TextBoxPlaceOrderUserId = new System.Windows.Forms.TextBox();
            this.LabelPlaceOrderUserId = new System.Windows.Forms.Label();
            this.LabelBedSheet = new System.Windows.Forms.Label();
            this.LabelSuit = new System.Windows.Forms.Label();
            this.TextBoxPlaceOrderSuitQt = new System.Windows.Forms.TextBox();
            this.TextBoxPlaceOrderBedSheetQt = new System.Windows.Forms.TextBox();
            this.ComboBoxShirtTask = new System.Windows.Forms.ComboBox();
            this.ComboBoxPantTask = new System.Windows.Forms.ComboBox();
            this.ComboBoxBedSheetTask = new System.Windows.Forms.ComboBox();
            this.ComboBoxSuitTask = new System.Windows.Forms.ComboBox();
            this.LabelOwnerSetStatus = new System.Windows.Forms.Label();
            this.LabelDetailOrderStatus = new System.Windows.Forms.Label();
            this.LabelDetailAmountCur = new System.Windows.Forms.Label();
            this.LabelDetailOrderAmount = new System.Windows.Forms.Label();
            this.TextBoxDetailOrderId = new System.Windows.Forms.TextBox();
            this.LabelDetailStatusCur = new System.Windows.Forms.Label();
            this.ListBoxOrderDetails = new System.Windows.Forms.ListBox();
            this.ButtonDetailOrderSee = new System.Windows.Forms.Button();
            this.LabelDetailAddress = new System.Windows.Forms.Label();
            this.LabelDetailName = new System.Windows.Forms.Label();
            this.LabelDetailOrdererAddress = new System.Windows.Forms.Label();
            this.LabelDetailOrdererName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelOwnerOrderId
            // 
            this.LabelOwnerOrderId.AutoSize = true;
            this.LabelOwnerOrderId.Location = new System.Drawing.Point(41, 19);
            this.LabelOwnerOrderId.Name = "LabelOwnerOrderId";
            this.LabelOwnerOrderId.Size = new System.Drawing.Size(48, 13);
            this.LabelOwnerOrderId.TabIndex = 0;
            this.LabelOwnerOrderId.Text = "Order Id:";
            // 
            // LabelDetailOrderId
            // 
            this.LabelDetailOrderId.AutoSize = true;
            this.LabelDetailOrderId.Location = new System.Drawing.Point(12, 222);
            this.LabelDetailOrderId.Name = "LabelDetailOrderId";
            this.LabelDetailOrderId.Size = new System.Drawing.Size(48, 13);
            this.LabelDetailOrderId.TabIndex = 1;
            this.LabelDetailOrderId.Text = "Order Id:";
            // 
            // TextBoxOwnerOrderId
            // 
            this.TextBoxOwnerOrderId.Location = new System.Drawing.Point(96, 16);
            this.TextBoxOwnerOrderId.Name = "TextBoxOwnerOrderId";
            this.TextBoxOwnerOrderId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxOwnerOrderId.TabIndex = 2;
            // 
            // ComboBoxOwnerOrderStatus
            // 
            this.ComboBoxOwnerOrderStatus.FormattingEnabled = true;
            this.ComboBoxOwnerOrderStatus.Location = new System.Drawing.Point(96, 42);
            this.ComboBoxOwnerOrderStatus.Name = "ComboBoxOwnerOrderStatus";
            this.ComboBoxOwnerOrderStatus.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxOwnerOrderStatus.TabIndex = 3;
            // 
            // ButtonSetStatus
            // 
            this.ButtonSetStatus.Location = new System.Drawing.Point(96, 69);
            this.ButtonSetStatus.Name = "ButtonSetStatus";
            this.ButtonSetStatus.Size = new System.Drawing.Size(100, 23);
            this.ButtonSetStatus.TabIndex = 5;
            this.ButtonSetStatus.Text = "Set Status";
            this.ButtonSetStatus.UseVisualStyleBackColor = true;
            this.ButtonSetStatus.Click += new System.EventHandler(this.ButtonSetStatus_Click);
            // 
            // LabelOwnerBalance
            // 
            this.LabelOwnerBalance.AutoSize = true;
            this.LabelOwnerBalance.Location = new System.Drawing.Point(12, 104);
            this.LabelOwnerBalance.Name = "LabelOwnerBalance";
            this.LabelOwnerBalance.Size = new System.Drawing.Size(86, 13);
            this.LabelOwnerBalance.TabIndex = 6;
            this.LabelOwnerBalance.Text = "Current Balance:";
            // 
            // LabelOwnerCurBalance
            // 
            this.LabelOwnerCurBalance.AutoSize = true;
            this.LabelOwnerCurBalance.Location = new System.Drawing.Point(93, 104);
            this.LabelOwnerCurBalance.Name = "LabelOwnerCurBalance";
            this.LabelOwnerCurBalance.Size = new System.Drawing.Size(13, 13);
            this.LabelOwnerCurBalance.TabIndex = 7;
            this.LabelOwnerCurBalance.Text = "0";
            // 
            // LabelCreateUserAddress
            // 
            this.LabelCreateUserAddress.AutoSize = true;
            this.LabelCreateUserAddress.Location = new System.Drawing.Point(274, 75);
            this.LabelCreateUserAddress.Name = "LabelCreateUserAddress";
            this.LabelCreateUserAddress.Size = new System.Drawing.Size(48, 13);
            this.LabelCreateUserAddress.TabIndex = 13;
            this.LabelCreateUserAddress.Text = "Address:";
            // 
            // ButtonCreateUser
            // 
            this.ButtonCreateUser.Location = new System.Drawing.Point(333, 98);
            this.ButtonCreateUser.Name = "ButtonCreateUser";
            this.ButtonCreateUser.Size = new System.Drawing.Size(100, 23);
            this.ButtonCreateUser.TabIndex = 12;
            this.ButtonCreateUser.Text = "Create Account";
            this.ButtonCreateUser.UseVisualStyleBackColor = true;
            this.ButtonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // LabelCreateUserName
            // 
            this.LabelCreateUserName.AutoSize = true;
            this.LabelCreateUserName.Location = new System.Drawing.Point(286, 48);
            this.LabelCreateUserName.Name = "LabelCreateUserName";
            this.LabelCreateUserName.Size = new System.Drawing.Size(38, 13);
            this.LabelCreateUserName.TabIndex = 11;
            this.LabelCreateUserName.Text = "Name:";
            // 
            // TextBoxCreateUserId
            // 
            this.TextBoxCreateUserId.Location = new System.Drawing.Point(333, 19);
            this.TextBoxCreateUserId.Name = "TextBoxCreateUserId";
            this.TextBoxCreateUserId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCreateUserId.TabIndex = 9;
            // 
            // LabelCreateUserId
            // 
            this.LabelCreateUserId.AutoSize = true;
            this.LabelCreateUserId.Location = new System.Drawing.Point(278, 22);
            this.LabelCreateUserId.Name = "LabelCreateUserId";
            this.LabelCreateUserId.Size = new System.Drawing.Size(44, 13);
            this.LabelCreateUserId.TabIndex = 8;
            this.LabelCreateUserId.Text = "User Id:";
            // 
            // TextBoxCreateUserAddress
            // 
            this.TextBoxCreateUserAddress.Location = new System.Drawing.Point(333, 72);
            this.TextBoxCreateUserAddress.Name = "TextBoxCreateUserAddress";
            this.TextBoxCreateUserAddress.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCreateUserAddress.TabIndex = 15;
            // 
            // TextBoxCreateUserName
            // 
            this.TextBoxCreateUserName.Location = new System.Drawing.Point(332, 46);
            this.TextBoxCreateUserName.Name = "TextBoxCreateUserName";
            this.TextBoxCreateUserName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCreateUserName.TabIndex = 16;
            // 
            // TextBoxPlaceOrderShirtQt
            // 
            this.TextBoxPlaceOrderShirtQt.Location = new System.Drawing.Point(541, 46);
            this.TextBoxPlaceOrderShirtQt.Name = "TextBoxPlaceOrderShirtQt";
            this.TextBoxPlaceOrderShirtQt.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlaceOrderShirtQt.TabIndex = 23;
            // 
            // TextBoxPlaceOrderPantQt
            // 
            this.TextBoxPlaceOrderPantQt.Location = new System.Drawing.Point(542, 72);
            this.TextBoxPlaceOrderPantQt.Name = "TextBoxPlaceOrderPantQt";
            this.TextBoxPlaceOrderPantQt.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlaceOrderPantQt.TabIndex = 22;
            // 
            // LabelPant
            // 
            this.LabelPant.AutoSize = true;
            this.LabelPant.Location = new System.Drawing.Point(499, 75);
            this.LabelPant.Name = "LabelPant";
            this.LabelPant.Size = new System.Drawing.Size(32, 13);
            this.LabelPant.TabIndex = 21;
            this.LabelPant.Text = "Pant:";
            // 
            // ButtonPlaceOrder
            // 
            this.ButtonPlaceOrder.Location = new System.Drawing.Point(543, 152);
            this.ButtonPlaceOrder.Name = "ButtonPlaceOrder";
            this.ButtonPlaceOrder.Size = new System.Drawing.Size(231, 23);
            this.ButtonPlaceOrder.TabIndex = 20;
            this.ButtonPlaceOrder.Text = "Place Order";
            this.ButtonPlaceOrder.UseVisualStyleBackColor = true;
            this.ButtonPlaceOrder.Click += new System.EventHandler(this.ButtonPlaceOrder_Click);
            // 
            // LabelShirt
            // 
            this.LabelShirt.AutoSize = true;
            this.LabelShirt.Location = new System.Drawing.Point(500, 48);
            this.LabelShirt.Name = "LabelShirt";
            this.LabelShirt.Size = new System.Drawing.Size(31, 13);
            this.LabelShirt.TabIndex = 19;
            this.LabelShirt.Text = "Shirt:";
            // 
            // TextBoxPlaceOrderUserId
            // 
            this.TextBoxPlaceOrderUserId.Location = new System.Drawing.Point(542, 19);
            this.TextBoxPlaceOrderUserId.Name = "TextBoxPlaceOrderUserId";
            this.TextBoxPlaceOrderUserId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlaceOrderUserId.TabIndex = 18;
            // 
            // LabelPlaceOrderUserId
            // 
            this.LabelPlaceOrderUserId.AutoSize = true;
            this.LabelPlaceOrderUserId.Location = new System.Drawing.Point(487, 22);
            this.LabelPlaceOrderUserId.Name = "LabelPlaceOrderUserId";
            this.LabelPlaceOrderUserId.Size = new System.Drawing.Size(44, 13);
            this.LabelPlaceOrderUserId.TabIndex = 17;
            this.LabelPlaceOrderUserId.Text = "User Id:";
            // 
            // LabelBedSheet
            // 
            this.LabelBedSheet.AutoSize = true;
            this.LabelBedSheet.Location = new System.Drawing.Point(475, 130);
            this.LabelBedSheet.Name = "LabelBedSheet";
            this.LabelBedSheet.Size = new System.Drawing.Size(60, 13);
            this.LabelBedSheet.TabIndex = 25;
            this.LabelBedSheet.Text = "Bed Sheet:";
            // 
            // LabelSuit
            // 
            this.LabelSuit.AutoSize = true;
            this.LabelSuit.Location = new System.Drawing.Point(503, 103);
            this.LabelSuit.Name = "LabelSuit";
            this.LabelSuit.Size = new System.Drawing.Size(28, 13);
            this.LabelSuit.TabIndex = 24;
            this.LabelSuit.Text = "Suit:";
            // 
            // TextBoxPlaceOrderSuitQt
            // 
            this.TextBoxPlaceOrderSuitQt.Location = new System.Drawing.Point(542, 100);
            this.TextBoxPlaceOrderSuitQt.Name = "TextBoxPlaceOrderSuitQt";
            this.TextBoxPlaceOrderSuitQt.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlaceOrderSuitQt.TabIndex = 27;
            // 
            // TextBoxPlaceOrderBedSheetQt
            // 
            this.TextBoxPlaceOrderBedSheetQt.Location = new System.Drawing.Point(543, 126);
            this.TextBoxPlaceOrderBedSheetQt.Name = "TextBoxPlaceOrderBedSheetQt";
            this.TextBoxPlaceOrderBedSheetQt.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlaceOrderBedSheetQt.TabIndex = 26;
            // 
            // ComboBoxShirtTask
            // 
            this.ComboBoxShirtTask.FormattingEnabled = true;
            this.ComboBoxShirtTask.Location = new System.Drawing.Point(653, 45);
            this.ComboBoxShirtTask.Name = "ComboBoxShirtTask";
            this.ComboBoxShirtTask.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxShirtTask.TabIndex = 28;
            // 
            // ComboBoxPantTask
            // 
            this.ComboBoxPantTask.FormattingEnabled = true;
            this.ComboBoxPantTask.Location = new System.Drawing.Point(653, 71);
            this.ComboBoxPantTask.Name = "ComboBoxPantTask";
            this.ComboBoxPantTask.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPantTask.TabIndex = 29;
            // 
            // ComboBoxBedSheetTask
            // 
            this.ComboBoxBedSheetTask.FormattingEnabled = true;
            this.ComboBoxBedSheetTask.Location = new System.Drawing.Point(653, 127);
            this.ComboBoxBedSheetTask.Name = "ComboBoxBedSheetTask";
            this.ComboBoxBedSheetTask.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxBedSheetTask.TabIndex = 31;
            // 
            // ComboBoxSuitTask
            // 
            this.ComboBoxSuitTask.FormattingEnabled = true;
            this.ComboBoxSuitTask.Location = new System.Drawing.Point(653, 101);
            this.ComboBoxSuitTask.Name = "ComboBoxSuitTask";
            this.ComboBoxSuitTask.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSuitTask.TabIndex = 30;
            // 
            // LabelOwnerSetStatus
            // 
            this.LabelOwnerSetStatus.AutoSize = true;
            this.LabelOwnerSetStatus.Location = new System.Drawing.Point(49, 45);
            this.LabelOwnerSetStatus.Name = "LabelOwnerSetStatus";
            this.LabelOwnerSetStatus.Size = new System.Drawing.Size(40, 13);
            this.LabelOwnerSetStatus.TabIndex = 4;
            this.LabelOwnerSetStatus.Text = "Status:";
            // 
            // LabelDetailOrderStatus
            // 
            this.LabelDetailOrderStatus.AutoSize = true;
            this.LabelDetailOrderStatus.Location = new System.Drawing.Point(12, 253);
            this.LabelDetailOrderStatus.Name = "LabelDetailOrderStatus";
            this.LabelDetailOrderStatus.Size = new System.Drawing.Size(40, 13);
            this.LabelDetailOrderStatus.TabIndex = 32;
            this.LabelDetailOrderStatus.Text = "Status:";
            // 
            // LabelDetailAmountCur
            // 
            this.LabelDetailAmountCur.AutoSize = true;
            this.LabelDetailAmountCur.Location = new System.Drawing.Point(70, 281);
            this.LabelDetailAmountCur.Name = "LabelDetailAmountCur";
            this.LabelDetailAmountCur.Size = new System.Drawing.Size(28, 13);
            this.LabelDetailAmountCur.TabIndex = 34;
            this.LabelDetailAmountCur.Text = "0.00";
            // 
            // LabelDetailOrderAmount
            // 
            this.LabelDetailOrderAmount.AutoSize = true;
            this.LabelDetailOrderAmount.Location = new System.Drawing.Point(12, 281);
            this.LabelDetailOrderAmount.Name = "LabelDetailOrderAmount";
            this.LabelDetailOrderAmount.Size = new System.Drawing.Size(46, 13);
            this.LabelDetailOrderAmount.TabIndex = 33;
            this.LabelDetailOrderAmount.Text = "Amount:";
            // 
            // TextBoxDetailOrderId
            // 
            this.TextBoxDetailOrderId.Location = new System.Drawing.Point(66, 219);
            this.TextBoxDetailOrderId.Name = "TextBoxDetailOrderId";
            this.TextBoxDetailOrderId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDetailOrderId.TabIndex = 35;
            // 
            // LabelDetailStatusCur
            // 
            this.LabelDetailStatusCur.AutoSize = true;
            this.LabelDetailStatusCur.Location = new System.Drawing.Point(63, 253);
            this.LabelDetailStatusCur.Name = "LabelDetailStatusCur";
            this.LabelDetailStatusCur.Size = new System.Drawing.Size(40, 13);
            this.LabelDetailStatusCur.TabIndex = 36;
            this.LabelDetailStatusCur.Text = "Status:";
            // 
            // ListBoxOrderDetails
            // 
            this.ListBoxOrderDetails.FormattingEnabled = true;
            this.ListBoxOrderDetails.Location = new System.Drawing.Point(185, 219);
            this.ListBoxOrderDetails.Name = "ListBoxOrderDetails";
            this.ListBoxOrderDetails.Size = new System.Drawing.Size(350, 199);
            this.ListBoxOrderDetails.TabIndex = 37;
            // 
            // ButtonDetailOrderSee
            // 
            this.ButtonDetailOrderSee.Location = new System.Drawing.Point(15, 306);
            this.ButtonDetailOrderSee.Name = "ButtonDetailOrderSee";
            this.ButtonDetailOrderSee.Size = new System.Drawing.Size(151, 38);
            this.ButtonDetailOrderSee.TabIndex = 38;
            this.ButtonDetailOrderSee.Text = "See Order Details";
            this.ButtonDetailOrderSee.UseVisualStyleBackColor = true;
            this.ButtonDetailOrderSee.Click += new System.EventHandler(this.ButtonDetailOrderSee_Click);
            // 
            // LabelDetailAddress
            // 
            this.LabelDetailAddress.AutoSize = true;
            this.LabelDetailAddress.Location = new System.Drawing.Point(550, 253);
            this.LabelDetailAddress.Name = "LabelDetailAddress";
            this.LabelDetailAddress.Size = new System.Drawing.Size(48, 13);
            this.LabelDetailAddress.TabIndex = 40;
            this.LabelDetailAddress.Text = "Address:";
            // 
            // LabelDetailName
            // 
            this.LabelDetailName.AutoSize = true;
            this.LabelDetailName.Location = new System.Drawing.Point(560, 226);
            this.LabelDetailName.Name = "LabelDetailName";
            this.LabelDetailName.Size = new System.Drawing.Size(38, 13);
            this.LabelDetailName.TabIndex = 39;
            this.LabelDetailName.Text = "Name:";
            // 
            // LabelDetailOrdererAddress
            // 
            this.LabelDetailOrdererAddress.AutoSize = true;
            this.LabelDetailOrdererAddress.Location = new System.Drawing.Point(604, 253);
            this.LabelDetailOrdererAddress.Name = "LabelDetailOrdererAddress";
            this.LabelDetailOrdererAddress.Size = new System.Drawing.Size(48, 13);
            this.LabelDetailOrdererAddress.TabIndex = 42;
            this.LabelDetailOrdererAddress.Text = "Address:";
            // 
            // LabelDetailOrdererName
            // 
            this.LabelDetailOrdererName.AutoSize = true;
            this.LabelDetailOrdererName.Location = new System.Drawing.Point(603, 226);
            this.LabelDetailOrdererName.Name = "LabelDetailOrdererName";
            this.LabelDetailOrdererName.Size = new System.Drawing.Size(38, 13);
            this.LabelDetailOrdererName.TabIndex = 41;
            this.LabelDetailOrdererName.Text = "Name:";
            // 
            // FormLaundrySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelDetailOrdererAddress);
            this.Controls.Add(this.LabelDetailOrdererName);
            this.Controls.Add(this.LabelDetailAddress);
            this.Controls.Add(this.LabelDetailName);
            this.Controls.Add(this.ButtonDetailOrderSee);
            this.Controls.Add(this.ListBoxOrderDetails);
            this.Controls.Add(this.LabelDetailStatusCur);
            this.Controls.Add(this.TextBoxDetailOrderId);
            this.Controls.Add(this.LabelDetailAmountCur);
            this.Controls.Add(this.LabelDetailOrderAmount);
            this.Controls.Add(this.LabelDetailOrderStatus);
            this.Controls.Add(this.ComboBoxBedSheetTask);
            this.Controls.Add(this.ComboBoxSuitTask);
            this.Controls.Add(this.ComboBoxPantTask);
            this.Controls.Add(this.ComboBoxShirtTask);
            this.Controls.Add(this.TextBoxPlaceOrderSuitQt);
            this.Controls.Add(this.TextBoxPlaceOrderBedSheetQt);
            this.Controls.Add(this.LabelBedSheet);
            this.Controls.Add(this.LabelSuit);
            this.Controls.Add(this.TextBoxPlaceOrderShirtQt);
            this.Controls.Add(this.TextBoxPlaceOrderPantQt);
            this.Controls.Add(this.LabelPant);
            this.Controls.Add(this.ButtonPlaceOrder);
            this.Controls.Add(this.LabelShirt);
            this.Controls.Add(this.TextBoxPlaceOrderUserId);
            this.Controls.Add(this.LabelPlaceOrderUserId);
            this.Controls.Add(this.TextBoxCreateUserName);
            this.Controls.Add(this.TextBoxCreateUserAddress);
            this.Controls.Add(this.LabelCreateUserAddress);
            this.Controls.Add(this.ButtonCreateUser);
            this.Controls.Add(this.LabelCreateUserName);
            this.Controls.Add(this.TextBoxCreateUserId);
            this.Controls.Add(this.LabelCreateUserId);
            this.Controls.Add(this.LabelOwnerCurBalance);
            this.Controls.Add(this.LabelOwnerBalance);
            this.Controls.Add(this.ButtonSetStatus);
            this.Controls.Add(this.LabelOwnerSetStatus);
            this.Controls.Add(this.ComboBoxOwnerOrderStatus);
            this.Controls.Add(this.TextBoxOwnerOrderId);
            this.Controls.Add(this.LabelDetailOrderId);
            this.Controls.Add(this.LabelOwnerOrderId);
            this.Name = "FormLaundrySystem";
            this.Text = "Laundry Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOwnerOrderId;
        private System.Windows.Forms.Label LabelDetailOrderId;
        private System.Windows.Forms.TextBox TextBoxOwnerOrderId;
        private System.Windows.Forms.ComboBox ComboBoxOwnerOrderStatus;
        private System.Windows.Forms.Button ButtonSetStatus;
        private System.Windows.Forms.Label LabelOwnerBalance;
        private System.Windows.Forms.Label LabelOwnerCurBalance;
        private System.Windows.Forms.Label LabelCreateUserAddress;
        private System.Windows.Forms.Button ButtonCreateUser;
        private System.Windows.Forms.Label LabelCreateUserName;
        private System.Windows.Forms.TextBox TextBoxCreateUserId;
        private System.Windows.Forms.Label LabelCreateUserId;
        private System.Windows.Forms.TextBox TextBoxCreateUserAddress;
        private System.Windows.Forms.TextBox TextBoxCreateUserName;
        private System.Windows.Forms.TextBox TextBoxPlaceOrderShirtQt;
        private System.Windows.Forms.TextBox TextBoxPlaceOrderPantQt;
        private System.Windows.Forms.Label LabelPant;
        private System.Windows.Forms.Button ButtonPlaceOrder;
        private System.Windows.Forms.Label LabelShirt;
        private System.Windows.Forms.TextBox TextBoxPlaceOrderUserId;
        private System.Windows.Forms.Label LabelPlaceOrderUserId;
        private System.Windows.Forms.Label LabelBedSheet;
        private System.Windows.Forms.Label LabelSuit;
        private System.Windows.Forms.TextBox TextBoxPlaceOrderSuitQt;
        private System.Windows.Forms.TextBox TextBoxPlaceOrderBedSheetQt;
        private System.Windows.Forms.ComboBox ComboBoxShirtTask;
        private System.Windows.Forms.ComboBox ComboBoxPantTask;
        private System.Windows.Forms.ComboBox ComboBoxBedSheetTask;
        private System.Windows.Forms.ComboBox ComboBoxSuitTask;
        private System.Windows.Forms.Label LabelOwnerSetStatus;
        private System.Windows.Forms.Label LabelDetailOrderStatus;
        private System.Windows.Forms.Label LabelDetailAmountCur;
        private System.Windows.Forms.Label LabelDetailOrderAmount;
        private System.Windows.Forms.TextBox TextBoxDetailOrderId;
        private System.Windows.Forms.Label LabelDetailStatusCur;
        private System.Windows.Forms.ListBox ListBoxOrderDetails;
        private System.Windows.Forms.Button ButtonDetailOrderSee;
        private System.Windows.Forms.Label LabelDetailAddress;
        private System.Windows.Forms.Label LabelDetailName;
        private System.Windows.Forms.Label LabelDetailOrdererAddress;
        private System.Windows.Forms.Label LabelDetailOrdererName;
    }
}

