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

namespace Study
{
    public partial class Add : Form
    {

        public string connectionString = "Data Source=(local)\\sqlexpress;Initial Catalog=kirill;Integrated Security=True";

        private string _type;
        public Add(string s1, string s2, string s3, string s4, string type)
        { 
            InitializeComponent();
            label1.Text = s1;
            label2.Text = s2;
            label3.Text = s3;
            label4.Text = s4;
            label5.Visible = false;
            textBox5.Visible = false;
            _type = type;
        }

        public Add(string s1, string s2, string s3, string s4, string s5, string type)
        {
            InitializeComponent();
            label1.Text = s1;
            label2.Text = s2;
            label3.Text = s3;
            label4.Text = s4;
            label5.Text = s5;
            _type = type;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch(_type)
            {
                case "S":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {  
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка добавлена!");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    break;
                case "T":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO PREPODAVATEL VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка добавлена!");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                case "O":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO PREDMET VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка добавлена!");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                case "C":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO KURSOVAYA VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка добавлена!");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
