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

namespace g
{
    public partial class Form4 : Form
    {
        Podcl podcl = new Podcl();
        MySqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            using(MySqlConnection conn = new MySqlConnection(podcl.str()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT FIO FROM Teacher", conn);
                using(var read = cmd.ExecuteReader())
                {
                    while(read.Read())
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
            DialogResult = DialogResult.OK;
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
