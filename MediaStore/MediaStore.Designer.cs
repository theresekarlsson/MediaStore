namespace MediaStore
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Checkout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCheckout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCheckoutInstructions = new System.Windows.Forms.Panel();
            this.lblTxtBoxChangeAmountSC = new System.Windows.Forms.Label();
            this.btnMinusOne = new System.Windows.Forms.Button();
            this.lblShopInstructions1 = new System.Windows.Forms.Label();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteAllFromCart = new System.Windows.Forms.Button();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.btnDeleteFromCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCheckout = new System.Windows.Forms.DataGridView();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductsInInventory = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInvProductsInInventory = new System.Windows.Forms.Label();
            this.panelAddProductDeliveryToInventory = new System.Windows.Forms.Panel();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.lblTxtboxProductType2 = new System.Windows.Forms.Label();
            this.txtboxProductType2 = new System.Windows.Forms.TextBox();
            this.lblTxtboxProductAmount = new System.Windows.Forms.Label();
            this.txtboxProductAmount = new System.Windows.Forms.TextBox();
            this.btnAddToProduct = new System.Windows.Forms.Button();
            this.lblAddNewProductDeliveryToInventory = new System.Windows.Forms.Label();
            this.lblAddNewProductDeliveryToInventoryInstr = new System.Windows.Forms.Label();
            this.lblTxtboxProductName2 = new System.Windows.Forms.Label();
            this.txtboxProductName2 = new System.Windows.Forms.TextBox();
            this.txtboxProductID2 = new System.Windows.Forms.TextBox();
            this.lblTxtboxProductID2 = new System.Windows.Forms.Label();
            this.panelAddNewProduct = new System.Windows.Forms.Panel();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.cboboxProductType1 = new System.Windows.Forms.ComboBox();
            this.lblTxtboxProductType1 = new System.Windows.Forms.Label();
            this.lblTxtboxProductPrice = new System.Windows.Forms.Label();
            this.txtboxProductPrice = new System.Windows.Forms.TextBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.lblAddNewProductToInventory = new System.Windows.Forms.Label();
            this.lblAddNewProductToInventoryInstr = new System.Windows.Forms.Label();
            this.lblTxtboxProductName1 = new System.Windows.Forms.Label();
            this.txtboxProductName1 = new System.Windows.Forms.TextBox();
            this.txtboxProductID1 = new System.Windows.Forms.TextBox();
            this.lblTxtboxProductID1 = new System.Windows.Forms.Label();
            this.panelDeleteProductFromInventory = new System.Windows.Forms.Panel();
            this.lblDeleteProduct = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblDeleteProductFromInventory = new System.Windows.Forms.Label();
            this.lblDeleteProductFromInventoryInstr = new System.Windows.Forms.Label();
            this.txtboxDeleteProduct = new System.Windows.Forms.TextBox();
            this.lblTxtboxDeleteProduct = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.myPLbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofdSomeKindOfInputFailure = new System.Windows.Forms.OpenFileDialog();
            this.mySLbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.Checkout.SuspendLayout();
            this.tableLayoutPanelCheckout.SuspendLayout();
            this.pnlCheckoutInstructions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).BeginInit();
            this.Inventory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAddProductDeliveryToInventory.SuspendLayout();
            this.panelAddNewProduct.SuspendLayout();
            this.panelDeleteProductFromInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPLbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySLbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.Checkout);
            this.Tabs.Controls.Add(this.Inventory);
            this.Tabs.Location = new System.Drawing.Point(1, 1);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(857, 571);
            this.Tabs.TabIndex = 0;
            // 
            // Checkout
            // 
            this.Checkout.Controls.Add(this.tableLayoutPanelCheckout);
            this.Checkout.Controls.Add(this.label6);
            this.Checkout.Controls.Add(this.lblProductsInInventory);
            this.Checkout.Location = new System.Drawing.Point(4, 22);
            this.Checkout.Name = "Checkout";
            this.Checkout.Padding = new System.Windows.Forms.Padding(3);
            this.Checkout.Size = new System.Drawing.Size(849, 545);
            this.Checkout.TabIndex = 1;
            this.Checkout.Text = "Kassa";
            this.Checkout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCheckout
            // 
            this.tableLayoutPanelCheckout.ColumnCount = 2;
            this.tableLayoutPanelCheckout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCheckout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCheckout.Controls.Add(this.pnlCheckoutInstructions, 1, 1);
            this.tableLayoutPanelCheckout.Controls.Add(this.panel2, 1, 4);
            this.tableLayoutPanelCheckout.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanelCheckout.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelCheckout.Controls.Add(this.dgvCheckout, 0, 1);
            this.tableLayoutPanelCheckout.Controls.Add(this.lblShoppingCart, 1, 2);
            this.tableLayoutPanelCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCheckout.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCheckout.Name = "tableLayoutPanelCheckout";
            this.tableLayoutPanelCheckout.RowCount = 4;
            this.tableLayoutPanelCheckout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelCheckout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelCheckout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCheckout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelCheckout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelCheckout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCheckout.Size = new System.Drawing.Size(843, 539);
            this.tableLayoutPanelCheckout.TabIndex = 14;
            // 
            // pnlCheckoutInstructions
            // 
            this.pnlCheckoutInstructions.Controls.Add(this.lblTxtBoxChangeAmountSC);
            this.pnlCheckoutInstructions.Controls.Add(this.btnMinusOne);
            this.pnlCheckoutInstructions.Controls.Add(this.lblShopInstructions1);
            this.pnlCheckoutInstructions.Controls.Add(this.btnPlusOne);
            this.pnlCheckoutInstructions.Controls.Add(this.btnAddToCart);
            this.pnlCheckoutInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheckoutInstructions.Location = new System.Drawing.Point(424, 18);
            this.pnlCheckoutInstructions.Name = "pnlCheckoutInstructions";
            this.pnlCheckoutInstructions.Size = new System.Drawing.Size(416, 145);
            this.pnlCheckoutInstructions.TabIndex = 1;
            // 
            // lblTxtBoxChangeAmountSC
            // 
            this.lblTxtBoxChangeAmountSC.AutoSize = true;
            this.lblTxtBoxChangeAmountSC.Location = new System.Drawing.Point(329, 83);
            this.lblTxtBoxChangeAmountSC.Name = "lblTxtBoxChangeAmountSC";
            this.lblTxtBoxChangeAmountSC.Size = new System.Drawing.Size(79, 13);
            this.lblTxtBoxChangeAmountSC.TabIndex = 19;
            this.lblTxtBoxChangeAmountSC.Text = "Ändra antal här";
            // 
            // btnMinusOne
            // 
            this.btnMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusOne.Location = new System.Drawing.Point(321, 99);
            this.btnMinusOne.Name = "btnMinusOne";
            this.btnMinusOne.Size = new System.Drawing.Size(43, 43);
            this.btnMinusOne.TabIndex = 1;
            this.btnMinusOne.Text = "-";
            this.btnMinusOne.UseVisualStyleBackColor = true;
            this.btnMinusOne.Click += new System.EventHandler(this.btnMinusOne_Click);
            // 
            // lblShopInstructions1
            // 
            this.lblShopInstructions1.AutoSize = true;
            this.lblShopInstructions1.Location = new System.Drawing.Point(5, 6);
            this.lblShopInstructions1.Name = "lblShopInstructions1";
            this.lblShopInstructions1.Size = new System.Drawing.Size(315, 78);
            this.lblShopInstructions1.TabIndex = 8;
            this.lblShopInstructions1.Text = resources.GetString("lblShopInstructions1.Text");
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusOne.Location = new System.Drawing.Point(370, 99);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(43, 43);
            this.btnPlusOne.TabIndex = 2;
            this.btnPlusOne.Text = "+";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(8, 99);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 43);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "Lägg till i varukorgen";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteAllFromCart);
            this.panel2.Controls.Add(this.btnConfirmPurchase);
            this.panel2.Controls.Add(this.btnDeleteFromCart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(424, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 45);
            this.panel2.TabIndex = 3;
            // 
            // btnDeleteAllFromCart
            // 
            this.btnDeleteAllFromCart.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAllFromCart.Location = new System.Drawing.Point(86, 0);
            this.btnDeleteAllFromCart.Name = "btnDeleteAllFromCart";
            this.btnDeleteAllFromCart.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAllFromCart.TabIndex = 1;
            this.btnDeleteAllFromCart.Text = "Ta bort alla";
            this.btnDeleteAllFromCart.UseVisualStyleBackColor = false;
            this.btnDeleteAllFromCart.Click += new System.EventHandler(this.btnDeleteAllFromCart_Click);
            // 
            // btnConfirmPurchase
            // 
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmPurchase.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPurchase.Location = new System.Drawing.Point(323, 0);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(93, 45);
            this.btnConfirmPurchase.TabIndex = 2;
            this.btnConfirmPurchase.Text = "GENOMFÖR KÖP";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            this.btnConfirmPurchase.Click += new System.EventHandler(this.btnConfirmPurchase_Click);
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFromCart.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFromCart.TabIndex = 0;
            this.btnDeleteFromCart.Text = "Ta bort en";
            this.btnDeleteFromCart.UseVisualStyleBackColor = false;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.btnDeleteFromCart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShoppingCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(424, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 296);
            this.panel1.TabIndex = 4;
            // 
            // dgvShoppingCart
            // 
            this.dgvShoppingCart.AllowUserToAddRows = false;
            this.dgvShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShoppingCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShoppingCart.Location = new System.Drawing.Point(0, 0);
            this.dgvShoppingCart.Name = "dgvShoppingCart";
            this.dgvShoppingCart.ReadOnly = true;
            this.dgvShoppingCart.RowHeadersVisible = false;
            this.dgvShoppingCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShoppingCart.Size = new System.Drawing.Size(416, 296);
            this.dgvShoppingCart.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produkter i lager:";
            // 
            // dgvCheckout
            // 
            this.dgvCheckout.AllowUserToAddRows = false;
            this.dgvCheckout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckout.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckout.Location = new System.Drawing.Point(3, 18);
            this.dgvCheckout.Name = "dgvCheckout";
            this.dgvCheckout.ReadOnly = true;
            this.dgvCheckout.RowHeadersVisible = false;
            this.tableLayoutPanelCheckout.SetRowSpan(this.dgvCheckout, 4);
            this.dgvCheckout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckout.Size = new System.Drawing.Size(415, 518);
            this.dgvCheckout.TabIndex = 10;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(424, 170);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(416, 16);
            this.lblShoppingCart.TabIndex = 7;
            this.lblShoppingCart.Text = "Varukorg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // lblProductsInInventory
            // 
            this.lblProductsInInventory.AutoSize = true;
            this.lblProductsInInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsInInventory.Location = new System.Drawing.Point(4, 8);
            this.lblProductsInInventory.Name = "lblProductsInInventory";
            this.lblProductsInInventory.Size = new System.Drawing.Size(118, 15);
            this.lblProductsInInventory.TabIndex = 2;
            this.lblProductsInInventory.Text = "Produkter i lager:";
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.tableLayoutPanel1);
            this.Inventory.Location = new System.Drawing.Point(4, 22);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(849, 545);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Lager";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblInvProductsInInventory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAddProductDeliveryToInventory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelAddNewProduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDeleteProductFromInventory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvInventory, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 539);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // lblInvProductsInInventory
            // 
            this.lblInvProductsInInventory.AutoSize = true;
            this.lblInvProductsInInventory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInvProductsInInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvProductsInInventory.Location = new System.Drawing.Point(424, 0);
            this.lblInvProductsInInventory.Name = "lblInvProductsInInventory";
            this.lblInvProductsInInventory.Size = new System.Drawing.Size(416, 15);
            this.lblInvProductsInInventory.TabIndex = 3;
            this.lblInvProductsInInventory.Text = "Produkter i lager:";
            // 
            // panelAddProductDeliveryToInventory
            // 
            this.panelAddProductDeliveryToInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddProductDeliveryToInventory.Controls.Add(this.btnClear2);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.lblTxtboxProductType2);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.txtboxProductType2);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.lblTxtboxProductAmount);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.txtboxProductAmount);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.btnAddToProduct);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.lblAddNewProductDeliveryToInventory);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.lblAddNewProductDeliveryToInventoryInstr);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.lblTxtboxProductName2);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.txtboxProductName2);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.txtboxProductID2);
            this.panelAddProductDeliveryToInventory.Controls.Add(this.lblTxtboxProductID2);
            this.panelAddProductDeliveryToInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddProductDeliveryToInventory.Location = new System.Drawing.Point(3, 192);
            this.panelAddProductDeliveryToInventory.Name = "panelAddProductDeliveryToInventory";
            this.panelAddProductDeliveryToInventory.Size = new System.Drawing.Size(415, 168);
            this.panelAddProductDeliveryToInventory.TabIndex = 24;
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(266, 133);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(60, 23);
            this.btnClear2.TabIndex = 1;
            this.btnClear2.Text = "Rensa";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // lblTxtboxProductType2
            // 
            this.lblTxtboxProductType2.AutoSize = true;
            this.lblTxtboxProductType2.Location = new System.Drawing.Point(258, 82);
            this.lblTxtboxProductType2.Name = "lblTxtboxProductType2";
            this.lblTxtboxProductType2.Size = new System.Drawing.Size(59, 13);
            this.lblTxtboxProductType2.TabIndex = 37;
            this.lblTxtboxProductType2.Text = "Varugrupp:";
            // 
            // txtboxProductType2
            // 
            this.txtboxProductType2.Enabled = false;
            this.txtboxProductType2.Location = new System.Drawing.Point(261, 98);
            this.txtboxProductType2.Name = "txtboxProductType2";
            this.txtboxProductType2.Size = new System.Drawing.Size(65, 20);
            this.txtboxProductType2.TabIndex = 36;
            // 
            // lblTxtboxProductAmount
            // 
            this.lblTxtboxProductAmount.AutoSize = true;
            this.lblTxtboxProductAmount.Location = new System.Drawing.Point(342, 82);
            this.lblTxtboxProductAmount.Name = "lblTxtboxProductAmount";
            this.lblTxtboxProductAmount.Size = new System.Drawing.Size(34, 13);
            this.lblTxtboxProductAmount.TabIndex = 33;
            this.lblTxtboxProductAmount.Text = "Antal:";
            // 
            // txtboxProductAmount
            // 
            this.txtboxProductAmount.Location = new System.Drawing.Point(345, 98);
            this.txtboxProductAmount.Name = "txtboxProductAmount";
            this.txtboxProductAmount.Size = new System.Drawing.Size(55, 20);
            this.txtboxProductAmount.TabIndex = 0;
            // 
            // btnAddToProduct
            // 
            this.btnAddToProduct.Location = new System.Drawing.Point(340, 133);
            this.btnAddToProduct.Name = "btnAddToProduct";
            this.btnAddToProduct.Size = new System.Drawing.Size(60, 23);
            this.btnAddToProduct.TabIndex = 2;
            this.btnAddToProduct.Text = "Spara";
            this.btnAddToProduct.UseVisualStyleBackColor = true;
            this.btnAddToProduct.Click += new System.EventHandler(this.btnAddToProduct_Click);
            // 
            // lblAddNewProductDeliveryToInventory
            // 
            this.lblAddNewProductDeliveryToInventory.AutoSize = true;
            this.lblAddNewProductDeliveryToInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProductDeliveryToInventory.Location = new System.Drawing.Point(10, 11);
            this.lblAddNewProductDeliveryToInventory.Name = "lblAddNewProductDeliveryToInventory";
            this.lblAddNewProductDeliveryToInventory.Size = new System.Drawing.Size(187, 15);
            this.lblAddNewProductDeliveryToInventory.TabIndex = 23;
            this.lblAddNewProductDeliveryToInventory.Text = "Lägg till leverans av produkt";
            // 
            // lblAddNewProductDeliveryToInventoryInstr
            // 
            this.lblAddNewProductDeliveryToInventoryInstr.AutoSize = true;
            this.lblAddNewProductDeliveryToInventoryInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProductDeliveryToInventoryInstr.Location = new System.Drawing.Point(10, 30);
            this.lblAddNewProductDeliveryToInventoryInstr.Name = "lblAddNewProductDeliveryToInventoryInstr";
            this.lblAddNewProductDeliveryToInventoryInstr.Size = new System.Drawing.Size(371, 30);
            this.lblAddNewProductDeliveryToInventoryInstr.TabIndex = 30;
            this.lblAddNewProductDeliveryToInventoryInstr.Text = "Klicka på den produkt i Lagerlistan som du vill lägga till en leverans\r\npå. Fyll " +
                "i antal produkter som levererats. Tryck sedan på \'Lägg till\'.";
            // 
            // lblTxtboxProductName2
            // 
            this.lblTxtboxProductName2.AutoSize = true;
            this.lblTxtboxProductName2.Location = new System.Drawing.Point(75, 82);
            this.lblTxtboxProductName2.Name = "lblTxtboxProductName2";
            this.lblTxtboxProductName2.Size = new System.Drawing.Size(30, 13);
            this.lblTxtboxProductName2.TabIndex = 29;
            this.lblTxtboxProductName2.Text = "Titel:";
            // 
            // txtboxProductName2
            // 
            this.txtboxProductName2.Enabled = false;
            this.txtboxProductName2.Location = new System.Drawing.Point(78, 98);
            this.txtboxProductName2.Name = "txtboxProductName2";
            this.txtboxProductName2.Size = new System.Drawing.Size(164, 20);
            this.txtboxProductName2.TabIndex = 0;
            // 
            // txtboxProductID2
            // 
            this.txtboxProductID2.Enabled = false;
            this.txtboxProductID2.Location = new System.Drawing.Point(13, 98);
            this.txtboxProductID2.Name = "txtboxProductID2";
            this.txtboxProductID2.Size = new System.Drawing.Size(47, 20);
            this.txtboxProductID2.TabIndex = 0;
            // 
            // lblTxtboxProductID2
            // 
            this.lblTxtboxProductID2.AutoSize = true;
            this.lblTxtboxProductID2.Location = new System.Drawing.Point(10, 82);
            this.lblTxtboxProductID2.Name = "lblTxtboxProductID2";
            this.lblTxtboxProductID2.Size = new System.Drawing.Size(35, 13);
            this.lblTxtboxProductID2.TabIndex = 27;
            this.lblTxtboxProductID2.Text = "Art.nr:";
            // 
            // panelAddNewProduct
            // 
            this.panelAddNewProduct.BackColor = System.Drawing.SystemColors.Control;
            this.panelAddNewProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddNewProduct.Controls.Add(this.btnClear1);
            this.panelAddNewProduct.Controls.Add(this.cboboxProductType1);
            this.panelAddNewProduct.Controls.Add(this.lblTxtboxProductType1);
            this.panelAddNewProduct.Controls.Add(this.lblTxtboxProductPrice);
            this.panelAddNewProduct.Controls.Add(this.txtboxProductPrice);
            this.panelAddNewProduct.Controls.Add(this.btnAddNewProduct);
            this.panelAddNewProduct.Controls.Add(this.lblAddNewProductToInventory);
            this.panelAddNewProduct.Controls.Add(this.lblAddNewProductToInventoryInstr);
            this.panelAddNewProduct.Controls.Add(this.lblTxtboxProductName1);
            this.panelAddNewProduct.Controls.Add(this.txtboxProductName1);
            this.panelAddNewProduct.Controls.Add(this.txtboxProductID1);
            this.panelAddNewProduct.Controls.Add(this.lblTxtboxProductID1);
            this.panelAddNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNewProduct.Location = new System.Drawing.Point(3, 18);
            this.panelAddNewProduct.Name = "panelAddNewProduct";
            this.panelAddNewProduct.Size = new System.Drawing.Size(415, 168);
            this.panelAddNewProduct.TabIndex = 25;
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(266, 134);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(60, 23);
            this.btnClear1.TabIndex = 4;
            this.btnClear1.Text = "Rensa";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // cboboxProductType1
            // 
            this.cboboxProductType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxProductType1.FormattingEnabled = true;
            this.cboboxProductType1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboboxProductType1.Items.AddRange(new object[] {
            "DVD",
            "CD",
            "Bok",
            "Spel"});
            this.cboboxProductType1.Location = new System.Drawing.Point(261, 95);
            this.cboboxProductType1.MaxDropDownItems = 4;
            this.cboboxProductType1.Name = "cboboxProductType1";
            this.cboboxProductType1.Size = new System.Drawing.Size(66, 21);
            this.cboboxProductType1.TabIndex = 2;
            // 
            // lblTxtboxProductType1
            // 
            this.lblTxtboxProductType1.AutoSize = true;
            this.lblTxtboxProductType1.Location = new System.Drawing.Point(259, 79);
            this.lblTxtboxProductType1.Name = "lblTxtboxProductType1";
            this.lblTxtboxProductType1.Size = new System.Drawing.Size(59, 13);
            this.lblTxtboxProductType1.TabIndex = 35;
            this.lblTxtboxProductType1.Text = "Varugrupp:";
            // 
            // lblTxtboxProductPrice
            // 
            this.lblTxtboxProductPrice.AutoSize = true;
            this.lblTxtboxProductPrice.Location = new System.Drawing.Point(343, 80);
            this.lblTxtboxProductPrice.Name = "lblTxtboxProductPrice";
            this.lblTxtboxProductPrice.Size = new System.Drawing.Size(57, 13);
            this.lblTxtboxProductPrice.TabIndex = 33;
            this.lblTxtboxProductPrice.Text = "Pris (SEK):";
            // 
            // txtboxProductPrice
            // 
            this.txtboxProductPrice.Location = new System.Drawing.Point(346, 96);
            this.txtboxProductPrice.Name = "txtboxProductPrice";
            this.txtboxProductPrice.Size = new System.Drawing.Size(55, 20);
            this.txtboxProductPrice.TabIndex = 3;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(340, 134);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(60, 23);
            this.btnAddNewProduct.TabIndex = 5;
            this.btnAddNewProduct.Text = "Spara";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // lblAddNewProductToInventory
            // 
            this.lblAddNewProductToInventory.AutoSize = true;
            this.lblAddNewProductToInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProductToInventory.Location = new System.Drawing.Point(10, 11);
            this.lblAddNewProductToInventory.Name = "lblAddNewProductToInventory";
            this.lblAddNewProductToInventory.Size = new System.Drawing.Size(129, 15);
            this.lblAddNewProductToInventory.TabIndex = 23;
            this.lblAddNewProductToInventory.Text = "Lägg till ny produkt";
            // 
            // lblAddNewProductToInventoryInstr
            // 
            this.lblAddNewProductToInventoryInstr.AutoSize = true;
            this.lblAddNewProductToInventoryInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProductToInventoryInstr.Location = new System.Drawing.Point(10, 30);
            this.lblAddNewProductToInventoryInstr.Name = "lblAddNewProductToInventoryInstr";
            this.lblAddNewProductToInventoryInstr.Size = new System.Drawing.Size(364, 30);
            this.lblAddNewProductToInventoryInstr.TabIndex = 30;
            this.lblAddNewProductToInventoryInstr.Text = "Fyll i artikelnummer, namn, varugrupp och pris på den produkt du \r\nvill lägga til" +
                "l. Tryck sedan på \'Lägg till\'.";
            // 
            // lblTxtboxProductName1
            // 
            this.lblTxtboxProductName1.AutoSize = true;
            this.lblTxtboxProductName1.Location = new System.Drawing.Point(75, 80);
            this.lblTxtboxProductName1.Name = "lblTxtboxProductName1";
            this.lblTxtboxProductName1.Size = new System.Drawing.Size(30, 13);
            this.lblTxtboxProductName1.TabIndex = 29;
            this.lblTxtboxProductName1.Text = "Titel:";
            // 
            // txtboxProductName1
            // 
            this.txtboxProductName1.Location = new System.Drawing.Point(78, 96);
            this.txtboxProductName1.Name = "txtboxProductName1";
            this.txtboxProductName1.Size = new System.Drawing.Size(164, 20);
            this.txtboxProductName1.TabIndex = 1;
            // 
            // txtboxProductID1
            // 
            this.txtboxProductID1.Location = new System.Drawing.Point(13, 96);
            this.txtboxProductID1.Name = "txtboxProductID1";
            this.txtboxProductID1.Size = new System.Drawing.Size(47, 20);
            this.txtboxProductID1.TabIndex = 0;
            // 
            // lblTxtboxProductID1
            // 
            this.lblTxtboxProductID1.AutoSize = true;
            this.lblTxtboxProductID1.Location = new System.Drawing.Point(10, 80);
            this.lblTxtboxProductID1.Name = "lblTxtboxProductID1";
            this.lblTxtboxProductID1.Size = new System.Drawing.Size(35, 13);
            this.lblTxtboxProductID1.TabIndex = 27;
            this.lblTxtboxProductID1.Text = "Art.nr:";
            // 
            // panelDeleteProductFromInventory
            // 
            this.panelDeleteProductFromInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeleteProductFromInventory.Controls.Add(this.lblDeleteProduct);
            this.panelDeleteProductFromInventory.Controls.Add(this.btnDeleteProduct);
            this.panelDeleteProductFromInventory.Controls.Add(this.lblDeleteProductFromInventory);
            this.panelDeleteProductFromInventory.Controls.Add(this.lblDeleteProductFromInventoryInstr);
            this.panelDeleteProductFromInventory.Controls.Add(this.txtboxDeleteProduct);
            this.panelDeleteProductFromInventory.Controls.Add(this.lblTxtboxDeleteProduct);
            this.panelDeleteProductFromInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeleteProductFromInventory.Location = new System.Drawing.Point(3, 366);
            this.panelDeleteProductFromInventory.Name = "panelDeleteProductFromInventory";
            this.panelDeleteProductFromInventory.Size = new System.Drawing.Size(415, 170);
            this.panelDeleteProductFromInventory.TabIndex = 23;
            // 
            // lblDeleteProduct
            // 
            this.lblDeleteProduct.AutoSize = true;
            this.lblDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteProduct.Location = new System.Drawing.Point(12, 129);
            this.lblDeleteProduct.Name = "lblDeleteProduct";
            this.lblDeleteProduct.Size = new System.Drawing.Size(0, 13);
            this.lblDeleteProduct.TabIndex = 31;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(339, 134);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(60, 23);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Ta bort";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblDeleteProductFromInventory
            // 
            this.lblDeleteProductFromInventory.AutoSize = true;
            this.lblDeleteProductFromInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteProductFromInventory.Location = new System.Drawing.Point(10, 11);
            this.lblDeleteProductFromInventory.Name = "lblDeleteProductFromInventory";
            this.lblDeleteProductFromInventory.Size = new System.Drawing.Size(124, 15);
            this.lblDeleteProductFromInventory.TabIndex = 23;
            this.lblDeleteProductFromInventory.Text = "Ta bort en produkt";
            // 
            // lblDeleteProductFromInventoryInstr
            // 
            this.lblDeleteProductFromInventoryInstr.AutoSize = true;
            this.lblDeleteProductFromInventoryInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteProductFromInventoryInstr.Location = new System.Drawing.Point(10, 31);
            this.lblDeleteProductFromInventoryInstr.Name = "lblDeleteProductFromInventoryInstr";
            this.lblDeleteProductFromInventoryInstr.Size = new System.Drawing.Size(358, 30);
            this.lblDeleteProductFromInventoryInstr.TabIndex = 30;
            this.lblDeleteProductFromInventoryInstr.Text = "Välj produkten du vill ta bort genom att klicka på den i lagerlistan.\r\nTryck seda" +
                "n på \'Ta bort\'.";
            // 
            // txtboxDeleteProduct
            // 
            this.txtboxDeleteProduct.Enabled = false;
            this.txtboxDeleteProduct.Location = new System.Drawing.Point(15, 100);
            this.txtboxDeleteProduct.Name = "txtboxDeleteProduct";
            this.txtboxDeleteProduct.Size = new System.Drawing.Size(385, 20);
            this.txtboxDeleteProduct.TabIndex = 0;
            // 
            // lblTxtboxDeleteProduct
            // 
            this.lblTxtboxDeleteProduct.AutoSize = true;
            this.lblTxtboxDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtboxDeleteProduct.Location = new System.Drawing.Point(12, 84);
            this.lblTxtboxDeleteProduct.Name = "lblTxtboxDeleteProduct";
            this.lblTxtboxDeleteProduct.Size = new System.Drawing.Size(70, 13);
            this.lblTxtboxDeleteProduct.TabIndex = 27;
            this.lblTxtboxDeleteProduct.Text = "Vald produkt:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(424, 18);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 10;
            this.tableLayoutPanel1.SetRowSpan(this.dgvInventory, 3);
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(416, 518);
            this.dgvInventory.TabIndex = 8;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRowInInventory);
            // 
            // ofdSomeKindOfInputFailure
            // 
            this.ofdSomeKindOfInputFailure.FileName = "openFileDialog1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 571);
            this.Controls.Add(this.Tabs);
            this.Name = "View";
            this.Text = "Media Store";
            this.Tabs.ResumeLayout(false);
            this.Checkout.ResumeLayout(false);
            this.Checkout.PerformLayout();
            this.tableLayoutPanelCheckout.ResumeLayout(false);
            this.tableLayoutPanelCheckout.PerformLayout();
            this.pnlCheckoutInstructions.ResumeLayout(false);
            this.pnlCheckoutInstructions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).EndInit();
            this.Inventory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelAddProductDeliveryToInventory.ResumeLayout(false);
            this.panelAddProductDeliveryToInventory.PerformLayout();
            this.panelAddNewProduct.ResumeLayout(false);
            this.panelAddNewProduct.PerformLayout();
            this.panelDeleteProductFromInventory.ResumeLayout(false);
            this.panelDeleteProductFromInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPLbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySLbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TabPage Checkout;
        private System.Windows.Forms.DataGridView dgvCheckout;
        private System.Windows.Forms.Label lblProductsInInventory;
        private System.Windows.Forms.Label lblInvProductsInInventory;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnConfirmPurchase;
        private System.Windows.Forms.Button btnDeleteFromCart;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShopInstructions1;
        private System.Windows.Forms.Panel panelDeleteProductFromInventory;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblDeleteProductFromInventory;
        private System.Windows.Forms.Label lblDeleteProductFromInventoryInstr;
        private System.Windows.Forms.Label lblTxtboxDeleteProduct;
        private System.Windows.Forms.Panel panelAddNewProduct;
        private System.Windows.Forms.Label lblTxtboxProductPrice;
        private System.Windows.Forms.TextBox txtboxProductPrice;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label lblAddNewProductToInventory;
        private System.Windows.Forms.Label lblAddNewProductToInventoryInstr;
        private System.Windows.Forms.Label lblTxtboxProductName1;
        private System.Windows.Forms.TextBox txtboxProductName1;
        private System.Windows.Forms.TextBox txtboxProductID1;
        private System.Windows.Forms.Label lblTxtboxProductID1;
        private System.Windows.Forms.Panel panelAddProductDeliveryToInventory;
        private System.Windows.Forms.Label lblTxtboxProductAmount;
        private System.Windows.Forms.TextBox txtboxProductAmount;
        private System.Windows.Forms.Button btnAddToProduct;
        private System.Windows.Forms.Label lblAddNewProductDeliveryToInventory;
        private System.Windows.Forms.Label lblAddNewProductDeliveryToInventoryInstr;
        private System.Windows.Forms.Label lblTxtboxProductName2;
        private System.Windows.Forms.TextBox txtboxProductName2;
        private System.Windows.Forms.TextBox txtboxProductID2;
        private System.Windows.Forms.Label lblTxtboxProductID2;
        private System.Windows.Forms.Label lblTxtboxProductType1;
        private System.Windows.Forms.Label lblTxtboxProductType2;
        private System.Windows.Forms.TextBox txtboxProductType2;
        private System.Windows.Forms.ComboBox cboboxProductType1;
        private System.Windows.Forms.BindingSource myPLbindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCheckout;
        private System.Windows.Forms.Panel pnlCheckoutInstructions;
        private System.Windows.Forms.DataGridView dgvShoppingCart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofdSomeKindOfInputFailure;
        private System.Windows.Forms.TextBox txtboxDeleteProduct;
        private System.Windows.Forms.Label lblDeleteProduct;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource mySLbindingSource;
        private System.Windows.Forms.Button btnMinusOne;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnDeleteAllFromCart;
        private System.Windows.Forms.Label lblTxtBoxChangeAmountSC;

    }
}

