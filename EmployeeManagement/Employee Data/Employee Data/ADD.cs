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
    public partial class ADD : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader de;
        public ADD()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SK\Desktop\Narayan Patel\vs codes\Employee Data\Employee Data\DD1.mdf;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string gender = " ";
                if (M.Checked==true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                cmd = new SqlCommand("insert into Employee(Code,Name,Salary,Gender,ContactNumber,City) values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + gender + "','" + textBox4.Text + "','"+comboBox1.Text+"')", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                //M.Dispose();
                //F.Dispose();
               
                comboBox1.SelectedValue = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                this.Close();
        
            }
        }

        private void M_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void F_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
