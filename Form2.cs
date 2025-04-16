using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace g
{
    public partial class Form2 : Form
    {
        private DateTime startTime;
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
            table();
            Form1 form1 = new Form1();
            toolStripStatusLabel1.Text = form1.textBox1.Text;
            timer1.Start();
        }
        void table()
        {
            using(MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
            cmd = new MySqlCommand("SELECT Lessons_id AS '№\nп/п',Date,LessonTopic,Vid_Zanit,Homework FROM `Lessons`", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable; 
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT FIO FROM Teacher", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["FIO"].ToString());
                    }
                }
            }
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ааToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void занятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void преподователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox3.Text = "";
                cmd = new MySqlCommand($"SELECT DISTINCT year FROM Year WHERE Prepodov_id = (SELECT Prepodov_id FROM Teacher WHERE FIO = '{comboBox1.Text}')", conn);
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["year"].ToString());
                    }
                }
            }
            guna2HtmlLabel1.Text = $"Календарно-тематический план по дисциплине {comboBox2.Text} преподователь {comboBox1.Text}";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT Lessons_id AS '№\nп/п',Date,LessonTopic,Vid_Zanit,Homework FROM `Lessons` " +
                    $"WHERE Prepodov_id = (SELECT Prepodov_id FROM Teacher WHERE FIO = '{comboBox1.Text}') ", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
                guna2HtmlLabel1.Text = $"Календарно-тематический план по дисциплине {comboBox2.Text} преподователь {comboBox1.Text}";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                cmd = new MySqlCommand("SELECT Name FROM Disciplines " +
                    "WHERE Discipline_id IN " +
                    "(SELECT Discipline_id FROM Year WHERE Prepodov_id = " +
                    $"(SELECT Prepodov_id FROM Teacher WHERE FIO = '{comboBox1.Text}') " +
                    $"AND year = '{comboBox3.Text}')", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["name"].ToString());
                    }
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            toolStripStatusLabel2.Text = $"{currentTime:dd.MM.yyyy} {currentTime:HH:mm:ss}";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }
    }
}
