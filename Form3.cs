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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace g
{
    public partial class Form3 : Form
    {
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
            table();
        }
        void table()
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT Discipline_id, Name AS Название, KolHourPractZan AS 'Кол-во часов на лекции', KolHourlecture AS 'Кол-во часов на пркактические' FROM `Disciplines`", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
                guna2DataGridView1.Columns[0].Visible = false;
            }
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Text = "Добавление дисциплины";
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO `Disciplines`(`Name`, `KolHourPractZan`, `KolHourlecture`, `Discipline_id`) " +
                    $"VALUES ('{form.textBox1.Text}','{form.textBox3.Text}','{form.textBox2.Text}',NULL)", conn);
                    cmd.ExecuteNonQuery();
                    table();
                }
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            int idrow = guna2DataGridView1.CurrentRow.Index;
            int idStud = Convert.ToInt32(guna2DataGridView1.Rows[idrow].Cells[0].Value);
            form.Text = "Редактирования дисциплины";
            form.textBox1.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[1].Value);
            form.textBox2.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[2].Value);
            form.textBox3.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[3].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand("UPDATE `Disciplines` SET " +
                    $"`Name`='{form.textBox1.Text}',`KolHourPractZan`='{form.textBox2.Text}'," +
                    $"`KolHourlecture`='{form.textBox3.Text}' WHERE Discipline_id = '{idStud}'", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            table();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверенны?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            int idrow = guna2DataGridView1.CurrentRow.Index;
            int idStud = Convert.ToInt32(guna2DataGridView1.Rows[idrow].Cells[0].Value);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"DELETE FROM `Disciplines` WHERE Discipline_id ={idStud}", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            table();
        }
    }
}
