namespace NTierArchitecture.UI.Forms
{
    partial class OrderForm
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
            groupBox1 = new GroupBox();
            btnAddBasket = new Button();
            label3 = new Label();
            label2 = new Label();
            nmrQuantity = new NumericUpDown();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            txtSearch = new TextBox();
            lstProductList = new ListBox();
            dgwOrderList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            ShipCountry = new DataGridViewTextBoxColumn();
            ShipCity = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            groupBox3 = new GroupBox();
            dgwOrderDetailList = new DataGridView();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            btnDelete = new Button();
            btnSaveOrder = new Button();
            btnNewOrder = new Button();
            lstBasket = new ListBox();
            lblBasketCount = new Label();
            lblBasketTotal = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrderList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetailList).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddBasket);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nmrQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(lstProductList);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 492);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Listesi";
            // 
            // btnAddBasket
            // 
            btnAddBasket.Location = new Point(19, 412);
            btnAddBasket.Name = "btnAddBasket";
            btnAddBasket.Size = new Size(821, 64);
            btnAddBasket.TabIndex = 2;
            btnAddBasket.Text = "Sepete Ekle";
            btnAddBasket.UseVisualStyleBackColor = true;
            btnAddBasket.Click += btnAddBasket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 365);
            label3.Name = "label3";
            label3.Size = new Size(155, 41);
            label3.TabIndex = 1;
            label3.Text = "Birim Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 359);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // nmrQuantity
            // 
            nmrQuantity.Location = new Point(147, 359);
            nmrQuantity.Margin = new Padding(16, 21, 16, 21);
            nmrQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrQuantity.Name = "nmrQuantity";
            nmrQuantity.Size = new Size(162, 47);
            nmrQuantity.TabIndex = 3;
            nmrQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(528, 41);
            label1.TabIndex = 1;
            label1.Text = "Lütfen aramak istediğiniz ürünü giriniz:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(514, 359);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(326, 47);
            txtUnitPrice.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 99);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(821, 47);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 40;
            lstProductList.Location = new Point(19, 152);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(821, 204);
            lstProductList.TabIndex = 4;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // dgwOrderList
            // 
            dgwOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderList.Columns.AddRange(new DataGridViewColumn[] { Id, OrderDate, ShipCountry, ShipCity });
            dgwOrderList.Location = new Point(19, 67);
            dgwOrderList.Name = "dgwOrderList";
            dgwOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwOrderList.Size = new Size(821, 190);
            dgwOrderList.TabIndex = 5;
            dgwOrderList.CellClick += dgwOrderList_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Sipariş No";
            Id.Name = "Id";
            Id.Width = 177;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Sipariş Tarihi";
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 206;
            // 
            // ShipCountry
            // 
            ShipCountry.DataPropertyName = "ShipCountry";
            ShipCountry.HeaderText = "Ülke";
            ShipCountry.Name = "ShipCountry";
            ShipCountry.Width = 102;
            // 
            // ShipCity
            // 
            ShipCity.DataPropertyName = "ShipCity";
            ShipCity.HeaderText = "Şehir";
            ShipCity.Name = "ShipCity";
            ShipCity.Width = 109;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwOrderList);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Location = new Point(0, 510);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(868, 304);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sipariş Bilgisi";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 260);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(563, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Fatura Toplam Tutarı :  12.500 + %20 KDV";
            lblTotal.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgwOrderDetailList);
            groupBox3.Location = new Point(884, 510);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(766, 292);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sipariş Detay Raporu";
            // 
            // dgwOrderDetailList
            // 
            dgwOrderDetailList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwOrderDetailList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderDetailList.Columns.AddRange(new DataGridViewColumn[] { Quantity, UnitPrice, ProductName, Employee, Customer });
            dgwOrderDetailList.Location = new Point(6, 46);
            dgwOrderDetailList.Name = "dgwOrderDetailList";
            dgwOrderDetailList.Size = new Size(748, 226);
            dgwOrderDetailList.TabIndex = 5;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Ürün Sayısı";
            Quantity.Name = "Quantity";
            Quantity.Width = 189;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Ürün Fiyatı";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 185;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Ürün Adı";
            ProductName.Name = "ProductName";
            ProductName.Width = 160;
            // 
            // Employee
            // 
            Employee.HeaderText = "Çalışan";
            Employee.Name = "Employee";
            Employee.Width = 136;
            // 
            // Customer
            // 
            Customer.HeaderText = "Müşteri";
            Customer.Name = "Customer";
            Customer.Width = 143;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDelete);
            groupBox4.Controls.Add(btnSaveOrder);
            groupBox4.Controls.Add(btnNewOrder);
            groupBox4.Controls.Add(lstBasket);
            groupBox4.Controls.Add(lblBasketCount);
            groupBox4.Controls.Add(lblBasketTotal);
            groupBox4.Location = new Point(878, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(766, 480);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Müşteri Sepeti";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(665, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(508, 414);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(252, 60);
            btnSaveOrder.TabIndex = 2;
            btnSaveOrder.Text = "Sipariş Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(250, 414);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(252, 60);
            btnNewOrder.TabIndex = 2;
            btnNewOrder.Text = "Yeni Sipariş";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // lstBasket
            // 
            lstBasket.FormattingEnabled = true;
            lstBasket.ItemHeight = 40;
            lstBasket.Location = new Point(6, 66);
            lstBasket.Name = "lstBasket";
            lstBasket.Size = new Size(754, 244);
            lstBasket.TabIndex = 5;
            // 
            // lblBasketCount
            // 
            lblBasketCount.AutoSize = true;
            lblBasketCount.Location = new Point(6, 368);
            lblBasketCount.Name = "lblBasketCount";
            lblBasketCount.Size = new Size(200, 41);
            lblBasketCount.TabIndex = 1;
            lblBasketCount.Text = "Ürün Adedi: 5";
            // 
            // lblBasketTotal
            // 
            lblBasketTotal.AutoSize = true;
            lblBasketTotal.Location = new Point(6, 324);
            lblBasketTotal.Name = "lblBasketTotal";
            lblBasketTotal.Size = new Size(346, 41);
            lblBasketTotal.TabIndex = 1;
            lblBasketTotal.Text = "Sepet Toplamı: 12.500 TL";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1662, 873);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrderList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetailList).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private GroupBox groupBox1;
        private ListBox lstProductList;
        private NumericUpDown nmrQuantity;
        private Button btnAddBasket;
        private Label label1;
        private TextBox txtSearch;
        private Label label3;
        private Label label2;
        private TextBox txtUnitPrice;
        private DataGridView dgwOrderList;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgwOrderDetailList;
        private GroupBox groupBox4;
        private Button btnSaveOrder;
        private Button btnNewOrder;
        private ListBox lstBasket;
        private Label lblBasketCount;
        private Label lblBasketTotal;
        private Button btnDelete;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn ShipCountry;
        private DataGridViewTextBoxColumn ShipCity;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Customer;
    }
}