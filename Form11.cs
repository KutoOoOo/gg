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
    public partial class Form11 : Form
    {
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form11()
        {
            InitializeComponent();
            table();
        }
        void table()
        {
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT Group_id , Name AS Название FROM `Groups`", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
                guna2DataGridView1.Columns[0].Visible = false;
                conn.Close();
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Text = "Добавление группы";
            int i = -1;
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"SELECT Specialization_id FROM Specialization WHERE Name = '{form.comboBox1.Text}'", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            i = Convert.ToInt32(reader["Specialization_id"]);
                        }
                    }

                    cmd = new MySqlCommand("INSERT INTO `Groups`(`Group_id`, `Name`,`Specialization_id`) " +
                 $"VALUES (NULL,'{form.textBox1.Text}',{i})", conn);
                    cmd.ExecuteNonQuery();
                }
                table();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            int i = -1;
            Form6 form = new Form6();
            form.Text = "Редактирование группы";
            int idrow = guna2DataGridView1.CurrentRow.Index;
            int idStud = Convert.ToInt32(guna2DataGridView1.Rows[idrow].Cells[0].Value);
            form.textBox1.Text = Convert.ToString(guna2DataGridView1.Rows[idrow].Cells[1].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection(podcl.str()))
                {
                    conn.Open();
                    cmd = new MySqlCommand($"SELECT Specialization_id FROM Specialization WHERE Name = '{form.comboBox1.Text}'", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            i = Convert.ToInt32(reader["Specialization_id"]);
                        }
                    }
                    cmd = new MySqlCommand("UPDATE `Groups` SET " +
                 $"`Name`='{form.textBox1.Text}',`Doljn`='{i}'," +
               $" WHERE Group_id = '{idStud}'", conn);
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
                    cmd = new MySqlCommand($"DELETE FROM `Groups` WHERE Group_id ={idStud}", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            table();
            TopMost = true;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
