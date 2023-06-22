using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_6
{
    public partial class FormDataMahasiswa : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=activity6; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        public FormDataMahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnMahasiswa.BindingSource = this.customersBindingSource;
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            Prodicbx();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text.Trim();
            nama = txtNama.Text.Trim();
            jk = cbxJenisKelamin.SelectedItem.ToString();
            alamat = txtAlamat.Text.Trim();
            tgl = dtTanggalLahir.Value;
            prodi = cbxProdi.SelectedValue.ToString();
            /*int hs = 0;
            koneksi.Open();
            string strs = "select id_prodi from dbo.prodi where nama_prodi = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", prodi));
            SqlDataReader dr = cm.ExecuteReader();*/
            if (string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(jk) || string.IsNullOrEmpty(prodi))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO mahasiswa (nim, nama_mahasiswa, alamat, jenis_kel, id_prodi, tgl_lahir) VALUES (@nim, @nama_mahasiswa, @alamat, @jenis_kel, @id_prodi, @tgl_lahir)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.AddWithValue("@nim", nim);
                cmd.Parameters.AddWithValue("@nama_mahasiswa", nama);
                cmd.Parameters.AddWithValue("@jenis_kel", jk);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@tgl_lahir", tgl);
                cmd.Parameters.AddWithValue("@id_prodi", prodi);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Disimpan");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void FormDataMahasiswa_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.nim, m.nama_mahasiswa, " +
                "m.alamat, m.jenis_kel, m.tgl_lahir, p.nama_prodi From dbo.mahasiswa m " +
                "join dbo.prodi p on m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNIM.DataBindings.Add(new Binding("Text", this.customersBindingSource, "nim", true));
            this.txtNama.DataBindings.Add(new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.txtAlamat.DataBindings.Add(new Binding("Text", this.customersBindingSource, "alamat", true));
            this.cbxJenisKelamin.DataBindings.Add(new Binding("Text", this.customersBindingSource, "jenis_kel", true));
            this.dtTanggalLahir.DataBindings.Add(new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.cbxProdi.DataBindings.Add(new Binding("Text", this.customersBindingSource, "nama_prodi", true));
            koneksi.Close();

        }
        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.cbxJenisKelamin.DataBindings.Clear();
            this.cbxProdi.DataBindings.Clear();
            this.dtTanggalLahir.DataBindings.Clear();
        }
        private void refreshform()
        {
            txtNIM.Enabled = false;
            txtNama.Enabled = false;
            cbxJenisKelamin.Enabled = false;
            txtAlamat.Enabled = false;
            dtTanggalLahir.Enabled = false;
            cbxProdi.Enabled = false;
            btnAdd.Enabled = true; 
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormDataMahasiswa_Load();
        }
        private void Prodicbx()
        {
            koneksi.Open();
            string str = "select id_prodi, nama_prodi from dbo.prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            koneksi.Close();
            cbxProdi.DisplayMember = "nama_prodi";
            cbxProdi.ValueMember = "id_prodi";
            cbxProdi.DataSource = dt;
        }
        private void FormDataMahasiswa_FormClosed(object sender, EventArgs e)
        {
            FormHalamanUtama fm = new FormHalamanUtama();
            fm.Show();
            this.Hide();
        }

    }
}
