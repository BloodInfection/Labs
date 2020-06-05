using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
           

        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            Вход form_enter;
            form_enter = new Вход();


            if (this.passwordtextBox.Text == "1234")
            {
                form_enter.Left = this.Left;
                form_enter.Top = this.Top;
                this.Hide();
                form_enter.Show();
            }
            else MessageBox.Show("Неверный пароль. Попробуйте снова.");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
