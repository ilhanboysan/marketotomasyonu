namespace Market_Sistemi
{
    partial class Kullanicilar_Frm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kasabtn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.kasabtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 524);
            this.panel1.TabIndex = 5;
            // 
            // kasabtn
            // 
            this.kasabtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.kasabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(62)))));
            this.kasabtn.Location = new System.Drawing.Point(27, 193);
            this.kasabtn.Name = "kasabtn";
            this.kasabtn.Size = new System.Drawing.Size(167, 62);
            this.kasabtn.TabIndex = 3;
            this.kasabtn.Text = "Kasa İşlemleri";
            this.kasabtn.UseVisualStyleBackColor = false;
            this.kasabtn.Click += new System.EventHandler(this.kasabtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBarcode.Location = new System.Drawing.Point(438, 428);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(616, 22);
            this.txtBarcode.TabIndex = 9;
            this.txtBarcode.Text = " ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Başlat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbKamera
            // 
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Location = new System.Drawing.Point(438, 21);
            this.cmbKamera.Name = "cmbKamera";
            this.cmbKamera.Size = new System.Drawing.Size(616, 24);
            this.cmbKamera.TabIndex = 7;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(438, 64);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(616, 344);
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // Kullanicilar_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1225, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbKamera);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Kullanicilar_Frm";
            this.Text = "Kullanicilar_Frm";
            this.Load += new System.EventHandler(this.Kullanicilar_Frm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kasabtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}