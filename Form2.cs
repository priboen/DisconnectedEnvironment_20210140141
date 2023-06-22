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
    public partial class FormDataProdi : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=activity6; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        double val = 0;

        private void refreshform()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public FormDataProdi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();

        }
        private void autoIDProdi()
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("Select count (id_prodi) from dbo.prodi", koneksi);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            koneksi.Close();
            i++;
            labelID.Text = "PRD" + val + i.ToString();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            autoIDProdi();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;
            string idProdi = labelID.Text;
            if (nmProdi == "")
            {
                MessageBox.Show("Masukan Nama Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.prodi (id_prodi, nama_prodi) values" +
                    " ('" + idProdi + "','" + nmProdi + "')";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter(idProdi, nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
        private void FormDataProdi_FormClose(object sender, EventArgs e)
        {
            FormHalamanUtama hu = new FormHalamanUtama();
            hu.Show();
            this.Hide();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }
    }
}
