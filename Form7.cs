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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите название спциальности");
                return;
            }
            else
                 if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите квалификацию специальности");
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
