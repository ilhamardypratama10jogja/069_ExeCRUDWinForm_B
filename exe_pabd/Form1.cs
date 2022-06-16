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

namespace exe_pabd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection("Data Source=ILHAMARDY2001;Initial Catalog=exepabd;User ID=sa;Password=1234");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where NamaUser = '" + textBox1.Text + "'  and Password = '" +textBox2.Text + "'",koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home panggil = new Home();
                panggil.Show();
            }

            else
            {
                MessageBox.Show("mohon isis user name dan password dengan benar !", "perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
