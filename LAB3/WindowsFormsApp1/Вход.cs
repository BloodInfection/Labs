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
    public partial class Вход : Form
    {
        public Вход()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Авторизация form_login;
            form_login = new Авторизация();
            this.Hide();
            form_login.Show();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            Клиенты form_clients;
            form_clients = new Клиенты();
            this.Hide();
            form_clients.Show();
        }

        private void cash_Click(object sender, EventArgs e)
        {
            Приход_расход form_cash;
            form_cash = new Приход_расход();
            this.Hide();
            form_cash.Show();
        }
    }
}
