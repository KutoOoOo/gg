using Guna.UI2.WinForms;
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
    public partial class Form4 : Form
    {
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
            comboBox4.Items.Add("Лекция");
            comboBox4.Items.Add("Практическая");
            comboBox4.SelectedIndex = 0;
            guna2TextBox2.MaxLength = 5;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            MaskedTextBox maskedTextBox = new MaskedTextBox();
            maskedTextBox.Mask = "00:00"; 
            maskedTextBox.Size = new System.Drawing.Size(123, 23);
            maskedTextBox.ValidatingType = typeof(DateTime); 
            guna2TextBox2.Controls.Add(maskedTextBox);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            using (MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT FIO FROM Teacher", conn);
                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        comboBox1.Items.Add(read["FIO"].ToString());
                    }
                }
                comboBox1.SelectedIndex = 0;
                cmd = new MySqlCommand("SELECT Name FROM `Groups`", conn);
                using (var read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        comboBox3.Items.Add(read["Name"].ToString());
                    }
                }
                comboBox3.SelectedIndex = 0;
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("Не введенно врямя начала");
                return;
            }
            else
             if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Не введенно врямя окончания");
                return;
            }
            else
             if (string.IsNullOrWhiteSpace(guna2TextBox3.Text))
            {
                MessageBox.Show("Введите тему занятия");
                return;
            }
            else
                DialogResult = DialogResult.OK;
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)||Char.IsControl(e.KeyChar)||e.KeyChar==':')
            {
                return;
            }
            e.Handled = true;
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
