using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form4 : Form
    {
        private string imie;

        public Form4(string imie)
        {
            InitializeComponent();
            this.imie=imie;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = imie;
        }
    }
}
