using System;

namespace Market_Sistemi
{
    partial class Form2
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
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btnMW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.tboxProductPrice = new System.Windows.Forms.TextBox();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tboxDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(23, 12);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(749, 150);
            this.dgProduct.TabIndex = 0;
           
            // 
            // btnMW
            // 
            this.btnMW.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnMW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.btnMW.Location = new System.Drawing.Point(605, 201);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(167, 62);
            this.btnMW.TabIndex = 2;
            this.btnMW.Text = "Ana Ekrana Dön";
            this.btnMW.UseVisualStyleBackColor = false;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxProductBarcode);
            this.groupBox1.Controls.Add(this.tboxProductPrice);
            this.groupBox1.Controls.Add(this.tboxProductName);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(23, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Ürünü Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Barkodu Girin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Kategorisi Seçin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı Girin";
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Location = new System.Drawing.Point(16, 178);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(100, 22);
            this.tboxProductBarcode.TabIndex = 3;
            // 
            // tboxProductPrice
            // 
            this.tboxProductPrice.Location = new System.Drawing.Point(16, 133);
            this.tboxProductPrice.Name = "tboxProductPrice";
            this.tboxProductPrice.Size = new System.Drawing.Size(100, 22);
            this.tboxProductPrice.TabIndex = 2;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(16, 88);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(100, 22);
            this.tboxProductName.TabIndex = 1;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(16, 42);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(205, 24);
            this.cmbBoxCategory.TabIndex = 0;
            this.cmbBoxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCategory_SelectedIndexChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.tboxDelete);
            this.groupBox2.Location = new System.Drawing.Point(318, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 234);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜrünSil";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tboxDelete
            // 
            this.tboxDelete.Location = new System.Drawing.Point(6, 44);
            this.tboxDelete.Name = "tboxDelete";
            this.tboxDelete.Size = new System.Drawing.Size(180, 22);
            this.tboxDelete.TabIndex = 0;
            this.tboxDelete.TextChanged += new System.EventHandler(this.tboxDelete_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.dgProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnMW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.TextBox tboxProductPrice;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tboxDelete;
    }
}