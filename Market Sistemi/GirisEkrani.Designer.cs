namespace Market_Sistemi
{
    partial class GirisEkrani
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
            this.logincontrolbtn = new System.Windows.Forms.Button();
            this.kaditext = new System.Windows.Forms.TextBox();
            this.pwtext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logincontrolbtn
            // 
            this.logincontrolbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logincontrolbtn.ForeColor = System.Drawing.Color.White;
            this.logincontrolbtn.Location = new System.Drawing.Point(24, 168);
            this.logincontrolbtn.Name = "logincontrolbtn";
            this.logincontrolbtn.Size = new System.Drawing.Size(214, 43);
            this.logincontrolbtn.TabIndex = 0;
            this.logincontrolbtn.Text = "Giriş Yap";
            this.logincontrolbtn.UseVisualStyleBackColor = false;
            this.logincontrolbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaditext
            // 
            this.kaditext.Location = new System.Drawing.Point(107, 54);
            this.kaditext.Name = "kaditext";
            this.kaditext.Size = new System.Drawing.Size(131, 22);
            this.kaditext.TabIndex = 2;
            // 
            // pwtext
            // 
            this.pwtext.Location = new System.Drawing.Point(107, 114);
            this.pwtext.Name = "pwtext";
            this.pwtext.Size = new System.Drawing.Size(131, 22);
            this.pwtext.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kaditext);
            this.groupBox1.Controls.Add(this.pwtext);
            this.groupBox1.Controls.Add(this.logincontrolbtn);
            this.groupBox1.Location = new System.Drawing.Point(90, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sifreniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adınız";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(479, 444);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logincontrolbtn;
        private System.Windows.Forms.TextBox kaditext;
        private System.Windows.Forms.TextBox pwtext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}