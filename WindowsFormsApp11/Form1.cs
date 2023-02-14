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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection kon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ucenik\source\repos\WindowsFormsApp11\WindowsFormsApp11\Database1.mdf;Integrated Security=True");
        SqlCommand kom = new SqlCommand();
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            kom.Connection = kon;
            kom.CommandText = "" +
                "SELECT * FROM Rezultat";

            kon.Open();
            dr = kom.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem red = new ListViewItem(dr[0].ToString());

                for(int i = 1; i < 5; i++)
                {
                    red.SubItems.Add(dr[i].ToString());
                }

                listView1.Items.Add(red);
                kon.Close();
            }
        }
    }
}
