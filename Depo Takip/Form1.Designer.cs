namespace Depo_Takip
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrunAdeti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbUrunAdi = new System.Windows.Forms.TextBox();
            this.tbStokKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGelisFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSatisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tbStokKoduGetir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStokKodGetir = new System.Windows.Forms.Button();
            this.tbUrunAdiGetir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUrunAdiGetir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSaat = new System.Windows.Forms.Label();
            this.lbTarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnListeGuncelle = new System.Windows.Forms.Button();
            this.tbKdv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // tbUrunAdeti
            // 
            this.tbUrunAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUrunAdeti.Location = new System.Drawing.Point(119, 67);
            this.tbUrunAdeti.Name = "tbUrunAdeti";
            this.tbUrunAdeti.Size = new System.Drawing.Size(74, 24);
            this.tbUrunAdeti.TabIndex = 4;
            this.tbUrunAdeti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrunAdeti_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adeti:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(1, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 499);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUrunAdi.Location = new System.Drawing.Point(119, 36);
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(191, 24);
            this.tbUrunAdi.TabIndex = 15;
            // 
            // tbStokKodu
            // 
            this.tbStokKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbStokKodu.Location = new System.Drawing.Point(119, 8);
            this.tbStokKodu.Name = "tbStokKodu";
            this.tbStokKodu.Size = new System.Drawing.Size(191, 24);
            this.tbStokKodu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stok Kodu :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(28, 122);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(153, 49);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(346, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Yeni Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(505, 122);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(153, 49);
            this.btnUrunSil.TabIndex = 10;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnDepoCikisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(361, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "KDV %";
            // 
            // tbGelisFiyati
            // 
            this.tbGelisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGelisFiyati.Location = new System.Drawing.Point(435, 34);
            this.tbGelisFiyati.Name = "tbGelisFiyati";
            this.tbGelisFiyati.Size = new System.Drawing.Size(74, 24);
            this.tbGelisFiyati.TabIndex = 22;
            this.tbGelisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGelisFiyati_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(329, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Geliş Fiyatı:";
            // 
            // tbSatisFiyati
            // 
            this.tbSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisFiyati.Location = new System.Drawing.Point(435, 64);
            this.tbSatisFiyati.Name = "tbSatisFiyati";
            this.tbSatisFiyati.Size = new System.Drawing.Size(74, 24);
            this.tbSatisFiyati.TabIndex = 24;
            this.tbSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSatisFiyati_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(329, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Satış Fiyatı:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(664, 122);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 49);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // tbStokKoduGetir
            // 
            this.tbStokKoduGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbStokKoduGetir.Location = new System.Drawing.Point(634, 8);
            this.tbStokKoduGetir.Name = "tbStokKoduGetir";
            this.tbStokKoduGetir.Size = new System.Drawing.Size(191, 22);
            this.tbStokKoduGetir.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(540, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Stok Kodu :";
            // 
            // btnStokKodGetir
            // 
            this.btnStokKodGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStokKodGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokKodGetir.Location = new System.Drawing.Point(844, 5);
            this.btnStokKodGetir.Name = "btnStokKodGetir";
            this.btnStokKodGetir.Size = new System.Drawing.Size(127, 25);
            this.btnStokKodGetir.TabIndex = 28;
            this.btnStokKodGetir.Text = "Ürünü Bul";
            this.btnStokKodGetir.UseVisualStyleBackColor = false;
            this.btnStokKodGetir.Click += new System.EventHandler(this.btnStokKodGetir_Click);
            // 
            // tbUrunAdiGetir
            // 
            this.tbUrunAdiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUrunAdiGetir.Location = new System.Drawing.Point(634, 38);
            this.tbUrunAdiGetir.Name = "tbUrunAdiGetir";
            this.tbUrunAdiGetir.Size = new System.Drawing.Size(191, 22);
            this.tbUrunAdiGetir.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(551, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ürün Adı:";
            // 
            // btnUrunAdiGetir
            // 
            this.btnUrunAdiGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunAdiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAdiGetir.Location = new System.Drawing.Point(844, 37);
            this.btnUrunAdiGetir.Name = "btnUrunAdiGetir";
            this.btnUrunAdiGetir.Size = new System.Drawing.Size(127, 25);
            this.btnUrunAdiGetir.TabIndex = 31;
            this.btnUrunAdiGetir.Text = "Ürünü Bul";
            this.btnUrunAdiGetir.UseVisualStyleBackColor = false;
            this.btnUrunAdiGetir.Click += new System.EventHandler(this.btnUrunAdiGetir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(992, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Saat :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(988, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tarih :";
            // 
            // lbSaat
            // 
            this.lbSaat.AutoSize = true;
            this.lbSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSaat.Location = new System.Drawing.Point(1050, 12);
            this.lbSaat.Name = "lbSaat";
            this.lbSaat.Size = new System.Drawing.Size(26, 18);
            this.lbSaat.TabIndex = 34;
            this.lbSaat.Text = "00";
            // 
            // lbTarih
            // 
            this.lbTarih.AutoSize = true;
            this.lbTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTarih.Location = new System.Drawing.Point(1050, 42);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(26, 18);
            this.lbTarih.TabIndex = 35;
            this.lbTarih.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnListeGuncelle
            // 
            this.btnListeGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeGuncelle.Location = new System.Drawing.Point(823, 122);
            this.btnListeGuncelle.Name = "btnListeGuncelle";
            this.btnListeGuncelle.Size = new System.Drawing.Size(153, 49);
            this.btnListeGuncelle.TabIndex = 36;
            this.btnListeGuncelle.Text = "Listeyi Güncelle";
            this.btnListeGuncelle.UseVisualStyleBackColor = false;
            this.btnListeGuncelle.Click += new System.EventHandler(this.btnListeGuncelle_Click);
            // 
            // tbKdv
            // 
            this.tbKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKdv.Location = new System.Drawing.Point(435, 5);
            this.tbKdv.Name = "tbKdv";
            this.tbKdv.Size = new System.Drawing.Size(74, 24);
            this.tbKdv.TabIndex = 38;
            this.tbKdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKdv_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(187, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 49);
            this.button1.TabIndex = 39;
            this.button1.Text = "Ürün Adeti Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKdv);
            this.Controls.Add(this.btnListeGuncelle);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.lbSaat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUrunAdiGetir);
            this.Controls.Add(this.tbUrunAdiGetir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnStokKodGetir);
            this.Controls.Add(this.tbStokKoduGetir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.tbSatisFiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGelisFiyati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tbStokKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.tbUrunAdeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrunAdeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbUrunAdi;
        private System.Windows.Forms.TextBox tbStokKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGelisFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSatisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox tbStokKoduGetir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStokKodGetir;
        private System.Windows.Forms.TextBox tbUrunAdiGetir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUrunAdiGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSaat;
        private System.Windows.Forms.Label lbTarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnListeGuncelle;
        private System.Windows.Forms.TextBox tbKdv;
        private System.Windows.Forms.Button button1;
    }
}

