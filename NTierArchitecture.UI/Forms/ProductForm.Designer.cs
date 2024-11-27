namespace NTierArchitecture.UI.Forms
{
    partial class ProductForm
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
            groupBox2 = new GroupBox();
            chkContinue = new CheckBox();
            chkState = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            txtUPrice = new TextBox();
            label4 = new Label();
            txtPrdName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCategories = new ComboBox();
            cmbSuppliers = new ComboBox();
            lstProductList = new ListBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkContinue);
            groupBox2.Controls.Add(chkState);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtUPrice);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPrdName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbCategories);
            groupBox2.Controls.Add(cmbSuppliers);
            groupBox2.Location = new Point(13, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(928, 370);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Kayıt Formu";
            // 
            // chkContinue
            // 
            chkContinue.AutoSize = true;
            chkContinue.Location = new Point(762, 305);
            chkContinue.Name = "chkContinue";
            chkContinue.Size = new Size(86, 41);
            chkContinue.TabIndex = 3;
            chkContinue.Text = "Evet";
            chkContinue.UseVisualStyleBackColor = true;
            // 
            // chkState
            // 
            chkState.AutoSize = true;
            chkState.Location = new Point(301, 304);
            chkState.Name = "chkState";
            chkState.Size = new Size(90, 41);
            chkState.TabIndex = 3;
            chkState.Text = "Aktif";
            chkState.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 306);
            label7.Name = "label7";
            label7.Size = new Size(141, 37);
            label7.TabIndex = 1;
            label7.Text = "Devamlılık";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 305);
            label6.Name = "label6";
            label6.Size = new Size(98, 37);
            label6.TabIndex = 1;
            label6.Text = "Durum";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(301, 253);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(621, 43);
            txtQuantity.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 256);
            label5.Name = "label5";
            label5.Size = new Size(145, 37);
            label5.TabIndex = 1;
            label5.Text = "Stok Adedi";
            // 
            // txtUPrice
            // 
            txtUPrice.Location = new Point(301, 204);
            txtUPrice.Name = "txtUPrice";
            txtUPrice.Size = new Size(621, 43);
            txtUPrice.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 207);
            label4.Name = "label4";
            label4.Size = new Size(148, 37);
            label4.TabIndex = 1;
            label4.Text = "Birim Fiyatı";
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(301, 155);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(621, 43);
            txtPrdName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 158);
            label3.Name = "label3";
            label3.Size = new Size(122, 37);
            label3.TabIndex = 1;
            label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 107);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 1;
            label2.Text = "Kategori Seçiniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 1;
            label1.Text = "Tedarikçi Seçiniz:";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(301, 104);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(621, 45);
            cmbCategories.TabIndex = 0;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(301, 53);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(621, 45);
            cmbSuppliers.TabIndex = 0;
            cmbSuppliers.SelectedIndexChanged += cmbSuppliers_SelectedIndexChanged;
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 37;
            lstProductList.Location = new Point(16, 553);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(925, 189);
            lstProductList.TabIndex = 4;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 760);
            Controls.Add(lstProductList);
            Controls.Add(groupBox2);
            Margin = new Padding(13, 17, 13, 17);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            Click += ProductForm_Click;
            Controls.SetChildIndex(groupBox2, 0);
            Controls.SetChildIndex(lstProductList, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private CheckBox chkContinue;
        private CheckBox chkState;
        private Label label7;
        private Label label6;
        private TextBox txtQuantity;
        private Label label5;
        private TextBox txtUPrice;
        private Label label4;
        private TextBox txtPrdName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategories;
        private ComboBox cmbSuppliers;
        private ListBox lstProductList;
    }
}