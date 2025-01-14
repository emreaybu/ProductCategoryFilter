namespace RecapProject1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.tbxProducts = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategory.SuspendLayout();
            this.gbxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(29, 26);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(695, 111);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(53, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 16);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(132, 46);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.tbxProducts);
            this.gbxProducts.Controls.Add(this.lblProducts);
            this.gbxProducts.Location = new System.Drawing.Point(29, 152);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Size = new System.Drawing.Size(695, 100);
            this.gbxProducts.TabIndex = 1;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxProducts
            // 
            this.tbxProducts.Location = new System.Drawing.Point(132, 52);
            this.tbxProducts.Name = "tbxProducts";
            this.tbxProducts.Size = new System.Drawing.Size(121, 22);
            this.tbxProducts.TabIndex = 1;
            this.tbxProducts.TextChanged += new System.EventHandler(this.tbxProducts_TextChanged);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(56, 52);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(50, 16);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Ürünler";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(29, 258);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(914, 637);
            this.dgwProducts.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 641);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxProducts);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProducts.ResumeLayout(false);
            this.gbxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.TextBox tbxProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

