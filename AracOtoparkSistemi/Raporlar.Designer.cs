namespace AracOtoparkSistemi
{
    partial class Raporlar
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
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toplamaracgirisi = new System.Windows.Forms.Label();
            this.toplamkalissuresi = new System.Windows.Forms.Label();
            this.toplamalinanucret = new System.Windows.Forms.Label();
            this.ortalama = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.Location = new System.Drawing.Point(30, 39);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.baslangicTarihi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.Location = new System.Drawing.Point(252, 39);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.bitisTarihi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam Araç Girişi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Kalış Süresi: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Toplam Alınan Ücret :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Araç Başı Ortalama Kalış Süresi:";
            // 
            // toplamaracgirisi
            // 
            this.toplamaracgirisi.AutoSize = true;
            this.toplamaracgirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplamaracgirisi.Location = new System.Drawing.Point(326, 82);
            this.toplamaracgirisi.Name = "toplamaracgirisi";
            this.toplamaracgirisi.Size = new System.Drawing.Size(15, 20);
            this.toplamaracgirisi.TabIndex = 3;
            this.toplamaracgirisi.Text = "-";
            // 
            // toplamkalissuresi
            // 
            this.toplamkalissuresi.AutoSize = true;
            this.toplamkalissuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplamkalissuresi.Location = new System.Drawing.Point(326, 116);
            this.toplamkalissuresi.Name = "toplamkalissuresi";
            this.toplamkalissuresi.Size = new System.Drawing.Size(15, 20);
            this.toplamkalissuresi.TabIndex = 3;
            this.toplamkalissuresi.Text = "-";
            // 
            // toplamalinanucret
            // 
            this.toplamalinanucret.AutoSize = true;
            this.toplamalinanucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplamalinanucret.Location = new System.Drawing.Point(326, 150);
            this.toplamalinanucret.Name = "toplamalinanucret";
            this.toplamalinanucret.Size = new System.Drawing.Size(15, 20);
            this.toplamalinanucret.TabIndex = 3;
            this.toplamalinanucret.Text = "-";
            // 
            // ortalama
            // 
            this.ortalama.AutoSize = true;
            this.ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ortalama.Location = new System.Drawing.Point(326, 182);
            this.ortalama.Name = "ortalama";
            this.ortalama.Size = new System.Drawing.Size(15, 20);
            this.ortalama.TabIndex = 3;
            this.ortalama.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ortalama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toplamalinanucret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toplamkalissuresi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toplamaracgirisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.baslangicTarihi);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker baslangicTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bitisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label toplamaracgirisi;
        private System.Windows.Forms.Label toplamkalissuresi;
        private System.Windows.Forms.Label toplamalinanucret;
        private System.Windows.Forms.Label ortalama;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}