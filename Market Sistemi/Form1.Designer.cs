namespace Market_Sistemi
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.kasabtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.kasabtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 554);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.button1.Location = new System.Drawing.Point(23, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ürün İşlemlerini Aç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.btnCategory.Location = new System.Drawing.Point(23, 35);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(167, 62);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Kategori İşlemlerini Aç";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(267, 67);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(616, 344);
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // cmbKamera
            // 
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Location = new System.Drawing.Point(267, 24);
            this.cmbKamera.Name = "cmbKamera";
            this.cmbKamera.Size = new System.Drawing.Size(616, 24);
            this.cmbKamera.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Başlat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(267, 431);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(616, 22);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.Text = " ";
            // 
            // kasabtn
            // 
            this.kasabtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.kasabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.kasabtn.Location = new System.Drawing.Point(23, 273);
            this.kasabtn.Name = "kasabtn";
            this.kasabtn.Size = new System.Drawing.Size(167, 62);
            this.kasabtn.TabIndex = 3;
            this.kasabtn.Text = "Kasa İşlemleri";
            this.kasabtn.UseVisualStyleBackColor = false;
            this.kasabtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbKamera);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button kasabtn;
    }
}

