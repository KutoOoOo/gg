using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Form10 : Form
    {
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form10()
        {
            InitializeComponent();
            table();
        }
        void table()
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT Prepodov_id, FIO AS ФИО ,Doljn AS Должность,Email,Phone AS Телефон FROM `Teacher`", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
                guna2DataGridView1.Columns[0].Visible = false;
                guna2DataGridView1.Columns[2].Visible = false;
                guna2DataGridView1.Columns[3].Visible = false;
                guna2DataGridView1.Columns[4].Visible = false;
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Text = "Добавление преподавателя";
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO `Disciplines`(`Prepodov_id`, `FIO`, `Doljn`, `Email`,`Phone`) " +
                   $"VALUES (NULL,'{form.textBox1.Text}','{form.textBox2.Text}','{form.textBox3.Text}','{form.textBox4.Text}')", conn);
                    cmd.ExecuteNonQuery();
                    table();
                }
            }

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Text = "Редактирования преподавателя";
            int idrow = guna2DataGridView1.CurrentRow.Index;
            int idStud = Convert.ToInt32(guna2DataGridView1.Rows[idrow].Cells[0].Value);
            form.textBox1.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[1].Value);
            form.textBox2.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[2].Value);
            form.textBox3.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[3].Value);
            form.textBox4.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[4].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand("UPDATE `Teacher` SET " +
                 $"`FIO`='{form.textBox1.Text}',`Doljn`='{form.textBox2.Text}'," +
                 $"`Email`='{form.textBox3.Text}',`Phone`='{form.textBox4.Text}' WHERE Prepodov_id = '{idStud}'", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            table();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
                    cmd = new MySqlCommand($"DELETE FROM `Teacher` WHERE Prepodov_id ={idStud}", conn);
                    cmd.ExecuteNonQuery();
                }
                table();
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = guna2DataGridView1.CurrentRow.Index;
            guna2TextBox2.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[2].Value);
            guna2TextBox3.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[3].Value);
            guna2TextBox4.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[4].Value);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
