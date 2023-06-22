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

namespace disconected
{

    public partial class FormDataMahasiswa : Form
    {
        private string stringConnection = "data source=LAPTOP-MCSQI6HJ\\RICCO;" +
            "database=tes_disconeted;User ID=sa;Password=Slametriyadi18";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        private string kstr;
        public FormDataMahasiswa()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
