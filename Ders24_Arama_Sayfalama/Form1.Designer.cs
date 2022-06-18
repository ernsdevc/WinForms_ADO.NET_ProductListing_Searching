
namespace Ders24_Arama_Sayfalama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.lst_urunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.txt_sayfano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_urunsayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(161, 76);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(145, 20);
            this.txt_productName.TabIndex = 1;
            this.txt_productName.TextChanged += new System.EventHandler(this.txt_productName_TextChanged);
            // 
            // lst_urunler
            // 
            this.lst_urunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lst_urunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lst_urunler.FullRowSelect = true;
            this.lst_urunler.GridLines = true;
            this.lst_urunler.HideSelection = false;
            this.lst_urunler.Location = new System.Drawing.Point(161, 149);
            this.lst_urunler.Margin = new System.Windows.Forms.Padding(4);
            this.lst_urunler.Name = "lst_urunler";
            this.lst_urunler.Size = new System.Drawing.Size(724, 381);
            this.lst_urunler.TabIndex = 28;
            this.lst_urunler.UseCompatibleStateImageBehavior = false;
            this.lst_urunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÜRÜN ADI";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FİYAT";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STOK";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KATEGORİ";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MARKA";
            this.columnHeader6.Width = 217;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geri.Location = new System.Drawing.Point(317, 551);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(155, 52);
            this.btn_geri.TabIndex = 29;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ileri.Location = new System.Drawing.Point(584, 551);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(142, 52);
            this.btn_ileri.TabIndex = 30;
            this.btn_ileri.Text = "İLERİ";
            this.btn_ileri.UseVisualStyleBackColor = false;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // txt_sayfano
            // 
            this.txt_sayfano.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sayfano.Location = new System.Drawing.Point(478, 556);
            this.txt_sayfano.Name = "txt_sayfano";
            this.txt_sayfano.Size = new System.Drawing.Size(100, 38);
            this.txt_sayfano.TabIndex = 31;
            this.txt_sayfano.Text = "1";
            this.txt_sayfano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "ÜRÜN SAYISI";
            // 
            // lbl_urunsayisi
            // 
            this.lbl_urunsayisi.AutoSize = true;
            this.lbl_urunsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_urunsayisi.Location = new System.Drawing.Point(831, 47);
            this.lbl_urunsayisi.Name = "lbl_urunsayisi";
            this.lbl_urunsayisi.Size = new System.Drawing.Size(29, 31);
            this.lbl_urunsayisi.TabIndex = 33;
            this.lbl_urunsayisi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 615);
            this.Controls.Add(this.lbl_urunsayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sayfano);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lst_urunler);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.ListView lst_urunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.TextBox txt_sayfano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_urunsayisi;
    }
}

