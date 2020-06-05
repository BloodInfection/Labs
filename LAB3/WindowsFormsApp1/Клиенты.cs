using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Клиенты : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-5BNL913\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");
        public Клиенты()
        {
            InitializeComponent();
        }

        private void Клиенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.bankDataSet.Client);
            con1.Open();
            load_data();
        }

        private void load_data()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT Client.IdClient AS [ID клиента], Account.IdAccount as [ID кредита], ClientFIO AS ФИО, ClientPassport AS Паспорт,  CashTaken AS [Получено], CashGiven AS [Отдано] FROM Client left join Account on Account.IdClient = Client.IdClient", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT IdClient AS ID, ClientFIO AS ФИО, ClientPassport AS Паспорт  FROM Client WHERE ClientFIO = '" + fio.Text + "'", con1);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT   IdAccount AS ID, IdClient AS Клиент, CashTaken AS [Получено], CashGiven AS [Отдано] FROM Account  WHERE IdClient = (SELECT IdClient FROM Client WHERE ClientFIO LIKE '%" + fio.Text + "%') ", con1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Вход form_enter;
            form_enter = new Вход();
            this.Hide();
            form_enter.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        string read_client_id() // считывание айди клиента
        {

            String client_id = null;
            SqlCommand cmd = new SqlCommand("SELECT IdClient FROM Client where ClientFIO = '" + client.Text + "'", con1);

            SqlDataReader reader_client = cmd.ExecuteReader();
            reader_client.Read();
            client_id = Convert.ToString(reader_client["IdClient"]);
            reader_client.Close();
            return client_id;


        }

        private void savebutton_Click(object sender, EventArgs e)
        {
           

            

            SqlCommand cmd = new SqlCommand("INSERT INTO Client(ClientFIO, ClientPassport) VALUES('" + clientfio.Text + "', '" + clientpassport.Text +  "')", con1);
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Запись сохранена!");
            
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("DELETE FROM Account WHERE IdClient='" + clientid.Text + "'", con1);
            SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE IdClient='" + clientid.Text + "'", con1);
            cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            load_data();
            MessageBox.Show("Клиент и кредиты удалены!");
        }

        private void updateinfo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Client SET ClientFIO = '" + clientfio.Text + "',  ClientPassport = '" + clientpassport.Text + "' WHERE IdClient = '" + clientid.Text + "' ", con1);
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Запись обновлена!");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveac_Click(object sender, EventArgs e)
        {
            string clientid = read_client_id();
            SqlCommand cmd = new SqlCommand("INSERT INTO Account(IdClient, CashTaken, CashGiven) VALUES('" + clientid + "', '" + cashtaken.Text + "', '" + cashgiven.Text + "')", con1);
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Запись сохранена!");
        }

        private void deleteac_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Account WHERE IdAccount='" + accountid.Text + "'", con1);
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Запись удалена!");
        }

        private void updateac_Click(object sender, EventArgs e)
        {
            string clientid = read_client_id();
            SqlCommand cmd = new SqlCommand("UPDATE Account SET IdClient = '" + clientid + "',  CashTaken = '" + cashtaken.Text + "' , CashGiven = '" + cashgiven.Text + "' WHERE IdAccount = '" + accountid.Text + "' ", con1);
            cmd.ExecuteNonQuery();
            load_data();
            MessageBox.Show("Запись обновлена!");
        }
    }
}
