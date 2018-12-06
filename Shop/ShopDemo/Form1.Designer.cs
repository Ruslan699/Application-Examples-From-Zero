namespace ShopDemo
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(888, 304);
            this.Name = "Form1";
            this.ResumeLayout(false);

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
    }
}

