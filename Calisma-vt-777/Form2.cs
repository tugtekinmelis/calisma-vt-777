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

namespace Calisma_vt_777
{
    public partial class Form2 : Form
    {
        string baglantiMetin = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiMetin))
            {
                baglan.Open(); //veritabanı bağlanısını aç.
                string sorgu = "SELECT * FROM elestiriler;"; //sorgumuz.

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
