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
    public partial class MainMenuF : Form
    {
        public MainMenuF()
        {
            InitializeComponent();
        }

        private void ShoppingCartBTN_Click(object sender, EventArgs e)
        {
            ShoppingCartF ShoppingCartForm = new ShoppingCartF();
            ShoppingCartForm.Show();
            this.Hide();
        }

        private void CatalogBTN_Click(object sender, EventArgs e)
        {
            CatalogF CatalogForm = new CatalogF();
            CatalogForm.Show();
            this.Hide();
        }

        private void SearchTXTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            Goods.Search.Add(new Goods(Goods.Search.Count, "Smartwatch", 293017749, 25000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "iPhone", 039274917, 75000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "iPad", 293057172, 100000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "Macbook", 194728401, 150000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "Playstation 5", 039163856, 40000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "Gaming PC", 193657020, 140000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "Gaming monitor", 104837256, 25000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "Gaming chair", 103992816, 15000));
            Goods.Search.Add(new Goods(Goods.Search.Count, "Piano", 485019462, 2000000));
            if (Goods.Search.Exists(x => x.ProductName == (SearchTXTBX.Text)))
            {
                MessageBox.Show("It exists");
            }
            else
            {
                MessageBox.Show("It does not exist");
            }
        }
    }
}
