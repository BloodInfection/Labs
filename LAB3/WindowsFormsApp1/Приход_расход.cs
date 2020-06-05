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
    public partial class Приход_расход : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-5BNL913\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");
        public Приход_расход()
        {
            InitializeComponent();
        }

        private void Приход_расход_Load(object sender, EventArgs e)
        {
            con1.Open();
            load_data();
        }

        private void load_data()
        {
            SqlDataAdapter da = new SqlDataAdapter("select sum(cashtaken) as Расход, sum(cashgiven) as Приход from account", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Вход form_enter;
            form_enter = new Вход();
            this.Hide();
            form_enter.Show();
        }
    }

}
