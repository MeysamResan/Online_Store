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
    public partial class CatalogF : Form
    {
        public CatalogF()
        {
            InitializeComponent();
        }

        private void BackToMainMenuBTN2_Click(object sender, EventArgs e)
        {
            MainMenuF MainMenuForm = new MainMenuF();
            MainMenuForm.Show();
            this.Hide();
        }

        private void Product1BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Smartwatch", 293017749, 25000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product2BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "iPhone", 039274917, 75000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product3BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "iPad", 293057172, 100000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product4BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Macbook", 194728401, 150000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product5BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Playstation 5", 039163856, 40000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product6BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Gaming PC", 193657020, 140000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product7BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Gaming monitor", 104837256, 25000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product8BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Gaming chair", 103992816, 15000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void Product9BTN_Click(object sender, EventArgs e)
        {
            TotalPriceTXTBX.Clear();
            Goods.AllProductsList.Add(new Goods(Goods.AllProductsList.Count + 1, "Piano", 485019462, 2000000));
            TotalPriceTXTBX.AppendText(Convert.ToString(Goods.AllProductsList.Sum(item => item.ProductPrice)) + "₽");
        }

        private void TotalPriceTXTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product1Label_Click(object sender, EventArgs e)
        {
            
        }

        private void Product2Label_Click(object sender, EventArgs e)
        {

        }

        private void Product3Label_Click(object sender, EventArgs e)
        {

        }

        private void Product4Label_Click(object sender, EventArgs e)
        {

        }

        private void Product5Label_Click(object sender, EventArgs e)
        {

        }

        private void Product6Label_Click(object sender, EventArgs e)
        {

        }

        private void Product7Label_Click(object sender, EventArgs e)
        {

        }

        private void Product8Label_Click(object sender, EventArgs e)
        {

        }

        private void Product9Label_Click(object sender, EventArgs e)
        {

        }

        private void CheckoutBTN2_Click(object sender, EventArgs e)
        {
            ShoppingCartF ShoppingCartForm = new ShoppingCartF();
            foreach (Goods item in Goods.AllProductsList)
            {
                ShoppingCartForm.richTextBox1.AppendText(item.N + ". " + item.ProductName + " " + Convert.ToString(item.ProductPrice + "₽" + "\n"));
            }
            ShoppingCartForm.richTextBox1.AppendText(Convert.ToString("\n\n\n\n\n" + "Total price = " + Goods.AllProductsList.Sum(item => item.ProductPrice)) + " ₽");
            ShoppingCartForm.Show();
            this.Hide();
        }

        private void CatalogF_Load(object sender, EventArgs e)
        {

        }
    }
}
