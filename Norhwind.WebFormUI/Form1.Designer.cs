namespace Northwind.WebFormUI
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
        /// the contents of 
        /// method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdatePQuentityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdatePStock = new System.Windows.Forms.TextBox();
            this.tbxUpdatePUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUpdatePCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdatePName = new System.Windows.Forms.TextBox();
            this.lblUpdarePQuentityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdarePStock = new System.Windows.Forms.Label();
            this.lblUpdarePPrice = new System.Windows.Forms.Label();
            this.lblUpdarePCategory = new System.Windows.Forms.Label();
            this.lblUpdarePName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddQuentityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxAddStock = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddQuentityPerUnit = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxUpdateProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(745, 24);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(100, 35);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Siparisler";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(745, 77);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(100, 33);
            this.btnCategories.TabIndex = 23;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(745, 129);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(100, 33);
            this.btnProducts.TabIndex = 22;
            this.btnProducts.Text = "Urunler";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(889, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "SIL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdatePQuentityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdatePStock);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdatePUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdatePCategory);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdatePName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdarePQuentityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdarePStock);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdarePPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdarePCategory);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdarePName);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(585, 374);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(437, 137);
            this.gbxUpdateProduct.TabIndex = 20;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Urun Guncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(299, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdatePQuentityPerUnit
            // 
            this.tbxUpdatePQuentityPerUnit.Location = new System.Drawing.Point(299, 62);
            this.tbxUpdatePQuentityPerUnit.Name = "tbxUpdatePQuentityPerUnit";
            this.tbxUpdatePQuentityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePQuentityPerUnit.TabIndex = 9;
            // 
            // tbxUpdatePStock
            // 
            this.tbxUpdatePStock.Location = new System.Drawing.Point(299, 17);
            this.tbxUpdatePStock.Name = "tbxUpdatePStock";
            this.tbxUpdatePStock.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePStock.TabIndex = 8;
            // 
            // tbxUpdatePUnitPrice
            // 
            this.tbxUpdatePUnitPrice.Location = new System.Drawing.Point(62, 105);
            this.tbxUpdatePUnitPrice.Name = "tbxUpdatePUnitPrice";
            this.tbxUpdatePUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePUnitPrice.TabIndex = 7;
            // 
            // cbxUpdatePCategory
            // 
            this.cbxUpdatePCategory.FormattingEnabled = true;
            this.cbxUpdatePCategory.Location = new System.Drawing.Point(62, 62);
            this.cbxUpdatePCategory.Name = "cbxUpdatePCategory";
            this.cbxUpdatePCategory.Size = new System.Drawing.Size(150, 21);
            this.cbxUpdatePCategory.TabIndex = 6;
            // 
            // tbxUpdatePName
            // 
            this.tbxUpdatePName.Location = new System.Drawing.Point(62, 20);
            this.tbxUpdatePName.Name = "tbxUpdatePName";
            this.tbxUpdatePName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePName.TabIndex = 5;
            // 
            // lblUpdarePQuentityPerUnit
            // 
            this.lblUpdarePQuentityPerUnit.AutoSize = true;
            this.lblUpdarePQuentityPerUnit.Location = new System.Drawing.Point(234, 69);
            this.lblUpdarePQuentityPerUnit.Name = "lblUpdarePQuentityPerUnit";
            this.lblUpdarePQuentityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblUpdarePQuentityPerUnit.TabIndex = 4;
            this.lblUpdarePQuentityPerUnit.Text = "Birim Adedi";
            // 
            // lblUpdarePStock
            // 
            this.lblUpdarePStock.AutoSize = true;
            this.lblUpdarePStock.Location = new System.Drawing.Point(234, 24);
            this.lblUpdarePStock.Name = "lblUpdarePStock";
            this.lblUpdarePStock.Size = new System.Drawing.Size(59, 13);
            this.lblUpdarePStock.TabIndex = 3;
            this.lblUpdarePStock.Text = "Stok Adedi";
            // 
            // lblUpdarePPrice
            // 
            this.lblUpdarePPrice.AutoSize = true;
            this.lblUpdarePPrice.Location = new System.Drawing.Point(7, 112);
            this.lblUpdarePPrice.Name = "lblUpdarePPrice";
            this.lblUpdarePPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUpdarePPrice.TabIndex = 2;
            this.lblUpdarePPrice.Text = "Fiyat";
            // 
            // lblUpdarePCategory
            // 
            this.lblUpdarePCategory.AutoSize = true;
            this.lblUpdarePCategory.Location = new System.Drawing.Point(7, 70);
            this.lblUpdarePCategory.Name = "lblUpdarePCategory";
            this.lblUpdarePCategory.Size = new System.Drawing.Size(46, 13);
            this.lblUpdarePCategory.TabIndex = 1;
            this.lblUpdarePCategory.Text = "Kategori";
            // 
            // lblUpdarePName
            // 
            this.lblUpdarePName.AutoSize = true;
            this.lblUpdarePName.Location = new System.Drawing.Point(7, 27);
            this.lblUpdarePName.Name = "lblUpdarePName";
            this.lblUpdarePName.Size = new System.Drawing.Size(48, 13);
            this.lblUpdarePName.TabIndex = 0;
            this.lblUpdarePName.Text = "Urun Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuentityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxAddStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategory);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblAddQuentityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddStock);
            this.gbxProductAdd.Controls.Add(this.lblAddPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddCategory);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(22, 374);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(441, 137);
            this.gbxProductAdd.TabIndex = 19;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Urun Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(299, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddQuentityPerUnit
            // 
            this.tbxAddQuentityPerUnit.Location = new System.Drawing.Point(299, 62);
            this.tbxAddQuentityPerUnit.Name = "tbxAddQuentityPerUnit";
            this.tbxAddQuentityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.tbxAddQuentityPerUnit.TabIndex = 9;
            // 
            // tbxAddStock
            // 
            this.tbxAddStock.Location = new System.Drawing.Point(299, 17);
            this.tbxAddStock.Name = "tbxAddStock";
            this.tbxAddStock.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStock.TabIndex = 8;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(62, 105);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUnitPrice.TabIndex = 7;
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(62, 62);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(150, 21);
            this.cbxAddCategory.TabIndex = 6;
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(62, 20);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(100, 20);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // lblAddQuentityPerUnit
            // 
            this.lblAddQuentityPerUnit.AutoSize = true;
            this.lblAddQuentityPerUnit.Location = new System.Drawing.Point(234, 69);
            this.lblAddQuentityPerUnit.Name = "lblAddQuentityPerUnit";
            this.lblAddQuentityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblAddQuentityPerUnit.TabIndex = 4;
            this.lblAddQuentityPerUnit.Text = "Birim Adedi";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Location = new System.Drawing.Point(234, 24);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(59, 13);
            this.lblAddStock.TabIndex = 3;
            this.lblAddStock.Text = "Stok Adedi";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(7, 112);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(29, 13);
            this.lblAddPrice.TabIndex = 2;
            this.lblAddPrice.Text = "Fiyat";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(7, 70);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(46, 13);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Kategori";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(7, 27);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(48, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Urun Adı";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(21, 88);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(702, 74);
            this.gbxProductName.TabIndex = 18;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Urun Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(63, 20);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(201, 20);
            this.tbxProductName.TabIndex = 3;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Urun Adı";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(21, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(702, 70);
            this.gbxCategory.TabIndex = 17;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Gore Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(63, 20);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(201, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(10, 168);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(1012, 187);
            this.dgwProduct.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 532);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdatePQuentityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdatePStock;
        private System.Windows.Forms.TextBox tbxUpdatePUnitPrice;
        private System.Windows.Forms.ComboBox cbxUpdatePCategory;
        private System.Windows.Forms.TextBox tbxUpdatePName;
        private System.Windows.Forms.Label lblUpdarePQuentityPerUnit;
        private System.Windows.Forms.Label lblUpdarePStock;
        private System.Windows.Forms.Label lblUpdarePPrice;
        private System.Windows.Forms.Label lblUpdarePCategory;
        private System.Windows.Forms.Label lblUpdarePName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAddQuentityPerUnit;
        private System.Windows.Forms.TextBox tbxAddStock;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Label lblAddQuentityPerUnit;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}

