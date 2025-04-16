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
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=Ychet;");
        MySqlCommand cmd;
        public Form6()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT Name FROM `Specialization`", conn);
                using(MySqlDataReader reader = cmd.ExecuteReader()) 
                { 
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Name"]);
                    }
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите название группы");
                return;
            }
            else
            DialogResult = DialogResult.OK;
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
