using Guna.UI2.WinForms;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите название");
                return;
            }
            else
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите часы на практику");
                return;
            }
            else
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Введите часы на лекции");
                return;
            }
            else
                DialogResult = DialogResult.OK;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }
            e.Handled = true;
        }
    }

}
