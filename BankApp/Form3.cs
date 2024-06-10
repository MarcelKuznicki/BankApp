using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace BankApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        string connectionString = "Data Source=STACJA771\\SQLEXPRESS;Initial Catalog=DBbank;Integrated Security=True;User ID=AD\\m.kuznicki;";
        //Rejestracja dane

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox6.Text;
            string pin = textBox2.Text;
            string birth = $"{textBox8.Text}-{textBox7.Text}-{textBox5.Text}";
            string phone = textBox3.Text;
            string pesel = textBox4.Text;



            if (name.Length>=1)
            {
                if (lastname.Length>=1)
                {
                    if (pin.Length==4 && pin.All(char.IsDigit))
                    {
                        if (birth.Length==10 && textBox8.Text.All(char.IsDigit) && textBox7.Text.All(char.IsDigit) &&textBox5.Text.All(char.IsDigit))
                        {
                            if (phone.Length==9 && phone.All(char.IsDigit))
                            {
                                if (pesel.Length==11 && pesel.All(char.IsDigit))
                                {
                                    using (SqlConnection sc = new SqlConnection(connectionString))
                                    {
                                        string command = $"INSERT INTO [DBbank].[dbo].[Klienci] ([imie],[nazwisko],[pin],[data_urodzenia],[numer_tel],[pesel],[stan_konta])\r\n  VALUES ('{name}','{lastname}','{pin}','{birth}',{phone},{pesel},0);";
                                        using (SqlCommand cmd = new SqlCommand(command, sc))
                                        {
                                            sc.Open();
                                            cmd.ExecuteNonQuery();
                                            sc.Close();
                                        }
                                    }
                                    MessageBox.Show($"Zarejestrowano użytkownika:\n{name}\n{lastname}\n{pin}\n{birth}\n{phone}\n{pesel}");
                                }
                                else
                                {
                                    MessageBox.Show($"popraw pesel");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"popraw numer tel");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"popraw date urodzenia");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"popraw pin");
                    }
                }
                else
                {
                    MessageBox.Show($"uzupełnij nazwisko");
                }
            }
            else
            {
                MessageBox.Show($"uzupełnij imię");
            }
        }
    }
}
