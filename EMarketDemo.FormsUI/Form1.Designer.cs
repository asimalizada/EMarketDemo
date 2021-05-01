
namespace EMarketDemo.FormsUI
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxCategoryIdUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxCategoryIdAdd = new System.Windows.Forms.TextBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxSearching = new System.Windows.Forms.GroupBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.tbxProductNameSearch = new System.Windows.Forms.TextBox();
            this.lblProductNameSearch = new System.Windows.Forms.Label();
            this.gbxByPrice = new System.Windows.Forms.GroupBox();
            this.lblByPriceMin = new System.Windows.Forms.Label();
            this.lblByPriceMax = new System.Windows.Forms.Label();
            this.tbxByPriceMin = new System.Windows.Forms.TextBox();
            this.tbxByPriceMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxSearching.SuspendLayout();
            this.gbxByPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 22);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(1170, 280);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(12, 331);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(676, 419);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "Crud";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCategoryIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(354, 48);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(303, 248);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(177, 145);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(109, 30);
            this.tbxUnitsInStockUpdate.TabIndex = 7;
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPriceUpdate.Location = new System.Drawing.Point(177, 108);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(109, 30);
            this.tbxPriceUpdate.TabIndex = 6;
            // 
            // tbxCategoryIdUpdate
            // 
            this.tbxCategoryIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCategoryIdUpdate.Location = new System.Drawing.Point(177, 74);
            this.tbxCategoryIdUpdate.Name = "tbxCategoryIdUpdate";
            this.tbxCategoryIdUpdate.Size = new System.Drawing.Size(109, 30);
            this.tbxCategoryIdUpdate.TabIndex = 5;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNameUpdate.Location = new System.Drawing.Point(177, 39);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(109, 30);
            this.tbxNameUpdate.TabIndex = 4;
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(15, 148);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(131, 25);
            this.lblUnitsInStockUpdate.TabIndex = 3;
            this.lblUnitsInStockUpdate.Text = "Units in Stock";
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceUpdate.Location = new System.Drawing.Point(15, 111);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(56, 25);
            this.lblPriceUpdate.TabIndex = 2;
            this.lblPriceUpdate.Text = "Price";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(15, 77);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(113, 25);
            this.lblCategoryIdUpdate.TabIndex = 1;
            this.lblCategoryIdUpdate.Text = "Category Id";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameUpdate.Location = new System.Drawing.Point(15, 42);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(64, 25);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Name";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.gbxAdd.Controls.Add(this.tbxPriceAdd);
            this.gbxAdd.Controls.Add(this.tbxCategoryIdAdd);
            this.gbxAdd.Controls.Add(this.tbxNameAdd);
            this.gbxAdd.Controls.Add(this.lblUnitsInStockAdd);
            this.gbxAdd.Controls.Add(this.lblPriceAdd);
            this.gbxAdd.Controls.Add(this.lblCategoryIdAdd);
            this.gbxAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(21, 48);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(303, 248);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(177, 145);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(109, 30);
            this.tbxUnitsInStockAdd.TabIndex = 7;
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPriceAdd.Location = new System.Drawing.Point(177, 108);
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(109, 30);
            this.tbxPriceAdd.TabIndex = 6;
            // 
            // tbxCategoryIdAdd
            // 
            this.tbxCategoryIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCategoryIdAdd.Location = new System.Drawing.Point(177, 74);
            this.tbxCategoryIdAdd.Name = "tbxCategoryIdAdd";
            this.tbxCategoryIdAdd.Size = new System.Drawing.Size(109, 30);
            this.tbxCategoryIdAdd.TabIndex = 5;
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNameAdd.Location = new System.Drawing.Point(177, 39);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(109, 30);
            this.tbxNameAdd.TabIndex = 4;
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(15, 148);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(131, 25);
            this.lblUnitsInStockAdd.TabIndex = 3;
            this.lblUnitsInStockAdd.Text = "Units in Stock";
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.AutoSize = true;
            this.lblPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceAdd.Location = new System.Drawing.Point(15, 111);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(56, 25);
            this.lblPriceAdd.TabIndex = 2;
            this.lblPriceAdd.Text = "Price";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(15, 77);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(113, 25);
            this.lblCategoryIdAdd.TabIndex = 1;
            this.lblCategoryIdAdd.Text = "Category Id";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductNameAdd.Location = new System.Drawing.Point(15, 42);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(64, 25);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Name";
            // 
            // gbxSearching
            // 
            this.gbxSearching.Controls.Add(this.gbxByPrice);
            this.gbxSearching.Controls.Add(this.cbxCategories);
            this.gbxSearching.Controls.Add(this.tbxProductNameSearch);
            this.gbxSearching.Controls.Add(this.lblProductNameSearch);
            this.gbxSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearching.Location = new System.Drawing.Point(708, 331);
            this.gbxSearching.Name = "gbxSearching";
            this.gbxSearching.Size = new System.Drawing.Size(474, 419);
            this.gbxSearching.TabIndex = 2;
            this.gbxSearching.TabStop = false;
            this.gbxSearching.Text = "Searching";
            // 
            // cbxCategories
            // 
            this.cbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(32, 104);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(179, 37);
            this.cbxCategories.TabIndex = 2;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // tbxProductNameSearch
            // 
            this.tbxProductNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductNameSearch.Location = new System.Drawing.Point(265, 48);
            this.tbxProductNameSearch.Name = "tbxProductNameSearch";
            this.tbxProductNameSearch.Size = new System.Drawing.Size(181, 34);
            this.tbxProductNameSearch.TabIndex = 1;
            this.tbxProductNameSearch.TextChanged += new System.EventHandler(this.tbxProductNameSearch_TextChanged);
            // 
            // lblProductNameSearch
            // 
            this.lblProductNameSearch.AutoSize = true;
            this.lblProductNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductNameSearch.Location = new System.Drawing.Point(27, 51);
            this.lblProductNameSearch.Name = "lblProductNameSearch";
            this.lblProductNameSearch.Size = new System.Drawing.Size(162, 29);
            this.lblProductNameSearch.TabIndex = 0;
            this.lblProductNameSearch.Text = "Product name";
            // 
            // gbxByPrice
            // 
            this.gbxByPrice.Controls.Add(this.tbxByPriceMax);
            this.gbxByPrice.Controls.Add(this.tbxByPriceMin);
            this.gbxByPrice.Controls.Add(this.lblByPriceMax);
            this.gbxByPrice.Controls.Add(this.lblByPriceMin);
            this.gbxByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxByPrice.Location = new System.Drawing.Point(37, 169);
            this.gbxByPrice.Name = "gbxByPrice";
            this.gbxByPrice.Size = new System.Drawing.Size(389, 141);
            this.gbxByPrice.TabIndex = 3;
            this.gbxByPrice.TabStop = false;
            this.gbxByPrice.Text = "By Price";
            // 
            // lblByPriceMin
            // 
            this.lblByPriceMin.AutoSize = true;
            this.lblByPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByPriceMin.Location = new System.Drawing.Point(40, 52);
            this.lblByPriceMin.Name = "lblByPriceMin";
            this.lblByPriceMin.Size = new System.Drawing.Size(55, 25);
            this.lblByPriceMin.TabIndex = 0;
            this.lblByPriceMin.Text = "Min :";
            // 
            // lblByPriceMax
            // 
            this.lblByPriceMax.AutoSize = true;
            this.lblByPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByPriceMax.Location = new System.Drawing.Point(204, 52);
            this.lblByPriceMax.Name = "lblByPriceMax";
            this.lblByPriceMax.Size = new System.Drawing.Size(66, 25);
            this.lblByPriceMax.TabIndex = 1;
            this.lblByPriceMax.Text = "Max : ";
            // 
            // tbxByPriceMin
            // 
            this.tbxByPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxByPriceMin.Location = new System.Drawing.Point(74, 87);
            this.tbxByPriceMin.Name = "tbxByPriceMin";
            this.tbxByPriceMin.Size = new System.Drawing.Size(100, 30);
            this.tbxByPriceMin.TabIndex = 2;
            this.tbxByPriceMin.TextChanged += new System.EventHandler(this.tbxByPriceMin_TextChanged);
            // 
            // tbxByPriceMax
            // 
            this.tbxByPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxByPriceMax.Location = new System.Drawing.Point(263, 83);
            this.tbxByPriceMax.Name = "tbxByPriceMax";
            this.tbxByPriceMax.Size = new System.Drawing.Size(100, 30);
            this.tbxByPriceMax.TabIndex = 3;
            this.tbxByPriceMax.TextChanged += new System.EventHandler(this.tbxByPriceMax_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 797);
            this.Controls.Add(this.gbxSearching);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxSearching.ResumeLayout(false);
            this.gbxSearching.PerformLayout();
            this.gbxByPrice.ResumeLayout(false);
            this.gbxByPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.Label lblPriceAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.TextBox tbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.TextBox tbxCategoryIdAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.GroupBox gbxSearching;
        private System.Windows.Forms.TextBox tbxProductNameSearch;
        private System.Windows.Forms.Label lblProductNameSearch;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.GroupBox gbxByPrice;
        private System.Windows.Forms.TextBox tbxByPriceMax;
        private System.Windows.Forms.TextBox tbxByPriceMin;
        private System.Windows.Forms.Label lblByPriceMax;
        private System.Windows.Forms.Label lblByPriceMin;
    }
}

