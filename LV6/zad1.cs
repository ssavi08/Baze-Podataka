using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baze_LV6_predlozak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            // OVDJE SLIJEDI PRIMJER IZ PREDLOŠKA:
            SqlConnection conn = new SqlConnection("Data Source=31.147.207.14;Initial Catalog=stuslu;User ID=student;Password=student");
            conn.Open();

            string statement = "SELECT * FROM student";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(statement, conn);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            dgvPodaci.DataSource = dt;
            conn.Close();

        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            // OVDJE PISATI KOD 1. ZADATKA IZ PREDLOŠKA:
            string imeT = txtIme.Text;
            string prezimeT = txtPrezime.Text;
            string value = "";
            bool isChecked = rbM.Checked;

            //prvjerava koje dugme stisnuto m il z
            if (isChecked)
                value = "M";
            else
                value = "F";

            SqlConnection conn = new SqlConnection("Data Source=31.147.207.14;Initial Catalog=stuslu; User ID=student; Password=student");
            conn.Open();

            string naredba = $"SELECT * FROM student WHERE ime LIKE '%{imeT}%' and prezime LIKE '%{prezimeT}%' and spol LIKE '{value}'";
            //% pokazuje sve znakove prije i poslje (ak upises sam jedno slovo nace ime sa tim slovom)

            //saljes string u ?bazu kao atribut 
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(naredba, conn);
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);
            dgvPodaci.DataSource = dt2;

            //Obavezno zatvort
            conn.Close();

        }
    }
}
