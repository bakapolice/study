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
    public partial class Study : Form
    {
        public Study()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=(local)\\sqlexpress;Initial Catalog=kirill;Integrated Security=True";

        private void Study_Load(object sender, EventArgs e)
        {
            dataGrid_Students.Rows.Clear();
            dataGrid_Teachers.Rows.Clear();
            dataGrid_Objects.Rows.Clear();
            dataGrid_Curses.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Загрузка таблицы студентов
                SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT", connection);
                connection.Open();
                try
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while(dataReader.Read())
                    {
                        dataGrid_Students.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4]);
                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Загрузка таблицы преподавателей
                cmd = new SqlCommand("SELECT * FROM PREPODAVATEL", connection);
                connection.Open();
                try
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        dataGrid_Teachers.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Загрузка таблицы предметов
                cmd = new SqlCommand("SELECT * FROM PREDMET", connection);
                connection.Open();
                try
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        dataGrid_Objects.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Загрузка таблицы курсовых
                cmd = new SqlCommand("SELECT * FROM KURSOVAYA", connection);
                connection.Open();
                try
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        dataGrid_Curses.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
        }

        //Поиск курсовых по имени студента
        private void buttonSearchStudentCurse_Click(object sender, EventArgs e)
        {
            if(dataGrid_StudentsCurse.Columns.Count ==0)
            {
                dataGrid_StudentsCurse.Columns.Add("Сolumn1", "ID Студента");
                dataGrid_StudentsCurse.Columns.Add("Сolumn2", "Имя");
                dataGrid_StudentsCurse.Columns.Add("Сolumn3", "Группа");
                dataGrid_StudentsCurse.Columns.Add("Сolumn4", "ID Курсовой");
                dataGrid_StudentsCurse.Columns.Add("Сolumn5", "ID Предмета");
                dataGrid_StudentsCurse.Columns.Add("Сolumn6", "Название предмета");
                dataGrid_StudentsCurse.Columns.Add("Сolumn7", "ID Преподаватель");
                dataGrid_StudentsCurse.Columns.Add("Сolumn8", "Имя преподавателя");
                dataGrid_StudentsCurse.Columns.Add("Сolumn9", "Тема курсовой");
                dataGrid_StudentsCurse.Columns.Add("Сolumn10", "Оценка");
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentsCurseSearch('"+txtbxStudentName.Text+"')", connection);
                connection.Open();
                try
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        dataGrid_StudentsCurse.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4], dataReader[5], dataReader[6], dataReader[7], dataReader[8], dataReader[9]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Поиск курсовых по теме
        private void buttonSearchTheme_Click(object sender, EventArgs e)
        {
            if (dataGrid_ThemeCurse.Columns.Count == 0)
            {
                dataGrid_ThemeCurse.Columns.Add("Сolumn1", "ID Курсовой");
                dataGrid_ThemeCurse.Columns.Add("Сolumn2", "Тема курсовой");
                dataGrid_ThemeCurse.Columns.Add("Сolumn3", "ID Предмета");
                dataGrid_ThemeCurse.Columns.Add("Сolumn4", "Название предмета");
                dataGrid_ThemeCurse.Columns.Add("Сolumn5", "ID Преподавателя");
                dataGrid_ThemeCurse.Columns.Add("Сolumn6", "Имя преподавателя");
                dataGrid_ThemeCurse.Columns.Add("Сolumn7", "ID Студента");
                dataGrid_ThemeCurse.Columns.Add("Сolumn8", "Имя студента");
                dataGrid_ThemeCurse.Columns.Add("Сolumn9", "Группа");
                dataGrid_ThemeCurse.Columns.Add("Сolumn10", "Оценка");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CurseSearch('" + txtbxCurseTheme.Text + "')", connection);
                    connection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        dataGrid_ThemeCurse.Rows.Add(dataReader[0], dataReader[1], dataReader[2], dataReader[3], dataReader[4], dataReader[5], dataReader[6], dataReader[7], dataReader[8], dataReader[9]);
                    }
                    connection.Close();
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGrid_Students_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = dataGrid_Students.SelectedCells[0].RowIndex;
            int studentID = (int)dataGrid_Students.Rows[rowIndex].Cells[0].Value;
            int objectID = (int)dataGrid_Students.Rows[rowIndex].Cells[1].Value;
            string studentName = (string)dataGrid_Students.Rows[rowIndex].Cells[2].Value;
            string studentGroup = (string)dataGrid_Students.Rows[rowIndex].Cells[3].Value;
            string studentPhone = (string)dataGrid_Students.Rows[rowIndex].Cells[4].Value;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET ID_STUDENT ="+studentID.ToString()+" " +
            //        ", ID_PREDMET="+objectID.ToString()+", STUDENT_NAME='"+studentName+"', GROUP='"+studentGroup+"'," +
            //        " PHONE='"+studentPhone+"' WHERE ID_STUDENT="+studentID.ToString()+"", connection);
            //    connection.Open();
            //    try
            //    {
            //             cmd.ExecuteNonQuery();
            //connection.Close();
            //MessageBox.Show("Изменение сохранены!");
            //        connection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}

        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
           
            string tag = ((Button)sender).Tag.ToString();
            string s1, s2, s3, s4, s5;
            switch(tag)
            {
                case "Student":
                    s1 = dataGrid_Students.Columns[0].HeaderText;
                    s2 = dataGrid_Students.Columns[1].HeaderText;
                    s3 = dataGrid_Students.Columns[2].HeaderText;
                    s4 = dataGrid_Students.Columns[3].HeaderText;
                    s5 = dataGrid_Students.Columns[4].HeaderText;
                    Add add = new Add(s1,s2,s3,s4,s5, "S");
                    add.ShowDialog();
                    break;
                case "Teacher":
                    s1 = dataGrid_Teachers.Columns[0].HeaderText;
                    s2 = dataGrid_Teachers.Columns[1].HeaderText;
                    s3 = dataGrid_Teachers.Columns[2].HeaderText;
                    s4 = dataGrid_Teachers.Columns[3].HeaderText;
                    add = new Add(s1, s2, s3, s4, "T");
                    add.ShowDialog();
                    break;
                case "Object":
                    s1 = dataGrid_Objects.Columns[0].HeaderText;
                    s2 = dataGrid_Objects.Columns[1].HeaderText;
                    s3 = dataGrid_Objects.Columns[2].HeaderText;
                    s4 = dataGrid_Objects.Columns[3].HeaderText;
                    add = new Add(s1, s2, s3, s4, "O");
                    add.ShowDialog();
                    break;
                case "Curse":
                    s1 = dataGrid_Curses.Columns[0].HeaderText;
                    s2 = dataGrid_Curses.Columns[1].HeaderText;
                    s3 = dataGrid_Curses.Columns[2].HeaderText;
                    s4 = dataGrid_Curses.Columns[3].HeaderText;
                    s5 = dataGrid_Curses.Columns[4].HeaderText;
                    add = new Add(s1, s2, s3, s4, s5, "C");
                    add.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            string s1, s2, s3, s4, s5;
            switch (tag)
            {
                case "Student":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE ID_STUDENT=" + dataGrid_Students.Rows[dataGrid_Students.SelectedCells[0].RowIndex].Cells[0].Value.ToString() +"", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка удалена!");
                            Study_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                case "Teacher":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM PREPODAVATEL WHERE ID_PREPODAVATEL=" + dataGrid_Teachers.Rows[dataGrid_Teachers.SelectedCells[0].RowIndex].Cells[0].Value.ToString() + "", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка удалена!");
                            Study_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                case "Object":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM PREDMET WHERE ID_PREDMET=" + dataGrid_Objects.Rows[dataGrid_Objects.SelectedCells[0].RowIndex].Cells[0].Value.ToString() + "", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка удалена!");
                            Study_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    break;
                case "Curse":
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM KURSOVAYA WHERE ID_KURSOVAYA=" + dataGrid_Curses.Rows[dataGrid_Curses.SelectedCells[0].RowIndex].Cells[0].Value.ToString() + "", connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Строка удалена!");
                            Study_Load(sender, e);
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
