namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //wybor login
        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
        //wybor rejestracja
        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}