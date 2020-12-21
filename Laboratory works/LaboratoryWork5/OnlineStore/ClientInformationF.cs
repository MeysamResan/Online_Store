using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class ClientInformationF : Form
    {
        public ClientInformationF()
        {
            InitializeComponent();
        }

        private void ClientInformationF_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.SelectAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void CheckoutBTN2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
        }
    }
}
