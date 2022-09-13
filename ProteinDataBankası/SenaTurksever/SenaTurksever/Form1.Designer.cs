namespace SenaTurksever
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSAYI = new System.Windows.Forms.TextBox();
            this.buttonBASLAT = new System.Windows.Forms.Button();
            this.buttonBUL = new System.Windows.Forms.Button();
            this.buttonBITIR = new System.Windows.Forms.Button();
            this.listboxTahminler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmininizi Giriniz(1000,9999):";
            // 
            // textSAYI
            // 
            this.textSAYI.Location = new System.Drawing.Point(236, 59);
            this.textSAYI.Name = "textSAYI";
            this.textSAYI.Size = new System.Drawing.Size(185, 22);
            this.textSAYI.TabIndex = 1;
            // 
            // buttonBASLAT
            // 
            this.buttonBASLAT.Location = new System.Drawing.Point(67, 310);
            this.buttonBASLAT.Name = "buttonBASLAT";
            this.buttonBASLAT.Size = new System.Drawing.Size(150, 42);
            this.buttonBASLAT.TabIndex = 2;
            this.buttonBASLAT.Text = "BAŞLAT";
            this.buttonBASLAT.UseVisualStyleBackColor = true;
            this.buttonBASLAT.Click += new System.EventHandler(this.buttonBASLAT_Click);
            // 
            // buttonBUL
            // 
            this.buttonBUL.Location = new System.Drawing.Point(447, 49);
            this.buttonBUL.Name = "buttonBUL";
            this.buttonBUL.Size = new System.Drawing.Size(156, 43);
            this.buttonBUL.TabIndex = 3;
            this.buttonBUL.Text = "BUL";
            this.buttonBUL.UseVisualStyleBackColor = true;
            this.buttonBUL.Click += new System.EventHandler(this.buttonBUL_Click);
            // 
            // buttonBITIR
            // 
            this.buttonBITIR.Location = new System.Drawing.Point(447, 310);
            this.buttonBITIR.Name = "buttonBITIR";
            this.buttonBITIR.Size = new System.Drawing.Size(156, 42);
            this.buttonBITIR.TabIndex = 4;
            this.buttonBITIR.Text = "BİTİR";
            this.buttonBITIR.UseVisualStyleBackColor = true;
            this.buttonBITIR.Click += new System.EventHandler(this.buttonBITIR_Click);
            // 
            // listboxTahminler
            // 
            this.listboxTahminler.FormattingEnabled = true;
            this.listboxTahminler.ItemHeight = 16;
            this.listboxTahminler.Location = new System.Drawing.Point(137, 120);
            this.listboxTahminler.Name = "listboxTahminler";
            this.listboxTahminler.Size = new System.Drawing.Size(390, 164);
            this.listboxTahminler.TabIndex = 5;
            this.listboxTahminler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(413, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sena Türksever 201613172016 Bilgisayar Müh. 2.Öğretim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listboxTahminler);
            this.Controls.Add(this.buttonBITIR);
            this.Controls.Add(this.buttonBUL);
            this.Controls.Add(this.buttonBASLAT);
            this.Controls.Add(this.textSAYI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sena Turksever Tahmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSAYI;
        private System.Windows.Forms.Button buttonBASLAT;
        private System.Windows.Forms.Button buttonBUL;
        private System.Windows.Forms.Button buttonBITIR;
        private System.Windows.Forms.ListBox listboxTahminler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

