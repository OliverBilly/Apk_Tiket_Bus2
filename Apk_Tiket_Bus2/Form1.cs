using System;
using System.Globalization;
using System.Windows.Forms;

namespace Aplikasi_Pemesanan_Tiket_Bus
{
    public partial class Form1 : Form
    {
        // Gunakan culture Indonesia untuk format mata uang
        readonly CultureInfo id = new CultureInfo("id-ID");

        public Form1()
        {
            InitializeComponent();
        }

        // => Pastikan event Form1_Load terhubung di Designer (Load += Form1_Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Isi default pilihan (jika belum diisi lewat Designer)
            if (cmbTujuan.Items.Count == 0)
                cmbTujuan.Items.AddRange(new object[] { "Jakarta", "Bandung", "Yogyakarta", "Surabaya" });

            if (cmbJam.Items.Count == 0)
                cmbJam.Items.AddRange(new object[] { "06:00", "08:00", "10:00", "12:00", "14:00", "16:00", "18:00" });

            // Format tanggal
            if (dtpTanggal != null)
            {
                dtpTanggal.Format = DateTimePickerFormat.Custom;
                dtpTanggal.CustomFormat = "dd MMMM yyyy";
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil input dasar
                string nama = txtNama?.Text.Trim() ?? "";
                string hp = txtHp?.Text.Trim() ?? "";
                if (cmbTujuan.SelectedIndex < 0)
                {
                    MessageBox.Show("Pilih tujuan dulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTujuan.Focus();
                    return;
                }
                if (cmbJam.SelectedIndex < 0)
                {
                    MessageBox.Show("Pilih jam keberangkatan dulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbJam.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(nama))
                {
                    MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNama.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(hp))
                {
                    MessageBox.Show("Nomor HP harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHp.Focus();
                    return;
                }

                string tujuan = cmbTujuan.SelectedItem.ToString();
                string tanggal = dtpTanggal.Value.ToString("dd MMMM yyyy", id);
                string jam = cmbJam.SelectedItem.ToString();

                // Jumlah: coba parse dari txtDetailJumlah jika user isi manual, kalau tidak default 1
                int jumlah;
                if (!int.TryParse(txtDetailJumlah.Text.Trim(), out jumlah) || jumlah <= 0)
                {
                    jumlah = 1; // fallback
                }

                // Harga per tujuan (contoh)
                int hargaPerTiket = tujuan switch
                {
                    "Jakarta" => 150_000,
                    "Bandung" => 120_000,
                    "Yogyakarta" => 200_000,
                    "Surabaya" => 250_000,
                    _ => 100_000
                };

                int totalSebelumDiskon = hargaPerTiket * jumlah;
                int diskon = (jumlah >= 3) ? (int)Math.Round(totalSebelumDiskon * 0.10) : 0; // 10% jika >=3
                int totalBayar = totalSebelumDiskon - diskon;

                // Tampilkan hasil di TextBox detail (kanan)
                txtDetailNama.Text = nama;
                txtDetailTujuan.Text = tujuan;
                txtDetailTanggal.Text = tanggal;
                txtDetailJam.Text = jam;
                txtDetailJumlah.Text = jumlah.ToString(); // tampilkan angka bersih
                txtDetailHarga.Text = totalSebelumDiskon.ToString("C0", id); // format Rp
                txtDetailDiskon.Text = diskon.ToString("C0", id);
                txtDetailTotal.Text = totalBayar.ToString("C0", id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Kosongkan input kiri
            if (txtNama != null) txtNama.Clear();
            if (txtHp != null) txtHp.Clear();
            if (cmbTujuan != null) cmbTujuan.SelectedIndex = -1;
            if (cmbJam != null) cmbJam.SelectedIndex = -1;
            if (dtpTanggal != null) dtpTanggal.Value = DateTime.Today;

            // Kosongkan detail kanan
            if (txtDetailNama != null) txtDetailNama.Clear();
            if (txtDetailTujuan != null) txtDetailTujuan.Clear();
            if (txtDetailTanggal != null) txtDetailTanggal.Clear();
            if (txtDetailJam != null) txtDetailJam.Clear();
            if (txtDetailJumlah != null) txtDetailJumlah.Clear();
            if (txtDetailHarga != null) txtDetailHarga.Clear();
            if (txtDetailDiskon != null) txtDetailDiskon.Clear();
            if (txtDetailTotal != null) txtDetailTotal.Clear();

            txtNama?.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Handler kosong — ada di Designer, supaya tidak error bila event terpasang
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
