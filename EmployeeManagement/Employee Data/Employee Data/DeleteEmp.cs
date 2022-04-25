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

namespace Employee_Data
{
    public partial class DeleteEmp : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public DeleteEmp()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SK\Desktop\Narayan Patel\vs codes\Employee Data\Employee Data\DD1.mdf;Integrated Security=True"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Delete from Employee Where Code=@Code", conn);
                cmd.Parameters.AddWithValue("@Code", textBox1.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Employee Data Deleted");
                }
                else MessageBox.Show("Employee Data Not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                conn.Close();
                this.Close();
            }
        }
    }
}
