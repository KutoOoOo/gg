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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            guna2ComboBox1.DropDownStyle =ComboBoxStyle.DropDownList;
            
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы заблокировали пользователя");
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Text = "Редактирования пользователя";
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Text = "Добавление пользователя";
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
