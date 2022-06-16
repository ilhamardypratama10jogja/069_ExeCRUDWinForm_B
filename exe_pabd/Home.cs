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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ILHAMARDY2001;Initial Catalog=exepabd;User ID=sa;Password=1234");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into UserTable values (@ID,@Name,@Age)",con);
            cmd.Parameters.AddWithValue("@ID",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Succesfully saved");





        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ILHAMARDY2001;Initial Catalog=exepabd;User ID=sa;Password=1234");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update  UserTable set Name=@Name, Age=@Age where ID =@ID", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Succesfully Updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ILHAMARDY2001;Initial Catalog=exepabd;User ID=sa;Password=1234");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete  UserTable where ID=@ID", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));


            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Succesfully Deleted");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ILHAMARDY2001;Initial Catalog=exepabd;User ID=sa;Password=1234");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select  * from UserTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    }
}
