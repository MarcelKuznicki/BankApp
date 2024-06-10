using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=STACJA771\\SQLEXPRESS;Initial Catalog=DBbank;Integrated Security=True;User ID=AD\\m.kuznicki;";
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();

            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string pin = textBox3.Text;


            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                sc.Open();
                string command = $"SELECT * FROM Klienci WHERE  imie = @imie  AND nazwisko = @nazwisko AND pin = @pin";
                using (SqlCommand cmd = new SqlCommand(command, sc))
                {

                    cmd.Parameters.AddWithValue("@imie", imie);
                    cmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                    cmd.Parameters.AddWithValue("@pin", pin);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show($"uzytkownik {imie} {nazwisko}");
                        Form4 form4 =  new Form4(imie);
                        form4.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("nie ma uzytkownika");
                    }
                    reader.Close();
                    sc.Close();
                }
            }
        }
    }
}
