namespace WindowsFormsApp16
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
            this.Y1 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.Label();
            this.Y3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.T2 = new System.Windows.Forms.Timer(this.components);
            this.T3 = new System.Windows.Forms.Timer(this.components);
            this.sonuclar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Y1
            // 
            this.Y1.BackColor = System.Drawing.Color.Red;
            this.Y1.ForeColor = System.Drawing.Color.White;
            this.Y1.Location = new System.Drawing.Point(0, 36);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(70, 16);
            this.Y1.TabIndex = 0;
            this.Y1.Text = "yarışmacı1";
            // 
            // Y2
            // 
            this.Y2.BackColor = System.Drawing.Color.Blue;
            this.Y2.ForeColor = System.Drawing.Color.White;
            this.Y2.Location = new System.Drawing.Point(0, 75);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(70, 16);
            this.Y2.TabIndex = 1;
            this.Y2.Text = "yarışmacı2";
            // 
            // Y3
            // 
            this.Y3.BackColor = System.Drawing.Color.Purple;
            this.Y3.ForeColor = System.Drawing.Color.White;
            this.Y3.Location = new System.Drawing.Point(0, 110);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(70, 16);
            this.Y3.TabIndex = 2;
            this.Y3.Text = "yarışmacı3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 259);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "yarış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // T2
            // 
            this.T2.Tick += new System.EventHandler(this.T2_Tick);
            // 
            // T3
            // 
            this.T3.Tick += new System.EventHandler(this.T3_Tick);
            // 
            // sonuclar
            // 
            this.sonuclar.FormattingEnabled = true;
            this.sonuclar.Location = new System.Drawing.Point(652, 110);
            this.sonuclar.Name = "sonuclar";
            this.sonuclar.Size = new System.Drawing.Size(120, 95);
            this.sonuclar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.sonuclar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Name = "Form1";
            this.Text = "yarış simülasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.Label Y2;
        private System.Windows.Forms.Label Y3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.Timer T2;
        private System.Windows.Forms.Timer T3;
        private System.Windows.Forms.ListBox sonuclar;
    }
}

