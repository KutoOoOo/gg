using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g
{
    public partial class Form13 : Form
    {
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form13()
        {
            InitializeComponent();
            table();
        }
        void table()
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT DISTINCT l.Prepodov_id,  t.FIO, g.Name, l.Date FROM `Lessons` l " +
                    "JOIN `Teacher` t ON l.`Prepodov_id` JOIN `Groups` g ON l.`Group_id`", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
                guna2DataGridView1.ForeColor = Color.Black;
                guna2DataGridView1.Columns[0].Visible = false;
            }
        }
        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            int p=-1, g=-1;
            Form4 form = new Form4();
            form.Text = "Добавление занятия";
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"SELECT Prepodov_id FROM `Teacher` WHERE FIO = '{form.comboBox1.Text}'",conn);
                    using (var read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            p = Convert.ToInt32(read["Prepodov_id"].ToString());
                        }
                    }
                    cmd = new MySqlCommand($"SELECT Group_id FROM `Groups` WHERE Name = '{form.comboBox3.Text}'",conn);
                    using (var read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            g = Convert.ToInt32(read["Group_id"].ToString());
                        }
                    }
                    cmd = new MySqlCommand("INSERT INTO `Lessons`(`Prepodov_id`, `Lessons_id`, `Date`,`StartTime`,`TimeEnding`,`Group_id`,`Vid_Zanit`,`LessonTopic`,`Homework`) " +
                       $"VALUES (@prepod,NULL,'{form.guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")}','{form.guna2TextBox2.Text}','{form.guna2TextBox1.Text}',@group,'{form.comboBox4.Text}','{form.guna2TextBox3.Text}','{form.textBox1.Text}')", conn);
                    cmd.Parameters.AddWithValue("@prepod",p);
                    cmd.Parameters.AddWithValue("@group",g);
                     cmd.ExecuteNonQuery();
                }
                table();
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            int p = -1, g = -1;
            Form4 form = new Form4();
            form.Text = "Редактирование занятия";
            int idrow = guna2DataGridView1.CurrentRow.Index;
            int idStud = Convert.ToInt32(guna2DataGridView1.Rows[idrow].Cells[0].Value);
            form.guna2TextBox1.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[1].Value);
          
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"SELECT Prepodov_id FROM `Teacher` WHERE FIO = '{form.comboBox1.Text}'", conn);
                    using (var read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            p = Convert.ToInt32(read["Prepodov_id"].ToString());
                        }
                    }
                    cmd = new MySqlCommand($"SELECT Group_id FROM `Groups` WHERE Name = '{form.comboBox3.Text}'", conn);
                    using (var read = cmd.ExecuteReader())
                    {
                        if (read.Read())
                        {
                            g = Convert.ToInt32(read["Group_id"].ToString());
                        }
                    }
                    cmd = new MySqlCommand($"UPDATE `Lessons` SET @prepod," +
                        $"NULL,`Date`='{form.guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")}',`StartTime`='{form.guna2TextBox2.Text}'," +
                        $"`TimeEnding`='{form.guna2TextBox1.Text}',@group,`Vid_Zanit`='{form.comboBox4.Text}'," +
                        $"`LessonTopic`='{form.guna2TextBox3.Text}',`Homework`='{form.textBox1.Text}' " +
                        $"WHERE Lessons_id = '{idStud}'", conn);
                    cmd.Parameters.AddWithValue("@prepod", p);
                    cmd.Parameters.AddWithValue("@group", g);
                    cmd.ExecuteNonQuery();
                }
            }
            table();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                DialogResult result = MessageBox.Show("Вы уверенны?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error,
                  MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                int idrow = guna2DataGridView1.CurrentRow.Index;
                int idStud = Convert.ToInt32(guna2DataGridView1.Rows[idrow].Cells[0].Value);
                if (result == DialogResult.Yes)
                {
                    cmd = new MySqlCommand($"DELETE FROM `Lessons` WHERE Lessons_id ={idStud}", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            table();
        }
    }
}
