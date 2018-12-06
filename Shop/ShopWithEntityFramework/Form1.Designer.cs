namespace ShopWithEntityFramework
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
            this.btn_Remove = new System.Windows.Forms.Button();
            this.gbx_Update = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tbx_UpdatedName = new System.Windows.Forms.TextBox();
            this.tbx_UpdatedStockAmount = new System.Windows.Forms.TextBox();
            this.lbl_UpdatedName = new System.Windows.Forms.Label();
            this.lbl_UpdatedStockAmount = new System.Windows.Forms.Label();
            this.lbl_UpdatedPrice = new System.Windows.Forms.Label();
            this.tbx_UpdatedPrice = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_StockAmount = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_StockAmount = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.gbx_Update.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(142, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(123, 31);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // gbx_Update
            // 
            this.gbx_Update.Controls.Add(this.btn_Update);
            this.gbx_Update.Controls.Add(this.tbx_UpdatedName);
            this.gbx_Update.Controls.Add(this.tbx_UpdatedStockAmount);
            this.gbx_Update.Controls.Add(this.lbl_UpdatedName);
            this.gbx_Update.Controls.Add(this.lbl_UpdatedStockAmount);
            this.gbx_Update.Controls.Add(this.lbl_UpdatedPrice);
            this.gbx_Update.Controls.Add(this.tbx_UpdatedPrice);
            this.gbx_Update.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.gbx_Update.Location = new System.Drawing.Point(473, 222);
            this.gbx_Update.Name = "gbx_Update";
            this.gbx_Update.Size = new System.Drawing.Size(304, 190);
            this.gbx_Update.TabIndex = 12;
            this.gbx_Update.TabStop = false;
            this.gbx_Update.Text = "Update a Product";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(121, 153);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(123, 31);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tbx_UpdatedName
            // 
            this.tbx_UpdatedName.Location = new System.Drawing.Point(121, 29);
            this.tbx_UpdatedName.Name = "tbx_UpdatedName";
            this.tbx_UpdatedName.Size = new System.Drawing.Size(123, 21);
            this.tbx_UpdatedName.TabIndex = 2;
            // 
            // tbx_UpdatedStockAmount
            // 
            this.tbx_UpdatedStockAmount.Location = new System.Drawing.Point(121, 111);
            this.tbx_UpdatedStockAmount.Name = "tbx_UpdatedStockAmount";
            this.tbx_UpdatedStockAmount.Size = new System.Drawing.Size(123, 21);
            this.tbx_UpdatedStockAmount.TabIndex = 6;
            // 
            // lbl_UpdatedName
            // 
            this.lbl_UpdatedName.AutoSize = true;
            this.lbl_UpdatedName.Location = new System.Drawing.Point(36, 29);
            this.lbl_UpdatedName.Name = "lbl_UpdatedName";
            this.lbl_UpdatedName.Size = new System.Drawing.Size(34, 13);
            this.lbl_UpdatedName.TabIndex = 1;
            this.lbl_UpdatedName.Text = "Name";
            // 
            // lbl_UpdatedStockAmount
            // 
            this.lbl_UpdatedStockAmount.AutoSize = true;
            this.lbl_UpdatedStockAmount.Location = new System.Drawing.Point(36, 111);
            this.lbl_UpdatedStockAmount.Name = "lbl_UpdatedStockAmount";
            this.lbl_UpdatedStockAmount.Size = new System.Drawing.Size(73, 13);
            this.lbl_UpdatedStockAmount.TabIndex = 5;
            this.lbl_UpdatedStockAmount.Text = "Stock Amount";
            // 
            // lbl_UpdatedPrice
            // 
            this.lbl_UpdatedPrice.AutoSize = true;
            this.lbl_UpdatedPrice.Location = new System.Drawing.Point(36, 72);
            this.lbl_UpdatedPrice.Name = "lbl_UpdatedPrice";
            this.lbl_UpdatedPrice.Size = new System.Drawing.Size(30, 13);
            this.lbl_UpdatedPrice.TabIndex = 3;
            this.lbl_UpdatedPrice.Text = "Price";
            // 
            // tbx_UpdatedPrice
            // 
            this.tbx_UpdatedPrice.Location = new System.Drawing.Point(121, 72);
            this.tbx_UpdatedPrice.Name = "tbx_UpdatedPrice";
            this.tbx_UpdatedPrice.Size = new System.Drawing.Size(123, 21);
            this.tbx_UpdatedPrice.TabIndex = 4;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btn_Add);
            this.gbxAdd.Controls.Add(this.tbx_Name);
            this.gbxAdd.Controls.Add(this.tbx_StockAmount);
            this.gbxAdd.Controls.Add(this.lbl_Name);
            this.gbxAdd.Controls.Add(this.lbl_StockAmount);
            this.gbxAdd.Controls.Add(this.lbl_Price);
            this.gbxAdd.Controls.Add(this.tbx_Price);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.gbxAdd.Location = new System.Drawing.Point(21, 222);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(304, 190);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(121, 153);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 31);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(121, 29);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(123, 21);
            this.tbx_Name.TabIndex = 2;
            // 
            // tbx_StockAmount
            // 
            this.tbx_StockAmount.Location = new System.Drawing.Point(121, 111);
            this.tbx_StockAmount.Name = "tbx_StockAmount";
            this.tbx_StockAmount.Size = new System.Drawing.Size(123, 21);
            this.tbx_StockAmount.TabIndex = 6;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(36, 29);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(34, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_StockAmount
            // 
            this.lbl_StockAmount.AutoSize = true;
            this.lbl_StockAmount.Location = new System.Drawing.Point(36, 111);
            this.lbl_StockAmount.Name = "lbl_StockAmount";
            this.lbl_StockAmount.Size = new System.Drawing.Size(73, 13);
            this.lbl_StockAmount.TabIndex = 5;
            this.lbl_StockAmount.Text = "Stock Amount";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(36, 72);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(30, 13);
            this.lbl_Price.TabIndex = 3;
            this.lbl_Price.Text = "Price";
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(121, 72);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.Size = new System.Drawing.Size(123, 21);
            this.tbx_Price.TabIndex = 4;
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 39);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(776, 150);
            this.dgwProducts.TabIndex = 10;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
           
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(594, 13);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(123, 20);
            this.tbx_Search.TabIndex = 14;
            this.tbx_Search.TextChanged += new System.EventHandler(this.tbx_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(541, 16);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 15;
            this.lbl_Search.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.tbx_Search);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.gbx_Update);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_Update.ResumeLayout(false);
            this.gbx_Update.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.GroupBox gbx_Update;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tbx_UpdatedName;
        private System.Windows.Forms.TextBox tbx_UpdatedStockAmount;
        private System.Windows.Forms.Label lbl_UpdatedName;
        private System.Windows.Forms.Label lbl_UpdatedStockAmount;
        private System.Windows.Forms.Label lbl_UpdatedPrice;
        private System.Windows.Forms.TextBox tbx_UpdatedPrice;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_StockAmount;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_StockAmount;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tbx_Price;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Label lbl_Search;
    }
}

