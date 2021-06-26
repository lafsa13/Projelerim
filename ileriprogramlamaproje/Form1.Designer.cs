namespace ileriprogramlamaproje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAç_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydet_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkış_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griyeÇevir_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifeÇevir_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.sıkıştır_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.netleştir_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sikistir_text = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAç_tool,
            this.dosyaKaydet_tool,
            this.çıkış_tool});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // dosyaAç_tool
            // 
            this.dosyaAç_tool.Name = "dosyaAç_tool";
            this.dosyaAç_tool.Size = new System.Drawing.Size(175, 26);
            this.dosyaAç_tool.Text = "Dosya Aç";
            this.dosyaAç_tool.Click += new System.EventHandler(this.dosyaAç_tool_Click);
            // 
            // dosyaKaydet_tool
            // 
            this.dosyaKaydet_tool.Name = "dosyaKaydet_tool";
            this.dosyaKaydet_tool.Size = new System.Drawing.Size(175, 26);
            this.dosyaKaydet_tool.Text = "Dosya Kaydet";
            this.dosyaKaydet_tool.Click += new System.EventHandler(this.dosyaKaydet_tool_Click);
            // 
            // çıkış_tool
            // 
            this.çıkış_tool.Name = "çıkış_tool";
            this.çıkış_tool.Size = new System.Drawing.Size(175, 26);
            this.çıkış_tool.Text = "Çıkış";
            this.çıkış_tool.Click += new System.EventHandler(this.çıkış_tool_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griyeÇevir_tool,
            this.negatifeÇevir_tool,
            this.sıkıştır_tool,
            this.netleştir_tool});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // griyeÇevir_tool
            // 
            this.griyeÇevir_tool.Name = "griyeÇevir_tool";
            this.griyeÇevir_tool.Size = new System.Drawing.Size(179, 26);
            this.griyeÇevir_tool.Text = "Griye Çevir";
            this.griyeÇevir_tool.Click += new System.EventHandler(this.griyeÇevir_tool_Click);
            // 
            // negatifeÇevir_tool
            // 
            this.negatifeÇevir_tool.Name = "negatifeÇevir_tool";
            this.negatifeÇevir_tool.Size = new System.Drawing.Size(179, 26);
            this.negatifeÇevir_tool.Text = "Negatife Çevir";
            this.negatifeÇevir_tool.Click += new System.EventHandler(this.negatifeÇevir_tool_Click);
            // 
            // sıkıştır_tool
            // 
            this.sıkıştır_tool.Name = "sıkıştır_tool";
            this.sıkıştır_tool.Size = new System.Drawing.Size(179, 26);
            this.sıkıştır_tool.Text = "Sıkıştır";
            this.sıkıştır_tool.Click += new System.EventHandler(this.sıkıştır_tool_Click);
            // 
            // netleştir_tool
            // 
            this.netleştir_tool.Name = "netleştir_tool";
            this.netleştir_tool.Size = new System.Drawing.Size(179, 26);
            this.netleştir_tool.Text = "Netleştir";
            this.netleştir_tool.Click += new System.EventHandler(this.netleştir_tool_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(21, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(906, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(433, 490);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::ileriprogramlamaproje.Properties.Resources.arkaplan;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.sikistir_text);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 600);
            this.panel1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(527, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Sıkıştırmak İstediğiniz Miktar :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // sikistir_text
            // 
            this.sikistir_text.BackColor = System.Drawing.SystemColors.Control;
            this.sikistir_text.Location = new System.Drawing.Point(713, 98);
            this.sikistir_text.Name = "sikistir_text";
            this.sikistir_text.Size = new System.Drawing.Size(100, 22);
            this.sikistir_text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1402, 607);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Görüntü İşleme";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAç_tool;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydet_tool;
        private System.Windows.Forms.ToolStripMenuItem çıkış_tool;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griyeÇevir_tool;
        private System.Windows.Forms.ToolStripMenuItem negatifeÇevir_tool;
        private System.Windows.Forms.ToolStripMenuItem sıkıştır_tool;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem netleştir_tool;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox sikistir_text;
    }
}

