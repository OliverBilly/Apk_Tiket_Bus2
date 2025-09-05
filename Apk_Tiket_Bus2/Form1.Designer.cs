namespace Aplikasi_Pemesanan_Tiket_Bus
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTujuan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();

            this.lblDetail = new System.Windows.Forms.GroupBox();
            this.txtDetailNama = new System.Windows.Forms.TextBox();
            this.txtDetailTujuan = new System.Windows.Forms.TextBox();
            this.txtDetailTanggal = new System.Windows.Forms.TextBox();
            this.txtDetailJam = new System.Windows.Forms.TextBox();
            this.txtDetailJumlah = new System.Windows.Forms.TextBox();
            this.txtDetailHarga = new System.Windows.Forms.TextBox();
            this.txtDetailDiskon = new System.Windows.Forms.TextBox();
            this.txtDetailTotal = new System.Windows.Forms.TextBox();

            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();

            this.btnPesan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.groupBox1.SuspendLayout();
            this.lblDetail.SuspendLayout();
            this.SuspendLayout();

            // 
            // label1 (judul utama)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.Text = "PO MAJU JAYA TICKET SYSTEM";

            // 
            // groupBox1 (input pemesanan)
            // 
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTujuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpTanggal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbJam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(50, 80);
            this.groupBox1.Size = new System.Drawing.Size(350, 400);
            this.groupBox1.Text = "Pemesanan Tiket";

            // txtNama
            this.txtNama.Location = new System.Drawing.Point(20, 60);
            this.txtNama.Size = new System.Drawing.Size(300, 29);
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Text = "Nama Pemesan";

            // txtHp
            this.txtHp.Location = new System.Drawing.Point(20, 120);
            this.txtHp.Size = new System.Drawing.Size(300, 29);
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Text = "Nomor HP";

            // cmbTujuan
            this.cmbTujuan.Location = new System.Drawing.Point(20, 180);
            this.cmbTujuan.Size = new System.Drawing.Size(300, 29);
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 155);
            this.label4.Text = "Tujuan";

            // dtpTanggal
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.CustomFormat = "dd MMMM yyyy";
            this.dtpTanggal.Location = new System.Drawing.Point(20, 240);
            this.dtpTanggal.Size = new System.Drawing.Size(300, 29);
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 215);
            this.label5.Text = "Tanggal";

            // cmbJam
            this.cmbJam.Location = new System.Drawing.Point(20, 300);
            this.cmbJam.Size = new System.Drawing.Size(300, 29);
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 275);
            this.label6.Text = "Jam Keberangkatan";

            // 
            // lblDetail (detail tiket)
            // 
            this.lblDetail.Controls.Add(this.txtDetailNama);
            this.lblDetail.Controls.Add(this.label7);
            this.lblDetail.Controls.Add(this.txtDetailTujuan);
            this.lblDetail.Controls.Add(this.label8);
            this.lblDetail.Controls.Add(this.txtDetailTanggal);
            this.lblDetail.Controls.Add(this.label10);
            this.lblDetail.Controls.Add(this.txtDetailJam);
            this.lblDetail.Controls.Add(this.label11);
            this.lblDetail.Controls.Add(this.txtDetailJumlah);
            this.lblDetail.Controls.Add(this.label12);
            this.lblDetail.Controls.Add(this.txtDetailHarga);
            this.lblDetail.Controls.Add(this.label13);
            this.lblDetail.Controls.Add(this.txtDetailDiskon);
            this.lblDetail.Controls.Add(this.label14);
            this.lblDetail.Controls.Add(this.txtDetailTotal);
            this.lblDetail.Controls.Add(this.label15);
            this.lblDetail.Controls.Add(this.btnPesan);
            this.lblDetail.Controls.Add(this.btnClear);
            this.lblDetail.Controls.Add(this.btnExit);
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetail.Location = new System.Drawing.Point(450, 80);
            this.lblDetail.Size = new System.Drawing.Size(400, 400);
            this.lblDetail.Text = "Detail Tiket";

            // label7 s/d label15 (judul kolom)
            this.label7.Location = new System.Drawing.Point(20, 30); this.label7.Text = "Nama";
            this.label8.Location = new System.Drawing.Point(20, 70); this.label8.Text = "Tujuan";
            this.label10.Location = new System.Drawing.Point(20, 110); this.label10.Text = "Tanggal";
            this.label11.Location = new System.Drawing.Point(20, 150); this.label11.Text = "Jam";
            this.label12.Location = new System.Drawing.Point(20, 190); this.label12.Text = "Jumlah";
            this.label13.Location = new System.Drawing.Point(20, 230); this.label13.Text = "Harga";
            this.label14.Location = new System.Drawing.Point(20, 270); this.label14.Text = "Diskon";
            this.label15.Location = new System.Drawing.Point(20, 310); this.label15.Text = "Total Bayar";

            // txtDetailNama
            this.txtDetailNama.Location = new System.Drawing.Point(120, 25);
            this.txtDetailNama.Size = new System.Drawing.Size(250, 29);

            // txtDetailTujuan
            this.txtDetailTujuan.Location = new System.Drawing.Point(120, 65);
            this.txtDetailTujuan.Size = new System.Drawing.Size(250, 29);

            // txtDetailTanggal
            this.txtDetailTanggal.Location = new System.Drawing.Point(120, 105);
            this.txtDetailTanggal.Size = new System.Drawing.Size(250, 29);

            // txtDetailJam
            this.txtDetailJam.Location = new System.Drawing.Point(120, 145);
            this.txtDetailJam.Size = new System.Drawing.Size(250, 29);

            // txtDetailJumlah
            this.txtDetailJumlah.Location = new System.Drawing.Point(120, 185);
            this.txtDetailJumlah.Size = new System.Drawing.Size(250, 29);

            // txtDetailHarga
            this.txtDetailHarga.Location = new System.Drawing.Point(120, 225);
            this.txtDetailHarga.Size = new System.Drawing.Size(250, 29);

            // txtDetailDiskon
            this.txtDetailDiskon.Location = new System.Drawing.Point(120, 265);
            this.txtDetailDiskon.Size = new System.Drawing.Size(250, 29);

            // txtDetailTotal
            this.txtDetailTotal.Location = new System.Drawing.Point(120, 305);
            this.txtDetailTotal.Size = new System.Drawing.Size(250, 29);

            // btnPesan
            this.btnPesan.Location = new System.Drawing.Point(20, 350);
            this.btnPesan.Size = new System.Drawing.Size(90, 30);
            this.btnPesan.Text = "Pesan";
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(150, 350);
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(280, 350);
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.label1);
            this.Text = "Aplikasi Pemesanan Tiket Bus";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblDetail.ResumeLayout(false);
            this.lblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTujuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbJam;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.GroupBox lblDetail;
        private System.Windows.Forms.TextBox txtDetailNama;
        private System.Windows.Forms.TextBox txtDetailTujuan;
        private System.Windows.Forms.TextBox txtDetailTanggal;
        private System.Windows.Forms.TextBox txtDetailJam;
        private System.Windows.Forms.TextBox txtDetailJumlah;
        private System.Windows.Forms.TextBox txtDetailHarga;
        private System.Windows.Forms.TextBox txtDetailDiskon;
        private System.Windows.Forms.TextBox txtDetailTotal;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
