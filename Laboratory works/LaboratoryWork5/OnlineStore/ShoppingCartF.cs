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
    public partial class ShoppingCartF : Form
    {
        public ShoppingCartF()
        {
            InitializeComponent();
        }

        private void BackToMainMenuBTN_Click(object sender, EventArgs e)
        {
            MainMenuF MainMenuForm = new MainMenuF();
            MainMenuForm.Show();
            this.Hide();
        }

        private void CheckoutBTN_Click(object sender, EventArgs e)
        {
            ClientInformationF clientInformationForm = new ClientInformationF();
            clientInformationForm.Show();
            this.Hide();
        }

        private void ShoppingCartF_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Goods.AllProductsList.RemoveAt(Int32.Parse(textBox1.Text) - 1);

            foreach (Goods item in Goods.AllProductsList)
            {
                richTextBox1.Text += (item.N + ". " + item.ProductName + " " + Convert.ToString(item.ProductPrice + "₽" + "\n"));
            }






            richTextBox1.AppendText(Convert.ToString("\n\n\n\n\n" + "Total price = " + Goods.AllProductsList.Sum(item => item.ProductPrice)) + " ₽");
        }
    }
}
