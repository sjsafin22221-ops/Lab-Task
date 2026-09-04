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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Order_MAnagement_System
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Data Source=DESKTOP-3J9K0F2;Initial Catalog=master;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(ConnectionString))
                {
                    connect.Open();

                    string loginQuery = "SELECT * FROM loginpage WHERE UserName=@username AND Password=@password";

                    using (SqlCommand cmd = new SqlCommand(loginQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBox4.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}